namespace test
{
    partial class AirlinesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.airline_id_label = new System.Windows.Forms.Label();
            this.airline_id_textBox = new System.Windows.Forms.TextBox();
            this.name_airline_label = new System.Windows.Forms.Label();
            this.name_airline_textBox = new System.Windows.Forms.TextBox();
            this.address_label = new System.Windows.Forms.Label();
            this.address_textBox = new System.Windows.Forms.TextBox();
            this.rating_label = new System.Windows.Forms.Label();
            this.rating_textBox = new System.Windows.Forms.TextBox();
            this.Add_airlines_button = new System.Windows.Forms.Button();
            this.Cancel_airlines_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // airline_id_label
            // 
            this.airline_id_label.AutoSize = true;
            this.airline_id_label.Location = new System.Drawing.Point(40, 27);
            this.airline_id_label.Name = "airline_id_label";
            this.airline_id_label.Size = new System.Drawing.Size(69, 20);
            this.airline_id_label.TabIndex = 0;
            this.airline_id_label.Text = "airline_id";
            // 
            // airline_id_textBox
            // 
            this.airline_id_textBox.Location = new System.Drawing.Point(115, 24);
            this.airline_id_textBox.Name = "airline_id_textBox";
            this.airline_id_textBox.Size = new System.Drawing.Size(125, 27);
            this.airline_id_textBox.TabIndex = 1;
            // 
            // name_airline_label
            // 
            this.name_airline_label.AutoSize = true;
            this.name_airline_label.Location = new System.Drawing.Point(16, 60);
            this.name_airline_label.Name = "name_airline_label";
            this.name_airline_label.Size = new System.Drawing.Size(93, 20);
            this.name_airline_label.TabIndex = 2;
            this.name_airline_label.Text = "name_airline";
            // 
            // name_airline_textBox
            // 
            this.name_airline_textBox.Location = new System.Drawing.Point(115, 57);
            this.name_airline_textBox.Name = "name_airline_textBox";
            this.name_airline_textBox.Size = new System.Drawing.Size(125, 27);
            this.name_airline_textBox.TabIndex = 3;
            // 
            // address_label
            // 
            this.address_label.AutoSize = true;
            this.address_label.Location = new System.Drawing.Point(49, 93);
            this.address_label.Name = "address_label";
            this.address_label.Size = new System.Drawing.Size(60, 20);
            this.address_label.TabIndex = 4;
            this.address_label.Text = "address";
            // 
            // address_textBox
            // 
            this.address_textBox.Location = new System.Drawing.Point(115, 90);
            this.address_textBox.Name = "address_textBox";
            this.address_textBox.Size = new System.Drawing.Size(125, 27);
            this.address_textBox.TabIndex = 5;
            // 
            // rating_label
            // 
            this.rating_label.AutoSize = true;
            this.rating_label.Location = new System.Drawing.Point(61, 124);
            this.rating_label.Name = "rating_label";
            this.rating_label.Size = new System.Drawing.Size(48, 20);
            this.rating_label.TabIndex = 6;
            this.rating_label.Text = "rating";
            // 
            // rating_textBox
            // 
            this.rating_textBox.Location = new System.Drawing.Point(115, 121);
            this.rating_textBox.Name = "rating_textBox";
            this.rating_textBox.Size = new System.Drawing.Size(125, 27);
            this.rating_textBox.TabIndex = 7;
            // 
            // Add_airlines_button
            // 
            this.Add_airlines_button.Location = new System.Drawing.Point(40, 287);
            this.Add_airlines_button.Name = "Add_airlines_button";
            this.Add_airlines_button.Size = new System.Drawing.Size(94, 29);
            this.Add_airlines_button.TabIndex = 8;
            this.Add_airlines_button.Text = "Add";
            this.Add_airlines_button.UseVisualStyleBackColor = true;
            this.Add_airlines_button.Click += new System.EventHandler(this.Add_airlines_button_Click);
            // 
            // Cancel_airlines_button
            // 
            this.Cancel_airlines_button.Location = new System.Drawing.Point(203, 287);
            this.Cancel_airlines_button.Name = "Cancel_airlines_button";
            this.Cancel_airlines_button.Size = new System.Drawing.Size(94, 29);
            this.Cancel_airlines_button.TabIndex = 9;
            this.Cancel_airlines_button.Text = "Cancel";
            this.Cancel_airlines_button.UseVisualStyleBackColor = true;
            this.Cancel_airlines_button.Click += new System.EventHandler(this.Cancel_airlines_button_Click);
            // 
            // AirlinesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 328);
            this.Controls.Add(this.Cancel_airlines_button);
            this.Controls.Add(this.Add_airlines_button);
            this.Controls.Add(this.rating_textBox);
            this.Controls.Add(this.rating_label);
            this.Controls.Add(this.address_textBox);
            this.Controls.Add(this.address_label);
            this.Controls.Add(this.name_airline_textBox);
            this.Controls.Add(this.name_airline_label);
            this.Controls.Add(this.airline_id_textBox);
            this.Controls.Add(this.airline_id_label);
            this.Name = "AirlinesForm";
            this.Text = "AirlineForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label airline_id_label;
        private TextBox airline_id_textBox;
        private Label name_airline_label;
        private TextBox name_airline_textBox;
        private Label address_label;
        private TextBox address_textBox;
        private Label rating_label;
        private TextBox rating_textBox;
        private Button Add_airlines_button;
        private Button Cancel_airlines_button;
    }
}