namespace AIS
{
    partial class adpap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adpap));
            this.payer_name = new System.Windows.Forms.TextBox();
            this.payer_inn = new System.Windows.Forms.TextBox();
            this.payer_kpp = new System.Windows.Forms.TextBox();
            this.payer_number = new System.Windows.Forms.TextBox();
            this.payer_bank = new System.Windows.Forms.TextBox();
            this.payer_bic_bank = new System.Windows.Forms.TextBox();
            this.payer_ammount = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.pay_number = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lab_payer_name = new System.Windows.Forms.Label();
            this.lab_payer_inn = new System.Windows.Forms.Label();
            this.lab_payer_kpp = new System.Windows.Forms.Label();
            this.lab_payer_num = new System.Windows.Forms.Label();
            this.lab_bank_payer = new System.Windows.Forms.Label();
            this.lab_bic_payer_bank = new System.Windows.Forms.Label();
            this.ammount = new System.Windows.Forms.Label();
            this.payer_comment = new System.Windows.Forms.Label();
            this.lab_pay_number = new System.Windows.Forms.Label();
            this.lab_pay_date = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.payer_bank_accnumber = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lab_image_scan = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.payer_addscan = new System.Windows.Forms.Button();
            this.payer_save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // payer_name
            // 
            resources.ApplyResources(this.payer_name, "payer_name");
            this.payer_name.Name = "payer_name";
            // 
            // payer_inn
            // 
            resources.ApplyResources(this.payer_inn, "payer_inn");
            this.payer_inn.Name = "payer_inn";
            this.payer_inn.TextChanged += new System.EventHandler(this.payer_inn_TextChanged);
            this.payer_inn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.payer_inn_KeyPress);
            // 
            // payer_kpp
            // 
            resources.ApplyResources(this.payer_kpp, "payer_kpp");
            this.payer_kpp.Name = "payer_kpp";
            this.payer_kpp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.payer_kpp_KeyPress);
            // 
            // payer_number
            // 
            resources.ApplyResources(this.payer_number, "payer_number");
            this.payer_number.Name = "payer_number";
            this.payer_number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.payer_number_KeyPress);
            // 
            // payer_bank
            // 
            resources.ApplyResources(this.payer_bank, "payer_bank");
            this.payer_bank.Name = "payer_bank";
            // 
            // payer_bic_bank
            // 
            resources.ApplyResources(this.payer_bic_bank, "payer_bic_bank");
            this.payer_bic_bank.Name = "payer_bic_bank";
            this.payer_bic_bank.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.payer_bic_bank_KeyPress);
            // 
            // payer_ammount
            // 
            resources.ApplyResources(this.payer_ammount, "payer_ammount");
            this.payer_ammount.Name = "payer_ammount";
            this.payer_ammount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.payer_ammount_KeyPress);
            // 
            // textBox8
            // 
            resources.ApplyResources(this.textBox8, "textBox8");
            this.textBox8.Name = "textBox8";
            // 
            // pay_number
            // 
            resources.ApplyResources(this.pay_number, "pay_number");
            this.pay_number.Name = "pay_number";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // lab_payer_name
            // 
            resources.ApplyResources(this.lab_payer_name, "lab_payer_name");
            this.lab_payer_name.Name = "lab_payer_name";
            // 
            // lab_payer_inn
            // 
            resources.ApplyResources(this.lab_payer_inn, "lab_payer_inn");
            this.lab_payer_inn.Name = "lab_payer_inn";
            // 
            // lab_payer_kpp
            // 
            resources.ApplyResources(this.lab_payer_kpp, "lab_payer_kpp");
            this.lab_payer_kpp.Name = "lab_payer_kpp";
            // 
            // lab_payer_num
            // 
            resources.ApplyResources(this.lab_payer_num, "lab_payer_num");
            this.lab_payer_num.Name = "lab_payer_num";
            // 
            // lab_bank_payer
            // 
            resources.ApplyResources(this.lab_bank_payer, "lab_bank_payer");
            this.lab_bank_payer.Name = "lab_bank_payer";
            // 
            // lab_bic_payer_bank
            // 
            resources.ApplyResources(this.lab_bic_payer_bank, "lab_bic_payer_bank");
            this.lab_bic_payer_bank.Name = "lab_bic_payer_bank";
            // 
            // ammount
            // 
            resources.ApplyResources(this.ammount, "ammount");
            this.ammount.Name = "ammount";
            // 
            // payer_comment
            // 
            resources.ApplyResources(this.payer_comment, "payer_comment");
            this.payer_comment.Name = "payer_comment";
            // 
            // lab_pay_number
            // 
            resources.ApplyResources(this.lab_pay_number, "lab_pay_number");
            this.lab_pay_number.Name = "lab_pay_number";
            // 
            // lab_pay_date
            // 
            resources.ApplyResources(this.lab_pay_date, "lab_pay_date");
            this.lab_pay_date.Name = "lab_pay_date";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // payer_bank_accnumber
            // 
            resources.ApplyResources(this.payer_bank_accnumber, "payer_bank_accnumber");
            this.payer_bank_accnumber.Name = "payer_bank_accnumber";
            this.payer_bank_accnumber.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.payer_bank_accnumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.payer_bank_accnumber_KeyPress);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            resources.ApplyResources(this.dateTimePicker1, "dateTimePicker1");
            this.dateTimePicker1.Name = "dateTimePicker1";
            // 
            // lab_image_scan
            // 
            resources.ApplyResources(this.lab_image_scan, "lab_image_scan");
            this.lab_image_scan.Name = "lab_image_scan";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lab_payer_num);
            this.groupBox1.Controls.Add(this.lab_payer_kpp);
            this.groupBox1.Controls.Add(this.lab_payer_inn);
            this.groupBox1.Controls.Add(this.lab_payer_name);
            this.groupBox1.Controls.Add(this.payer_number);
            this.groupBox1.Controls.Add(this.payer_kpp);
            this.groupBox1.Controls.Add(this.payer_inn);
            this.groupBox1.Controls.Add(this.payer_name);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.payer_bank_accnumber);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lab_bic_payer_bank);
            this.groupBox2.Controls.Add(this.lab_bank_payer);
            this.groupBox2.Controls.Add(this.payer_bic_bank);
            this.groupBox2.Controls.Add(this.payer_bank);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // payer_addscan
            // 
            resources.ApplyResources(this.payer_addscan, "payer_addscan");
            this.payer_addscan.Name = "payer_addscan";
            this.payer_addscan.UseVisualStyleBackColor = true;
            this.payer_addscan.Click += new System.EventHandler(this.payer_addscan_Click);
            // 
            // payer_save
            // 
            resources.ApplyResources(this.payer_save, "payer_save");
            this.payer_save.Name = "payer_save";
            this.payer_save.UseVisualStyleBackColor = true;
            this.payer_save.Click += new System.EventHandler(this.payer_save_Click);
            // 
            // adpap
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.payer_save);
            this.Controls.Add(this.payer_addscan);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lab_image_scan);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lab_pay_date);
            this.Controls.Add(this.lab_pay_number);
            this.Controls.Add(this.payer_comment);
            this.Controls.Add(this.ammount);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pay_number);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.payer_ammount);
            this.Name = "adpap";
            this.Load += new System.EventHandler(this.adpap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox payer_name;
        private System.Windows.Forms.TextBox payer_inn;
        private System.Windows.Forms.TextBox payer_kpp;
        private System.Windows.Forms.TextBox payer_number;
        private System.Windows.Forms.TextBox payer_bank;
        private System.Windows.Forms.TextBox payer_bic_bank;
        private System.Windows.Forms.TextBox payer_ammount;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox pay_number;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lab_payer_name;
        private System.Windows.Forms.Label lab_payer_inn;
        private System.Windows.Forms.Label lab_payer_kpp;
        private System.Windows.Forms.Label lab_payer_num;
        private System.Windows.Forms.Label lab_bank_payer;
        private System.Windows.Forms.Label lab_bic_payer_bank;
        private System.Windows.Forms.Label ammount;
        private System.Windows.Forms.Label payer_comment;
        private System.Windows.Forms.Label lab_pay_number;
        private System.Windows.Forms.Label lab_pay_date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox payer_bank_accnumber;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lab_image_scan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button payer_addscan;
        private System.Windows.Forms.Button payer_save;
    }
}