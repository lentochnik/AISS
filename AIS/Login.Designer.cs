namespace AIS
{
    partial class Login
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.EntAuth = new System.Windows.Forms.Button();
            this.LogINN = new System.Windows.Forms.Label();
            this.PasswordN = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EntAuth
            // 
            this.EntAuth.Location = new System.Drawing.Point(87, 195);
            this.EntAuth.Name = "EntAuth";
            this.EntAuth.Size = new System.Drawing.Size(71, 23);
            this.EntAuth.TabIndex = 3;
            this.EntAuth.Text = "Exit";
            this.EntAuth.UseVisualStyleBackColor = true;
            this.EntAuth.Click += new System.EventHandler(this.EntAuth_Click);
            // 
            // LogINN
            // 
            this.LogINN.AutoSize = true;
            this.LogINN.Enabled = false;
            this.LogINN.ForeColor = System.Drawing.Color.Black;
            this.LogINN.Location = new System.Drawing.Point(34, 25);
            this.LogINN.Name = "LogINN";
            this.LogINN.Size = new System.Drawing.Size(33, 13);
            this.LogINN.TabIndex = 2;
            this.LogINN.Text = "Login";
            // 
            // PasswordN
            // 
            this.PasswordN.AutoSize = true;
            this.PasswordN.Enabled = false;
            this.PasswordN.ForeColor = System.Drawing.Color.Black;
            this.PasswordN.Location = new System.Drawing.Point(14, 62);
            this.PasswordN.Name = "PasswordN";
            this.PasswordN.Size = new System.Drawing.Size(53, 13);
            this.PasswordN.TabIndex = 3;
            this.PasswordN.Text = "Password";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(73, 22);
            this.textBox1.MaxLength = 255;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(73, 59);
            this.textBox2.MaxLength = 64;
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(87, 85);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(71, 57);
            this.button3.TabIndex = 2;
            this.button3.Text = "Enter";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(224, 1);
            this.button1.MaximumSize = new System.Drawing.Size(20, 20);
            this.button1.MinimumSize = new System.Drawing.Size(20, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(20, 20);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(244, 230);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.PasswordN);
            this.Controls.Add(this.LogINN);
            this.Controls.Add(this.EntAuth);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AIS";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EntAuth;
        private System.Windows.Forms.Label LogINN;
        private System.Windows.Forms.Label PasswordN;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
    }
}

