using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kargo_Calculation
{
    
    public partial class Form1 : Form
    {
        public List<string> Products { get; set; } = new List<string>();
        public List<string> Countries { get; set; } = new List<string>();
        public double  Price { get; set; }
        public Form1()
        {
            InitializeComponent();
            Products.Add("Dangerous");
            Products.Add("Liquid");
            Products.Add("Solid");
            Countries.Add("USA");
            Countries.Add("Turkey");
            Countries.Add("China");
            cbx_ProductTypes.DataSource = Products;
            cbx_Countries.DataSource = Countries;
        }
        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            Product dangerousProduct = new DangerousProduct();
            Product liquidProduct = new LiquidProduct();
            Product solidProduct = new SolidProduct();
            if (cbx_ProductTypes.SelectedItem.ToString() == "Dangerous")
            {
                Price += dangerousProduct.Calculate();
            }
            else if (cbx_ProductTypes.SelectedItem.ToString() == "Liquid")
            {
                Price += liquidProduct.Calculate();
            }
            else if (cbx_ProductTypes.SelectedItem.ToString() == "Solid")
            {
                Price += solidProduct.Calculate();
            }
            switch (cbx_Countries.SelectedItem.ToString())
            {
                case "USA":
                    Price += 5;
                    break;
                case "Turkey":
                    Price += 2;
                    break;
                case "China":
                    Price += 1;
                    break;
            }
            if(double.Parse(txtB_Weight.Text)>1&& double.Parse(txtB_Weight.Text) < 2)
            {
                Price += 2.5;
            }
            else if (double.Parse(txtB_Weight.Text) > 2 && double.Parse(txtB_Weight.Text) < 5)
            {
                Price += 4;
            }
            else if (double.Parse(txtB_Weight.Text) >5)
            {
                Price += 6.5;
            }

            if (double.Parse(txtB_Length.Text)>10)
            {
                Price += 8;
            }
            if (double.Parse(txtB_Width.Text) > 10)
            {
                Price += 8;
            }
            double count = double.Parse(txtB_count.Text);
            lbl_Price.Text = (Price*count) .ToString();
            Price = 0;
        }
    }
}
