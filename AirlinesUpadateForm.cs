using DataBaseApp_v._1._1;
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
    public partial class AirlinesUpadateForm : Form
    {
        Airline current_airline = new Airline(); 
        public AirlinesUpadateForm(Airline current_airline)
        {
            InitializeComponent();
            this.current_airline=current_airline;
            airline_id_textBox.Text = current_airline.AirlineId.ToString();
            name_airline_textBox.Text = current_airline.NameAirline;
            address_textBox.Text = current_airline.Address;
            rating_textBox.Text = current_airline.Rating.ToString();
        }

        private void Upadate_airlines_button_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost; Port=5432; Database=travel_agency; UserId=postgres; Password=588228; commandTimeout=120;";
            NpgsqlConnection conn = new NpgsqlConnection(connectionString);
            conn.Open();
            NpgsqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE airlines" +
                " SET airline_id = @id, name_airline = @name, address = @add, rating = @rat" +
                " WHERE airline_id = @oldID;";
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(airline_id_textBox.Text));
            cmd.Parameters.AddWithValue("@name",name_airline_textBox.Text);
            cmd.Parameters.AddWithValue("@add", address_textBox.Text);
            cmd.Parameters.AddWithValue("@rat", Convert.ToInt32(rating_textBox.Text));
            cmd.Parameters.AddWithValue("@oldID", current_airline.AirlineId);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error update airlines data", ex);
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
