using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;


namespace WinFormsApp1
{



    public class AmadeusAPI
    {
        private readonly string _apiKey;
        private readonly string _apiSecret;
        private readonly HttpClient _httpClient;

        public AmadeusAPI(string apiKey, string apiSecret)
        {
            _apiKey = apiKey;
            _apiSecret = apiSecret;
            _httpClient = new HttpClient();
        }

        public async Task<string> GetAccessToken()
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Post, "https://test.api.amadeus.com/v1/security/oauth2/token")
                {
                    Content = new FormUrlEncodedContent(new Dictionary<string, string>
                    {
                        { "client_id", _apiKey },
                        { "client_secret", _apiSecret },
                        { "grant_type", "client_credentials" }
                    })
                };

                var response = await _httpClient.SendAsync(request);
                
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var jsonObject = JObject.Parse(content);
                    var token = jsonObject["access_token"]?.ToString();
                    
                    if (string.IsNullOrEmpty(token))
                    {
                        System.Diagnostics.Debug.WriteLine("Access token is empty in response");
                        return null;
                    }
                    
                    return token;
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine($"Failed to get access token. Status code: {response.StatusCode}");
                    return null;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error getting access token: {ex.Message}");
                return null;
            }
        }



        public async Task<List<FlightObject>> GetFlightsx(string originn, string dest)
        {
            List<FlightObject> flightsList = new List<FlightObject>();

            try
            {
                if (string.IsNullOrEmpty(originn) || string.IsNullOrEmpty(dest))
                {
                    System.Diagnostics.Debug.WriteLine("Origin or destination cannot be empty");
                    return flightsList;
                }

                string accessToken = await GetAccessToken();

                if (string.IsNullOrEmpty(accessToken))
                {
                    System.Diagnostics.Debug.WriteLine("Failed to obtain access token");
                    return flightsList;
                }

                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
                var x = $"https://test.api.amadeus.com/v2/shopping/flight-offers?originLocationCode={originn}&destinationLocationCode={dest}&departureDate=2024-05-01&adults=2";
                var response = await _httpClient.GetAsync(x);

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var jsonObject = JObject.Parse(content);
                    var flights = jsonObject["data"];

                    if (flights != null && flights.Count() > 0)
                    {
                        foreach (var flightOffer in flights)
                        {
                            try
                            {
                                var itineraries = flightOffer["itineraries"];
                                var price = flightOffer["price"];
                                var numberOfSeats = flightOffer["numberOfBookableSeats"];

                                if (itineraries != null && itineraries.Count() > 0 && price != null && numberOfSeats != null)
                                {
                                    var segments = itineraries[0]["segments"];
                                    if (segments != null && segments.Count() > 0)
                                    {
                                        var departureAt = segments[0]["departure"]?["at"]?.ToString();
                                        var totalPrice = price["total"]?.ToString();
                                        var seats = numberOfSeats.ToString();

                                        if (!string.IsNullOrEmpty(departureAt) && !string.IsNullOrEmpty(totalPrice) && !string.IsNullOrEmpty(seats))
                                        {
                                            FlightObject flight = new FlightObject
                                            {
                                                date = DateTime.Parse(departureAt),
                                                origin = originn,
                                                destination = dest,
                                                segments = segments.Count(),
                                                price = decimal.Parse(totalPrice),
                                                noOfseats = int.Parse(seats)
                                            };

                                            flightsList.Add(flight);
                                        }
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                System.Diagnostics.Debug.WriteLine($"Error parsing flight: {ex.Message}");
                                continue;
                            }
                        }
                    }
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine($"API call failed with status code: {response.StatusCode}");
                }
            }
            catch (HttpRequestException ex)
            {
                System.Diagnostics.Debug.WriteLine($"Http request error in GetFlightsx: {ex.Message}");
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in GetFlightsx: {ex.Message}");
            }

            return flightsList;
        }

        public async Task<List<string>> GetHotels(string cityCode)
        {
            List<string> hotelNames = new List<string>();

            try
            {
                if (string.IsNullOrEmpty(cityCode))
                {
                    System.Diagnostics.Debug.WriteLine("City code cannot be empty");
                    return hotelNames;
                }

                string accessToken = await GetAccessToken();

                if (string.IsNullOrEmpty(accessToken))
                {
                    System.Diagnostics.Debug.WriteLine("Failed to obtain access token");
                    return hotelNames;
                }

                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                var response = await _httpClient.GetAsync($"https://test.api.amadeus.com/v1/reference-data/locations/hotels/by-city?cityCode={cityCode}");
                
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var jsonObject = JObject.Parse(content);
                    var hotels = jsonObject["data"];

                    if (hotels != null && hotels.Count() > 0)
                    {
                        foreach (var hotel in hotels)
                        {
                            try
                            {
                                var hotelName = hotel["name"]?.ToString();
                                if (!string.IsNullOrEmpty(hotelName))
                                {
                                    hotelNames.Add(hotelName);
                                    if (hotelNames.Count >= 10)
                                        break;
                                }
                            }
                            catch (Exception ex)
                            {
                                System.Diagnostics.Debug.WriteLine($"Error parsing hotel: {ex.Message}");
                                continue;
                            }
                        }
                    }
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine($"API call failed with status code: {response.StatusCode}");
                }
            }
            catch (HttpRequestException ex)
            {
                System.Diagnostics.Debug.WriteLine($"Http request error in GetHotels: {ex.Message}");
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in GetHotels: {ex.Message}");
            }

            return hotelNames;
        }
    }

}

