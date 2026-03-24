using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class FlightObject
    {
        public DateTime date;
        public string origin;
        public string destination;
        public int segments;
        public decimal price;
        public int noOfseats;

        public override string ToString()
        {
            return $"Flight Details:\n" +
                   $"- Date: {date.ToString("yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture)}\n" +
                   $"- Origin: {origin}\n" +
                   $"- Destination: {destination}\n" +
                   $"- Segments: {segments}\n" +
                   $"- Price: €{price.ToString("N2", CultureInfo.InvariantCulture)}\n" +
                   $"- Number of Seats: {noOfseats}";
        }


    }
}
