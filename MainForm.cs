using dbapp;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
using test;

namespace DataBaseApp_v._1._1
{
    public partial class MainForm : Form
    {
        int current_airline_id = 0;
        Airline current_airline = new Airline();
        public MainForm()
        {
            InitializeComponent();
            Load_data();
        }
        private void Load_data()
        {
            string connectionString = "Server=localhost; Port=5432; Database=travel_agency; UserId=postgres; Password=588228; commandTimeout=120;";
            NpgsqlConnection conn = new NpgsqlConnection(connectionString);
            try
            {
                conn.Open();
            }
            catch (Exception e)
            {
                throw new Exception("Error connecting to the database", e);
            }
            try
            {
                // getting data
                string sql = "SELECT * FROM airlines";
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(sql, conn);
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                ds.Reset();
                adapter.Fill(ds);
                dt = ds.Tables[0];
                airlines.DataSource = dt;
            }
            catch (Exception e)
            {
                throw new Exception("Error getting airlines data from database", e);
            }

            try
            {
                // getting data
                string sql = "SELECT * FROM branch";
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(sql, conn);
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                ds.Reset();
                adapter.Fill(ds);
                dt = ds.Tables[0];
                branch.DataSource = dt;
            }
            catch (Exception e)
            {
                throw new Exception("Error getting branch data from database", e);
            }
            try
            {
                // getting data
                string sql = "SELECT * FROM client";
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(sql, conn);
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                ds.Reset();
                adapter.Fill(ds);
                dt = ds.Tables[0];
                client.DataSource = dt;
            }
            catch (Exception e)
            {
                throw new Exception("Error getting client data from database", e);
            }
            try
            {
                // getting data
                string sql = "SELECT * FROM contract";
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(sql, conn);
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                ds.Reset();
                adapter.Fill(ds);
                dt = ds.Tables[0];
                contract.DataSource = dt;
            }
            catch (Exception e)
            {
                throw new Exception("Error getting contract data from database", e);
            }
            try
            {
                // getting data
                string sql = "SELECT * FROM employee";
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(sql, conn);
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                ds.Reset();
                adapter.Fill(ds);
                dt = ds.Tables[0];
                employee.DataSource = dt;
            }
            catch (Exception e)
            {
                throw new Exception("Error getting employee data from database", e);
            }
            try
            {
                // getting data
                string sql = "SELECT * FROM hotel";
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(sql, conn);
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                ds.Reset();
                adapter.Fill(ds);
                dt = ds.Tables[0];
                hotel.DataSource = dt;
            }
            catch (Exception e)
            {
                throw new Exception("Error getting hotel data from database", e);
            }
            try
            {
                // getting data
                string sql = "SELECT * FROM ticket";
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(sql, conn);
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                ds.Reset();
                adapter.Fill(ds);
                dt = ds.Tables[0];
                ticket.DataSource = dt;
            }
            catch (Exception e)
            {
                throw new Exception("Error getting ticket data from database", e);
            }
            try
            {
                // getting data
                string sql = "SELECT * FROM tour";
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(sql, conn);
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                ds.Reset();
                adapter.Fill(ds);
                dt = ds.Tables[0];
                tour.DataSource = dt;
            }
            catch (Exception e)
            {
                throw new Exception("Error getting tour data from database", e);
            }
            try
            {
                // getting data
                string sql = "SELECT * FROM trip";
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(sql, conn);
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                ds.Reset();
                adapter.Fill(ds);
                dt = ds.Tables[0];
                trip.DataSource = dt;
            }
            catch (Exception e)
            {
                throw new Exception("Error getting trip data from database", e);
            }


            conn.Close();

        }

        private void Load_data(NpgsqlCommand cmd) 
        {
            string connectionString = "Server=localhost; Port=5432; Database=travel_agency; UserId=postgres; Password=588228; commandTimeout=120;";
            NpgsqlConnection conn = new NpgsqlConnection(connectionString);
            try
            {
                conn.Open();
            }
            catch (Exception e)
            {
                throw new Exception("Error connecting to the database", e);
            }
            try
            {
                // getting data
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd.CommandText, conn);
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                ds.Reset();
                adapter.Fill(ds);
                dt = ds.Tables[0];
                airlines.DataSource = dt;
            }
            catch (Exception e)
            {
                throw new Exception("Error getting airlines data from database", e);
            }
        }

        private void add_airlines_button_Click(object sender, EventArgs e)
        {
            AirlinesForm airlinesForm = new AirlinesForm();
            airlinesForm.ShowDialog();
            Load_data();
        }

        private void edit_airlines_button_Click(object sender, EventArgs e)
        {
            AirlinesUpadateForm airlinesUpadateForm = new AirlinesUpadateForm(current_airline);
            airlinesUpadateForm.ShowDialog();
            Load_data();
        }

        private void delete_airlines_button_Click(object sender, EventArgs e)
        {
            //AirlinesDeleteForm airlinesDeleteform = new AirlinesDeleteForm();
            //airlinesDeleteform.ShowDialog();
            string connectionString = "Server=localhost; Port=5432; Database=travel_agency; UserId=postgres; Password=588228; commandTimeout=120;";
            NpgsqlConnection conn = new NpgsqlConnection(connectionString);
            conn.Open();
            NpgsqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM airlines WHERE airline_id = @id";
            cmd.Parameters.AddWithValue("@id", current_airline.AirlineId);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error delete airlines data from database", ex);
            }
            conn.Close();
            Load_data();
        }

        private void airlines_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                current_airline_id = e.RowIndex + 1;
            }
        }

        private void airlines_SelectionChanged(object sender, EventArgs e)
        {
            if(airlines.SelectedRows.Count > 0 && airlines.Rows.Count > airlines.NewRowIndex + 1) 
            {
                current_airline.AirlineId = Convert.ToInt32(airlines.SelectedRows[0].Cells[0].Value);
                current_airline.NameAirline = airlines.SelectedRows[0].Cells[1].Value.ToString();
                current_airline.Address = airlines.SelectedRows[0].Cells[2].Value.ToString();
                current_airline.Rating = Convert.ToInt32(airlines.SelectedRows[0].Cells[3].Value);

            }
        }

        private void filters_airlines_button_Click(object sender, EventArgs e)
        {
            FiltersForm filtersForm = new FiltersForm();
            filtersForm.ShowDialog();
            try
            {
                Load_data(filtersForm.get_filter_command());
            }
            catch 
            {
                filtersForm.Close();
            }
        }

        private void cancel_airline_filters_button_Click(object sender, EventArgs e)
        {
            Load_data();
        }
    }
}
