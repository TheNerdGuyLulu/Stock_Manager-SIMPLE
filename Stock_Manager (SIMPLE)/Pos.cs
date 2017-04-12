using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public Pos()
        {
            InitializeComponent();
            Global.insert = new Insert();
            Global.insert.InsertProduct(new Product("Raquete", 1.2M, 10));
            Global.insert.InsertProduct(new Product("Bola", 12.2M, 0));
            Global.insert.InsertProduct(new Product("Caixa", 25.2M, 0));
        }

        private void Pos_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;

            Products();
        }

        private void Products()
        {
            List<string> pessoasString = new List<string>();
            pessoasString.Clear();
            foreach (var item in Global.insert.ProductList)
            {
                pessoasString.Add(string.Format("#{0} - {1}", item.codProd, item.nomeProd));
            }
            lbProduct.DataSource = pessoasString;
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
                tbTotal.Text = Global.insert.ProductList[selectedIndex].valorProd.ToString("C");
                tbVerQuant.Text = Global.insert.ProductList[selectedIndex].quantidadeProd.ToString();
                selectedIndex++;
                string path = Application.StartupPath + "\\Images\\" + selectedIndex + ".jpg";
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
            if (Global.insert.ProductList.Count == 0)
            {
                MessageBox.Show("Não existem produtos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Deseja mesmo remover o produto selecionado?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Global.insert.ProductList.RemoveAt(lbProduct.SelectedIndex);
                    Products();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel1.Visible = true;
            tbName.Text = null;
            tbPrice.Text = null;
            tbQuant.Text = "0";
            pbPreView.BackgroundImage = null;
        }

        OpenFileDialog open = new OpenFileDialog();
        int fileopened = 0;

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
            if (!string.IsNullOrEmpty(tbName.Text) || !string.IsNullOrEmpty(tbPrice.Text))
            {
                if (decimal.TryParse(tbPrice.Text, out decimal price))
                {
                    if (int.TryParse(tbQuant.Text, out int quant))
                    {
                        InsertData(tbName.Text, price, quant);
                       
                        if (fileopened == 1)
                            InsertImage();
                        else
                            DeleteImage();

                        tbName.Text = null;
                        tbPrice.Text = null;
                        tbQuant.Text = "0";
                    }
                    else if (string.IsNullOrEmpty(tbQuant.Text))
                    {
                        InsertData(tbName.Text, price, 0);

                        if (fileopened == 1)
                            InsertImage();
                        else
                            DeleteImage();

                        tbName.Text = null;
                        tbPrice.Text = null;
                        tbQuant.Text = "0";
                    }
                    else
                    {
                        MessageBox.Show("O valor que inseriu na quantidade não é válido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    MessageBox.Show("O preço deve ser separado por uma virgula!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Preencha todos os campos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);

            pbPreView.BackgroundImage = null;
        }

        private void InsertData(string _name, decimal _price, int _quant)
        {
            Global.insert.InsertProduct(new Product(_name, _price, _quant));
            panel2.Visible = false;
            panel1.Visible = true;
            Products();
        }

        private void InsertImage()
        {
            Bitmap productImage = new Bitmap(open.FileName);
            var item = Global.insert.ProductList.Last();
            string path = Application.StartupPath;
            string totalpath = path + "\\Images\\" + item.codProd.ToString() + ".jpg";
            productImage.Save(totalpath, ImageFormat.Jpeg);
        }

        private void DeleteImage()
        {
            var item = Global.insert.ProductList.Last();
            string path = Application.StartupPath;
            string totalpath = path + "\\Images\\" + item.codProd.ToString() + ".jpg";
            File.Delete(totalpath);
        }

        private void tbQuant_Click(object sender, EventArgs e)
        {
            tbQuant.SelectAll();
        }
    }
}
