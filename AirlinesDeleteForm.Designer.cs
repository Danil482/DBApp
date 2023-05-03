namespace test
{
    partial class AirlinesDeleteForm
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
            this.Delete_airlines_button = new System.Windows.Forms.Button();
            this.Cancel_airlines_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // airline_id_label
            // 
            this.airline_id_label.AutoSize = true;
            this.airline_id_label.Location = new System.Drawing.Point(50, 30);
            this.airline_id_label.Name = "airline_id_label";
            this.airline_id_label.Size = new System.Drawing.Size(69, 20);
            this.airline_id_label.TabIndex = 1;
            this.airline_id_label.Text = "airline_id";
            // 
            // airline_id_textBox
            // 
            this.airline_id_textBox.Location = new System.Drawing.Point(125, 27);
            this.airline_id_textBox.Name = "airline_id_textBox";
            this.airline_id_textBox.Size = new System.Drawing.Size(125, 27);
            this.airline_id_textBox.TabIndex = 2;
            // 
            // Delete_airlines_button
            // 
            this.Delete_airlines_button.Location = new System.Drawing.Point(40, 287);
            this.Delete_airlines_button.Name = "Delete_airlines_button";
            this.Delete_airlines_button.Size = new System.Drawing.Size(94, 29);
            this.Delete_airlines_button.TabIndex = 9;
            this.Delete_airlines_button.Text = "Delete";
            this.Delete_airlines_button.UseVisualStyleBackColor = true;
            this.Delete_airlines_button.Click += new System.EventHandler(this.Delete_airlines_button_Click);
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
            // AirlinesDeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 328);
            this.Controls.Add(this.Cancel_airlines_button);
            this.Controls.Add(this.Delete_airlines_button);
            this.Controls.Add(this.airline_id_textBox);
            this.Controls.Add(this.airline_id_label);
            this.Name = "AirlinesDeleteForm";
            this.Text = "Airlines_delete_form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label airline_id_label;
        private TextBox airline_id_textBox;
        private Button Delete_airlines_button;
        private Button Cancel_airlines_button;
    }
}