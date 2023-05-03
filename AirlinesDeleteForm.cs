using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class AirlinesDeleteForm : Form
    {
        public AirlinesDeleteForm()
        {
            InitializeComponent();
        }

        private void Delete_airlines_button_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost; Port=5432; Database=travel_agency; UserId=postgres; Password=588228; commandTimeout=120;";
            NpgsqlConnection conn = new NpgsqlConnection(connectionString);
            conn.Open();
            NpgsqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM airlines WHERE airline_id = @id";            
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(airline_id_textBox.Text));
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error insert airlines data to database", ex);
            }
            conn.Close();
            this.Close();
        }

        private void Cancel_airlines_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
