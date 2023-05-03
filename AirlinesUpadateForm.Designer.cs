namespace test
{
    partial class AirlinesUpadateForm
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
            this.address_textBox = new System.Windows.Forms.TextBox();
            this.rating_textBox = new System.Windows.Forms.TextBox();
            this.name_airline_textBox = new System.Windows.Forms.TextBox();
            this.name_airline_label = new System.Windows.Forms.Label();
            this.address_label = new System.Windows.Forms.Label();
            this.rating_label = new System.Windows.Forms.Label();
            this.Upadate_airlines_button = new System.Windows.Forms.Button();
            this.Cancel_airlines_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // airline_id_label
            // 
            this.airline_id_label.AutoSize = true;
            this.airline_id_label.Location = new System.Drawing.Point(40, 27);
            this.airline_id_label.Name = "airline_id_label";
            this.airline_id_label.Size = new System.Drawing.Size(69, 20);
            this.airline_id_label.TabIndex = 1;
            this.airline_id_label.Text = "airline_id";
            // 
            // airline_id_textBox
            // 
            this.airline_id_textBox.Location = new System.Drawing.Point(115, 27);
            this.airline_id_textBox.Name = "airline_id_textBox";
            this.airline_id_textBox.Size = new System.Drawing.Size(125, 27);
            this.airline_id_textBox.TabIndex = 2;
            // 
            // address_textBox
            // 
            this.address_textBox.Location = new System.Drawing.Point(115, 93);
            this.address_textBox.Name = "address_textBox";
            this.address_textBox.Size = new System.Drawing.Size(125, 27);
            this.address_textBox.TabIndex = 3;
            // 
            // rating_textBox
            // 
            this.rating_textBox.Location = new System.Drawing.Point(115, 126);
            this.rating_textBox.Name = "rating_textBox";
            this.rating_textBox.Size = new System.Drawing.Size(125, 27);
            this.rating_textBox.TabIndex = 4;
            // 
            // name_airline_textBox
            // 
            this.name_airline_textBox.Location = new System.Drawing.Point(115, 60);
            this.name_airline_textBox.Name = "name_airline_textBox";
            this.name_airline_textBox.Size = new System.Drawing.Size(125, 27);
            this.name_airline_textBox.TabIndex = 5;
            // 
            // name_airline_label
            // 
            this.name_airline_label.AutoSize = true;
            this.name_airline_label.Location = new System.Drawing.Point(16, 63);
            this.name_airline_label.Name = "name_airline_label";
            this.name_airline_label.Size = new System.Drawing.Size(93, 20);
            this.name_airline_label.TabIndex = 6;
            this.name_airline_label.Text = "name_airline";
            // 
            // address_label
            // 
            this.address_label.AutoSize = true;
            this.address_label.Location = new System.Drawing.Point(49, 93);
            this.address_label.Name = "address_label";
            this.address_label.Size = new System.Drawing.Size(60, 20);
            this.address_label.TabIndex = 7;
            this.address_label.Text = "address";
            // 
            // rating_label
            // 
            this.rating_label.AutoSize = true;
            this.rating_label.Location = new System.Drawing.Point(61, 126);
            this.rating_label.Name = "rating_label";
            this.rating_label.Size = new System.Drawing.Size(48, 20);
            this.rating_label.TabIndex = 8;
            this.rating_label.Text = "rating";
            // 
            // Upadate_airlines_button
            // 
            this.Upadate_airlines_button.Location = new System.Drawing.Point(40, 287);
            this.Upadate_airlines_button.Name = "Upadate_airlines_button";
            this.Upadate_airlines_button.Size = new System.Drawing.Size(94, 29);
            this.Upadate_airlines_button.TabIndex = 9;
            this.Upadate_airlines_button.Text = "Edit";
            this.Upadate_airlines_button.UseVisualStyleBackColor = true;
            this.Upadate_airlines_button.Click += new System.EventHandler(this.Upadate_airlines_button_Click);
            // 
            // Cancel_airlines_button
            // 
            this.Cancel_airlines_button.Location = new System.Drawing.Point(203, 287);
            this.Cancel_airlines_button.Name = "Cancel_airlines_button";
            this.Cancel_airlines_button.Size = new System.Drawing.Size(94, 29);
            this.Cancel_airlines_button.TabIndex = 10;
            this.Cancel_airlines_button.Text = "Cancel";
            this.Cancel_airlines_button.UseVisualStyleBackColor = true;
            this.Cancel_airlines_button.Click += new System.EventHandler(this.Cancel_airlines_button_Click);
            // 
            // AirlinesUpadateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 328);
            this.Controls.Add(this.Cancel_airlines_button);
            this.Controls.Add(this.Upadate_airlines_button);
            this.Controls.Add(this.rating_label);
            this.Controls.Add(this.address_label);
            this.Controls.Add(this.name_airline_label);
            this.Controls.Add(this.name_airline_textBox);
            this.Controls.Add(this.rating_textBox);
            this.Controls.Add(this.address_textBox);
            this.Controls.Add(this.airline_id_textBox);
            this.Controls.Add(this.airline_id_label);
            this.Name = "AirlinesUpadateForm";
            this.Text = "AirlinesUpadateForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label airline_id_label;
        private TextBox airline_id_textBox;
        private TextBox address_textBox;
        private TextBox rating_textBox;
        private TextBox name_airline_textBox;
        private Label name_airline_label;
        private Label address_label;
        private Label rating_label;
        private Button Upadate_airlines_button;
        private Button Cancel_airlines_button;
    }
}