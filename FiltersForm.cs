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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace dbapp
{
    public partial class FiltersForm : Form
    {
        NpgsqlCommand cmd = new NpgsqlCommand();
        public static List<Label> labels = new List<Label>();
        public static List<System.Windows.Forms.TextBox> textBoxes = new List<System.Windows.Forms.TextBox>();
        public static List<System.Windows.Forms.ComboBox> comboBoxes = new List<System.Windows.Forms.ComboBox>();
        public static List<System.Windows.Forms.Button> buttons= new List<System.Windows.Forms.Button>();
        public FiltersForm()
        {
            InitializeComponent();
            labels.Add(panel_label1);
            textBoxes.Add(panel_textBox1);
            comboBoxes.Add(type_comboBox1);
            buttons.Add(delete_button1);
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ok_button_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost; Port=5432; Database=travel_agency; UserId=postgres; Password=588228; commandTimeout=120;";
            NpgsqlConnection conn = new NpgsqlConnection(connectionString);
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                throw new Exception("Error connecting to the database", ex);
            }
            NpgsqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM airlines WHERE (" + line_textBox.Text + " )";
            //cmd.Parameters.AddWithValue("@line", line_textBox.Text);
            this.cmd = cmd;
            conn.Close();
            this.Close();
        }
        public NpgsqlCommand get_filter_command() 
        {
            return this.cmd;
        }

        private void cancel_panel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void apply_button_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost; Port=5432; Database=travel_agency; UserId=postgres; Password=588228; commandTimeout=120;";
            NpgsqlConnection conn = new NpgsqlConnection(connectionString);
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                throw new Exception("Error connecting to the database", ex);
            }
            NpgsqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM airlines WHERE (" + panel_label1.Text + " "
                + type_comboBox1.SelectedItem + " " + panel_textBox1.Text + " )";
            this.cmd = cmd;
            conn.Close();
            this.Close();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            Label newLabel = new Label();
            Label lastOldLabel = labels.LastOrDefault();
            if (lastOldLabel == null)
            {
                newLabel.Location = new Point(8, 63);
            }
            else
            {
                newLabel.Location = new Point(lastOldLabel.Location.X, lastOldLabel.Location.Y + 32);
            }
            if (airline_comboBox.SelectedItem != null) 
            {
                newLabel.Text = airline_comboBox.SelectedItem.ToString();
            }
            else
            {
                newLabel.Text = "airline_id";
            }

            labels.Add(newLabel);
            panel_tabPage.Controls.Add(newLabel);

            System.Windows.Forms.ComboBox newComboBox = new System.Windows.Forms.ComboBox();
            System.Windows.Forms.ComboBox lastOldComboBox = comboBoxes.LastOrDefault();
            if(lastOldComboBox == null) 
            {
                newComboBox.Items.Add('=');
                newComboBox.Items.Add("LIKE");
                newComboBox.Location = new Point(136, 59);
            }
            else
            {
                newComboBox.Size = lastOldComboBox.Size;
                newComboBox.Location = new Point(lastOldComboBox.Location.X, lastOldComboBox.Location.Y + 32);
            }
            comboBoxes.Add(newComboBox);
            panel_tabPage.Controls.Add(newComboBox);

            System.Windows.Forms.TextBox newTextBox = new System.Windows.Forms.TextBox();
            System.Windows.Forms.TextBox lastOldTextBox = textBoxes.LastOrDefault();
            if (lastOldTextBox == null)
            {
                newTextBox.Location = new Point(293, 61);
                newTextBox.Size = new Size(125, 27);
            }
            else
            {
                newTextBox.Location = new Point(lastOldTextBox.Location.X, lastOldTextBox.Location.Y + 32);
                newTextBox.Size = lastOldTextBox.Size;
            }
            textBoxes.Add(newTextBox);
            panel_tabPage.Controls.Add(newTextBox);

            System.Windows.Forms.Button newButton = new System.Windows.Forms.Button();
            System.Windows.Forms.Button lastOdlButton = buttons.LastOrDefault();

            if(lastOdlButton == null) 
            {
                newButton.Location = new Point(424, 59);
            }
            else
            {
                newButton.Location = new Point(lastOdlButton.Location.X, lastOdlButton.Location.Y + 32);
            }
            newButton.Text = "Delete";
            newButton.Size = new Size(94, 29);
            buttons.Add(newButton);
            panel_tabPage.Controls.Add(newButton);
        }

        private void delete_button1_Click(object sender, EventArgs e)
        {

        }
    }
}
