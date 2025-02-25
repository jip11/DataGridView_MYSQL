using System;
using System.Windows.Forms;

using System.Data;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Xml.Linq;
using Mysqlx.Session;

namespace DataGridView_MySQL_CS
{
    public partial class Form1 : Form
    {
        int OffsetNum = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void ResetTable()
        {
            string sqlSelectAll = "SELECT * FROM products LIMIT 10";
            string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            using (MySqlConnection con = new MySqlConnection(constr))
            {
                con.Open();
                using (MySqlDataAdapter sda = new MySqlDataAdapter(sqlSelectAll, con))
                {
                    using (DataTable dt = new DataTable())
                    {
                        sda.Fill(dt);
                        dgvProducts.DataSource = dt;
                    }
                }
                con.Close();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ResetTable();
        }
        private void Form1_AddProduct()
        {
            string sqlAddProduct = "INSERT INTO products(name, category, quantity, price) VALUES(@name, @category, @quantity, @price)";
            string sqlSelectAll = "SELECT * FROM products LIMIT 10";

            string name = NameField.Text;
            string category = CategoryField.Text;
            int quantity = int.Parse(QuantityField.Text);
            int price = int.Parse(PriceField.Text);

            string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            using (MySqlConnection con = new MySqlConnection(constr))
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand(sqlAddProduct, con))
                {
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@category", category);
                    cmd.Parameters.AddWithValue("@quantity", quantity);
                    cmd.Parameters.AddWithValue("@price", price);

                    using (MySqlDataAdapter sda = new MySqlDataAdapter())
                    {
                        sda.InsertCommand = cmd;
                        sda.InsertCommand.ExecuteNonQuery();
                    }

                    using (MySqlDataAdapter sda = new MySqlDataAdapter(sqlSelectAll, con))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            dgvProducts.DataSource = dt;
                        }
                    }
                }
                con.Close();
            }
        }
        private void Delete_Product(int ProductId)
        {
            string sqlSelectAll = "SELECT * FROM products LIMIT 10";
            string sqlDeleteProduct = "DELETE from products WHERE id = @id";

            string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            using (MySqlConnection con = new MySqlConnection(constr))
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand(sqlDeleteProduct, con))
                {
                    cmd.Parameters.AddWithValue("@id", ProductId);

                    using (MySqlDataAdapter sda = new MySqlDataAdapter())
                    {
                        sda.InsertCommand = cmd;
                        sda.InsertCommand.ExecuteNonQuery();
                    }

                    using (MySqlDataAdapter sda = new MySqlDataAdapter(sqlSelectAll, con))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            dgvProducts.DataSource = dt;
                        }
                    }
                }
                con.Close();
            }
        }
        private void SearchById(int ProductId)
        {
            string sqlSelectById = "SELECT * FROM products WHERE id = @id";

            string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            using (MySqlConnection con = new MySqlConnection(constr))
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand(sqlSelectById, con))
                {
                    cmd.Parameters.AddWithValue("@id", ProductId);

                    using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            dgvProducts.DataSource = dt;
                        }
                    }
                }
                con.Close();
            }
        }
        
        private void PageFunction(int OffsetBy)
        {
            string sqlOffsetSelect = "SELECT * FROM products LIMIT 10 OFFSET @OffsetNum";

            if (OffsetNum == 0 && OffsetBy == -10)
            {
                return;
            }
            OffsetNum = OffsetNum + OffsetBy;
            

            string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            using (MySqlConnection con = new MySqlConnection(constr))
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand(sqlOffsetSelect, con))
                {
                    cmd.Parameters.AddWithValue("@OffsetNum", OffsetNum);

                    using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            dgvProducts.DataSource = dt;
                        }
                    }
                }
                con.Close();
            }
        }

        private void EndFunction()
        {
            string sqlCountProducts = "SELECT COUNT(*) FROM products";
            

            string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            using (MySqlConnection con = new MySqlConnection(constr))
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand(sqlCountProducts, con))
                {
                    using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            int Count = Convert.ToInt32(dt.Rows[0][0]);
                            Count = Count - Count % 10;
                            OffsetNum = 0;
                            PageFunction(Count);
                        }
                    }
                }
                con.Close();
            }
        }

        private void ClearForm()
        {
            NameField.Text = "";
            CategoryField.Text = "";
            QuantityField.Text = "";
            PriceField.Text = "";
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Form1_AddProduct();
            ClearForm();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            var Row = dgvProducts.SelectedRows[0];
            var Cell = Row.Cells[0];
            var Value = Cell.Value;
            string ProductId = dgvProducts.SelectedRows[0].Cells[0].Value.ToString();
            Delete_Product(int.Parse(ProductId));
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string ProductId = IdField.Text;
            SearchById(int.Parse(ProductId));
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            ResetTable();
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            ResetTable();
        }

        private void PageBackBtn_Click(object sender, EventArgs e)
        {
            PageFunction(-10);
        }

        private void PageForwardBtn_Click(object sender, EventArgs e)
        {
            PageFunction(10);
        }

        private void EndBtn_Click(object sender, EventArgs e)
        {
            EndFunction();
        }
    }
}
