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
    public partial class Drinks : Form
    {
        public Drinks()
        {
            InitializeComponent();
            Con = new Functions();
            ShowDrink();
        }
        Functions Con;
        private void ShowDrink()
        {
            string Query = "Select * from DrinkTbl";
            DrinkDGV.DataSource = Con.GetData(Query);
        }
        int Key = 0;


        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (DNameTb.Text == "" || PriceTb.Text == "")
            {
                MessageBox.Show("You missed some data! Fill All items");
            }
            else
            {
                try
                {
                    int selectedRowIndex = DrinkDGV.SelectedRows[0].Index;
                    int DCode = Convert.ToInt32(DrinkDGV.Rows[selectedRowIndex].Cells["DCode"].Value);
                    string Dname = DNameTb.Text;
                    int Price = Convert.ToInt32(PriceTb.Text);
                    string Query = "Update DrinkTbl set DName = '{0}', DPrice= {1} where DCode = {2}";
                    Query = string.Format(Query, Dname, Price, DCode);
                    Con.SetData(Query);
                    MessageBox.Show("You succesfully updated Drink");
                    ShowDrink();
                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = DrinkDGV.SelectedRows[0].Index;
            int Key = Convert.ToInt32(DrinkDGV.Rows[selectedRowIndex].Cells["DCode"].Value);
            if (Key == 0)
            {
                MessageBox.Show("You didn`t select an item");
            }
            else
            {
                try
                {
                    string Query = "Delete from DrinkTbl where DCode = {0}";
                    Query = string.Format(Query, Key);
                    Con.SetData(Query);
                    MessageBox.Show("You succesfully deleted");
                    ShowDrink();
                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (DNameTb.Text == "" || PriceTb.Text == "")
            {
                MessageBox.Show("You missed some data! Fill All items");
            }
            else
            {
                try
                {

                    string Dname = DNameTb.Text;
                    int Price = Convert.ToInt32(PriceTb.Text);
                    string Query = "insert into DrinkTbl values ('{0}',{1})";
                    Query = string.Format(Query, Dname, Price);
                    Con.SetData(Query);
                    MessageBox.Show("You succesfully added new Drink");
                    ShowDrink();
                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void DrinkDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DNameTb.Text = DrinkDGV.SelectedRows[0].Cells[1].Value.ToString();
            PriceTb.Text = DrinkDGV.SelectedRows[0].Cells[2].Value.ToString();
            if (Key == 0)
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(DrinkDGV.SelectedRows[0].Cells[0].Value.ToString());
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Foods foods = new Foods();
            foods.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Billing Obj = new Billing();
            Obj.Show();
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

        private void label7_Click(object sender, EventArgs e)
        {
            DNameTb.Text = "";
            PriceTb.Text = "";
        }
    }
}
