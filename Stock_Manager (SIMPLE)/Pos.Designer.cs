using System.Drawing;

namespace Stock_Manager__SIMPLE_
{
    partial class Pos
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblVerQuant = new System.Windows.Forms.Label();
            this.tbVerQuant = new System.Windows.Forms.TextBox();
            this.separatorBar = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblCod = new System.Windows.Forms.Label();
            this.tbCod = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pbProduct = new System.Windows.Forms.PictureBox();
            this.lbProduct = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblQuant = new System.Windows.Forms.Label();
            this.tbQuant = new System.Windows.Forms.TextBox();
            this.pbPreView = new System.Windows.Forms.PictureBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.btnAddImg = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAddProduto = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.ttExit = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProduct)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblVerQuant);
            this.panel1.Controls.Add(this.tbVerQuant);
            this.panel1.Controls.Add(this.separatorBar);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.lblCod);
            this.panel1.Controls.Add(this.tbCod);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.pbProduct);
            this.panel1.Controls.Add(this.lbProduct);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.tbTotal);
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Location = new System.Drawing.Point(130, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 295);
            this.panel1.TabIndex = 14;
            // 
            // lblVerQuant
            // 
            this.lblVerQuant.AutoSize = true;
            this.lblVerQuant.Location = new System.Drawing.Point(130, 216);
            this.lblVerQuant.Name = "lblVerQuant";
            this.lblVerQuant.Size = new System.Drawing.Size(62, 13);
            this.lblVerQuant.TabIndex = 15;
            this.lblVerQuant.Text = "Quantidade";
            // 
            // tbVerQuant
            // 
            this.tbVerQuant.Location = new System.Drawing.Point(198, 213);
            this.tbVerQuant.Name = "tbVerQuant";
            this.tbVerQuant.Size = new System.Drawing.Size(121, 20);
            this.tbVerQuant.TabIndex = 16;
            this.tbVerQuant.TabStop = false;
            // 
            // separatorBar
            // 
            this.separatorBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.separatorBar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.separatorBar.Location = new System.Drawing.Point(-2, 240);
            this.separatorBar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.separatorBar.Name = "separatorBar";
            this.separatorBar.Size = new System.Drawing.Size(322, 1);
            this.separatorBar.TabIndex = 9;
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::Stock_Manager__SIMPLE_.Properties.Resources.exit;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(278, 244);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(40, 49);
            this.btnExit.TabIndex = 5;
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ttExit.SetToolTip(this.btnExit, "Sair");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Black;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(216, 13);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(58, 20);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Procurar";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Location = new System.Drawing.Point(-2, 15);
            this.lblCod.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(95, 13);
            this.lblCod.TabIndex = 2;
            this.lblCod.Text = "Código do Produto";
            // 
            // tbCod
            // 
            this.tbCod.BackColor = System.Drawing.Color.White;
            this.tbCod.Location = new System.Drawing.Point(97, 13);
            this.tbCod.Margin = new System.Windows.Forms.Padding(2);
            this.tbCod.Name = "tbCod";
            this.tbCod.Size = new System.Drawing.Size(116, 20);
            this.tbCod.TabIndex = 0;
            this.tbCod.Enter += new System.EventHandler(this.tbCod_Enter);
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(0, 271);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Eliminar produto";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // pbProduct
            // 
            this.pbProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbProduct.Location = new System.Drawing.Point(0, 47);
            this.pbProduct.Margin = new System.Windows.Forms.Padding(2);
            this.pbProduct.Name = "pbProduct";
            this.pbProduct.Size = new System.Drawing.Size(150, 134);
            this.pbProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProduct.TabIndex = 1;
            this.pbProduct.TabStop = false;
            // 
            // lbProduct
            // 
            this.lbProduct.FormattingEnabled = true;
            this.lbProduct.Location = new System.Drawing.Point(166, 47);
            this.lbProduct.Margin = new System.Windows.Forms.Padding(2);
            this.lbProduct.Name = "lbProduct";
            this.lbProduct.Size = new System.Drawing.Size(153, 134);
            this.lbProduct.TabIndex = 2;
            this.lbProduct.SelectedIndexChanged += new System.EventHandler(this.lbProduct_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(0, 244);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Adicionar produto";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(198, 190);
            this.tbTotal.Margin = new System.Windows.Forms.Padding(2);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(121, 20);
            this.tbTotal.TabIndex = 5;
            this.tbTotal.TabStop = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(130, 193);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.lblQuant);
            this.panel2.Controls.Add(this.tbQuant);
            this.panel2.Controls.Add(this.pbPreView);
            this.panel2.Controls.Add(this.tbPrice);
            this.panel2.Controls.Add(this.btnAddImg);
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Controls.Add(this.btnAddProduto);
            this.panel2.Controls.Add(this.tbName);
            this.panel2.Controls.Add(this.lblPrice);
            this.panel2.Controls.Add(this.lblName);
            this.panel2.Location = new System.Drawing.Point(130, 10);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(320, 295);
            this.panel2.TabIndex = 15;
            // 
            // lblQuant
            // 
            this.lblQuant.AutoSize = true;
            this.lblQuant.Location = new System.Drawing.Point(65, 61);
            this.lblQuant.Name = "lblQuant";
            this.lblQuant.Size = new System.Drawing.Size(62, 13);
            this.lblQuant.TabIndex = 12;
            this.lblQuant.Text = "Quantidade";
            // 
            // tbQuant
            // 
            this.tbQuant.Location = new System.Drawing.Point(156, 58);
            this.tbQuant.Name = "tbQuant";
            this.tbQuant.Size = new System.Drawing.Size(98, 20);
            this.tbQuant.TabIndex = 8;
            this.tbQuant.Text = "0";
            this.tbQuant.Click += new System.EventHandler(this.tbQuant_Click);
            // 
            // pbPreView
            // 
            this.pbPreView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbPreView.Location = new System.Drawing.Point(75, 128);
            this.pbPreView.Name = "pbPreView";
            this.pbPreView.Size = new System.Drawing.Size(178, 126);
            this.pbPreView.TabIndex = 10;
            this.pbPreView.TabStop = false;
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(156, 35);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(98, 20);
            this.tbPrice.TabIndex = 7;
            // 
            // btnAddImg
            // 
            this.btnAddImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddImg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAddImg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnAddImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddImg.Location = new System.Drawing.Point(156, 81);
            this.btnAddImg.Name = "btnAddImg";
            this.btnAddImg.Size = new System.Drawing.Size(99, 23);
            this.btnAddImg.TabIndex = 9;
            this.btnAddImg.Text = "Inserir imagem";
            this.btnAddImg.UseVisualStyleBackColor = true;
            this.btnAddImg.Click += new System.EventHandler(this.btnAddImg_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = global::Stock_Manager__SIMPLE_.Properties.Resources.wrong;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(243, 111);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(11, 12);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAddProduto
            // 
            this.btnAddProduto.BackgroundImage = global::Stock_Manager__SIMPLE_.Properties.Resources.correct;
            this.btnAddProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddProduto.FlatAppearance.BorderSize = 0;
            this.btnAddProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduto.Location = new System.Drawing.Point(225, 111);
            this.btnAddProduto.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddProduto.Name = "btnAddProduto";
            this.btnAddProduto.Size = new System.Drawing.Size(11, 12);
            this.btnAddProduto.TabIndex = 10;
            this.btnAddProduto.UseVisualStyleBackColor = true;
            this.btnAddProduto.Click += new System.EventHandler(this.btnAddProduto_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(156, 12);
            this.tbName.Margin = new System.Windows.Forms.Padding(2);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(98, 20);
            this.tbName.TabIndex = 6;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(65, 38);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(35, 13);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = "Preço";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(63, 14);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(89, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nome do produto";
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(9, 10);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(76, 78);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // Pos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(523, 329);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Pos";
            this.Text = "Stock Manager V1.0";
            this.Load += new System.EventHandler(this.Pos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProduct)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.PictureBox pbProduct;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.TextBox tbCod;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.ListBox lbProduct;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label separatorBar;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ToolTip ttExit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAddProduto;
        private System.Windows.Forms.Button btnAddImg;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.PictureBox pbPreView;
        private System.Windows.Forms.Label lblQuant;
        private System.Windows.Forms.TextBox tbQuant;
        private System.Windows.Forms.TextBox tbVerQuant;
        private System.Windows.Forms.Label lblVerQuant;
    }
}

