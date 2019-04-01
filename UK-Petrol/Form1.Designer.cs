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
            this.customerDitailspanel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.totalLab = new System.Windows.Forms.Label();
            this.literPriceLab = new System.Windows.Forms.Label();
            this.literLab = new System.Windows.Forms.Label();
            this.petrolLab = new System.Windows.Forms.Label();
            this.emailLab = new System.Windows.Forms.Label();
            this.PhoneLab = new System.Windows.Forms.Label();
            this.fullNameLab = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.customerpanel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.totalPriceTxt = new System.Windows.Forms.Label();
            this.priceOfLitrTxt = new System.Windows.Forms.Label();
            this.PetrolTypeTxt = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.amountOfLitrTxt = new System.Windows.Forms.TextBox();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.numberTxt = new System.Windows.Forms.TextBox();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.Insert = new System.Windows.Forms.Button();
            this.Customersbutton2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BackToHomeBttn = new System.Windows.Forms.Button();
            this.notFoundLab = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.searchBttn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveCustomerBtn = new System.Windows.Forms.Button();
            this.addNewCustomerLab = new System.Windows.Forms.Label();
            this.customersPanel.SuspendLayout();
            this.customerDitailspanel1.SuspendLayout();
            this.customerpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // goToCustomersPageBttn
            // 
            this.goToCustomersPageBttn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.goToCustomersPageBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goToCustomersPageBttn.Location = new System.Drawing.Point(156, 191);
            this.goToCustomersPageBttn.Name = "goToCustomersPageBttn";
            this.goToCustomersPageBttn.Size = new System.Drawing.Size(240, 63);
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
            this.label1.Location = new System.Drawing.Point(109, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "PETROLEUM UK LTD";
            // 
            // customersPanel
            // 
            this.customersPanel.CausesValidation = false;
            this.customersPanel.Controls.Add(this.customerpanel);
            this.customersPanel.Controls.Add(this.customerDitailspanel1);
            this.customersPanel.Controls.Add(this.Insert);
            this.customersPanel.Controls.Add(this.Customersbutton2);
            this.customersPanel.Controls.Add(this.textBox1);
            this.customersPanel.Controls.Add(this.BackToHomeBttn);
            this.customersPanel.Controls.Add(this.notFoundLab);
            this.customersPanel.Controls.Add(this.label8);
            this.customersPanel.Controls.Add(this.searchBttn);
            this.customersPanel.Controls.Add(this.dataGridView1);
            this.customersPanel.Location = new System.Drawing.Point(1, -2);
            this.customersPanel.Margin = new System.Windows.Forms.Padding(2);
            this.customersPanel.Name = "customersPanel";
            this.customersPanel.Size = new System.Drawing.Size(530, 445);
            this.customersPanel.TabIndex = 4;
            this.customersPanel.Visible = false;
            this.customersPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.customersPanel_Paint);
            // 
            // customerDitailspanel1
            // 
            this.customerDitailspanel1.Controls.Add(this.button1);
            this.customerDitailspanel1.Controls.Add(this.totalLab);
            this.customerDitailspanel1.Controls.Add(this.literPriceLab);
            this.customerDitailspanel1.Controls.Add(this.literLab);
            this.customerDitailspanel1.Controls.Add(this.petrolLab);
            this.customerDitailspanel1.Controls.Add(this.emailLab);
            this.customerDitailspanel1.Controls.Add(this.PhoneLab);
            this.customerDitailspanel1.Controls.Add(this.fullNameLab);
            this.customerDitailspanel1.Controls.Add(this.label17);
            this.customerDitailspanel1.Controls.Add(this.label18);
            this.customerDitailspanel1.Controls.Add(this.label19);
            this.customerDitailspanel1.Controls.Add(this.label20);
            this.customerDitailspanel1.Controls.Add(this.label21);
            this.customerDitailspanel1.Controls.Add(this.label22);
            this.customerDitailspanel1.Controls.Add(this.label23);
            this.customerDitailspanel1.Controls.Add(this.label24);
            this.customerDitailspanel1.Location = new System.Drawing.Point(0, 5);
            this.customerDitailspanel1.Name = "customerDitailspanel1";
            this.customerDitailspanel1.Size = new System.Drawing.Size(531, 393);
            this.customerDitailspanel1.TabIndex = 5;
            this.customerDitailspanel1.Visible = false;
            this.customerDitailspanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.customerDitailspanel1_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(261, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 24);
            this.button1.TabIndex = 39;
            this.button1.Text = "Edit Customer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // totalLab
            // 
            this.totalLab.AutoSize = true;
            this.totalLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLab.Location = new System.Drawing.Point(220, 271);
            this.totalLab.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalLab.Name = "totalLab";
            this.totalLab.Size = new System.Drawing.Size(0, 20);
            this.totalLab.TabIndex = 47;
            // 
            // literPriceLab
            // 
            this.literPriceLab.AutoSize = true;
            this.literPriceLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.literPriceLab.Location = new System.Drawing.Point(220, 240);
            this.literPriceLab.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.literPriceLab.Name = "literPriceLab";
            this.literPriceLab.Size = new System.Drawing.Size(0, 20);
            this.literPriceLab.TabIndex = 46;
            // 
            // literLab
            // 
            this.literLab.AutoSize = true;
            this.literLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.literLab.Location = new System.Drawing.Point(220, 205);
            this.literLab.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.literLab.Name = "literLab";
            this.literLab.Size = new System.Drawing.Size(0, 20);
            this.literLab.TabIndex = 45;
            // 
            // petrolLab
            // 
            this.petrolLab.AutoSize = true;
            this.petrolLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.petrolLab.Location = new System.Drawing.Point(220, 173);
            this.petrolLab.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.petrolLab.Name = "petrolLab";
            this.petrolLab.Size = new System.Drawing.Size(0, 20);
            this.petrolLab.TabIndex = 44;
            // 
            // emailLab
            // 
            this.emailLab.AutoSize = true;
            this.emailLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLab.Location = new System.Drawing.Point(220, 142);
            this.emailLab.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.emailLab.Name = "emailLab";
            this.emailLab.Size = new System.Drawing.Size(0, 20);
            this.emailLab.TabIndex = 43;
            // 
            // PhoneLab
            // 
            this.PhoneLab.AutoSize = true;
            this.PhoneLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneLab.Location = new System.Drawing.Point(220, 109);
            this.PhoneLab.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PhoneLab.Name = "PhoneLab";
            this.PhoneLab.Size = new System.Drawing.Size(0, 20);
            this.PhoneLab.TabIndex = 42;
            // 
            // fullNameLab
            // 
            this.fullNameLab.AutoSize = true;
            this.fullNameLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullNameLab.Location = new System.Drawing.Point(220, 77);
            this.fullNameLab.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fullNameLab.Name = "fullNameLab";
            this.fullNameLab.Size = new System.Drawing.Size(0, 20);
            this.fullNameLab.TabIndex = 41;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(55, 10);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(167, 24);
            this.label17.TabIndex = 40;
            this.label17.Text = "Customer Details";
            this.label17.UseMnemonic = false;
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(128, 266);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(59, 20);
            this.label18.TabIndex = 38;
            this.label18.Text = "Total :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(87, 235);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(100, 20);
            this.label19.TabIndex = 37;
            this.label19.Text = "Price/Liter :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(125, 200);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(64, 20);
            this.label20.TabIndex = 36;
            this.label20.Text = "Liters :";
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(122, 168);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(66, 20);
            this.label21.TabIndex = 35;
            this.label21.Text = "Petrol :";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(125, 137);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(63, 20);
            this.label22.TabIndex = 34;
            this.label22.Text = "Email :";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(53, 104);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(137, 20);
            this.label23.TabIndex = 33;
            this.label23.Text = "Phone Number :";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(93, 72);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(97, 20);
            this.label24.TabIndex = 32;
            this.label24.Text = "Full name :";
            // 
            // customerpanel
            // 
            this.customerpanel.Controls.Add(this.addNewCustomerLab);
            this.customerpanel.Controls.Add(this.label6);
            this.customerpanel.Controls.Add(this.totalPriceTxt);
            this.customerpanel.Controls.Add(this.priceOfLitrTxt);
            this.customerpanel.Controls.Add(this.PetrolTypeTxt);
            this.customerpanel.Controls.Add(this.label13);
            this.customerpanel.Controls.Add(this.label11);
            this.customerpanel.Controls.Add(this.label10);
            this.customerpanel.Controls.Add(this.button2);
            this.customerpanel.Controls.Add(this.label9);
            this.customerpanel.Controls.Add(this.label7);
            this.customerpanel.Controls.Add(this.label4);
            this.customerpanel.Controls.Add(this.label5);
            this.customerpanel.Controls.Add(this.label3);
            this.customerpanel.Controls.Add(this.label2);
            this.customerpanel.Controls.Add(this.amountOfLitrTxt);
            this.customerpanel.Controls.Add(this.emailTxt);
            this.customerpanel.Controls.Add(this.numberTxt);
            this.customerpanel.Controls.Add(this.nameTxt);
            this.customerpanel.Controls.Add(this.saveCustomerBtn);
            this.customerpanel.Location = new System.Drawing.Point(2, 6);
            this.customerpanel.Margin = new System.Windows.Forms.Padding(2);
            this.customerpanel.Name = "customerpanel";
            this.customerpanel.Size = new System.Drawing.Size(531, 392);
            this.customerpanel.TabIndex = 13;
            this.customerpanel.TabStop = true;
            this.customerpanel.Visible = false;
            this.customerpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.customerpanel_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(334, 187);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "£";
            // 
            // totalPriceTxt
            // 
            this.totalPriceTxt.AutoSize = true;
            this.totalPriceTxt.Location = new System.Drawing.Point(187, 259);
            this.totalPriceTxt.Name = "totalPriceTxt";
            this.totalPriceTxt.Size = new System.Drawing.Size(0, 13);
            this.totalPriceTxt.TabIndex = 30;
            // 
            // priceOfLitrTxt
            // 
            this.priceOfLitrTxt.AutoSize = true;
            this.priceOfLitrTxt.Location = new System.Drawing.Point(352, 185);
            this.priceOfLitrTxt.Name = "priceOfLitrTxt";
            this.priceOfLitrTxt.Size = new System.Drawing.Size(0, 13);
            this.priceOfLitrTxt.TabIndex = 29;
            // 
            // PetrolTypeTxt
            // 
            this.PetrolTypeTxt.FormattingEnabled = true;
            this.PetrolTypeTxt.Items.AddRange(new object[] {
            "Petrol",
            "Diesel",
            "LPG",
            "Petrol Leaded"});
            this.PetrolTypeTxt.Location = new System.Drawing.Point(190, 179);
            this.PetrolTypeTxt.Name = "PetrolTypeTxt";
            this.PetrolTypeTxt.Size = new System.Drawing.Size(145, 21);
            this.PetrolTypeTxt.TabIndex = 28;
            this.PetrolTypeTxt.SelectedIndexChanged += new System.EventHandler(this.PetrolTypeTxt_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(176, 220);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "L";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(176, 259);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "£";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(61, 16);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 24);
            this.label10.TabIndex = 24;
            this.label10.Text = "Edit Customer";
            this.label10.UseMnemonic = false;
            this.label10.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(190, 344);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 24);
            this.button2.TabIndex = 23;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(64, 259);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Total";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(64, 220);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Liters";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 178);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Petrol";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 146);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Email ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 107);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Phone Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Full name";
            // 
            // amountOfLitrTxt
            // 
            this.amountOfLitrTxt.Location = new System.Drawing.Point(189, 214);
            this.amountOfLitrTxt.Name = "amountOfLitrTxt";
            this.amountOfLitrTxt.Size = new System.Drawing.Size(146, 20);
            this.amountOfLitrTxt.TabIndex = 13;
            this.amountOfLitrTxt.Text = "0";
            this.amountOfLitrTxt.TextChanged += new System.EventHandler(this.amountOfLitrTxt_TextChanged);
            this.amountOfLitrTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.amountOfLitrTxt_KeyPress);
            // 
            // emailTxt
            // 
            this.emailTxt.Location = new System.Drawing.Point(189, 142);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(200, 20);
            this.emailTxt.TabIndex = 11;
            // 
            // numberTxt
            // 
            this.numberTxt.Location = new System.Drawing.Point(189, 107);
            this.numberTxt.Name = "numberTxt";
            this.numberTxt.Size = new System.Drawing.Size(200, 20);
            this.numberTxt.TabIndex = 10;
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(189, 71);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(200, 20);
            this.nameTxt.TabIndex = 9;
            // 
            // Insert
            // 
            this.Insert.Location = new System.Drawing.Point(400, 403);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(94, 24);
            this.Insert.TabIndex = 29;
            this.Insert.Text = "Insert Customer";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click_1);
            // 
            // Customersbutton2
            // 
            this.Customersbutton2.Location = new System.Drawing.Point(197, 403);
            this.Customersbutton2.Name = "Customersbutton2";
            this.Customersbutton2.Size = new System.Drawing.Size(94, 24);
            this.Customersbutton2.TabIndex = 16;
            this.Customersbutton2.Text = "Customers";
            this.Customersbutton2.UseVisualStyleBackColor = true;
            this.Customersbutton2.Visible = false;
            this.Customersbutton2.Click += new System.EventHandler(this.Customersbutton2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(8, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(368, 35);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "Search...";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // BackToHomeBttn
            // 
            this.BackToHomeBttn.Location = new System.Drawing.Point(12, 403);
            this.BackToHomeBttn.Name = "BackToHomeBttn";
            this.BackToHomeBttn.Size = new System.Drawing.Size(88, 24);
            this.BackToHomeBttn.TabIndex = 8;
            this.BackToHomeBttn.Text = "Home";
            this.BackToHomeBttn.UseVisualStyleBackColor = true;
            this.BackToHomeBttn.Click += new System.EventHandler(this.BackToHomeBttn_Click);
            // 
            // notFoundLab
            // 
            this.notFoundLab.AutoSize = true;
            this.notFoundLab.BackColor = System.Drawing.Color.Transparent;
            this.notFoundLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notFoundLab.ForeColor = System.Drawing.Color.Red;
            this.notFoundLab.Location = new System.Drawing.Point(8, 89);
            this.notFoundLab.Name = "notFoundLab";
            this.notFoundLab.Size = new System.Drawing.Size(0, 20);
            this.notFoundLab.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(156, 10);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 29);
            this.label8.TabIndex = 15;
            this.label8.Text = "CUSTOMERS";
            // 
            // searchBttn
            // 
            this.searchBttn.AutoSize = true;
            this.searchBttn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.searchBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBttn.Location = new System.Drawing.Point(388, 49);
            this.searchBttn.Name = "searchBttn";
            this.searchBttn.Size = new System.Drawing.Size(142, 41);
            this.searchBttn.TabIndex = 10;
            this.searchBttn.Text = "Search";
            this.searchBttn.UseVisualStyleBackColor = false;
            this.searchBttn.Click += new System.EventHandler(this.searchBttn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(70)))), ((int)(((byte)(71)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(4, 112);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(526, 281);
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
            // saveCustomerBtn
            // 
            this.saveCustomerBtn.Location = new System.Drawing.Point(190, 344);
            this.saveCustomerBtn.Name = "saveCustomerBtn";
            this.saveCustomerBtn.Size = new System.Drawing.Size(74, 24);
            this.saveCustomerBtn.TabIndex = 32;
            this.saveCustomerBtn.Text = "Save";
            this.saveCustomerBtn.UseVisualStyleBackColor = true;
            this.saveCustomerBtn.Visible = false;
            this.saveCustomerBtn.Click += new System.EventHandler(this.saveCustomerBtn_Click);
            // 
            // addNewCustomerLab
            // 
            this.addNewCustomerLab.AutoSize = true;
            this.addNewCustomerLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewCustomerLab.Location = new System.Drawing.Point(63, 16);
            this.addNewCustomerLab.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addNewCustomerLab.Name = "addNewCustomerLab";
            this.addNewCustomerLab.Size = new System.Drawing.Size(169, 24);
            this.addNewCustomerLab.TabIndex = 33;
            this.addNewCustomerLab.Text = "Add new customer";
            this.addNewCustomerLab.UseMnemonic = false;
            this.addNewCustomerLab.Visible = false;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(185)))), ((int)(((byte)(2)))));
            this.ClientSize = new System.Drawing.Size(530, 444);
            this.Controls.Add(this.customersPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.goToCustomersPageBttn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Petroleum UK Ltd ";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.customersPanel.ResumeLayout(false);
            this.customersPanel.PerformLayout();
            this.customerDitailspanel1.ResumeLayout(false);
            this.customerDitailspanel1.PerformLayout();
            this.customerpanel.ResumeLayout(false);
            this.customerpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox amountOfLitrTxt;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.TextBox numberTxt;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Button Customersbutton2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel customerDitailspanel1;
        private System.Windows.Forms.Label totalLab;
        private System.Windows.Forms.Label literPriceLab;
        private System.Windows.Forms.Label literLab;
        private System.Windows.Forms.Label petrolLab;
        private System.Windows.Forms.Label emailLab;
        private System.Windows.Forms.Label PhoneLab;
        private System.Windows.Forms.Label fullNameLab;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.ComboBox PetrolTypeTxt;
        private System.Windows.Forms.Label priceOfLitrTxt;
        private System.Windows.Forms.Label totalPriceTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button saveCustomerBtn;
        private System.Windows.Forms.Label addNewCustomerLab;
    }
}

