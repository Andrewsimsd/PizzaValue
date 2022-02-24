using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaValue
{
    public partial class Form1 : Form
    {
        public double Pizza1Price;
        public double Pizza2Price;

        public double Pizza1Size;
        public double Pizza2Size;

        public double Pizza1CrustValue;
        public double Pizza2CrustValue;

        public double Pizza1PricePerSqIn;
        public double Pizza2PricePerSqIn;

        public double Pizza1TotalValue;
        public double Pizza2TotalValue;


        public Form1()
        {
            InitializeComponent();
            Pizza1Price = 0;
            Pizza2Price = 0;

            Pizza1Size = 0;
            Pizza2Size = 0;

            Pizza1CrustValue = 0;
            Pizza2CrustValue = 0;

            Pizza1PricePerSqIn = 0;
            Pizza2PricePerSqIn = 0;

            Pizza1TotalValue = 0;
            Pizza2TotalValue = 0;
        }

        public void UpdateGui()
        {
            CaptureGuiValues();
            CalculatePizzaPricePerIn();
            CalculatePizzaTotalValue();
            UpdateCrustDescriptions();
            labelPizza1PricePerSqIn.Text = Pizza1PricePerSqIn.ToString("c");
            labelPizza2PricePerSqIn.Text = Pizza2PricePerSqIn.ToString("c");
            labelPizza1AdjValue.Text = Pizza1TotalValue.ToString();
            labelPizza2AdjValue.Text = Pizza2TotalValue.ToString();
        }

        public void CaptureGuiValues()
        {
            Double.TryParse(tbPizza1Price.Text, out Pizza1Price);
            Double.TryParse(tbPizza2Price.Text, out Pizza2Price);

            Double.TryParse(tbPizza1Size.Text, out Pizza1Size);
            Double.TryParse(tbPizza2Size.Text, out Pizza2Size);

            Pizza1CrustValue = trackBarPizza1CrustValue.Value;
            Pizza2CrustValue = trackBarPizza2CrustValue.Value;
        }
        public void CalculatePizzaPricePerIn()
        {
            Pizza1PricePerSqIn = Pizza1Price / (Math.Pow(Pizza1Size, 2) * Math.PI);
            Pizza2PricePerSqIn = Pizza2Price / (Math.Pow(Pizza2Size, 2) * Math.PI);
        }
        public void CalculatePizzaTotalValue()
        {
            double pizza1PizzaArea = (Math.Pow(Pizza1Size - 1, 2) * Math.PI);
            double pizza1CrustArea = (Math.Pow(Pizza1Size, 2) * Math.PI) - pizza1PizzaArea;
            double pizza2PizzaArea = (Math.Pow(Pizza2Size - 1, 2) * Math.PI);
            double pizza2CrustArea = (Math.Pow(Pizza2Size, 2) * Math.PI) - pizza2PizzaArea;
            Pizza1TotalValue = (pizza1PizzaArea*Pizza1PricePerSqIn) + (pizza1CrustArea*Pizza1CrustValue/5 * Pizza1PricePerSqIn) ;
            Pizza2TotalValue = (pizza2PizzaArea*Pizza2PricePerSqIn) + (pizza2CrustArea*Pizza2CrustValue/5 * Pizza2PricePerSqIn) ;
        }
        public void UpdateCrustDescriptions()
        {
            labelPizza1CrustDescription.Text = GetCrustDescription(Pizza1CrustValue);
            labelPizza2CrustDescription.Text = GetCrustDescription(Pizza2CrustValue);
        }
        public string GetCrustDescription(double value)
        {
            string description;
            if (value <= 1)
            {
                description = "I hate it!";
            }
            else if (value <= 3)
            {
                description = "It's not great.";
            }
            else if (value <= 6)
            {
                description = "It's okay.";
            }
            else if (value <= 9)
            {
                description = "It's pretty good.";
            }
            else
            {
                description = "I love it!.";
            }
            return description;
        }
        private void tbPizza1Price_TextChanged(object sender, EventArgs e)
        {
            UpdateGui();
        }

        private void tbPizza1Size_TextChanged(object sender, EventArgs e)
        {
            UpdateGui();
        }

        private void tbPizza2Price_TextChanged(object sender, EventArgs e)
        {
            UpdateGui();
        }

        private void tbPizza2Size_TextChanged(object sender, EventArgs e)
        {
            UpdateGui();
        }

        private void trackBarPizza1CrustValue_Scroll(object sender, EventArgs e)
        {
            UpdateGui();
        }

        private void trackBarPizza2CrustValue_Scroll(object sender, EventArgs e)
        {
            UpdateGui();
        }
    }
}
