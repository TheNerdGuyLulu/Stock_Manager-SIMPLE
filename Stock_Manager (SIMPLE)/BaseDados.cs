using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace Stock_Manager__SIMPLE_
{
    public class BaseDados
    {
        string connectionString;
        SqlConnection productsSql;

        public BaseDados()
        {
            connectionString = ConfigurationManager.ConnectionStrings["products_DataBase"].ConnectionString;
            productsSql = new SqlConnection(connectionString);
            try
            {
                productsSql.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível connectar com a base de dados", "Erro");
                throw;
            }
        }

        public void Products(ListBox _listbox)
        {
            using (SqlDataAdapter fillData = new SqlDataAdapter("SELECT id, (CAST(id AS VARCHAR) + ' - ' + name) as productFullName FROM products", productsSql))
            {
                DataTable data = new DataTable();

                fillData.Fill(data);
                _listbox.DisplayMember = "productFullName";
                _listbox.ValueMember = "id";
                _listbox.DataSource = data;
                fillData.Dispose();
            }
        }

        public void InsertData(Product _product)
        {
            string command = "INSERT INTO products(name, price, quantity) VALUES (@name, @price, @quantity); SELECT SCOPE_IDENTITY();";
            SqlCommand cmd = new SqlCommand(command, productsSql);
            cmd.Parameters.AddWithValue("@name", _product.nomeProd.Trim());
            cmd.Parameters.AddWithValue("@price", _product.valorProd);
            cmd.Parameters.AddWithValue("@quantity", _product.quantidadeProd);
            SqlDataReader data = cmd.ExecuteReader();
            data.Read();
            int id = int.Parse(data[0].ToString());
            cmd.Dispose();
            data.Close();
            data.Dispose();
            if (Pos.fileopened == 1)
            {
                InsertImage(id);
                Pos.fileopened = 0;
            }
            else
                DeleteImage(id);
        }

        public static void InsertImage(int id)
        {
            Bitmap productImage = new Bitmap(Pos.open.FileName);
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

        public int CountRows()
        {
            string command = "SELECT COUNT(*) FROM products";
            SqlCommand cmd = new SqlCommand(command, productsSql);

            return (int)cmd.ExecuteScalar();
        }

        public DataTable PriceQuantity()
        {
            string command = "SELECT price, quantity, name FROM products";
            SqlCommand cmd = new SqlCommand(command, productsSql);
            DataTable results = new DataTable();
            SqlDataReader data = cmd.ExecuteReader();
            results.Load(data);
            cmd.Dispose();
            data.Dispose();
            data.Close();
            results.Dispose();
            return results;
        }

        public void DeleteData(int _selectedIndex)
        {
            string command = "DELETE FROM products WHERE id = @index";
            SqlCommand cmd = new SqlCommand(command, productsSql);
            cmd.Parameters.AddWithValue("@index", _selectedIndex);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }

        public void UpdateData(string _name, decimal _price, int _quantity, int _id)
        {
            string command = "UPDATE products SET name = @name, price = @price, quantity = @quantity WHERE id = @id";
            SqlCommand cmd = new SqlCommand(command, productsSql);
            cmd.Parameters.AddWithValue("@name", _name);
            cmd.Parameters.AddWithValue("@price", _price);
            cmd.Parameters.AddWithValue("@quantity", _quantity);
            cmd.Parameters.AddWithValue("@id", _id);
            cmd.ExecuteNonQuery();
            cmd.Dispose();

            if (Pos.fileopened == 1)
            {
                InsertImage(_id);
                Pos.fileopened = 0;
            }
        }
    }
}
