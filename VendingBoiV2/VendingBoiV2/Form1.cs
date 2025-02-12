using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendingBoiV2
{
    public partial class Form1 : Form
    {
        private decimal totalAmount = 0;
        private string selectedProductName;
        private decimal selectedProductPrice;
        private CoinSlot coinSlot;
        private Inventory inventory;
        public Form1()
        {
            InitializeComponent();
            coinSlot = new CoinSlot();
            inventory = new Inventory();

        }
        private void showProduct(string productName, decimal price)
        {
            var productInfo = inventory.GetProductInfo(productName);

            // Ensure the price matches the inventory price
            if (productInfo.Price != price)
            {
                lblPurchaseMessage.Text = "Product price mismatch.";
                return;
            }

            selectedProductName = productName;
            selectedProductPrice = productInfo.Price;
            lblProductName.Text = productName;
            lblProductPrice.Text = productInfo.Price.ToString("C");

            // Check if the product is available
            if (productInfo.Stock <= 0)
            {
                lblPurchaseMessage.Text = "This product is out of stock.";
            }
            else
            {
                lblPurchaseMessage.Text = "";
            }
        }

        //Display Product Name And Price
        private void btnProduct1_Click(object sender, EventArgs e)
        {
            showProduct("Vending Machine 1", 200.00m);
        }

        private void btnProduct2_Click(object sender, EventArgs e)
        {
            showProduct("Vending Machine 2", 225.00m);
        }

        private void btnProduct3_Click(object sender, EventArgs e)
        {
            showProduct("Vending Machine 3", 175.00m);
        }

        private void btnProduct4_Click(object sender, EventArgs e)
        {
            showProduct("Vending Machine 4", 201.00m);
        }

        private void btnProduct5_Click(object sender, EventArgs e)
        {
            showProduct("Vending Machine 5", 420.00m);
        }

        private void btnProduct6_Click(object sender, EventArgs e)
        {
            showProduct("Vending Machine 6", 60.00m);
        }

        private void btnProduct7_Click(object sender, EventArgs e)
        {
            showProduct("Vending Machine 7", 70.00m);
        }

        private void btnProduct8_Click(object sender, EventArgs e)
        {
            showProduct("Vending Machine 8", 100.00m);
        }

        private void btnProduct9_Click(object sender, EventArgs e)
        {
            showProduct("Vending Machine 9", 150.00m);
        }

        private void btnProduct10_Click(object sender, EventArgs e)
        {
            showProduct("Vending Machine 10", 221.00m);
        }

        private void btnProduct11_Click(object sender, EventArgs e)
        {
            showProduct("Vending Machine 11", 12.00m);
        }

        private void btnProduct12_Click(object sender, EventArgs e)
        {
            showProduct("Vending Machine 12", 2.00m);
        }

        //Money Coin Code
        private void btnDollars20_Click(object sender, EventArgs e)
        {
            coinSlot.InsertCoin("twenty");
            UpdateTotalLabel();
        }

        private void btnDollar10_Click(object sender, EventArgs e)
        {
            coinSlot.InsertCoin("ten");
            UpdateTotalLabel();
        }

        private void btnDollar5_Click(object sender, EventArgs e)
        {
            coinSlot.InsertCoin("five");
            UpdateTotalLabel();
        }

        private void btnDollar1_Click(object sender, EventArgs e)
        {
            coinSlot.InsertCoin("dollar");
            UpdateTotalLabel();
        }

        //Update Money Label
        private void UpdateTotalLabel()
        {
            lblTotalAmount.Text = coinSlot.Total().ToString("C");
        }

        //PUrchase the Item and Display you Purchased It
        private void btnPurchase_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedProductName))
            {
                lblPurchaseMessage.Text = "Please select a product.";
                return;
            }
            if (!inventory.IsProductAvailable(selectedProductName))
            {
                lblPurchaseMessage.Text = "This Product Is Out Of Stock!";
                return;
            }

            if ((decimal)coinSlot.Total() >= selectedProductPrice)
            {
                // Call the PurchaseProduct method to decrease the stock
                if (inventory.PurchaseProduct(selectedProductName))
                {
                    coinSlot.CoinReturn(); // Clear the coin slot after purchase
                    lblTotalAmount.Text = coinSlot.Total().ToString("C");
                    lblPurchaseMessage.Text = $"You purchased {selectedProductName}!";

                    // Optionally reset the product selection
                    selectedProductName = null;
                    selectedProductPrice = 0;
                    lblProductName.Text = "";
                    lblProductPrice.Text = "";
                }
                else
                {
                    lblPurchaseMessage.Text = "Purchase failed. Please try again.";
                }
            }
            else
            {
                lblPurchaseMessage.Text = "Not enough money deposited.";
            }
        }
    }
}
