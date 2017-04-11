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
        public Pos()
        {
            InitializeComponent();
            Global.insert = new Insert();
            Global.insert.InsertProduct(new Product("Raquete", 1.2M));
            Global.insert.InsertProduct(new Product("Raquete", 12.2M));
            Global.insert.InsertProduct(new Product("Raquete", 25.2M));
        }

        private void Pos_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;

            foreach (var item in Global.insert.ProductList)
            {
                lbProduct.Items.Add(string.Format("#{0} - {1} - {2}", item.codProd, item.nomeProd, item.valorProd));
            }
            /*
            int i = 0;
            while (i < codProd.Length)
            {
                lbProduct.Items.Add(string.Format("#{0} - {1}", codProd[i], nomeProd[i]));
                i++;

            }*/

        }


        private void showMsgBox()
        {
           DialogResult mensage1 = MessageBox.Show("Não existe!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbCod.Text))
            {
                if (int.TryParse(tbCod.Text, out int searchText))
                {
                    if (searchText >= 0 && searchText <= Global.insert.ProductList.Count())
                        lbProduct.SelectedIndex = searchText - 1;
                    else
                        showMsgBox();
                }
                else
                {
                    showMsgBox();
                }
            }
            else
            {
                showMsgBox();
            }
        }

        private void lbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = lbProduct.SelectedIndex;

            if (lbProduct.SelectedIndex >= 0 && lbProduct.SelectedIndex <= Global.insert.ProductList.Count())
            {
                var item = Global.insert.ProductList[selectedIndex];
                tbTotal.Text = item.valorProd.ToString("C");
            }
            /*
            int selectedIndex = lbProduct.SelectedIndex;
            if (lbProduct.SelectedIndex >= 0 && lbProduct.SelectedIndex < codProd.Length)
            {
                tbTotal.Text = valorProd[selectedIndex].ToString("C");
                pbProduct.Image = (Image)Properties.Resources.ResourceManager.GetObject("_" + selectedIndex.ToString());
            }*/
        }

        private void tbCod_Enter(object sender, EventArgs e)
        {
            tbCod.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel1.Visible = true;
        }
    }
}
