using System.Collections.Generic;
using System.Linq;

class Product
{
    public string Name { get; set; }
    public string Category { get; set; }
    public decimal Price { get; set; }

    public static void TotalPrice(ILookup<string, Product> lookup)
    {
        foreach (var category in lookup)
        {
            decimal totalPrice = 0;
            foreach (var item in category)
            {
                totalPrice += item.Price;
                Console.WriteLine(item.Name + " " + item.Price);
            }
            Console.WriteLine(category.Key + " " + totalPrice);
        }
    }
}