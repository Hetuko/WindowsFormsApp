﻿
namespace WindowsFormsApp
{
    partial class SignIn
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
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonSignIn = new System.Windows.Forms.Button();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.exitFromProgramm = new System.Windows.Forms.Button();
            this.emptyLogin = new System.Windows.Forms.Label();
            this.emptyPass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(300, 122);
            this.textBoxLogin.Name = "textBox1";
            this.textBoxLogin.Size = new System.Drawing.Size(202, 20);
            this.textBoxLogin.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(300, 184);
            this.textBoxPassword.Name = "textBox2";
            this.textBoxPassword.Size = new System.Drawing.Size(202, 20);
            this.textBoxPassword.TabIndex = 1;
            // 
            // button1
            // 
            this.buttonSignIn.Location = new System.Drawing.Point(300, 259);
            this.buttonSignIn.Name = "button1";
            this.buttonSignIn.Size = new System.Drawing.Size(75, 23);
            this.buttonSignIn.TabIndex = 2;
            this.buttonSignIn.Text = "Sign in";
            this.buttonSignIn.UseVisualStyleBackColor = true;
            this.buttonSignIn.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.buttonRegister.Location = new System.Drawing.Point(427, 259);
            this.buttonRegister.Name = "button2";
            this.buttonRegister.Size = new System.Drawing.Size(75, 23);
            this.buttonRegister.TabIndex = 3;
            this.buttonRegister.Text = "Register";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.button2_Click);
            // 
            // exitFromProgramm
            // 
            this.exitFromProgramm.Location = new System.Drawing.Point(713, 13);
            this.exitFromProgramm.Name = "exitFromProgramm";
            this.exitFromProgramm.Size = new System.Drawing.Size(75, 23);
            this.exitFromProgramm.TabIndex = 4;
            this.exitFromProgramm.Text = "EXIT";
            this.exitFromProgramm.UseVisualStyleBackColor = true;
            this.exitFromProgramm.Click += new System.EventHandler(this.exitFromProgramm_Click);
            // 
            // emptyLogin
            // 
            this.emptyLogin.AutoSize = true;
            this.emptyLogin.Location = new System.Drawing.Point(357, 145);
            this.emptyLogin.Name = "emptyLogin";
            this.emptyLogin.Size = new System.Drawing.Size(89, 13);
            this.emptyLogin.TabIndex = 5;
            this.emptyLogin.Text = "The field is empty";
            this.emptyLogin.Visible = false;
            // 
            // emptyPass
            // 
            this.emptyPass.AutoSize = true;
            this.emptyPass.Location = new System.Drawing.Point(357, 207);
            this.emptyPass.Name = "emptyPass";
            this.emptyPass.Size = new System.Drawing.Size(89, 13);
            this.emptyPass.TabIndex = 5;
            this.emptyPass.Text = "The field is empty";
            this.emptyPass.Visible = false;
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.emptyPass);
            this.Controls.Add(this.emptyLogin);
            this.Controls.Add(this.exitFromProgramm);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.buttonSignIn);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.textBoxPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignIn";
            this.Text = "SignIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonSignIn;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Button exitFromProgramm;
        private System.Windows.Forms.Label emptyLogin;
        private System.Windows.Forms.Label emptyPass;
    }
}