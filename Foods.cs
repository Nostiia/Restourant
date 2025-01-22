using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restourant
{
    public partial class Foods : Form
    {
        public Foods()
        {
            InitializeComponent();
            Con = new Functions();
            ShowFood();
        }
        Functions Con;
        private void ShowFood()
        {
            string Query = "Select * from FoodTbl";
            FoodDGV.DataSource = Con.GetData(Query);
        }

        int Key = 0;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            FNameTb.Text = "";
            PriceTb.Text = "";
            CategoryTb.Text = "";
            
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FNameTb.Text = FoodDGV.SelectedRows[0].Cells[1].Value.ToString();
            CategoryTb.Text = FoodDGV.SelectedRows[0].Cells[2].Value.ToString();
            PriceTb.Text = FoodDGV.SelectedRows[0].Cells[3].Value.ToString();
            if (Key == 0)
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(FoodDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void AddBtn_Click_1(object sender, EventArgs e)
        {
            if (FNameTb.Text == "" || CategoryTb.Text == "" || PriceTb.Text == "")
            {
                MessageBox.Show("You missed some data! Fill All items");
            }
            else
            {
                try
                {

                    string Fname = FNameTb.Text;
                    string Category = CategoryTb.Text;
                    int Price = Convert.ToInt32(PriceTb.Text);
                    string Query = "insert into FoodTbl values ('{0}','{1}',{2})";
                    Query = string.Format(Query, Fname, Category, Price);
                    Con.SetData(Query);
                    MessageBox.Show("You succesfully added new food");
                    ShowFood();
                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = FoodDGV.SelectedRows[0].Index;
            int Key = Convert.ToInt32(FoodDGV.Rows[selectedRowIndex].Cells["FCode"].Value);
            if (Key == 0)
            {
                MessageBox.Show("You didn`t select an item");
            }
            else
            {
                try
                {
                    string Query = "Delete from FoodTbl where FCode = {0}";
                    Query = string.Format(Query, Key);
                    Con.SetData(Query);
                    MessageBox.Show("You succesfully deleted");
                    ShowFood();
                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (FNameTb.Text == "" || CategoryTb.Text == "" || PriceTb.Text == "")
            {
                MessageBox.Show("You missed some data! Fill All items");
            }
            else
            {
                try
                {
                    int selectedRowIndex = FoodDGV.SelectedRows[0].Index;
                    int FCode = Convert.ToInt32(FoodDGV.Rows[selectedRowIndex].Cells["FCode"].Value);
                    string Fname = FNameTb.Text;
                    string Category = CategoryTb.Text;
                    int Price = Convert.ToInt32(PriceTb.Text);
                    string Query = "Update FoodTbl set FName = '{0}', FCategory = '{1}', FPrice= {2} where FCode = {3}";
                    Query = string.Format(Query, Fname, Category, Price, FCode);
                    Con.SetData(Query);
                    MessageBox.Show("You succesfully updated food");
                    ShowFood();
                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Billing Obj = new Billing();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Drinks drinks = new Drinks();
            drinks.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
