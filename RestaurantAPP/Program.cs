using System;
using System.Collections.Generic;
using System.Linq;

namespace RestaurantAPP
{
    internal class Program
    {
        static void Main(string[] args)
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
                Console.WriteLine($"{restaurant.Id} | {restaurant.Name} | {restaurant.Type} | {restaurant.Rating}");
            }

            Console.WriteLine("-----------------------------");
            Console.WriteLine($"Total restaurants: {restaurants.Count}");

            double average = 0;
            foreach (Restaurant restaurant in restaurants)
            {
                average += restaurant.Rating;
            }
            average /= restaurants.Count;
            Console.WriteLine($"Average rating: {average:F2}");

            public static void SearchRestaurant(List<Restaurant> restaurants)
            {
                Console.Write("กรอกชื่อร้านที่ต้องการค้นหา: ");
                string keyword = Console.ReadLine()?.Trim();

                if (string.IsNullOrWhiteSpace(keyword))
                {
                    Console.WriteLine("\nไม่ได้กรอกคำค้นหา!");
                    return;
                }
                Restaurant max = Restaurant.GetMax(restaurants);
                Restaurant min = Restaurant.GetMin(restaurants);

                Console.WriteLine($"Average rating: {average:F2}");
                Console.WriteLine($"Max Rating: {max.Rating} - {max.Name}");
                Console.WriteLine($"Min Rating: {min.Rating} - {min.Name}");
        //----------------------------------------------------------------//

                Console.WriteLine("\n=== Add New Restaurant ===");

                Console.Write("Enter restaurant name: ");
                string name = Console.ReadLine();

                Console.Write("Enter restaurant type: ");
                string type = Console.ReadLine();

                Console.Write("Enter restaurant rating: ");
                double rating = double.Parse(Console.ReadLine());

                int id = restaurants.Count + 1;

                restaurants.Add(new Restaurant(id, name, type, rating));

                Console.WriteLine("Restaurant added successfully!");

                Console.WriteLine("-----------------------------");
                Console.WriteLine($"Total: {restaurants.Count} restaurants");

                foreach (Restaurant restaurant in restaurants)
                {
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine($"ID: {restaurant.Id}");
                    Console.WriteLine($"Name: {restaurant.Name}");
                    Console.WriteLine($"Type: {restaurant.Type}");
                    Console.WriteLine($"Rating: {restaurant.Rating}");
                }
            }

                var results = restaurants
                    .Where(r => r.Name.ToLower().Contains(keyword.ToLower()))
                    .ToList();

                if (results.Count > 0)
                {
                    Console.WriteLine($"\n--- ผลการค้นหาสำหรับ \"{keyword}\" ({results.Count} รายการ) ---");
                    foreach (var restaurant in results)
                    {
                        Console.WriteLine($"[ID: {restaurant.Id}] {restaurant.Name} | ประเภท: {restaurant.Type} | คะแนน: {restaurant.Rating}");
                    }
                }
                else
                {
                    Console.WriteLine($"\nไม่พบร้านอาหารที่ชื่อตรงกับ \"{keyword}\"");
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
}
    public Restaurant(int id, string name, string type, double rating)
    {
        Id = id;
        Name = name;
        Type = type;
        Rating = rating;
    }
    public static Restaurant GetMax(List<Restaurant> restaurants)
    {
        return restaurants.OrderByDescending(r => r.Rating).First();
    }
    public static Restaurant GetMin(List<Restaurant> restaurants)
    {
        return restaurants.OrderBy(r => r.Rating).First();
    }
}

