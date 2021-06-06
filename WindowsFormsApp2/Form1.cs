using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        string connectionString = "Server=DESKTOP-6KJ2COE\\SQLEXPRESS;" +
                "Database=adonetdb;Trusted_Connection=True;";

        public Form1()
        {
            InitializeComponent();

            LogOutButton.Hide();

            tabControl1.Hide();
            dataGridView2.Hide();
        }

        private void LogInForm_Click(object sender, EventArgs e)
        {
            login loginForm = new login();
            loginForm.Show();

            LoginStatusColor();
        }

        async void LoginStatusColor()
        {
            while (!login.CheckLogIn)
            {
                await Task.Delay(100);
                
                if (login.CheckLogIn)
                {
                    LoginStatusLabel.ForeColor = Color.Lime;
                    ReadyStatusLabel.Visible = true;

                    tabControl1.Show();

                    LogOutButton.Show();
                    LogInForm_Button.Hide();
                    
                    try
                    {
                        LoadData();
                        StatusChanger(true);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    login.CheckLogIn = false;
                }
            }
        }

        private void LoadData()
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();

            string Query = "SELECT * FROM Goods ORDER BY Name";

            SqlCommand Command = new SqlCommand(Query, sqlConnection);

            SqlDataReader Reader = Command.ExecuteReader();

            List<string[]> sqlData = new List<string[]>();

            while (Reader.Read())
            {
                sqlData.Add(new string[4]);

                sqlData[sqlData.Count - 1][0] = Reader[0].ToString();
                sqlData[sqlData.Count - 1][1] = Reader[1].ToString();
                sqlData[sqlData.Count - 1][2] = Reader[2].ToString();
                sqlData[sqlData.Count - 1][3] = Reader[3].ToString();
            }

            Reader.Close();
            sqlConnection.Close();

            foreach (string[] s in sqlData)
            {
                dataGridView1.Rows.Add(s);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            try
            {
                LoadData();
                StatusChanger(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                AddData();
                StatusChanger(true);

                IdTextBox.Clear();
                ProductTextBox.Clear();
                PriceTextBox.Clear();
                QuantityTextBox.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }
        private void AddData()
        {
            int idItem = Convert.ToInt32(IdTextBox.Text);
            string productItem = ProductTextBox.Text;
            float priceItem = float.Parse(PriceTextBox.Text);
            int quantityItem = Convert.ToInt32(QuantityTextBox.Text);

            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            string Query = $"INSERT INTO Goods " +
                $"VALUES ('{idItem}', '{productItem}', '{priceItem}', '{quantityItem}')";
            SqlCommand Command = new SqlCommand(Query, sqlConnection);

            Command.ExecuteNonQuery();
            sqlConnection.Close();

            LatestAddition();
        }

        private void LatestAddition()
        {
            string latestAddition = $"{IdTextBox.Text}\t{ProductTextBox.Text}\t{PriceTextBox.Text}" +
                $"\t{QuantityTextBox.Text} \n";

            LatestAdditionTextBox.Text += latestAddition;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();


            string item = SearchTextBox.Text;
            if (item != "")
            {
                try
                {
                    SearchData(item);
                    dataGridView2.Show();
                    StatusChanger(true);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearTextBoxButton.PerformClick();
                }
            }
            else
            {
                dataGridView2.Hide();
                MessageBox.Show("Enter a name or ID to continue!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchData(string item)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();

            string Query;
            if (FindSimilarCheckBox.Checked)
            {
                if (byIdRadioButton.Checked)
                {
                    Query = $"SELECT * FROM Goods WHERE Id LIKE '{Convert.ToInt32(item)}%'";
                }
                else
                {
                    Query = $"SELECT * FROM Goods WHERE Name LIKE '{item}%'";
                }
            }
            else
            {
                if (byIdRadioButton.Checked)
                {
                    Query = $"SELECT * FROM Goods WHERE Id='{Convert.ToInt32(item)}'";
                }
                else
                {
                    Query = $"SELECT * FROM Goods WHERE Name='{item}'";
                }
            }

            SqlCommand Command = new SqlCommand(Query, sqlConnection);

            SqlDataReader Reader = Command.ExecuteReader();

            List<string[]> sqlData = new List<string[]>();

            while (Reader.Read())
            {
                sqlData.Add(new string[4]);

                sqlData[sqlData.Count - 1][0] = Reader[0].ToString();
                sqlData[sqlData.Count - 1][1] = Reader[1].ToString();
                sqlData[sqlData.Count - 1][2] = Reader[2].ToString();
                sqlData[sqlData.Count - 1][3] = Reader[3].ToString();
            }

            Reader.Close();
            sqlConnection.Close();

            FindSimilarCheckBox.Checked = true;

            foreach (string[] s in sqlData)
            {
                dataGridView2.Rows.Add(s);
            }

        }

        private void IdTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            string item = SearchTextBox.Text;
            if (item != "")
            {
                dataGridView2.Show();
                try
                {
                    DeleteData(item);
                    StatusChanger(true);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                dataGridView2.Rows.Clear();
            }
            else
            {
                dataGridView2.Hide();

                MessageBox.Show("Enter a name or ID to continue!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DeleteData(string item)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();

            string Query;
            if (byIdRadioButton.Checked)
            {
                Query = $"Delete FROM Goods WHERE Id='{Convert.ToInt32(item)}'";
            }
            else
            {
                Query = $"Delete FROM Goods WHERE Name='{item}'";
            }

            SqlCommand Command = new SqlCommand(Query, sqlConnection);

            Command.ExecuteNonQuery();

            sqlConnection.Close();

        }

        private void ClearTextBoxButton_Click(object sender, EventArgs e)
        {
            SearchTextBox.Clear();
            dataGridView2.Rows.Clear();

        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            tabControl1.Hide();
            dataGridView2.Hide();

            dataGridView1.Rows.Clear();

            LogInForm_Button.Show();

            LoginStatusLabel.ForeColor = Color.Red;
            ReadyStatusLabel.Visible = false;

        }
        
        async private void StatusChanger(bool status)
        {
            if (status)
            {
                ReadyStatusLabel.Visible = false;
                CompletedStatusLabel.Visible = true;
                await Task.Delay(7000);
                CompletedStatusLabel.Visible = false;
                ReadyStatusLabel.Visible = true;
            }
        }

        private void ClearSearchEditTextBoxButton_Click(object sender, EventArgs e)
        {
            SearchEditTextBox.Clear();

            CurrentIdTextBox.Clear();
            CurrentNameTextBox.Clear();
            CurrentPriceTextBox.Clear();
            CurrentQuantityTextBox.Clear();

            NewIdTextBox.Clear();
            NewNameTextBox.Clear();
            NewPriceTextBox.Clear();
            NewQuantityTextBox.Clear();
        }

        private void SearchEditButton_Click(object sender, EventArgs e)
        {
            string item = SearchEditTextBox.Text;
            if (item != "")
            {
                try
                {
                    SearchEditData(item);
                    StatusChanger(true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearTextBoxButton.PerformClick();
                }
            }
            else
            {
                MessageBox.Show("Enter a name or ID to continue!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchEditData(string item)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            string Query;
            
            if (byIdRadioButton.Checked)
            {
                Query = $"SELECT * FROM Goods WHERE Id='{Convert.ToInt32(item)}'";
            }
            else
            {
                Query = $"SELECT * FROM Goods WHERE Name='{item}'";
            }
            

            SqlCommand Command = new SqlCommand(Query, sqlConnection);
            SqlDataReader Reader = Command.ExecuteReader();

            while(Reader.Read())
            {
                CurrentIdTextBox.Text = Reader[0].ToString();
                CurrentNameTextBox.Text = Reader[1].ToString();
                CurrentPriceTextBox.Text = Reader[2].ToString();
                CurrentQuantityTextBox.Text = Reader[3].ToString();

                NewIdTextBox.Text = Reader[0].ToString();
                NewNameTextBox.Text = Reader[1].ToString();
                NewPriceTextBox.Text = Reader[2].ToString();
                NewQuantityTextBox.Text = Reader[3].ToString();
            }

            Reader.Close();
            sqlConnection.Close();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            string item = SearchEditTextBox.Text;
            try
            {
                EditData(item);
                
                StatusChanger(true);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditData(string item)
        {
            int idItem = Convert.ToInt32(NewIdTextBox.Text);
            string productItem = NewNameTextBox.Text;
            float priceItem = float.Parse(NewPriceTextBox.Text);
            int quantityItem = Convert.ToInt32(NewQuantityTextBox.Text);

            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            string Query;


            if (ByIdEditRadioButton.Checked)
            {
                Query = $"UPDATE Goods " +
                    $"SET Id = {idItem}, Name = '{productItem}', Price = {priceItem}, Quantity = {quantityItem} " +
                    $"WHERE Id = {Convert.ToInt32(item)}";
            }
            else
            {
                Query = $"UPDATE Goods " +
                    $"SET Id = {idItem}, Name = '{productItem}', Price = {priceItem}, Quantity = {quantityItem} " +
                    $"WHERE Name = '{item}'";
            }


            SqlCommand Command = new SqlCommand(Query, sqlConnection);

            Command.ExecuteNonQuery();
            sqlConnection.Close();
        }

        private void AddTabPage_Click(object sender, EventArgs e)
        {

        }
    }
}
