namespace WindowsFormsApplication1
{
    partial class new_employee_form
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
            this.id = new System.Windows.Forms.Label();
            this.first_name = new System.Windows.Forms.Label();
            this.last_name = new System.Windows.Forms.Label();
            this.birth_date = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_first_name = new System.Windows.Forms.TextBox();
            this.txt_last_name = new System.Windows.Forms.TextBox();
            this.txt_birth_date = new System.Windows.Forms.TextBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.employee_DGV = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.id_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.first_name_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.last_name_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birth_date_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.search_by_txt = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.employee_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(12, 18);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(18, 13);
            this.id.TabIndex = 0;
            this.id.Text = "ID";
            // 
            // first_name
            // 
            this.first_name.AutoSize = true;
            this.first_name.Location = new System.Drawing.Point(12, 43);
            this.first_name.Name = "first_name";
            this.first_name.Size = new System.Drawing.Size(57, 13);
            this.first_name.TabIndex = 1;
            this.first_name.Text = "First Name";
            // 
            // last_name
            // 
            this.last_name.AutoSize = true;
            this.last_name.Location = new System.Drawing.Point(12, 67);
            this.last_name.Name = "last_name";
            this.last_name.Size = new System.Drawing.Size(58, 13);
            this.last_name.TabIndex = 0;
            this.last_name.Text = "Last Name";
            // 
            // birth_date
            // 
            this.birth_date.AutoSize = true;
            this.birth_date.Location = new System.Drawing.Point(12, 92);
            this.birth_date.Name = "birth_date";
            this.birth_date.Size = new System.Drawing.Size(54, 13);
            this.birth_date.TabIndex = 1;
            this.birth_date.Text = "Birth Date";
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Location = new System.Drawing.Point(12, 118);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(45, 13);
            this.address.TabIndex = 1;
            this.address.Text = "Address";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(90, 15);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(244, 20);
            this.txt_id.TabIndex = 2;
            // 
            // txt_first_name
            // 
            this.txt_first_name.Location = new System.Drawing.Point(90, 40);
            this.txt_first_name.Name = "txt_first_name";
            this.txt_first_name.Size = new System.Drawing.Size(244, 20);
            this.txt_first_name.TabIndex = 2;
            // 
            // txt_last_name
            // 
            this.txt_last_name.Location = new System.Drawing.Point(90, 64);
            this.txt_last_name.Name = "txt_last_name";
            this.txt_last_name.Size = new System.Drawing.Size(244, 20);
            this.txt_last_name.TabIndex = 2;
            // 
            // txt_birth_date
            // 
            this.txt_birth_date.Location = new System.Drawing.Point(90, 89);
            this.txt_birth_date.Name = "txt_birth_date";
            this.txt_birth_date.Size = new System.Drawing.Size(244, 20);
            this.txt_birth_date.TabIndex = 2;
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(15, 214);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(341, 20);
            this.txt_search.TabIndex = 2;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(90, 141);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(244, 23);
            this.add.TabIndex = 3;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // employee_DGV
            // 
            this.employee_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employee_DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_column,
            this.first_name_column,
            this.last_name_column,
            this.birth_date_column,
            this.address_column});
            this.employee_DGV.Location = new System.Drawing.Point(15, 244);
            this.employee_DGV.Name = "employee_DGV";
            this.employee_DGV.Size = new System.Drawing.Size(544, 150);
            this.employee_DGV.TabIndex = 4;
            this.employee_DGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employee_DGV_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 412);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.clear_inputs);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(201, 412);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.reset_DGV);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(388, 412);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(171, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.exit_form);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(462, 213);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(95, 23);
            this.search.TabIndex = 3;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_click);
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(90, 115);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(244, 20);
            this.txt_address.TabIndex = 2;
            // 
            // id_column
            // 
            this.id_column.HeaderText = "ID";
            this.id_column.Name = "id_column";
            // 
            // first_name_column
            // 
            this.first_name_column.HeaderText = "First Name";
            this.first_name_column.Name = "first_name_column";
            // 
            // last_name_column
            // 
            this.last_name_column.HeaderText = "First Name";
            this.last_name_column.Name = "last_name_column";
            // 
            // birth_date_column
            // 
            this.birth_date_column.HeaderText = "Birth Date";
            this.birth_date_column.Name = "birth_date_column";
            // 
            // address_column
            // 
            this.address_column.HeaderText = "Address";
            this.address_column.Name = "address_column";
            // 
            // search_by_txt
            // 
            this.search_by_txt.FormattingEnabled = true;
            this.search_by_txt.Items.AddRange(new object[] {
            "id",
            "first_name",
            "last_name",
            "birth_date",
            "address"});
            this.search_by_txt.Location = new System.Drawing.Point(362, 214);
            this.search_by_txt.Name = "search_by_txt";
            this.search_by_txt.Size = new System.Drawing.Size(94, 21);
            this.search_by_txt.TabIndex = 5;
            // 
            // new_employee_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 460);
            this.Controls.Add(this.search_by_txt);
            this.Controls.Add(this.employee_DGV);
            this.Controls.Add(this.search);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.add);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.txt_birth_date);
            this.Controls.Add(this.txt_last_name);
            this.Controls.Add(this.txt_first_name);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.address);
            this.Controls.Add(this.birth_date);
            this.Controls.Add(this.last_name);
            this.Controls.Add(this.first_name);
            this.Controls.Add(this.id);
            this.Name = "new_employee_form";
            this.Text = "Add New Employee";
            this.Load += new System.EventHandler(this.new_employee_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employee_DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label first_name;
        private System.Windows.Forms.Label last_name;
        private System.Windows.Forms.Label birth_date;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_first_name;
        private System.Windows.Forms.TextBox txt_last_name;
        private System.Windows.Forms.TextBox txt_birth_date;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.DataGridView employee_DGV;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn first_name_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn last_name_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn birth_date_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn address_column;
        private System.Windows.Forms.ComboBox search_by_txt;
    }
}

