using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingBoiV2
{


    internal class CoinSlot
    {
        private double totalAmount;

        public CoinSlot()
        {
            totalAmount = 0.0;
        }

        public void InsertCoin(string coin)
        {
            switch (coin.ToLower())
            {
                case "twenty":
                    totalAmount += 20.00;
                    break;
                case "ten":
                    totalAmount += 10.00;
                    break;
                case "five":
                    totalAmount += 5.00;
                    break;
                case "dollar":
                    totalAmount += 1.00;
                    break;
                default:
                    throw new ArgumentException("Invalid coin type.");
            }
        }

        public double Total()
        {
            return totalAmount;
        }

        public void CoinReturn()
        {
            totalAmount = 0.0;
        }
    }
}
