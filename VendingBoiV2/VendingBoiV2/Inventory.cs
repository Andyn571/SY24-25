using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingBoiV2
{
    internal class Inventory
    {
        
        
            private Dictionary<string, (decimal Price, int Stock)> products;

            public Inventory()
            {
            products = new Dictionary<string, (decimal Price, int Stock)>
                {
                { "Vending Machine 1", (200.00m, 5) },
                { "Vending Machine 2", (225.00m, 5) },
                { "Vending Machine 3", (175.00m, 5) },
                { "Vending Machine 4", (201.00m, 5) },
                { "Vending Machine 5", (420.00m, 5) },
                { "Vending Machine 6", (60.00m, 5) },
                { "Vending Machine 7", (70.00m, 5) },
                { "Vending Machine 8", (100.00m, 5) },
                { "Vending Machine 9", (150.00m, 5) },
                { "Vending Machine 10", (221.00m, 5) },
                { "Vending Machine 11", (12.00m, 5) },
                { "Vending Machine 12", (2.00m, 5) }
                };
            }

            public (decimal Price, int Stock) GetProductInfo(string productName)
            {
                if (products.TryGetValue(productName, out var productInfo))
                {
                    return productInfo;
                }
                return (0, 0);
            }

            public bool PurchaseProduct(string productName)
            {
                if (products.ContainsKey(productName) && products[productName].Stock > 0)
                {
                    products[productName] = (products[productName].Price, products[productName].Stock - 1);
                    return true;
                }
                return false;
            }

            public bool IsProductAvailable(string productName)
            {
                return products.ContainsKey(productName) && products[productName].Stock > 0;
            }
        
    }
}
