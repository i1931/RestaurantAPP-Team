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
                new Restaurant(3, "Din Tai Fung", "Taiwanese Cuisine", 4.7)
            };

            
            SearchRestaurant(restaurants);
        }

        // Method สำหรับค้นหาร้านอาหาร
        static void SearchRestaurant(List<Restaurant> restaurants)
        {
            Console.Write("กรอกชื่อร้านที่ต้องการค้นหา: ");
            string keyword = Console.ReadLine()?.Trim();

            if (string.IsNullOrWhiteSpace(keyword))
            {
                Console.WriteLine("\nไม่ได้กรอกคำค้นหา!");
                return;
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