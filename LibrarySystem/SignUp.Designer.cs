namespace LibrarySystem
{
    partial class SignUp
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.systemName = new System.Windows.Forms.Label();
            this.exitbtn = new System.Windows.Forms.Label();
            this.loginhereBtn = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.showPass = new System.Windows.Forms.CheckBox();
            this.signupBtn = new System.Windows.Forms.Button();
            this.typePass = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.typeEmail = new System.Windows.Forms.TextBox();
            this.userName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.typeUser = new System.Windows.Forms.TextBox();
            this.nameofUser = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.systemName);
            this.panel1.Location = new System.Drawing.Point(-5, -6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 537);
            this.panel1.TabIndex = 1;
            // 
            // systemName
            // 
            this.systemName.AutoSize = true;
            this.systemName.Font = new System.Drawing.Font("Calisto MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.systemName.ForeColor = System.Drawing.Color.White;
            this.systemName.Location = new System.Drawing.Point(41, 280);
            this.systemName.Name = "systemName";
            this.systemName.Size = new System.Drawing.Size(263, 26);
            this.systemName.TabIndex = 2;
            this.systemName.Text = "Library Inventory System";
            // 
            // exitbtn
            // 
            this.exitbtn.AutoSize = true;
            this.exitbtn.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbtn.Location = new System.Drawing.Point(755, 25);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(22, 20);
            this.exitbtn.TabIndex = 20;
            this.exitbtn.Text = "X";
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // loginhereBtn
            // 
            this.loginhereBtn.AutoSize = true;
            this.loginhereBtn.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginhereBtn.Location = new System.Drawing.Point(597, 493);
            this.loginhereBtn.Name = "loginhereBtn";
            this.loginhereBtn.Size = new System.Drawing.Size(90, 20);
            this.loginhereBtn.TabIndex = 19;
            this.loginhereBtn.Text = "Log in here";
            this.loginhereBtn.Click += new System.EventHandler(this.loginhereBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calisto MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(415, 495);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Already have an account?";
            // 
            // showPass
            // 
            this.showPass.AutoSize = true;
            this.showPass.Font = new System.Drawing.Font("Calisto MT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPass.Location = new System.Drawing.Point(645, 344);
            this.showPass.Name = "showPass";
            this.showPass.Size = new System.Drawing.Size(116, 19);
            this.showPass.TabIndex = 17;
            this.showPass.Text = "Show Password";
            this.showPass.UseVisualStyleBackColor = true;
            this.showPass.CheckedChanged += new System.EventHandler(this.showPass_CheckedChanged);
            // 
            // signupBtn
            // 
            this.signupBtn.BackColor = System.Drawing.Color.Green;
            this.signupBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signupBtn.FlatAppearance.BorderSize = 0;
            this.signupBtn.Font = new System.Drawing.Font("Calisto MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupBtn.ForeColor = System.Drawing.Color.White;
            this.signupBtn.Location = new System.Drawing.Point(375, 369);
            this.signupBtn.Name = "signupBtn";
            this.signupBtn.Size = new System.Drawing.Size(148, 58);
            this.signupBtn.TabIndex = 16;
            this.signupBtn.Text = "SIGN UP";
            this.signupBtn.UseVisualStyleBackColor = false;
            this.signupBtn.Click += new System.EventHandler(this.signupBtn_Click);
            // 
            // typePass
            // 
            this.typePass.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typePass.Location = new System.Drawing.Point(375, 293);
            this.typePass.Multiline = true;
            this.typePass.Name = "typePass";
            this.typePass.Size = new System.Drawing.Size(386, 35);
            this.typePass.TabIndex = 15;
            this.typePass.TextChanged += new System.EventHandler(this.typePass_TextChanged);
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(371, 265);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(83, 20);
            this.password.TabIndex = 14;
            this.password.Text = "Password:";
            // 
            // typeEmail
            // 
            this.typeEmail.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeEmail.Location = new System.Drawing.Point(375, 138);
            this.typeEmail.Multiline = true;
            this.typeEmail.Name = "typeEmail";
            this.typeEmail.Size = new System.Drawing.Size(386, 35);
            this.typeEmail.TabIndex = 13;
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName.Location = new System.Drawing.Point(371, 110);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(120, 20);
            this.userName.TabIndex = 12;
            this.userName.Text = "Email Address:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(357, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 32);
            this.label1.TabIndex = 11;
            this.label1.Text = "Get Started";
            // 
            // typeUser
            // 
            this.typeUser.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeUser.Location = new System.Drawing.Point(375, 215);
            this.typeUser.Multiline = true;
            this.typeUser.Name = "typeUser";
            this.typeUser.Size = new System.Drawing.Size(386, 35);
            this.typeUser.TabIndex = 22;
            this.typeUser.TextChanged += new System.EventHandler(this.typeUser_TextChanged);
            // 
            // nameofUser
            // 
            this.nameofUser.AutoSize = true;
            this.nameofUser.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameofUser.Location = new System.Drawing.Point(371, 187);
            this.nameofUser.Name = "nameofUser";
            this.nameofUser.Size = new System.Drawing.Size(88, 20);
            this.nameofUser.TabIndex = 21;
            this.nameofUser.Text = "Username:";
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 531);
            this.Controls.Add(this.typeUser);
            this.Controls.Add(this.nameofUser);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.loginhereBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.showPass);
            this.Controls.Add(this.signupBtn);
            this.Controls.Add(this.typePass);
            this.Controls.Add(this.password);
            this.Controls.Add(this.typeEmail);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label systemName;
        private System.Windows.Forms.Label exitbtn;
        private System.Windows.Forms.Label loginhereBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox showPass;
        private System.Windows.Forms.Button signupBtn;
        private System.Windows.Forms.TextBox typePass;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox typeEmail;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox typeUser;
        private System.Windows.Forms.Label nameofUser;
    }
}