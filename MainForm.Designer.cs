namespace DataBaseApp_v._1._1
{
    partial class MainForm
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
            this.airlines = new System.Windows.Forms.DataGridView();
            this.airline_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_airline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabAirlines = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cancel_airline_filters_button = new System.Windows.Forms.Button();
            this.filters_airlines_button = new System.Windows.Forms.Button();
            this.delete_airlines_button = new System.Windows.Forms.Button();
            this.edit_airlines_button = new System.Windows.Forms.Button();
            this.add_airlines_button = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.delete_branch_button = new System.Windows.Forms.Button();
            this.edit_branch_button = new System.Windows.Forms.Button();
            this.add_branch_button = new System.Windows.Forms.Button();
            this.branch = new System.Windows.Forms.DataGridView();
            this.branch_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address_branch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.delete_client_button = new System.Windows.Forms.Button();
            this.edit_client_button = new System.Windows.Forms.Button();
            this.add_client_button = new System.Windows.Forms.Button();
            this.client = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.delete_contract_button = new System.Windows.Forms.Button();
            this.edit_contract_button = new System.Windows.Forms.Button();
            this.add_contract_button = new System.Windows.Forms.Button();
            this.contract = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.delete_employee_button = new System.Windows.Forms.Button();
            this.edit_employee_button = new System.Windows.Forms.Button();
            this.add_emplyee_button = new System.Windows.Forms.Button();
            this.employee = new System.Windows.Forms.DataGridView();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.delete_hote_button = new System.Windows.Forms.Button();
            this.edit_hotel_button = new System.Windows.Forms.Button();
            this.add_hotel_button = new System.Windows.Forms.Button();
            this.hotel = new System.Windows.Forms.DataGridView();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.delete_ticket_button = new System.Windows.Forms.Button();
            this.edit_ticket_button = new System.Windows.Forms.Button();
            this.add_ticket_button = new System.Windows.Forms.Button();
            this.ticket = new System.Windows.Forms.DataGridView();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tour = new System.Windows.Forms.DataGridView();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.trip = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.airlines)).BeginInit();
            this.tabAirlines.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.branch)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.client)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contract)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employee)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hotel)).BeginInit();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticket)).BeginInit();
            this.tabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tour)).BeginInit();
            this.tabPage9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trip)).BeginInit();
            this.SuspendLayout();
            // 
            // airlines
            // 
            this.airlines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.airlines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.airline_id,
            this.name_airline,
            this.address,
            this.rating});
            this.airlines.Location = new System.Drawing.Point(0, 0);
            this.airlines.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.airlines.Name = "airlines";
            this.airlines.RowHeadersWidth = 51;
            this.airlines.RowTemplate.Height = 24;
            this.airlines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.airlines.Size = new System.Drawing.Size(628, 515);
            this.airlines.TabIndex = 0;
            this.airlines.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.airlines_CellClick);
            this.airlines.SelectionChanged += new System.EventHandler(this.airlines_SelectionChanged);
            // 
            // airline_id
            // 
            this.airline_id.DataPropertyName = "airline_id";
            this.airline_id.HeaderText = "airline_id";
            this.airline_id.MinimumWidth = 6;
            this.airline_id.Name = "airline_id";
            this.airline_id.Width = 125;
            // 
            // name_airline
            // 
            this.name_airline.DataPropertyName = "name_airline";
            this.name_airline.HeaderText = "name_airline";
            this.name_airline.MinimumWidth = 6;
            this.name_airline.Name = "name_airline";
            this.name_airline.ReadOnly = true;
            this.name_airline.Width = 125;
            // 
            // address
            // 
            this.address.DataPropertyName = "address";
            this.address.HeaderText = "address";
            this.address.MinimumWidth = 6;
            this.address.Name = "address";
            this.address.ReadOnly = true;
            this.address.Width = 125;
            // 
            // rating
            // 
            this.rating.DataPropertyName = "rating";
            this.rating.HeaderText = "rating";
            this.rating.MinimumWidth = 6;
            this.rating.Name = "rating";
            this.rating.ReadOnly = true;
            this.rating.Width = 125;
            // 
            // tabAirlines
            // 
            this.tabAirlines.Controls.Add(this.tabPage1);
            this.tabAirlines.Controls.Add(this.tabPage2);
            this.tabAirlines.Controls.Add(this.tabPage3);
            this.tabAirlines.Controls.Add(this.tabPage4);
            this.tabAirlines.Controls.Add(this.tabPage5);
            this.tabAirlines.Controls.Add(this.tabPage6);
            this.tabAirlines.Controls.Add(this.tabPage7);
            this.tabAirlines.Controls.Add(this.tabPage8);
            this.tabAirlines.Controls.Add(this.tabPage9);
            this.tabAirlines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabAirlines.Location = new System.Drawing.Point(0, 0);
            this.tabAirlines.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabAirlines.Name = "tabAirlines";
            this.tabAirlines.SelectedIndex = 0;
            this.tabAirlines.Size = new System.Drawing.Size(800, 562);
            this.tabAirlines.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cancel_airline_filters_button);
            this.tabPage1.Controls.Add(this.filters_airlines_button);
            this.tabPage1.Controls.Add(this.delete_airlines_button);
            this.tabPage1.Controls.Add(this.edit_airlines_button);
            this.tabPage1.Controls.Add(this.add_airlines_button);
            this.tabPage1.Controls.Add(this.airlines);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(792, 529);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "airlines";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cancel_airline_filters_button
            // 
            this.cancel_airline_filters_button.Location = new System.Drawing.Point(669, 294);
            this.cancel_airline_filters_button.Name = "cancel_airline_filters_button";
            this.cancel_airline_filters_button.Size = new System.Drawing.Size(100, 50);
            this.cancel_airline_filters_button.TabIndex = 4;
            this.cancel_airline_filters_button.Text = "Cancel";
            this.cancel_airline_filters_button.UseVisualStyleBackColor = true;
            this.cancel_airline_filters_button.Click += new System.EventHandler(this.cancel_airline_filters_button_Click);
            // 
            // filters_airlines_button
            // 
            this.filters_airlines_button.Location = new System.Drawing.Point(669, 238);
            this.filters_airlines_button.Name = "filters_airlines_button";
            this.filters_airlines_button.Size = new System.Drawing.Size(100, 50);
            this.filters_airlines_button.TabIndex = 2;
            this.filters_airlines_button.Text = "Filters";
            this.filters_airlines_button.UseVisualStyleBackColor = true;
            this.filters_airlines_button.Click += new System.EventHandler(this.filters_airlines_button_Click);
            // 
            // delete_airlines_button
            // 
            this.delete_airlines_button.Location = new System.Drawing.Point(669, 181);
            this.delete_airlines_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.delete_airlines_button.Name = "delete_airlines_button";
            this.delete_airlines_button.Size = new System.Drawing.Size(100, 50);
            this.delete_airlines_button.TabIndex = 3;
            this.delete_airlines_button.Text = "Delete";
            this.delete_airlines_button.UseVisualStyleBackColor = true;
            this.delete_airlines_button.Click += new System.EventHandler(this.delete_airlines_button_Click);
            // 
            // edit_airlines_button
            // 
            this.edit_airlines_button.Location = new System.Drawing.Point(669, 124);
            this.edit_airlines_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.edit_airlines_button.Name = "edit_airlines_button";
            this.edit_airlines_button.Size = new System.Drawing.Size(100, 50);
            this.edit_airlines_button.TabIndex = 2;
            this.edit_airlines_button.Text = "Edit";
            this.edit_airlines_button.UseVisualStyleBackColor = true;
            this.edit_airlines_button.Click += new System.EventHandler(this.edit_airlines_button_Click);
            // 
            // add_airlines_button
            // 
            this.add_airlines_button.Location = new System.Drawing.Point(669, 66);
            this.add_airlines_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.add_airlines_button.Name = "add_airlines_button";
            this.add_airlines_button.Size = new System.Drawing.Size(100, 50);
            this.add_airlines_button.TabIndex = 1;
            this.add_airlines_button.Text = "Add";
            this.add_airlines_button.UseVisualStyleBackColor = true;
            this.add_airlines_button.Click += new System.EventHandler(this.add_airlines_button_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.delete_branch_button);
            this.tabPage2.Controls.Add(this.edit_branch_button);
            this.tabPage2.Controls.Add(this.add_branch_button);
            this.tabPage2.Controls.Add(this.branch);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(792, 529);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "branch";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // delete_branch_button
            // 
            this.delete_branch_button.Location = new System.Drawing.Point(669, 181);
            this.delete_branch_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.delete_branch_button.Name = "delete_branch_button";
            this.delete_branch_button.Size = new System.Drawing.Size(100, 50);
            this.delete_branch_button.TabIndex = 4;
            this.delete_branch_button.Text = "Delete";
            this.delete_branch_button.UseVisualStyleBackColor = true;
            // 
            // edit_branch_button
            // 
            this.edit_branch_button.Location = new System.Drawing.Point(669, 124);
            this.edit_branch_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.edit_branch_button.Name = "edit_branch_button";
            this.edit_branch_button.Size = new System.Drawing.Size(100, 50);
            this.edit_branch_button.TabIndex = 3;
            this.edit_branch_button.Text = "Edit";
            this.edit_branch_button.UseVisualStyleBackColor = true;
            // 
            // add_branch_button
            // 
            this.add_branch_button.Location = new System.Drawing.Point(669, 66);
            this.add_branch_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.add_branch_button.Name = "add_branch_button";
            this.add_branch_button.Size = new System.Drawing.Size(100, 50);
            this.add_branch_button.TabIndex = 2;
            this.add_branch_button.Text = "Add";
            this.add_branch_button.UseVisualStyleBackColor = true;
            // 
            // branch
            // 
            this.branch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.branch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.branch_id,
            this.address_branch,
            this.postcode});
            this.branch.Location = new System.Drawing.Point(0, 0);
            this.branch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.branch.Name = "branch";
            this.branch.RowHeadersWidth = 51;
            this.branch.RowTemplate.Height = 24;
            this.branch.Size = new System.Drawing.Size(628, 515);
            this.branch.TabIndex = 0;
            // 
            // branch_id
            // 
            this.branch_id.DataPropertyName = "branch_id";
            this.branch_id.HeaderText = "branch_id";
            this.branch_id.MinimumWidth = 6;
            this.branch_id.Name = "branch_id";
            this.branch_id.ReadOnly = true;
            this.branch_id.Width = 125;
            // 
            // address_branch
            // 
            this.address_branch.DataPropertyName = "address";
            this.address_branch.HeaderText = "address";
            this.address_branch.MinimumWidth = 6;
            this.address_branch.Name = "address_branch";
            this.address_branch.ReadOnly = true;
            this.address_branch.Width = 125;
            // 
            // postcode
            // 
            this.postcode.DataPropertyName = "postcode";
            this.postcode.HeaderText = "postcode";
            this.postcode.MinimumWidth = 6;
            this.postcode.Name = "postcode";
            this.postcode.ReadOnly = true;
            this.postcode.Width = 125;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.delete_client_button);
            this.tabPage3.Controls.Add(this.edit_client_button);
            this.tabPage3.Controls.Add(this.add_client_button);
            this.tabPage3.Controls.Add(this.client);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(792, 529);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "client";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // delete_client_button
            // 
            this.delete_client_button.Location = new System.Drawing.Point(669, 181);
            this.delete_client_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.delete_client_button.Name = "delete_client_button";
            this.delete_client_button.Size = new System.Drawing.Size(100, 50);
            this.delete_client_button.TabIndex = 5;
            this.delete_client_button.Text = "Delete";
            this.delete_client_button.UseVisualStyleBackColor = true;
            // 
            // edit_client_button
            // 
            this.edit_client_button.Location = new System.Drawing.Point(669, 124);
            this.edit_client_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.edit_client_button.Name = "edit_client_button";
            this.edit_client_button.Size = new System.Drawing.Size(100, 50);
            this.edit_client_button.TabIndex = 4;
            this.edit_client_button.Text = "Edit";
            this.edit_client_button.UseVisualStyleBackColor = true;
            // 
            // add_client_button
            // 
            this.add_client_button.Location = new System.Drawing.Point(669, 66);
            this.add_client_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.add_client_button.Name = "add_client_button";
            this.add_client_button.Size = new System.Drawing.Size(100, 50);
            this.add_client_button.TabIndex = 3;
            this.add_client_button.Text = "Add";
            this.add_client_button.UseVisualStyleBackColor = true;
            // 
            // client
            // 
            this.client.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.client.Location = new System.Drawing.Point(0, 0);
            this.client.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.client.Name = "client";
            this.client.RowHeadersWidth = 51;
            this.client.RowTemplate.Height = 24;
            this.client.Size = new System.Drawing.Size(628, 515);
            this.client.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.delete_contract_button);
            this.tabPage4.Controls.Add(this.edit_contract_button);
            this.tabPage4.Controls.Add(this.add_contract_button);
            this.tabPage4.Controls.Add(this.contract);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(792, 529);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "contract";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // delete_contract_button
            // 
            this.delete_contract_button.Location = new System.Drawing.Point(669, 181);
            this.delete_contract_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.delete_contract_button.Name = "delete_contract_button";
            this.delete_contract_button.Size = new System.Drawing.Size(100, 50);
            this.delete_contract_button.TabIndex = 6;
            this.delete_contract_button.Text = "Delete";
            this.delete_contract_button.UseVisualStyleBackColor = true;
            // 
            // edit_contract_button
            // 
            this.edit_contract_button.Location = new System.Drawing.Point(669, 124);
            this.edit_contract_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.edit_contract_button.Name = "edit_contract_button";
            this.edit_contract_button.Size = new System.Drawing.Size(100, 50);
            this.edit_contract_button.TabIndex = 5;
            this.edit_contract_button.Text = "Edit";
            this.edit_contract_button.UseVisualStyleBackColor = true;
            // 
            // add_contract_button
            // 
            this.add_contract_button.Location = new System.Drawing.Point(669, 66);
            this.add_contract_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.add_contract_button.Name = "add_contract_button";
            this.add_contract_button.Size = new System.Drawing.Size(100, 50);
            this.add_contract_button.TabIndex = 4;
            this.add_contract_button.Text = "Add";
            this.add_contract_button.UseVisualStyleBackColor = true;
            // 
            // contract
            // 
            this.contract.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contract.Location = new System.Drawing.Point(0, 0);
            this.contract.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.contract.Name = "contract";
            this.contract.RowHeadersWidth = 51;
            this.contract.RowTemplate.Height = 24;
            this.contract.Size = new System.Drawing.Size(628, 515);
            this.contract.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.delete_employee_button);
            this.tabPage5.Controls.Add(this.edit_employee_button);
            this.tabPage5.Controls.Add(this.add_emplyee_button);
            this.tabPage5.Controls.Add(this.employee);
            this.tabPage5.Location = new System.Drawing.Point(4, 29);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(792, 529);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "employee";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // delete_employee_button
            // 
            this.delete_employee_button.Location = new System.Drawing.Point(669, 181);
            this.delete_employee_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.delete_employee_button.Name = "delete_employee_button";
            this.delete_employee_button.Size = new System.Drawing.Size(100, 50);
            this.delete_employee_button.TabIndex = 7;
            this.delete_employee_button.Text = "Delete";
            this.delete_employee_button.UseVisualStyleBackColor = true;
            // 
            // edit_employee_button
            // 
            this.edit_employee_button.Location = new System.Drawing.Point(669, 124);
            this.edit_employee_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.edit_employee_button.Name = "edit_employee_button";
            this.edit_employee_button.Size = new System.Drawing.Size(100, 50);
            this.edit_employee_button.TabIndex = 6;
            this.edit_employee_button.Text = "Edit";
            this.edit_employee_button.UseVisualStyleBackColor = true;
            // 
            // add_emplyee_button
            // 
            this.add_emplyee_button.Location = new System.Drawing.Point(669, 66);
            this.add_emplyee_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.add_emplyee_button.Name = "add_emplyee_button";
            this.add_emplyee_button.Size = new System.Drawing.Size(100, 50);
            this.add_emplyee_button.TabIndex = 5;
            this.add_emplyee_button.Text = "Add";
            this.add_emplyee_button.UseVisualStyleBackColor = true;
            // 
            // employee
            // 
            this.employee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employee.Location = new System.Drawing.Point(0, 0);
            this.employee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.employee.Name = "employee";
            this.employee.RowHeadersWidth = 51;
            this.employee.RowTemplate.Height = 24;
            this.employee.Size = new System.Drawing.Size(628, 515);
            this.employee.TabIndex = 0;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.delete_hote_button);
            this.tabPage6.Controls.Add(this.edit_hotel_button);
            this.tabPage6.Controls.Add(this.add_hotel_button);
            this.tabPage6.Controls.Add(this.hotel);
            this.tabPage6.Location = new System.Drawing.Point(4, 29);
            this.tabPage6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(792, 529);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "hotel";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // delete_hote_button
            // 
            this.delete_hote_button.Location = new System.Drawing.Point(669, 181);
            this.delete_hote_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.delete_hote_button.Name = "delete_hote_button";
            this.delete_hote_button.Size = new System.Drawing.Size(100, 50);
            this.delete_hote_button.TabIndex = 8;
            this.delete_hote_button.Text = "Delete";
            this.delete_hote_button.UseVisualStyleBackColor = true;
            // 
            // edit_hotel_button
            // 
            this.edit_hotel_button.Location = new System.Drawing.Point(669, 124);
            this.edit_hotel_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.edit_hotel_button.Name = "edit_hotel_button";
            this.edit_hotel_button.Size = new System.Drawing.Size(100, 50);
            this.edit_hotel_button.TabIndex = 7;
            this.edit_hotel_button.Text = "Edit";
            this.edit_hotel_button.UseVisualStyleBackColor = true;
            // 
            // add_hotel_button
            // 
            this.add_hotel_button.Location = new System.Drawing.Point(669, 66);
            this.add_hotel_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.add_hotel_button.Name = "add_hotel_button";
            this.add_hotel_button.Size = new System.Drawing.Size(100, 50);
            this.add_hotel_button.TabIndex = 6;
            this.add_hotel_button.Text = "Add";
            this.add_hotel_button.UseVisualStyleBackColor = true;
            // 
            // hotel
            // 
            this.hotel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hotel.Location = new System.Drawing.Point(0, 0);
            this.hotel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hotel.Name = "hotel";
            this.hotel.RowHeadersWidth = 51;
            this.hotel.RowTemplate.Height = 24;
            this.hotel.Size = new System.Drawing.Size(628, 515);
            this.hotel.TabIndex = 0;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.delete_ticket_button);
            this.tabPage7.Controls.Add(this.edit_ticket_button);
            this.tabPage7.Controls.Add(this.add_ticket_button);
            this.tabPage7.Controls.Add(this.ticket);
            this.tabPage7.Location = new System.Drawing.Point(4, 29);
            this.tabPage7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(792, 529);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "ticket";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // delete_ticket_button
            // 
            this.delete_ticket_button.Location = new System.Drawing.Point(669, 181);
            this.delete_ticket_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.delete_ticket_button.Name = "delete_ticket_button";
            this.delete_ticket_button.Size = new System.Drawing.Size(100, 50);
            this.delete_ticket_button.TabIndex = 9;
            this.delete_ticket_button.Text = "Delete";
            this.delete_ticket_button.UseVisualStyleBackColor = true;
            // 
            // edit_ticket_button
            // 
            this.edit_ticket_button.Location = new System.Drawing.Point(669, 124);
            this.edit_ticket_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.edit_ticket_button.Name = "edit_ticket_button";
            this.edit_ticket_button.Size = new System.Drawing.Size(100, 50);
            this.edit_ticket_button.TabIndex = 8;
            this.edit_ticket_button.Text = "Edit";
            this.edit_ticket_button.UseVisualStyleBackColor = true;
            // 
            // add_ticket_button
            // 
            this.add_ticket_button.Location = new System.Drawing.Point(669, 66);
            this.add_ticket_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.add_ticket_button.Name = "add_ticket_button";
            this.add_ticket_button.Size = new System.Drawing.Size(100, 50);
            this.add_ticket_button.TabIndex = 7;
            this.add_ticket_button.Text = "Add";
            this.add_ticket_button.UseVisualStyleBackColor = true;
            // 
            // ticket
            // 
            this.ticket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ticket.Location = new System.Drawing.Point(0, 0);
            this.ticket.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ticket.Name = "ticket";
            this.ticket.RowHeadersWidth = 51;
            this.ticket.RowTemplate.Height = 24;
            this.ticket.Size = new System.Drawing.Size(628, 515);
            this.ticket.TabIndex = 0;
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.button3);
            this.tabPage8.Controls.Add(this.button2);
            this.tabPage8.Controls.Add(this.button1);
            this.tabPage8.Controls.Add(this.tour);
            this.tabPage8.Location = new System.Drawing.Point(4, 29);
            this.tabPage8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new System.Drawing.Size(792, 529);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "tour";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(669, 181);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 50);
            this.button3.TabIndex = 10;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(669, 124);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 50);
            this.button2.TabIndex = 9;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(669, 66);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 50);
            this.button1.TabIndex = 8;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tour
            // 
            this.tour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tour.Location = new System.Drawing.Point(0, 0);
            this.tour.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tour.Name = "tour";
            this.tour.RowHeadersWidth = 51;
            this.tour.RowTemplate.Height = 24;
            this.tour.Size = new System.Drawing.Size(628, 515);
            this.tour.TabIndex = 0;
            // 
            // tabPage9
            // 
            this.tabPage9.Controls.Add(this.button6);
            this.tabPage9.Controls.Add(this.button5);
            this.tabPage9.Controls.Add(this.button4);
            this.tabPage9.Controls.Add(this.trip);
            this.tabPage9.Location = new System.Drawing.Point(4, 29);
            this.tabPage9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Size = new System.Drawing.Size(792, 529);
            this.tabPage9.TabIndex = 8;
            this.tabPage9.Text = "trip";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(669, 181);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 50);
            this.button6.TabIndex = 11;
            this.button6.Text = "Delete";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(669, 124);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 50);
            this.button5.TabIndex = 10;
            this.button5.Text = "Edit";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(669, 66);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 50);
            this.button4.TabIndex = 9;
            this.button4.Text = "Add";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // trip
            // 
            this.trip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.trip.Location = new System.Drawing.Point(0, 0);
            this.trip.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.trip.Name = "trip";
            this.trip.RowHeadersWidth = 51;
            this.trip.RowTemplate.Height = 24;
            this.trip.Size = new System.Drawing.Size(628, 515);
            this.trip.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.tabAirlines);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.airlines)).EndInit();
            this.tabAirlines.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.branch)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.client)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.contract)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employee)).EndInit();
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hotel)).EndInit();
            this.tabPage7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ticket)).EndInit();
            this.tabPage8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tour)).EndInit();
            this.tabPage9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trip)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView airlines;
        private System.Windows.Forms.DataGridViewTextBoxColumn airline_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_airline;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn rating;
        private System.Windows.Forms.TabControl tabAirlines;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView branch;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.DataGridViewTextBoxColumn branch_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn address_branch;
        private System.Windows.Forms.DataGridViewTextBoxColumn postcode;
        private System.Windows.Forms.Button delete_airlines_button;
        private System.Windows.Forms.Button edit_airlines_button;
        private System.Windows.Forms.Button add_airlines_button;
        private System.Windows.Forms.DataGridView client;
        private System.Windows.Forms.Button delete_branch_button;
        private System.Windows.Forms.Button edit_branch_button;
        private System.Windows.Forms.Button add_branch_button;
        private System.Windows.Forms.Button delete_client_button;
        private System.Windows.Forms.Button edit_client_button;
        private System.Windows.Forms.Button add_client_button;
        private System.Windows.Forms.DataGridView contract;
        private System.Windows.Forms.Button delete_contract_button;
        private System.Windows.Forms.Button edit_contract_button;
        private System.Windows.Forms.Button add_contract_button;
        private System.Windows.Forms.DataGridView employee;
        private System.Windows.Forms.Button delete_employee_button;
        private System.Windows.Forms.Button edit_employee_button;
        private System.Windows.Forms.Button add_emplyee_button;
        private System.Windows.Forms.DataGridView hotel;
        private System.Windows.Forms.Button delete_hote_button;
        private System.Windows.Forms.Button edit_hotel_button;
        private System.Windows.Forms.Button add_hotel_button;
        private System.Windows.Forms.DataGridView ticket;
        private System.Windows.Forms.Button delete_ticket_button;
        private System.Windows.Forms.Button edit_ticket_button;
        private System.Windows.Forms.Button add_ticket_button;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView tour;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView trip;
        private Button cancel_airline_filters_button;
        private Button filters_airlines_button;
    }
}

