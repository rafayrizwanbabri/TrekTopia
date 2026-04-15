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
            var request = new HttpRequestMessage(HttpMethod.Post, "https://test.api.amadeus.com/v1/security/oauth2/token")
            {
                Content = new FormUrlEncodedContent(new Dictionary<string, string>
            {
                { "client_id", _apiKey },
                { "client_secret", _apiSecret },
                { "grant_type", "client_credentials" }
            })
            };

            var response = await _httpClient.SendAsync(request);//for sending http request in c# we use _httpClient
            var content = await response.Content.ReadAsStringAsync();
            return JObject.Parse(content)["access_token"]?.ToString();//? means it access token can be null
        }



        public async Task<List<FlightObject>> GetFlightsx(string originn, string dest)
        {

            string accessToken = await GetAccessToken();
            List<FlightObject> flightsList = new List<FlightObject>();

            if (!string.IsNullOrEmpty(accessToken))
            {
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
                var x = $"https://test.api.amadeus.com/v2/shopping/flight-offers?originLocationCode={originn}&destinationLocationCode={dest}&departureDate=2024-05-01&adults=2";
                var response = await _httpClient.GetAsync(x);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var flights = JObject.Parse(content)["data"];
                    var jsonObject = JObject.Parse(content);

                    foreach (var flightOffer in jsonObject["data"])
                    {
                        FlightObject flight = new FlightObject
                        {
                            // Parse the departure date and time of the first segment
                            date = DateTime.Parse(flightOffer["itineraries"][0]["segments"][0]["departure"]["at"].ToString()),
                            // Get the origin IATA code from the first segment
                            origin = originn,
                            // Get the destination IATA code from the last segment
                            destination = dest,
                            // Count the number of segments
                            segments = flightOffer["itineraries"][0]["segments"].Count(),
                            // Parse the total price
                            price = decimal.Parse(flightOffer["price"]["total"].ToString()),
                            // Get the number of bookable seats
                            noOfseats = int.Parse(flightOffer["numberOfBookableSeats"].ToString())
                        };

                        // Add the flight object to the list
                        flightsList.Add(flight);
                    }




                }
            }

            return flightsList;
        }

        public async Task<List<string>> GetHotels(string cityCode)//async function return only Task object
        {
            List<string> hotelNames = new List<string>();
            string accessToken = await GetAccessToken();

            if (!string.IsNullOrEmpty(accessToken))//accesstoken==bearertoken
            {
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                var response = await _httpClient.GetAsync($"https://test.api.amadeus.com/v1/reference-data/locations/hotels/by-city?cityCode={cityCode}");
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var hotels = JObject.Parse(content)["data"];

                    foreach (var hotel in hotels)
                    {
                        hotelNames.Add(hotel["name"].ToString());//add means append
                        if (hotelNames.Count >= 10)
                            break;
                    }
                }
            }

            return hotelNames;
        }
    }

}

