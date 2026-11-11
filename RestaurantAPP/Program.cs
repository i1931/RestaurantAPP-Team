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
                Console.WriteLine(
                    $"{restaurant.Id} | {restaurant.Name} | {restaurant.Type} | {restaurant.Rating}"
                );
            }
            // แสดงร้านอาหารทั้งหมด
            ShowList(restaurants);

            Console.WriteLine("=======================================================");
            Console.WriteLine($"Total restaurants: {restaurants.Count}");
            Console.WriteLine("-----------------------------");
            Console.WriteLine($"Total restaurants: {restaurants.Count}");

            double average = 0;
            // คำนวณคะแนนเฉลี่ย คำทำ นางสาว ปณิดา ลี่ไพฑูรย์
            double average = 0;

            foreach (Restaurant restaurant in restaurants)
            {
                average += restaurant.Rating;
            }

            average /= restaurants.Count;

            Console.WriteLine($"Average rating: {average:F2}");
            Restaurant max = Restaurant.GetMax(restaurants);
            Restaurant min = Restaurant.GetMin(restaurants);

            Console.WriteLine($"Average rating: {average:F2}");
            Console.WriteLine($"Max Rating: {max.Rating} - {max.Name}");
            Console.WriteLine($"Min Rating: {min.Rating} - {min.Name}");

            // ค้นหาร้านอาหาร
            SearchRestaurant(restaurants);

            // เพิ่มร้านอาหาร นายทศวรรต ธาราดล
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

            ShowList(restaurants);

            Console.WriteLine($"Total: {restaurants.Count} restaurants");

            Console.ReadKey();
        }

        // แสดงรายการร้านอาหาร นายนิติวัฒน์ ดวงมาลา
        static void ShowList(List<Restaurant> restaurants)
        {
            foreach (Restaurant restaurant in restaurants)
            {
                Console.WriteLine(
                    $"{restaurant.Id} | {restaurant.Name} | {restaurant.Type} | {restaurant.Rating}");
            }
        }

            Restaurant.ShowGoodRating(restaurants);
        // ค้นหาร้านอาหาร
        public static void SearchRestaurant(List<Restaurant> restaurants)
        {
            Console.Write("\nกรอกชื่อร้านที่ต้องการค้นหา: ");
            string keyword = Console.ReadLine()?.Trim();

            Console.WriteLine("=======================================================");
        }
    }
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public double Rating { get; set; }
            if (string.IsNullOrWhiteSpace(keyword))
            {
                Console.WriteLine("ไม่ได้กรอกคำค้นหา!");
                return;
            }

            var results = restaurants
                .Where(r => r.Name.IndexOf(keyword,
                    StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();

            if (results.Count > 0)
            {
                Console.WriteLine($"\n--- ผลการค้นหา ({results.Count} รายการ) ---");

                foreach (var restaurant in results)
                {
                    Console.WriteLine(
                        $"[ID: {restaurant.Id}] {restaurant.Name} | ประเภท: {restaurant.Type} | คะแนน: {restaurant.Rating}");
                }
            }
            else
            {
                Console.WriteLine("ไม่พบร้านอาหาร");
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
        public static void ShowGoodRating(List<Restaurant> restaurants)
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
        public static Restaurant GetMin(List<Restaurant> restaurants)
        {
            return restaurants.OrderBy(r => r.Rating).First();
        }
    }
}