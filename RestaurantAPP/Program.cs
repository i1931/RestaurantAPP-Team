using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantAPP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                List<Restaurant> restaurants = new List<Restaurant>
            {
                new Restaurant(1, "Quanjude Roast Duck", "Beijing Cuisine", 4.5),
                new Restaurant(2, "Donglaishun Hot Pot", "Hot Pot", 4.6),
                new Restaurant(3, "Din Tai Fung", "Taiwanese Cuisine", 4.7),
                new Restaurant(4, "Huguosi Snacks", "Snacks", 4.2),
                new Restaurant(5, "Haidilao Hot Pot", "Hot Pot", 4.8)
             };

                foreach (Restaurant restaurant in restaurants)
                {
                    Console.WriteLine(
                        $"{restaurant.Id} | {restaurant.Name} | {restaurant.Type} | {restaurant.Rating}"
                    );
                }

                Console.WriteLine("=======================================================");
                Console.WriteLine($"Total restaurants: {restaurants.Count}");

                double average = 0;

                foreach (Restaurant restaurant in restaurants)
                {
                    average += restaurant.Rating;
                }

                average /= restaurants.Count;

                Console.WriteLine($"Average rating: {average:F2}");
                ShowGoodRating(restaurants);

            }



            Console.WriteLine("=======================================================");
        }

        private static void ShowGoodRating(List<Restaurant> restaurants)
        {
            Console.WriteLine("=======================================================");
            Console.WriteLine("=== Restaurants rated 4.5 and above ===");
            int count = 0;

            foreach (Restaurant restaurant in restaurants)
            {
                if (restaurant.Rating >= 4.5)
                {
                    Console.WriteLine($"{restaurant.Name} | {restaurant.Rating}");
                    count++;
                }
            }

            if (count == 0)
            {
                Console.WriteLine("No restaurant rated 4.5 or above.");
            }
            else
            {
                Console.WriteLine($"Total: {count} restaurants");
            }
        }
    }
}
public class Restaurant
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }
    public double Rating { get; set; }

    public Restaurant(int id, string name, string type, double rating)
    {
        Id = id;
        Name = name;
        Type = type;
        Rating = rating;
    }
}

