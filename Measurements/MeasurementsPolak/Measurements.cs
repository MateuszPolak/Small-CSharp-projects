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

namespace MeasurementsPolak
{
    public partial class Measurements : Form
    {

        
        

        public Measurements()
        {
            InitializeComponent();
            this.Text = "Measurements";
            //
            loadlist();
        }

        private void Measurements_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'databaseMeasurementsDataSet.TabMeas' . Możesz go przenieść lub usunąć.
            this.tabMeasTableAdapter.Fill(this.databaseMeasurementsDataSet.TabMeas);

        }


        private void buttonIns_Click(object sender, EventArgs e)
        {
            try
            {
                
                string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Matt\\source\\repos\\MeasurementsPolak\\MeasurementsPolak\\DatabaseMeasurements.mdf;Integrated Security = True";
                SqlConnection sqlCon = new SqlConnection();
                sqlCon.ConnectionString = connString;
                sqlCon.Open();
                //All commands
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlCon;
                //sqlCmd.Parameters.Clear();

                sqlCmd.CommandText = "INSERT INTO TabMeas (Time,Value,Comment) VALUES (@time,@value,@comment)";
                DateTime dateTimeVariable = DateTime.Now;
                sqlCmd.Parameters.AddWithValue("@time", dateTimeVariable);
                sqlCmd.Parameters.AddWithValue("@comment", textBoxComm.Text);
                sqlCmd.Parameters.AddWithValue("@value", textBoxVal.Text);
                sqlCmd.ExecuteNonQuery();
                textBoxVal.Text = "";
                textBoxComm.Text = "";
                sqlCon.Close();
                
                //In case of success
                MessageBox.Show("Saved succesfully");
                loadlist();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Task failed successfully");
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Matt\\source\\repos\\MeasurementsPolak\\MeasurementsPolak\\DatabaseMeasurements.mdf;Integrated Security = True";
                SqlConnection sqlCon = new SqlConnection();
                sqlCon.ConnectionString = connString;
                sqlCon.Open();
                //All commands
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlCon;

                sqlCmd.CommandText = "DELETE FROM TabMeas WHERE Id = @id";
                sqlCmd.Parameters.AddWithValue("@id", listBoxID.SelectedItem.ToString());

                sqlCmd.ExecuteNonQuery();

                textBoxVal.Text = "";
                textBoxComm.Text = "";
                sqlCon.Close();
                loadlist();
                MessageBox.Show("Deleted succesfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Task failed successfully");
            }
        }

        private void buttonUpd_Click(object sender, EventArgs e)
        {
            try
            {
                string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Matt\\source\\repos\\MeasurementsPolak\\MeasurementsPolak\\DatabaseMeasurements.mdf;Integrated Security = True";
                SqlConnection sqlCon = new SqlConnection();
                sqlCon.ConnectionString = connString;
                sqlCon.Open();
                //All commands
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = "UPDATE TabMeas SET time=@time, value=@value, comment=@comment WHERE Id = @id";
                DateTime dateTimeVariable = DateTime.Now;
                sqlCmd.Parameters.AddWithValue("@id", listBoxID.SelectedItem.ToString());
                sqlCmd.Parameters.AddWithValue("@time", dateTimeVariable);
                sqlCmd.Parameters.AddWithValue("@comment", textBoxComm.Text);
                sqlCmd.Parameters.AddWithValue("@value", textBoxVal.Text);
                sqlCmd.ExecuteNonQuery();

                textBoxVal.Text = "";
                textBoxComm.Text = "";
                sqlCon.Close();
                loadlist();
                //All commands
                MessageBox.Show("Update succesfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Task failed successfully");
            }
        }

        private void loadlist()
        {
            string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Matt\\source\\repos\\MeasurementsPolak\\MeasurementsPolak\\DatabaseMeasurements.mdf;Integrated Security = True";
            SqlConnection sqlCon = new SqlConnection();
            sqlCon.ConnectionString = connString;
            sqlCon.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM TabMeas", sqlCon);
            SqlDataReader reader = command.ExecuteReader();
            using (reader)
            {
                listBoxID.Items.Clear();
                listBoxTime.Items.Clear();
                listBoxVal.Items.Clear();
                listBoxComm.Items.Clear();
                while (reader.Read())
                {
                    listBoxID.Items.Add(reader[0].ToString());
                    listBoxTime.Items.Add(reader[1].ToString());
                    listBoxVal.Items.Add(reader[2].ToString());
                    listBoxComm.Items.Add(reader[3].ToString());
                }
            }
            sqlCon.Close();
            //GridView update
            SqlCommand sqlCmd = new SqlCommand("SELECT * FROM TabMeas", sqlCon);
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = sqlCmd;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = dbdataset;
                GridViewMeas.DataSource = dbdataset;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error 2");
            }
            finally
            {
                sqlCon.Close();
            }


        }

        private void GridViewMeas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
