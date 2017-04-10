using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock_Manager__SIMPLE_
{
    public partial class Pos : Form
    {
        // string[] codProd = new string[6];
        string[] codProd;
        string[] nomeProd;
        decimal[] valorProd;
        public Pos()
        {
            InitializeComponent();
        }

        private void Pos_Load(object sender, EventArgs e)
        {
            loadProducts();
            int i = 0;
            while (i < codProd.Length)
            {
                lbProduct.Items.Add(string.Format("#{0} - {1} - {2}", codProd[i], nomeProd[i], valorProd[i]));
                i++;

            }

        }

        private void loadProducts()
        {
            // string[] codProd = {"1", "2", "3", "4", "5", "6" };
            codProd = new string[6] { "1", "2", "3", "4", "5", "6" };

            nomeProd = new string[6] { "Raquete", "Bola", "Caixa", "Computador", "Prato", "Rádio" };

            valorProd = new decimal[] { 24.3M, 15, 5, 999.99M, 2, 18 };
        }

        private void showMsgBox()
        {
            MessageBox.Show("No such thing", "Warning");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Func<DialogResult> showMsgBox = () => 

            if (!string.IsNullOrEmpty(tbCod.Text))
            {
                int searchText;
                bool searchTextParse = int.TryParse(tbCod.Text, out searchText);
                if (searchTextParse)
                {
                    if (searchText >= 0 && searchText < codProd.Length)
                        lbProduct.SelectedIndex = searchText - 1;
                    else
                        showMsgBox();
                }
                else
                {
                    showMsgBox();
                }
            }
        }

        private void lbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = lbProduct.SelectedIndex;
            if (lbProduct.SelectedIndex >= 0 && lbProduct.SelectedIndex < codProd.Length)
            {
                tbTotal.Text = valorProd[selectedIndex].ToString("C");
                pbProduct.Image = (Image)Properties.Resources.ResourceManager.GetObject("_" + selectedIndex.ToString());
            }
        }

        private void tbCod_Enter(object sender, EventArgs e)
        {
            tbCod.Text = "";
        }
    }
}
