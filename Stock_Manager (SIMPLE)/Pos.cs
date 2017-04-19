using System;
using System.Collections.Generic;
using System.Configuration;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock_Manager__SIMPLE_
{
    public partial class Pos : Form
    {
        BaseDados bd = new BaseDados();

        public Pos()
        {
            InitializeComponent();
        }

        private void Pos_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            bd.Products(lbProduct);
        }


        private void showMsgBox()
        {
            MessageBox.Show("Não existe!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbCod.Text))
            {
                if (int.TryParse(tbCod.Text, out int searchText))
                {
                    lbProduct.SelectedIndex = 0;

                    for (int i = 1; i < lbProduct.Items.Count; i++)
                    {
                        if (searchText == int.Parse(lbProduct.SelectedValue.ToString()))
                        {
                            lbProduct.SelectedValue = searchText;
                            break;
                        }
                        lbProduct.SelectedIndex++;
                    }

                    if (searchText != int.Parse(lbProduct.SelectedValue.ToString()))
                    {
                        lbProduct.SelectedIndex = 0;
                        showMsgBox();
                    }
                }
                else
                    showMsgBox();
            }
            else
                showMsgBox();
        }

        private void lbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = lbProduct.SelectedIndex;

            if (lbProduct.SelectedIndex >= 0 && lbProduct.SelectedIndex <= bd.CountRows())
            {
                tbVerName.Text = bd.PriceQuantity().Rows[selectedIndex][2].ToString();
                tbTotal.Text = decimal.Parse(bd.PriceQuantity().Rows[selectedIndex][0].ToString()).ToString("C");
                tbVerQuant.Text = int.Parse(bd.PriceQuantity().Rows[selectedIndex][1].ToString()).ToString();
                string path = Application.StartupPath + "\\Images\\" + lbProduct.SelectedValue + ".jpg";
                if (File.Exists(path))
                    pbProduct.BackgroundImage = new Bitmap(path);
                else
                    pbProduct.BackgroundImage = Properties.Resources.empty;
            }
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
            if (bd.CountRows() == 0)
                MessageBox.Show("Não existem produtos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (MessageBox.Show("Deseja mesmo remover o produto selecionado?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    pbProduct.BackgroundImage.Dispose();
                    File.Delete(Application.StartupPath + "\\Images\\" + lbProduct.SelectedValue + ".jpg");
                    bd.DeleteData((int)lbProduct.SelectedValue);
                    bd.Products(lbProduct);
                }
            }

            if (lbProduct.Items.Count == 0)
            {
                tbTotal.Text = null;
                tbVerQuant.Text = null;
                pbProduct.BackgroundImage = null;
            }
        }

        static OpenFileDialog open = new OpenFileDialog();
        public static int fileopened = 0;

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel1.Visible = true;
            tbName.Text = null;
            tbPrice.Text = null;
            tbQuant.Text = "0";
            pbPreView.BackgroundImage = null;
            fileopened = 0;
        }


        private void btnAddImg_Click(object sender, EventArgs e)
        {
            open.Filter = "Imagens (*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.JPEG;*.PNG";
            open.Title = "Selecionar imagem";
            open.Multiselect = false;
            open.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            open.CheckFileExists = true;
            open.CheckPathExists = true;
            open.ShowReadOnly = true;
            if (open.ShowDialog() == DialogResult.OK)
            {
                Bitmap productImage = new Bitmap(open.FileName);
                pbPreView.BackgroundImage = new Bitmap(productImage);
                productImage.Dispose();
                fileopened = 1;
            }
            open.Dispose();
        }

        private void btnAddProduto_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbName.Text))
            {
                if (!string.IsNullOrEmpty(tbQuant.Text))
                {
                    if (!string.IsNullOrEmpty(tbPrice.Text))
                    {
                        if (decimal.TryParse(tbPrice.Text, out decimal price))
                        {
                            if (int.TryParse(tbQuant.Text, out int quant))
                                InsertData(tbName.Text, price, quant);
                            else
                                MessageBox.Show("O valor que inseriu na quantidade não é válido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                            MessageBox.Show("O preço deve ser válido e separado por uma virgula!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (int.TryParse(tbQuant.Text, out int quant))
                            InsertData(tbName.Text, 0, quant);
                        else
                            MessageBox.Show("O valor que inseriu na quantidade não é válido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (!string.IsNullOrEmpty(tbPrice.Text))
                    {
                        if (decimal.TryParse(tbPrice.Text, out decimal price))
                            InsertData(tbName.Text, price, 0);
                        else
                            MessageBox.Show("O preço deve ser válido e separado por uma virgula!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        InsertData(tbName.Text, 0, 0);
                }
            }
            else
                MessageBox.Show("Indique o nome do produto!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            pbPreView.BackgroundImage = null;
            fileopened = 0;
        }

        private void InsertData(string _name, decimal _price, int _quant)
        {
            bd.InsertData(new Product(_name, _price, _quant));
            panel2.Visible = false;
            panel1.Visible = true;
            bd.Products(lbProduct);
            tbName.Text = null;
            tbPrice.Text = null;
            tbQuant.Text = "0";
        }

        public static void InsertImage(int id)
        {
            Bitmap productImage = new Bitmap(open.FileName);
            string path = Application.StartupPath;
            string totalpath = path + "\\Images\\" + id + ".jpg";
            productImage.Save(totalpath, ImageFormat.Jpeg);
        }

        public static void DeleteImage(int id)
        {
            string path = Application.StartupPath;
            string totalpath = path + "\\Images\\" + id + ".jpg";
            File.Delete(totalpath);
        }

        private void tbQuant_Click(object sender, EventArgs e)
        {
            tbQuant.SelectAll();
        }

        string tbTotalText;
        string tbVerQuantText;

        private void btnEditar_Click(object sender, EventArgs e)
        {
            tbTotal.Text = tbTotal.Text.Substring(0, tbTotal.Text.Length - 2);
            tbTotal.ReadOnly = false;
            tbVerQuant.ReadOnly = false;
            btnEditar.Visible = false;
            lbProduct.Enabled = false;
            tbCod.Enabled = false;
            btnSearch.Enabled = false;
            btnSearch.BackColor = Color.White;
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Visible = true;
            tbVerName.ReadOnly = false;
            tbTotalText = tbTotal.Text;
            tbVerQuantText = tbVerQuant.Text;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbVerName.Text))
            {
                if (!string.IsNullOrEmpty(tbVerQuant.Text))
                {
                    if (!string.IsNullOrEmpty(tbTotal.Text))
                    {
                        if (decimal.TryParse(tbTotal.Text, out decimal price))
                        {
                            if (int.TryParse(tbVerQuant.Text, out int quant))
                                bd.UpdateData(tbVerName.Text, price, quant, (int)lbProduct.SelectedValue);
                            else
                                MessageBox.Show("O valor que inseriu na quantidade não é válido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                            MessageBox.Show("O preço deve ser válido e separado por uma virgula!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (int.TryParse(tbVerQuant.Text, out int quant))
                            bd.UpdateData(tbVerName.Text, 0, quant, (int)lbProduct.SelectedValue);
                        else
                            MessageBox.Show("O valor que inseriu na quantidade não é válido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (!string.IsNullOrEmpty(tbPrice.Text))
                    {
                        if (decimal.TryParse(tbTotal.Text, out decimal price))
                            bd.UpdateData(tbVerName.Text, price, 0, (int)lbProduct.SelectedValue);
                        else
                            MessageBox.Show("O preço deve ser válido e separado por uma virgula!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        bd.UpdateData(tbVerName.Text, 0, 0, (int)lbProduct.SelectedValue);
                }
            }
            else
                MessageBox.Show("Indique o nome do produto!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);

            tbTotal.Text = string.Format("{0} €", tbTotal.Text);
            tbTotal.ReadOnly = true;
            tbVerQuant.ReadOnly = true;
            btnEditar.Visible = true;
            lbProduct.Enabled = true;
            tbCod.Enabled = true;
            btnSearch.Enabled = true;
            btnSearch.BackColor = Color.Black;
            btnAdd.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Visible = false;
            tbVerName.ReadOnly = true;
            bd.Products(lbProduct);
        }

    }
}
