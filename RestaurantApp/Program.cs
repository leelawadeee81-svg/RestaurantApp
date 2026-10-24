using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello TIT.1/1");

        }
    }
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public double Rating { get; set; }

        public Restaurant(int id, string name, string category, double rating)
        {
            this.Id = id;
            this.Name = name;
            this.Category = category;
            this.Rating = rating;
        }


    }

}
