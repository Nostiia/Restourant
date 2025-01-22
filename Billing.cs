using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Restourant
{
    public partial class Billing : Form
    {
        public Billing()
        {
            InitializeComponent();
            Con = new Functions();
            ShowFood();
            ShowDrink();
        }

        Functions Con;
        private void ShowFood()
        {
            string Query = "Select * from FoodTbl";
            FoodDGV.DataSource = Con.GetData(Query);
        }
        private void ShowDrink()
        {
            string Query = "Select * from DrinkTbl";
            DrinkDGV.DataSource = Con.GetData(Query);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        int Key = 0;
        private void FoodDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ItemTb.Text = FoodDGV.SelectedRows[0].Cells[1].Value.ToString();
            //CategoryTb.Text = FoodDGV.SelectedRows[0].Cells[2].Value.ToString();
            PriceTb.Text = FoodDGV.SelectedRows[0].Cells[3].Value.ToString();
            if (ItemTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(FoodDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void DrinkDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ItemTb.Text = DrinkDGV.SelectedRows[0].Cells[1].Value.ToString();
            //CategoryTb.Text = FoodDGV.SelectedRows[0].Cells[2].Value.ToString();
            PriceTb.Text = DrinkDGV.SelectedRows[0].Cells[2].Value.ToString();
            if (ItemTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(DrinkDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
        int n = 0;
        int GrdTotal = 0;
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (QtyTb.Text == "" || PriceTb.Text == "")
            {
                MessageBox.Show("You missed some data");
            }
            else
            {
                int Qte = Convert.ToInt32(QtyTb.Text);
                int Total = Convert.ToInt32(PriceTb.Text) * Qte;
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(BillDGV);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = ItemTb.Text;
                newRow.Cells[2].Value = PriceTb;
                newRow.Cells[3].Value = QtyTb.Text;
                newRow.Cells[4].Value = "Rs " + Total;

                BillDGV.Rows.Add(newRow);
                n++;
                GrdTotal = GrdTotal + Total;
                GrdTotallbl.Text = "Rs " + GrdTotal;
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

        private void EditBtn_Click(object sender, EventArgs e)
        {
            ItemTb.Text = "";
            PriceTb.Text = "";
            QtyTb.Text = "";
            CustomerTb.Text = "";
            GrdTotallbl.Text = "";

        }

        private void payed_Click(object sender, EventArgs e)
        {
            BillDGV.Rows.Clear();
            GrdTotallbl.Text = "Price";
        }
    }
}
