namespace dbapp
{
    partial class FiltersForm
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
            this.Filters_tabControl = new System.Windows.Forms.TabControl();
            this.line_tabPage = new System.Windows.Forms.TabPage();
            this.line_textBox = new System.Windows.Forms.TextBox();
            this.cancel_line_button = new System.Windows.Forms.Button();
            this.ok_button = new System.Windows.Forms.Button();
            this.panel_tabPage = new System.Windows.Forms.TabPage();
            this.delete_button1 = new System.Windows.Forms.Button();
            this.panel_textBox1 = new System.Windows.Forms.TextBox();
            this.type_comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel_label1 = new System.Windows.Forms.Label();
            this.cancel_panel_button = new System.Windows.Forms.Button();
            this.apply_button = new System.Windows.Forms.Button();
            this.generate_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.airline_comboBox = new System.Windows.Forms.ComboBox();
            this.Filters_tabControl.SuspendLayout();
            this.line_tabPage.SuspendLayout();
            this.panel_tabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // Filters_tabControl
            // 
            this.Filters_tabControl.Controls.Add(this.line_tabPage);
            this.Filters_tabControl.Controls.Add(this.panel_tabPage);
            this.Filters_tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Filters_tabControl.Location = new System.Drawing.Point(0, 0);
            this.Filters_tabControl.Name = "Filters_tabControl";
            this.Filters_tabControl.SelectedIndex = 0;
            this.Filters_tabControl.Size = new System.Drawing.Size(800, 450);
            this.Filters_tabControl.TabIndex = 0;
            // 
            // line_tabPage
            // 
            this.line_tabPage.Controls.Add(this.line_textBox);
            this.line_tabPage.Controls.Add(this.cancel_line_button);
            this.line_tabPage.Controls.Add(this.ok_button);
            this.line_tabPage.Location = new System.Drawing.Point(4, 29);
            this.line_tabPage.Name = "line_tabPage";
            this.line_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.line_tabPage.Size = new System.Drawing.Size(792, 417);
            this.line_tabPage.TabIndex = 0;
            this.line_tabPage.Text = "Line";
            this.line_tabPage.UseVisualStyleBackColor = true;
            // 
            // line_textBox
            // 
            this.line_textBox.Location = new System.Drawing.Point(3, 30);
            this.line_textBox.Name = "line_textBox";
            this.line_textBox.Size = new System.Drawing.Size(789, 27);
            this.line_textBox.TabIndex = 2;
            // 
            // cancel_line_button
            // 
            this.cancel_line_button.Location = new System.Drawing.Point(381, 98);
            this.cancel_line_button.Name = "cancel_line_button";
            this.cancel_line_button.Size = new System.Drawing.Size(100, 50);
            this.cancel_line_button.TabIndex = 1;
            this.cancel_line_button.Text = "Cancel";
            this.cancel_line_button.UseVisualStyleBackColor = true;
            this.cancel_line_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // ok_button
            // 
            this.ok_button.Location = new System.Drawing.Point(275, 98);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(100, 50);
            this.ok_button.TabIndex = 0;
            this.ok_button.Text = "OK";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // panel_tabPage
            // 
            this.panel_tabPage.Controls.Add(this.delete_button1);
            this.panel_tabPage.Controls.Add(this.panel_textBox1);
            this.panel_tabPage.Controls.Add(this.type_comboBox1);
            this.panel_tabPage.Controls.Add(this.panel_label1);
            this.panel_tabPage.Controls.Add(this.cancel_panel_button);
            this.panel_tabPage.Controls.Add(this.apply_button);
            this.panel_tabPage.Controls.Add(this.generate_button);
            this.panel_tabPage.Controls.Add(this.add_button);
            this.panel_tabPage.Controls.Add(this.airline_comboBox);
            this.panel_tabPage.Location = new System.Drawing.Point(4, 29);
            this.panel_tabPage.Name = "panel_tabPage";
            this.panel_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.panel_tabPage.Size = new System.Drawing.Size(792, 417);
            this.panel_tabPage.TabIndex = 1;
            this.panel_tabPage.Text = "Panel";
            this.panel_tabPage.UseVisualStyleBackColor = true;
            // 
            // delete_button1
            // 
            this.delete_button1.Location = new System.Drawing.Point(424, 59);
            this.delete_button1.Name = "delete_button1";
            this.delete_button1.Size = new System.Drawing.Size(94, 29);
            this.delete_button1.TabIndex = 8;
            this.delete_button1.Text = "Delete";
            this.delete_button1.UseVisualStyleBackColor = true;
            this.delete_button1.Click += new System.EventHandler(this.delete_button1_Click);
            // 
            // panel_textBox1
            // 
            this.panel_textBox1.Location = new System.Drawing.Point(293, 61);
            this.panel_textBox1.Name = "panel_textBox1";
            this.panel_textBox1.Size = new System.Drawing.Size(125, 27);
            this.panel_textBox1.TabIndex = 7;
            // 
            // type_comboBox1
            // 
            this.type_comboBox1.FormattingEnabled = true;
            this.type_comboBox1.Items.AddRange(new object[] {
            "LIKE",
            "="});
            this.type_comboBox1.Location = new System.Drawing.Point(136, 59);
            this.type_comboBox1.Name = "type_comboBox1";
            this.type_comboBox1.Size = new System.Drawing.Size(151, 28);
            this.type_comboBox1.TabIndex = 6;
            // 
            // panel_label1
            // 
            this.panel_label1.AutoSize = true;
            this.panel_label1.Location = new System.Drawing.Point(8, 64);
            this.panel_label1.Name = "panel_label1";
            this.panel_label1.Size = new System.Drawing.Size(69, 20);
            this.panel_label1.TabIndex = 5;
            this.panel_label1.Text = "airline_id";
            // 
            // cancel_panel_button
            // 
            this.cancel_panel_button.Location = new System.Drawing.Point(465, 6);
            this.cancel_panel_button.Name = "cancel_panel_button";
            this.cancel_panel_button.Size = new System.Drawing.Size(94, 29);
            this.cancel_panel_button.TabIndex = 4;
            this.cancel_panel_button.Text = "Cancel";
            this.cancel_panel_button.UseVisualStyleBackColor = true;
            this.cancel_panel_button.Click += new System.EventHandler(this.cancel_panel_button_Click);
            // 
            // apply_button
            // 
            this.apply_button.Location = new System.Drawing.Point(365, 5);
            this.apply_button.Name = "apply_button";
            this.apply_button.Size = new System.Drawing.Size(94, 29);
            this.apply_button.TabIndex = 3;
            this.apply_button.Text = "Apply";
            this.apply_button.UseVisualStyleBackColor = true;
            this.apply_button.Click += new System.EventHandler(this.apply_button_Click);
            // 
            // generate_button
            // 
            this.generate_button.Location = new System.Drawing.Point(265, 5);
            this.generate_button.Name = "generate_button";
            this.generate_button.Size = new System.Drawing.Size(94, 29);
            this.generate_button.TabIndex = 2;
            this.generate_button.Text = "Generate";
            this.generate_button.UseVisualStyleBackColor = true;
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(165, 5);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(94, 29);
            this.add_button.TabIndex = 1;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // airline_comboBox
            // 
            this.airline_comboBox.FormattingEnabled = true;
            this.airline_comboBox.Items.AddRange(new object[] {
            "airline_id",
            "name_airline",
            "address",
            "rating"});
            this.airline_comboBox.Location = new System.Drawing.Point(8, 6);
            this.airline_comboBox.Name = "airline_comboBox";
            this.airline_comboBox.Size = new System.Drawing.Size(151, 28);
            this.airline_comboBox.TabIndex = 0;
            // 
            // FiltersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Filters_tabControl);
            this.Name = "FiltersForm";
            this.Text = "Filters";
            this.Filters_tabControl.ResumeLayout(false);
            this.line_tabPage.ResumeLayout(false);
            this.line_tabPage.PerformLayout();
            this.panel_tabPage.ResumeLayout(false);
            this.panel_tabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl Filters_tabControl;
        private TabPage line_tabPage;
        private Button cancel_line_button;
        private Button ok_button;
        private TabPage panel_tabPage;
        private TextBox line_textBox;
        private ComboBox airline_comboBox;
        private Button cancel_panel_button;
        private Button apply_button;
        private Button generate_button;
        private Button add_button;
        private Button delete_button1;
        private TextBox panel_textBox1;
        private ComboBox type_comboBox1;
        private Label panel_label1;
    }
}