namespace UK_Petrol
{
    partial class mainForm
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
            this.goToCustomersPageBttn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.customersPanel = new System.Windows.Forms.Panel();
            this.Customersbutton2 = new System.Windows.Forms.Button();
            this.customerpanel = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.totalPriceTxt = new System.Windows.Forms.TextBox();
            this.priceOfLitrTxt = new System.Windows.Forms.TextBox();
            this.amountOfLitrTxt = new System.Windows.Forms.TextBox();
            this.PetrolTypeTxt = new System.Windows.Forms.TextBox();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.numberTxt = new System.Windows.Forms.TextBox();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BackToHomeBttn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notFoundLab = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.searchBttn = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.customersPanel.SuspendLayout();
            this.customerpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // goToCustomersPageBttn
            // 
            this.goToCustomersPageBttn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.goToCustomersPageBttn.AutoSize = true;
            this.goToCustomersPageBttn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.goToCustomersPageBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goToCustomersPageBttn.Location = new System.Drawing.Point(286, 455);
            this.goToCustomersPageBttn.Margin = new System.Windows.Forms.Padding(6);
            this.goToCustomersPageBttn.Name = "goToCustomersPageBttn";
            this.goToCustomersPageBttn.Size = new System.Drawing.Size(420, 137);
            this.goToCustomersPageBttn.TabIndex = 3;
            this.goToCustomersPageBttn.Text = "Customers";
            this.goToCustomersPageBttn.UseVisualStyleBackColor = false;
            this.goToCustomersPageBttn.Click += new System.EventHandler(this.goToCustomersPageBttn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(257, 182);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(585, 73);
            this.label1.TabIndex = 2;
            this.label1.Text = "Petroleum UK LTD";
            // 
            // customersPanel
            // 
            this.customersPanel.CausesValidation = false;
            this.customersPanel.Controls.Add(this.customerpanel);
            this.customersPanel.Controls.Add(this.Customersbutton2);
            this.customersPanel.Controls.Add(this.textBox1);
            this.customersPanel.Controls.Add(this.BackToHomeBttn);
            this.customersPanel.Controls.Add(this.notFoundLab);
            this.customersPanel.Controls.Add(this.label8);
            this.customersPanel.Controls.Add(this.searchBttn);
            this.customersPanel.Controls.Add(this.dataGridView2);
            this.customersPanel.Controls.Add(this.dataGridView1);
            this.customersPanel.Location = new System.Drawing.Point(-3, 2);
            this.customersPanel.Name = "customersPanel";
            this.customersPanel.Size = new System.Drawing.Size(1062, 855);
            this.customersPanel.TabIndex = 4;
            this.customersPanel.Visible = false;
            this.customersPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.customersPanel_Paint);
            // 
            // Customersbutton2
            // 
            this.Customersbutton2.Location = new System.Drawing.Point(231, 788);
            this.Customersbutton2.Margin = new System.Windows.Forms.Padding(6);
            this.Customersbutton2.Name = "Customersbutton2";
            this.Customersbutton2.Size = new System.Drawing.Size(150, 47);
            this.Customersbutton2.TabIndex = 16;
            this.Customersbutton2.Text = "Customers";
            this.Customersbutton2.UseVisualStyleBackColor = true;
            this.Customersbutton2.Visible = false;
            this.Customersbutton2.Click += new System.EventHandler(this.Customersbutton2_Click);
            // 
            // customerpanel
            // 
            this.customerpanel.Controls.Add(this.label10);
            this.customerpanel.Controls.Add(this.button2);
            this.customerpanel.Controls.Add(this.label9);
            this.customerpanel.Controls.Add(this.label6);
            this.customerpanel.Controls.Add(this.label7);
            this.customerpanel.Controls.Add(this.label4);
            this.customerpanel.Controls.Add(this.label5);
            this.customerpanel.Controls.Add(this.label3);
            this.customerpanel.Controls.Add(this.label2);
            this.customerpanel.Controls.Add(this.totalPriceTxt);
            this.customerpanel.Controls.Add(this.priceOfLitrTxt);
            this.customerpanel.Controls.Add(this.amountOfLitrTxt);
            this.customerpanel.Controls.Add(this.PetrolTypeTxt);
            this.customerpanel.Controls.Add(this.emailTxt);
            this.customerpanel.Controls.Add(this.numberTxt);
            this.customerpanel.Controls.Add(this.nameTxt);
            this.customerpanel.Location = new System.Drawing.Point(2, 3);
            this.customerpanel.Name = "customerpanel";
            this.customerpanel.Size = new System.Drawing.Size(1062, 754);
            this.customerpanel.TabIndex = 13;
            this.customerpanel.Visible = false;
            this.customerpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.customerpanel_Paint);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(122, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(303, 42);
            this.label10.TabIndex = 24;
            this.label10.Text = "Customer Details";
            this.label10.UseMnemonic = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(378, 662);
            this.button2.Margin = new System.Windows.Forms.Padding(6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(397, 47);
            this.button2.TabIndex = 23;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(127, 557);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 25);
            this.label9.TabIndex = 22;
            this.label9.Text = "Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(127, 487);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 25);
            this.label6.TabIndex = 21;
            this.label6.Text = "Price/Liter";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(127, 424);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 25);
            this.label7.TabIndex = 20;
            this.label7.Text = "Liters";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "Petrol";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(127, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "Email ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Phone Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Full name";
            // 
            // totalPriceTxt
            // 
            this.totalPriceTxt.Location = new System.Drawing.Point(378, 551);
            this.totalPriceTxt.Margin = new System.Windows.Forms.Padding(6);
            this.totalPriceTxt.Name = "totalPriceTxt";
            this.totalPriceTxt.Size = new System.Drawing.Size(397, 31);
            this.totalPriceTxt.TabIndex = 15;
            // 
            // priceOfLitrTxt
            // 
            this.priceOfLitrTxt.Location = new System.Drawing.Point(378, 481);
            this.priceOfLitrTxt.Margin = new System.Windows.Forms.Padding(6);
            this.priceOfLitrTxt.Name = "priceOfLitrTxt";
            this.priceOfLitrTxt.Size = new System.Drawing.Size(397, 31);
            this.priceOfLitrTxt.TabIndex = 14;
            // 
            // amountOfLitrTxt
            // 
            this.amountOfLitrTxt.Location = new System.Drawing.Point(378, 412);
            this.amountOfLitrTxt.Margin = new System.Windows.Forms.Padding(6);
            this.amountOfLitrTxt.Name = "amountOfLitrTxt";
            this.amountOfLitrTxt.Size = new System.Drawing.Size(397, 31);
            this.amountOfLitrTxt.TabIndex = 13;
            // 
            // PetrolTypeTxt
            // 
            this.PetrolTypeTxt.Location = new System.Drawing.Point(378, 343);
            this.PetrolTypeTxt.Margin = new System.Windows.Forms.Padding(6);
            this.PetrolTypeTxt.Name = "PetrolTypeTxt";
            this.PetrolTypeTxt.Size = new System.Drawing.Size(397, 31);
            this.PetrolTypeTxt.TabIndex = 12;
            // 
            // emailTxt
            // 
            this.emailTxt.Location = new System.Drawing.Point(378, 274);
            this.emailTxt.Margin = new System.Windows.Forms.Padding(6);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(397, 31);
            this.emailTxt.TabIndex = 11;
            // 
            // numberTxt
            // 
            this.numberTxt.Location = new System.Drawing.Point(378, 206);
            this.numberTxt.Margin = new System.Windows.Forms.Padding(6);
            this.numberTxt.Name = "numberTxt";
            this.numberTxt.Size = new System.Drawing.Size(397, 31);
            this.numberTxt.TabIndex = 10;
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(378, 137);
            this.nameTxt.Margin = new System.Windows.Forms.Padding(6);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(397, 31);
            this.nameTxt.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(16, 98);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(732, 62);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "Customer name";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // BackToHomeBttn
            // 
            this.BackToHomeBttn.Location = new System.Drawing.Point(23, 788);
            this.BackToHomeBttn.Margin = new System.Windows.Forms.Padding(6);
            this.BackToHomeBttn.Name = "BackToHomeBttn";
            this.BackToHomeBttn.Size = new System.Drawing.Size(150, 47);
            this.BackToHomeBttn.TabIndex = 8;
            this.BackToHomeBttn.Text = "Home";
            this.BackToHomeBttn.UseVisualStyleBackColor = true;
            this.BackToHomeBttn.Click += new System.EventHandler(this.BackToHomeBttn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(8, 216);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1051, 541);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Full Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Number";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Email";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // notFoundLab
            // 
            this.notFoundLab.AutoSize = true;
            this.notFoundLab.BackColor = System.Drawing.Color.Transparent;
            this.notFoundLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notFoundLab.ForeColor = System.Drawing.Color.Red;
            this.notFoundLab.Location = new System.Drawing.Point(16, 172);
            this.notFoundLab.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.notFoundLab.Name = "notFoundLab";
            this.notFoundLab.Size = new System.Drawing.Size(0, 37);
            this.notFoundLab.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(313, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(331, 55);
            this.label8.TabIndex = 15;
            this.label8.Text = "CUSTOMERS";
            // 
            // searchBttn
            // 
            this.searchBttn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBttn.AutoSize = true;
            this.searchBttn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.searchBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBttn.Location = new System.Drawing.Point(776, 94);
            this.searchBttn.Margin = new System.Windows.Forms.Padding(6);
            this.searchBttn.Name = "searchBttn";
            this.searchBttn.Size = new System.Drawing.Size(280, 78);
            this.searchBttn.TabIndex = 10;
            this.searchBttn.Text = "Search";
            this.searchBttn.UseVisualStyleBackColor = false;
            this.searchBttn.Click += new System.EventHandler(this.searchBttn_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.ColumnHeadersVisible = false;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4});
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.Location = new System.Drawing.Point(16, 161);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(732, 393);
            this.dataGridView2.TabIndex = 17;
            this.dataGridView2.Visible = false;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Full Name";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 876);
            this.Controls.Add(this.customersPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.goToCustomersPageBttn);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Petroleum UK Ltd ";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.customersPanel.ResumeLayout(false);
            this.customersPanel.PerformLayout();
            this.customerpanel.ResumeLayout(false);
            this.customerpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button goToCustomersPageBttn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel customersPanel;
        private System.Windows.Forms.Button searchBttn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BackToHomeBttn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label notFoundLab;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel customerpanel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox totalPriceTxt;
        private System.Windows.Forms.TextBox priceOfLitrTxt;
        private System.Windows.Forms.TextBox amountOfLitrTxt;
        private System.Windows.Forms.TextBox PetrolTypeTxt;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.TextBox numberTxt;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Button Customersbutton2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewLinkColumn Column4;
    }
}

