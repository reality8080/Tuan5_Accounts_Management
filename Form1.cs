using Microsoft.Data.SqlClient;
using System.Data;
using System.Net;

namespace Accounts
{
    public partial class Form1 : Form
    {
        private static String connectionString = "Data Source=(localdb)\\localThienPhu;Initial Catalog=AccountManage;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        public Form1()
        {
            InitializeComponent();
        }

        public static DataTable show()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SelectAll", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);
                }
                connection.Close();
            }
            return dataTable;
        }

        public static void insert(Int64 Serie, String Name, String Address, Double Balance)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("insertACC", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@serie", Serie);
                    command.Parameters.AddWithValue("@name", Name);
                    command.Parameters.AddWithValue("@address", Address);
                    command.Parameters.AddWithValue("@balance", Balance);
                    Int64 row = command.ExecuteNonQuery();
                    if (row > 0)
                    {
                        MessageBox.Show("Insert success");
                    }
                    else
                    {
                        MessageBox.Show("Insert fail");
                    }
                }
                connection.Close();
            }
        }

        public static void update(Int64 Serie, String Name, String Address, Double Balance)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("upDateACC", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@serie", Serie);
                    command.Parameters.AddWithValue("@name", Name);
                    command.Parameters.AddWithValue("@address", Address);
                    command.Parameters.AddWithValue("@balance", Balance);
                    Int64 row = command.ExecuteNonQuery();
                    if (row > 0)
                    {
                        MessageBox.Show("Update success");
                    }
                    //else
                    //{
                    //    MessageBox.Show("Update fail");
                    //}
                }
            }
        }
        public static void delete(Int64 Serie)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("deleteACC", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@serie", Serie);
                    Int64 row = command.ExecuteNonQuery();
                    if (row < 0)
                    {
                        MessageBox.Show("Delete success");
                    }
                    else
                    {
                        MessageBox.Show("Delete fail");
                    }
                }
            }
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            try
            {
                infoDGV.DataSource = show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Canh Bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            try
            {
                insert(Int64.Parse(serieTxt.Text), nameTxt.Text, addressTxt.Text, Convert.ToDouble(BalanceTxt.Text));
                infoDGV.DataSource = show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Canh Bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                delete(Int64.Parse(serieTxt.Text));
                infoDGV.DataSource = show();
                serieTxt.Clear();
                nameTxt.Clear();
                addressTxt.Clear();
                BalanceTxt.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Canh Bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                update(Int64.Parse(serieTxt.Text), nameTxt.Text, addressTxt.Text, Convert.ToDouble(BalanceTxt.Text));
                infoDGV.DataSource = show();
                serieTxt.Clear();
                nameTxt.Clear();
                addressTxt.Clear();
                BalanceTxt.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Canh Bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void infoDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = infoDGV.Rows[e.RowIndex];
                serieTxt.Text = row.Cells[1].Value?.ToString() ?? string.Empty;
                nameTxt.Text = row.Cells[2].Value?.ToString() ?? string.Empty;
                addressTxt.Text = row.Cells[3].Value?.ToString() ?? string.Empty;
                BalanceTxt.Text = row.Cells[4].Value?.ToString() ?? string.Empty;
                serieTxt.Enabled = false;
            }
        }

        private void serieTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Canh Bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void nameTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Canh Bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void addressTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '/')
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Canh Bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BalanceTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.')
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Canh Bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
