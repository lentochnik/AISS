namespace AIS
{
    partial class Client_Info
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
            this.Cname = new System.Windows.Forms.TextBox();
            this.Cpatr = new System.Windows.Forms.TextBox();
            this.Csurname = new System.Windows.Forms.TextBox();
            this.CCompname = new System.Windows.Forms.TextBox();
            this.Cclinum = new System.Windows.Forms.TextBox();
            this.Cinn = new System.Windows.Forms.TextBox();
            this.Ckpp = new System.Windows.Forms.TextBox();
            this.Caccnum = new System.Windows.Forms.TextBox();
            this.Creg = new System.Windows.Forms.TextBox();
            this.Cstreet = new System.Windows.Forms.TextBox();
            this.Cadrs2 = new System.Windows.Forms.TextBox();
            this.Cpcod = new System.Windows.Forms.TextBox();
            this.Clegform = new System.Windows.Forms.ComboBox();
            this.Ccountr = new System.Windows.Forms.ComboBox();
            this.Lab_Cname = new System.Windows.Forms.Label();
            this.Lab_Csurname = new System.Windows.Forms.Label();
            this.Lab_Cpatr = new System.Windows.Forms.Label();
            this.Lab_CCompname = new System.Windows.Forms.Label();
            this.Lab_Cclinum = new System.Windows.Forms.Label();
            this.Lab_Cinn = new System.Windows.Forms.Label();
            this.Lab_Ckpp = new System.Windows.Forms.Label();
            this.Lab_Caccnum = new System.Windows.Forms.Label();
            this.Lab_Clegform = new System.Windows.Forms.Label();
            this.Lab_Creg = new System.Windows.Forms.Label();
            this.Lab_Ccountr = new System.Windows.Forms.Label();
            this.Lab_Cstreet = new System.Windows.Forms.Label();
            this.Lab_Cadrs2 = new System.Windows.Forms.Label();
            this.Lab_Cpcod = new System.Windows.Forms.Label();
            this.Lab_Ctel = new System.Windows.Forms.Label();
            this.Lab_Cfax = new System.Windows.Forms.Label();
            this.Lab_Ccur = new System.Windows.Forms.Label();
            this.Ccur = new System.Windows.Forms.ComboBox();
            this.But_CIcancel = new System.Windows.Forms.Button();
            this.But_CIcreate = new System.Windows.Forms.Button();
            this.Lab_Cemail = new System.Windows.Forms.Label();
            this.Cemail = new System.Windows.Forms.TextBox();
            this.Ctel = new System.Windows.Forms.MaskedTextBox();
            this.Cfax = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // Cname
            // 
            this.Cname.Location = new System.Drawing.Point(79, 43);
            this.Cname.Name = "Cname";
            this.Cname.Size = new System.Drawing.Size(100, 20);
            this.Cname.TabIndex = 0;
            // 
            // Cpatr
            // 
            this.Cpatr.Location = new System.Drawing.Point(79, 95);
            this.Cpatr.Name = "Cpatr";
            this.Cpatr.Size = new System.Drawing.Size(100, 20);
            this.Cpatr.TabIndex = 1;
            // 
            // Csurname
            // 
            this.Csurname.Location = new System.Drawing.Point(79, 69);
            this.Csurname.Name = "Csurname";
            this.Csurname.Size = new System.Drawing.Size(100, 20);
            this.Csurname.TabIndex = 2;
            // 
            // CCompname
            // 
            this.CCompname.Location = new System.Drawing.Point(83, 43);
            this.CCompname.Multiline = true;
            this.CCompname.Name = "CCompname";
            this.CCompname.Size = new System.Drawing.Size(392, 72);
            this.CCompname.TabIndex = 3;
            this.CCompname.Visible = false;
            // 
            // Cclinum
            // 
            this.Cclinum.Enabled = false;
            this.Cclinum.Location = new System.Drawing.Point(335, 4);
            this.Cclinum.Name = "Cclinum";
            this.Cclinum.Size = new System.Drawing.Size(140, 20);
            this.Cclinum.TabIndex = 4;
            this.Cclinum.TextChanged += new System.EventHandler(this.Cclinum_TextChanged);
            // 
            // Cinn
            // 
            this.Cinn.Location = new System.Drawing.Point(79, 134);
            this.Cinn.MaxLength = 12;
            this.Cinn.Name = "Cinn";
            this.Cinn.Size = new System.Drawing.Size(186, 20);
            this.Cinn.TabIndex = 5;
            this.Cinn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cinn_KeyPress);
            // 
            // Ckpp
            // 
            this.Ckpp.Location = new System.Drawing.Point(79, 160);
            this.Ckpp.MaxLength = 9;
            this.Ckpp.Name = "Ckpp";
            this.Ckpp.Size = new System.Drawing.Size(186, 20);
            this.Ckpp.TabIndex = 6;
            this.Ckpp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Ckpp_KeyPress);
            // 
            // Caccnum
            // 
            this.Caccnum.Location = new System.Drawing.Point(79, 186);
            this.Caccnum.MaxLength = 20;
            this.Caccnum.Name = "Caccnum";
            this.Caccnum.Size = new System.Drawing.Size(186, 20);
            this.Caccnum.TabIndex = 7;
            this.Caccnum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Caccnum_KeyPress);
            // 
            // Creg
            // 
            this.Creg.Location = new System.Drawing.Point(79, 271);
            this.Creg.Name = "Creg";
            this.Creg.Size = new System.Drawing.Size(100, 20);
            this.Creg.TabIndex = 9;
            // 
            // Cstreet
            // 
            this.Cstreet.Location = new System.Drawing.Point(79, 297);
            this.Cstreet.Name = "Cstreet";
            this.Cstreet.Size = new System.Drawing.Size(100, 20);
            this.Cstreet.TabIndex = 10;
            // 
            // Cadrs2
            // 
            this.Cadrs2.Location = new System.Drawing.Point(79, 323);
            this.Cadrs2.Multiline = true;
            this.Cadrs2.Name = "Cadrs2";
            this.Cadrs2.Size = new System.Drawing.Size(344, 39);
            this.Cadrs2.TabIndex = 11;
            // 
            // Cpcod
            // 
            this.Cpcod.Location = new System.Drawing.Point(324, 293);
            this.Cpcod.Name = "Cpcod";
            this.Cpcod.Size = new System.Drawing.Size(100, 20);
            this.Cpcod.TabIndex = 12;
            // 
            // Clegform
            // 
            this.Clegform.FormattingEnabled = true;
            this.Clegform.Items.AddRange(new object[] {
            "Entity",
            "Individual"});
            this.Clegform.Location = new System.Drawing.Point(79, 4);
            this.Clegform.Name = "Clegform";
            this.Clegform.Size = new System.Drawing.Size(121, 21);
            this.Clegform.TabIndex = 16;
            this.Clegform.SelectedIndexChanged += new System.EventHandler(this.Clegform_SelectedIndexChanged);
            // 
            // Ccountr
            // 
            this.Ccountr.FormattingEnabled = true;
            this.Ccountr.Items.AddRange(new object[] {
            "Abkhazia",
            "Afghanistan",
            "Albania",
            "Algeria",
            "Argentina",
            "Armenia",
            "Australia",
            "Austria",
            "Azerbaijan",
            "Bahamas",
            "Bahrain",
            "Bangladesh",
            "Belarus",
            "Belgium",
            "Bermuda Islands",
            "Bolivia",
            "Brazil",
            "Bulgaria",
            "Burundi",
            "Cambodia",
            "Cameroon",
            "Canada",
            "Chile",
            "China",
            "Colombia",
            "Congo",
            "Costa Rica",
            "Cuba",
            "Cyprus",
            "Czech Republic",
            "Denmark",
            "Dominican Republic",
            "Ecuador",
            "Egypt",
            "El Salvador",
            "Estonia",
            "Ethiopia",
            "Finland",
            "France",
            "Georgia",
            "Germany",
            "Ghana",
            "Gibraltar",
            "United Kingdom",
            "Greece",
            "Guatemala",
            "Guinea",
            "Haiti",
            "Hawaii",
            "Honduras",
            "Hong Kong",
            "Hungary",
            "Iceland",
            "India",
            "Indonesia",
            "Iran",
            "Iraq",
            "Ireland",
            "Israel",
            "Italy",
            "Ivory Coast",
            "Jamaica",
            "Japan",
            "Kazakhstan",
            "Kenya",
            "Kuwait",
            "Kyrgyzstan",
            "Latvia",
            "Lebanon",
            "Liberia",
            "Libya",
            "Lithuania",
            "Luxemburg",
            "Madagascar",
            "Malawi",
            "Malaysia",
            "Malta",
            "Mexico",
            "Moldova",
            "Monaco",
            "Mongolia",
            "Morocco",
            "Nepal",
            "Netherlands",
            "New Zeland",
            "Nicaragua",
            "Nigeria",
            "North Korea",
            "Norway",
            "Oman",
            "Pakistan",
            "Panama",
            "Papua New Guinea",
            "Paraguay",
            "Peru",
            "Philippines",
            "Poland",
            "Portugal",
            "Puerto Rico",
            "Romania",
            "Russian Federation",
            "Rwanda",
            "Saudi Arabia",
            "Senegal",
            "Sierra Leone",
            "Singapore",
            "Slovakia",
            "Slovenia",
            "South Africa",
            "South Korea",
            "South Ossetia",
            "Spain",
            "Sri Lanka",
            "Sudan",
            "Sweden",
            "Switzerland",
            "Syria",
            "Taiwan",
            "Tajikistan",
            "Thailand",
            "Togo",
            "Tunisia",
            "Turkey",
            "Turkmenistan",
            "Uganda",
            "Ukraine",
            "United Arab Emirates",
            "United States of America",
            "Uruguay",
            "Uzbekistan",
            "Venezuela",
            "Yemen",
            "Zaire",
            "Zambia",
            "Zimbabwe"});
            this.Ccountr.Location = new System.Drawing.Point(79, 245);
            this.Ccountr.Name = "Ccountr";
            this.Ccountr.Size = new System.Drawing.Size(121, 21);
            this.Ccountr.TabIndex = 17;
            this.Ccountr.SelectedIndexChanged += new System.EventHandler(this.Ccountr_SelectedIndexChanged);
            // 
            // Lab_Cname
            // 
            this.Lab_Cname.AutoSize = true;
            this.Lab_Cname.Location = new System.Drawing.Point(38, 46);
            this.Lab_Cname.Name = "Lab_Cname";
            this.Lab_Cname.Size = new System.Drawing.Size(38, 13);
            this.Lab_Cname.TabIndex = 18;
            this.Lab_Cname.Text = "Name:";
            // 
            // Lab_Csurname
            // 
            this.Lab_Csurname.AutoSize = true;
            this.Lab_Csurname.Location = new System.Drawing.Point(24, 72);
            this.Lab_Csurname.Name = "Lab_Csurname";
            this.Lab_Csurname.Size = new System.Drawing.Size(52, 13);
            this.Lab_Csurname.TabIndex = 19;
            this.Lab_Csurname.Text = "Surname:";
            // 
            // Lab_Cpatr
            // 
            this.Lab_Cpatr.AutoSize = true;
            this.Lab_Cpatr.Location = new System.Drawing.Point(15, 98);
            this.Lab_Cpatr.Name = "Lab_Cpatr";
            this.Lab_Cpatr.Size = new System.Drawing.Size(62, 13);
            this.Lab_Cpatr.TabIndex = 20;
            this.Lab_Cpatr.Text = "Patronymic:";
            // 
            // Lab_CCompname
            // 
            this.Lab_CCompname.AutoSize = true;
            this.Lab_CCompname.Location = new System.Drawing.Point(-1, 72);
            this.Lab_CCompname.Name = "Lab_CCompname";
            this.Lab_CCompname.Size = new System.Drawing.Size(83, 13);
            this.Lab_CCompname.TabIndex = 21;
            this.Lab_CCompname.Text = "Company name:";
            this.Lab_CCompname.Visible = false;
            // 
            // Lab_Cclinum
            // 
            this.Lab_Cclinum.AutoSize = true;
            this.Lab_Cclinum.Location = new System.Drawing.Point(282, 7);
            this.Lab_Cclinum.Name = "Lab_Cclinum";
            this.Lab_Cclinum.Size = new System.Drawing.Size(50, 13);
            this.Lab_Cclinum.TabIndex = 22;
            this.Lab_Cclinum.Text = "Client №:";
            // 
            // Lab_Cinn
            // 
            this.Lab_Cinn.AutoSize = true;
            this.Lab_Cinn.Location = new System.Drawing.Point(47, 137);
            this.Lab_Cinn.Name = "Lab_Cinn";
            this.Lab_Cinn.Size = new System.Drawing.Size(29, 13);
            this.Lab_Cinn.TabIndex = 23;
            this.Lab_Cinn.Text = "INN:";
            // 
            // Lab_Ckpp
            // 
            this.Lab_Ckpp.AutoSize = true;
            this.Lab_Ckpp.Location = new System.Drawing.Point(45, 163);
            this.Lab_Ckpp.Name = "Lab_Ckpp";
            this.Lab_Ckpp.Size = new System.Drawing.Size(31, 13);
            this.Lab_Ckpp.TabIndex = 24;
            this.Lab_Ckpp.Text = "KPP:";
            // 
            // Lab_Caccnum
            // 
            this.Lab_Caccnum.AutoSize = true;
            this.Lab_Caccnum.Location = new System.Drawing.Point(45, 189);
            this.Lab_Caccnum.Name = "Lab_Caccnum";
            this.Lab_Caccnum.Size = new System.Drawing.Size(31, 13);
            this.Lab_Caccnum.TabIndex = 25;
            this.Lab_Caccnum.Text = "ACC:";
            // 
            // Lab_Clegform
            // 
            this.Lab_Clegform.AutoSize = true;
            this.Lab_Clegform.Location = new System.Drawing.Point(18, 8);
            this.Lab_Clegform.Name = "Lab_Clegform";
            this.Lab_Clegform.Size = new System.Drawing.Size(59, 13);
            this.Lab_Clegform.TabIndex = 26;
            this.Lab_Clegform.Text = "Legal form:";
            // 
            // Lab_Creg
            // 
            this.Lab_Creg.AutoSize = true;
            this.Lab_Creg.Location = new System.Drawing.Point(32, 274);
            this.Lab_Creg.Name = "Lab_Creg";
            this.Lab_Creg.Size = new System.Drawing.Size(44, 13);
            this.Lab_Creg.TabIndex = 27;
            this.Lab_Creg.Text = "Region:";
            // 
            // Lab_Ccountr
            // 
            this.Lab_Ccountr.AutoSize = true;
            this.Lab_Ccountr.Location = new System.Drawing.Point(31, 248);
            this.Lab_Ccountr.Name = "Lab_Ccountr";
            this.Lab_Ccountr.Size = new System.Drawing.Size(46, 13);
            this.Lab_Ccountr.TabIndex = 28;
            this.Lab_Ccountr.Text = "Country:";
            // 
            // Lab_Cstreet
            // 
            this.Lab_Cstreet.AutoSize = true;
            this.Lab_Cstreet.Location = new System.Drawing.Point(38, 300);
            this.Lab_Cstreet.Name = "Lab_Cstreet";
            this.Lab_Cstreet.Size = new System.Drawing.Size(38, 13);
            this.Lab_Cstreet.TabIndex = 29;
            this.Lab_Cstreet.Text = "Street:";
            // 
            // Lab_Cadrs2
            // 
            this.Lab_Cadrs2.AutoSize = true;
            this.Lab_Cadrs2.Location = new System.Drawing.Point(26, 337);
            this.Lab_Cadrs2.Name = "Lab_Cadrs2";
            this.Lab_Cadrs2.Size = new System.Drawing.Size(51, 13);
            this.Lab_Cadrs2.TabIndex = 30;
            this.Lab_Cadrs2.Text = "Adress 2:";
            // 
            // Lab_Cpcod
            // 
            this.Lab_Cpcod.AutoSize = true;
            this.Lab_Cpcod.Location = new System.Drawing.Point(227, 297);
            this.Lab_Cpcod.Name = "Lab_Cpcod";
            this.Lab_Cpcod.Size = new System.Drawing.Size(94, 13);
            this.Lab_Cpcod.TabIndex = 31;
            this.Lab_Cpcod.Text = "Postal / ZIP code:";
            // 
            // Lab_Ctel
            // 
            this.Lab_Ctel.AutoSize = true;
            this.Lab_Ctel.Location = new System.Drawing.Point(51, 371);
            this.Lab_Ctel.Name = "Lab_Ctel";
            this.Lab_Ctel.Size = new System.Drawing.Size(25, 13);
            this.Lab_Ctel.TabIndex = 32;
            this.Lab_Ctel.Text = "Tel:";
            // 
            // Lab_Cfax
            // 
            this.Lab_Cfax.AutoSize = true;
            this.Lab_Cfax.Location = new System.Drawing.Point(210, 372);
            this.Lab_Cfax.Name = "Lab_Cfax";
            this.Lab_Cfax.Size = new System.Drawing.Size(27, 13);
            this.Lab_Cfax.TabIndex = 33;
            this.Lab_Cfax.Text = "Fax:";
            // 
            // Lab_Ccur
            // 
            this.Lab_Ccur.AutoSize = true;
            this.Lab_Ccur.Location = new System.Drawing.Point(286, 162);
            this.Lab_Ccur.Name = "Lab_Ccur";
            this.Lab_Ccur.Size = new System.Drawing.Size(52, 13);
            this.Lab_Ccur.TabIndex = 34;
            this.Lab_Ccur.Text = "Currency:";
            // 
            // Ccur
            // 
            this.Ccur.FormattingEnabled = true;
            this.Ccur.Items.AddRange(new object[] {
            "RUB"});
            this.Ccur.Location = new System.Drawing.Point(344, 159);
            this.Ccur.Name = "Ccur";
            this.Ccur.Size = new System.Drawing.Size(80, 21);
            this.Ccur.TabIndex = 38;
            // 
            // But_CIcancel
            // 
            this.But_CIcancel.Location = new System.Drawing.Point(349, 404);
            this.But_CIcancel.Name = "But_CIcancel";
            this.But_CIcancel.Size = new System.Drawing.Size(75, 23);
            this.But_CIcancel.TabIndex = 39;
            this.But_CIcancel.Text = "Cancel";
            this.But_CIcancel.UseVisualStyleBackColor = true;
            this.But_CIcancel.Click += new System.EventHandler(this.button1_Click);
            // 
            // But_CIcreate
            // 
            this.But_CIcreate.Location = new System.Drawing.Point(79, 404);
            this.But_CIcreate.Name = "But_CIcreate";
            this.But_CIcreate.Size = new System.Drawing.Size(75, 23);
            this.But_CIcreate.TabIndex = 40;
            this.But_CIcreate.Text = "Create";
            this.But_CIcreate.UseVisualStyleBackColor = true;
            this.But_CIcreate.Click += new System.EventHandler(this.But_CIcreate_Click);
            // 
            // Lab_Cemail
            // 
            this.Lab_Cemail.AutoSize = true;
            this.Lab_Cemail.Location = new System.Drawing.Point(283, 251);
            this.Lab_Cemail.Name = "Lab_Cemail";
            this.Lab_Cemail.Size = new System.Drawing.Size(37, 13);
            this.Lab_Cemail.TabIndex = 42;
            this.Lab_Cemail.Text = "e-mail:";
            // 
            // Cemail
            // 
            this.Cemail.Location = new System.Drawing.Point(323, 248);
            this.Cemail.Name = "Cemail";
            this.Cemail.Size = new System.Drawing.Size(100, 20);
            this.Cemail.TabIndex = 43;
            // 
            // Ctel
            // 
            this.Ctel.Location = new System.Drawing.Point(83, 368);
            this.Ctel.Name = "Ctel";
            this.Ctel.Size = new System.Drawing.Size(100, 20);
            this.Ctel.TabIndex = 45;
            this.Ctel.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Ctel_MaskInputRejected);
            this.Ctel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Ctel_KeyPress);
            // 
            // Cfax
            // 
            this.Cfax.Location = new System.Drawing.Point(238, 369);
            this.Cfax.Name = "Cfax";
            this.Cfax.Size = new System.Drawing.Size(100, 20);
            this.Cfax.TabIndex = 46;
            this.Cfax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cfax_KeyPress);
            // 
            // Client_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 439);
            this.ControlBox = false;
            this.Controls.Add(this.Cfax);
            this.Controls.Add(this.Ctel);
            this.Controls.Add(this.Cemail);
            this.Controls.Add(this.Lab_Cemail);
            this.Controls.Add(this.But_CIcreate);
            this.Controls.Add(this.But_CIcancel);
            this.Controls.Add(this.Ccur);
            this.Controls.Add(this.Lab_Ccur);
            this.Controls.Add(this.Lab_Cfax);
            this.Controls.Add(this.Lab_Ctel);
            this.Controls.Add(this.Lab_Cpcod);
            this.Controls.Add(this.Lab_Cadrs2);
            this.Controls.Add(this.Lab_Cstreet);
            this.Controls.Add(this.Lab_Ccountr);
            this.Controls.Add(this.Lab_Creg);
            this.Controls.Add(this.Lab_Clegform);
            this.Controls.Add(this.Lab_Caccnum);
            this.Controls.Add(this.Lab_Ckpp);
            this.Controls.Add(this.Lab_Cinn);
            this.Controls.Add(this.Lab_Cclinum);
            this.Controls.Add(this.Lab_CCompname);
            this.Controls.Add(this.Lab_Cpatr);
            this.Controls.Add(this.Lab_Csurname);
            this.Controls.Add(this.Lab_Cname);
            this.Controls.Add(this.Ccountr);
            this.Controls.Add(this.Clegform);
            this.Controls.Add(this.Cpcod);
            this.Controls.Add(this.Cadrs2);
            this.Controls.Add(this.Cstreet);
            this.Controls.Add(this.Creg);
            this.Controls.Add(this.Caccnum);
            this.Controls.Add(this.Ckpp);
            this.Controls.Add(this.Cinn);
            this.Controls.Add(this.Cclinum);
            this.Controls.Add(this.CCompname);
            this.Controls.Add(this.Csurname);
            this.Controls.Add(this.Cpatr);
            this.Controls.Add(this.Cname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Client_Info";
            this.Text = "New client";
            this.Load += new System.EventHandler(this.Client_Info_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Cname;
        private System.Windows.Forms.TextBox Cpatr;
        private System.Windows.Forms.TextBox Csurname;
        private System.Windows.Forms.TextBox CCompname;
        private System.Windows.Forms.TextBox Cclinum;
        private System.Windows.Forms.TextBox Cinn;
        private System.Windows.Forms.TextBox Ckpp;
        private System.Windows.Forms.TextBox Caccnum;
        private System.Windows.Forms.TextBox Creg;
        private System.Windows.Forms.TextBox Cstreet;
        private System.Windows.Forms.TextBox Cadrs2;
        private System.Windows.Forms.TextBox Cpcod;
        private System.Windows.Forms.ComboBox Clegform;
        private System.Windows.Forms.ComboBox Ccountr;
        private System.Windows.Forms.Label Lab_Cname;
        private System.Windows.Forms.Label Lab_Csurname;
        private System.Windows.Forms.Label Lab_Cpatr;
        private System.Windows.Forms.Label Lab_CCompname;
        private System.Windows.Forms.Label Lab_Cclinum;
        private System.Windows.Forms.Label Lab_Cinn;
        private System.Windows.Forms.Label Lab_Ckpp;
        private System.Windows.Forms.Label Lab_Caccnum;
        private System.Windows.Forms.Label Lab_Clegform;
        private System.Windows.Forms.Label Lab_Creg;
        private System.Windows.Forms.Label Lab_Ccountr;
        private System.Windows.Forms.Label Lab_Cstreet;
        private System.Windows.Forms.Label Lab_Cadrs2;
        private System.Windows.Forms.Label Lab_Cpcod;
        private System.Windows.Forms.Label Lab_Ctel;
        private System.Windows.Forms.Label Lab_Cfax;
        private System.Windows.Forms.Label Lab_Ccur;
        private System.Windows.Forms.ComboBox Ccur;
        private System.Windows.Forms.Button But_CIcancel;
        private System.Windows.Forms.Button But_CIcreate;
        private System.Windows.Forms.Label Lab_Cemail;
        private System.Windows.Forms.TextBox Cemail;
        private System.Windows.Forms.MaskedTextBox Ctel;
        private System.Windows.Forms.MaskedTextBox Cfax;
    }
}