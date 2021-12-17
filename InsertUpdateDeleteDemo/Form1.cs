using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormApplication;

namespace InsertUpdateDeleteDemo
{
    public partial class frmMain : Form
    {
        SqlConnection connection = DBAUtilities.GetConnection("DESKTOP-DL5TFII\\SQLEXPRESS", "Prova");
        SqlCommand command;
        SqlDataAdapter adapter;

        int ID = 0;
        public frmMain()
        {
            InitializeComponent();
            DisplayData();
        }
        private void DisplayData()
        {
            connection.Open();
            DataTable dt = new DataTable();
            adapter = new SqlDataAdapter("SELECT * FROM Immobili", connection);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }
        private void Insert_Click(object sender, EventArgs e)
        {
            if(id_tipo.Text != "" && via.Text != "" && superficie.Text != "" && vani.Text != "" && prezzo.Text != "" && id_proprietario.Text != "" && in_vendita.Text != "")
            {
                command = new SqlCommand("insert into Immobili(id_tipo, via, superficie, vani, prezzo, id_proprietario, in_vendita) " +
                    "values(@id_tipo, @via, @superficie, @vani, @prezzo, @id_proprietario, @in_vendita)", connection);
                connection.Open();
                command.Parameters.AddWithValue("@id_tipo", id_tipo.Text);
                command.Parameters.AddWithValue("@via", via.Text);
                command.Parameters.AddWithValue("@superficie", superficie.Text);
                command.Parameters.AddWithValue("@vani", vani.Text);
                command.Parameters.AddWithValue("@prezzo", prezzo.Text);
                command.Parameters.AddWithValue("@id_proprietario", id_proprietario.Text);
                command.Parameters.AddWithValue("@in_vendita", in_vendita.Text);
                command.ExecuteNonQuery();
                connection.Close();
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }
        }
        private void ClearData()
        {
            via.Text = "";
            id_proprietario.Text = "";
            id_tipo.Text = "";
            superficie.Text = "";
            vani.Text = "";
            prezzo.Text = "";
            in_vendita.Text = "";
            ID = 0;
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (id_tipo.Text != "" && via.Text != "" && superficie.Text != "" && vani.Text != "" && prezzo.Text != "" && id_proprietario.Text != "" && in_vendita.Text != "")
            {
                command = new SqlCommand("update Immobili set id_tipo=@id_tipo, via=@via, superficie=@superficie, vani=@vani, prezzo=@prezzo, id_proprietario=@id_proprietario, in_vendita=@in_vendita where ID=@id", connection);
                connection.Open();
                command.Parameters.AddWithValue("@id", ID);
                command.Parameters.AddWithValue("@id_tipo", id_tipo.Text);
                command.Parameters.AddWithValue("@via", via.Text);
                command.Parameters.AddWithValue("@superficie", superficie.Text);
                command.Parameters.AddWithValue("@vani", vani.Text);
                command.Parameters.AddWithValue("@prezzo", prezzo.Text);
                command.Parameters.AddWithValue("@id_proprietario", id_proprietario.Text);
                command.Parameters.AddWithValue("@in_vendita", in_vendita.Text);
                command.ExecuteNonQuery();
                connection.Close();
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                command = new SqlCommand("delete Immobili where ID=@id", connection);
                connection.Open();
                command.Parameters.AddWithValue("@id", ID);
                command.ExecuteNonQuery();
                connection.Close();
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            id_tipo.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            via.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            superficie.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            vani.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            prezzo.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            id_proprietario.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            in_vendita.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
        }
    }
}
