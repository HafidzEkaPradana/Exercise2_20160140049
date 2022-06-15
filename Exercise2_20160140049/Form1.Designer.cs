
namespace Exercise2_20160140049
{
    partial class Form1
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
            this.btnToLogin = new System.Windows.Forms.Button();
            this.btnToRegister = new System.Windows.Forms.Button();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.loginbtn = new System.Windows.Forms.Button();
            this.txLoginPass = new System.Windows.Forms.TextBox();
            this.txLoginUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.regisPanel = new System.Windows.Forms.Panel();
            this.regisBtn = new System.Windows.Forms.Button();
            this.txRegisPass = new System.Windows.Forms.TextBox();
            this.txRegisUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.loginPanel.SuspendLayout();
            this.regisPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnToLogin
            // 
            this.btnToLogin.BackColor = System.Drawing.Color.Black;
            this.btnToLogin.FlatAppearance.BorderSize = 0;
            this.btnToLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToLogin.ForeColor = System.Drawing.Color.White;
            this.btnToLogin.Location = new System.Drawing.Point(-1, -1);
            this.btnToLogin.Name = "btnToLogin";
            this.btnToLogin.Size = new System.Drawing.Size(421, 143);
            this.btnToLogin.TabIndex = 10;
            this.btnToLogin.Text = "Login";
            this.btnToLogin.UseVisualStyleBackColor = false;
            this.btnToLogin.Click += new System.EventHandler(this.btnToLogin_Click);
            // 
            // btnToRegister
            // 
            this.btnToRegister.BackColor = System.Drawing.Color.Black;
            this.btnToRegister.FlatAppearance.BorderSize = 0;
            this.btnToRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToRegister.ForeColor = System.Drawing.Color.White;
            this.btnToRegister.Location = new System.Drawing.Point(418, -1);
            this.btnToRegister.Name = "btnToRegister";
            this.btnToRegister.Size = new System.Drawing.Size(422, 143);
            this.btnToRegister.TabIndex = 11;
            this.btnToRegister.Text = "Register";
            this.btnToRegister.UseVisualStyleBackColor = false;
            this.btnToRegister.Click += new System.EventHandler(this.btnToRegister_Click);
            // 
            // loginPanel
            // 
            this.loginPanel.BackColor = System.Drawing.Color.Black;
            this.loginPanel.Controls.Add(this.checkBox1);
            this.loginPanel.Controls.Add(this.loginbtn);
            this.loginPanel.Controls.Add(this.txLoginPass);
            this.loginPanel.Controls.Add(this.txLoginUsername);
            this.loginPanel.Controls.Add(this.label2);
            this.loginPanel.Controls.Add(this.label1);
            this.loginPanel.Location = new System.Drawing.Point(0, 143);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(839, 406);
            this.loginPanel.TabIndex = 12;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(334, 189);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(173, 24);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Term and Condition";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // loginbtn
            // 
            this.loginbtn.ForeColor = System.Drawing.Color.Black;
            this.loginbtn.Location = new System.Drawing.Point(198, 228);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(416, 50);
            this.loginbtn.TabIndex = 4;
            this.loginbtn.Text = "Login";
            this.loginbtn.UseVisualStyleBackColor = true;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // txLoginPass
            // 
            this.txLoginPass.Location = new System.Drawing.Point(334, 143);
            this.txLoginPass.Name = "txLoginPass";
            this.txLoginPass.PasswordChar = '*';
            this.txLoginPass.Size = new System.Drawing.Size(280, 26);
            this.txLoginPass.TabIndex = 3;
            // 
            // txLoginUsername
            // 
            this.txLoginUsername.Location = new System.Drawing.Point(334, 86);
            this.txLoginUsername.Name = "txLoginUsername";
            this.txLoginUsername.Size = new System.Drawing.Size(280, 26);
            this.txLoginUsername.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(194, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(194, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username :";
            // 
            // regisPanel
            // 
            this.regisPanel.BackColor = System.Drawing.Color.Black;
            this.regisPanel.Controls.Add(this.regisBtn);
            this.regisPanel.Controls.Add(this.txRegisPass);
            this.regisPanel.Controls.Add(this.txRegisUser);
            this.regisPanel.Controls.Add(this.label3);
            this.regisPanel.Controls.Add(this.label4);
            this.regisPanel.Location = new System.Drawing.Point(0, 143);
            this.regisPanel.Name = "regisPanel";
            this.regisPanel.Size = new System.Drawing.Size(839, 406);
            this.regisPanel.TabIndex = 13;
            // 
            // regisBtn
            // 
            this.regisBtn.ForeColor = System.Drawing.Color.Black;
            this.regisBtn.Location = new System.Drawing.Point(198, 228);
            this.regisBtn.Name = "regisBtn";
            this.regisBtn.Size = new System.Drawing.Size(416, 50);
            this.regisBtn.TabIndex = 4;
            this.regisBtn.Text = "Register";
            this.regisBtn.UseVisualStyleBackColor = true;
            this.regisBtn.Click += new System.EventHandler(this.regisBtn_Click);
            // 
            // txRegisPass
            // 
            this.txRegisPass.Location = new System.Drawing.Point(334, 143);
            this.txRegisPass.Name = "txRegisPass";
            this.txRegisPass.PasswordChar = '*';
            this.txRegisPass.Size = new System.Drawing.Size(280, 26);
            this.txRegisPass.TabIndex = 3;
            // 
            // txRegisUser
            // 
            this.txRegisUser.Location = new System.Drawing.Point(334, 86);
            this.txRegisUser.Name = "txRegisUser";
            this.txRegisUser.Size = new System.Drawing.Size(280, 26);
            this.txRegisUser.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(194, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Password : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(194, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Username :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(838, 548);
            this.Controls.Add(this.loginPanel);
            this.Controls.Add(this.btnToRegister);
            this.Controls.Add(this.btnToLogin);
            this.Controls.Add(this.regisPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.regisPanel.ResumeLayout(false);
            this.regisPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnToLogin;
        private System.Windows.Forms.Button btnToRegister;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txLoginPass;
        private System.Windows.Forms.TextBox txLoginUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.Panel regisPanel;
        private System.Windows.Forms.Button regisBtn;
        private System.Windows.Forms.TextBox txRegisPass;
        private System.Windows.Forms.TextBox txRegisUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

