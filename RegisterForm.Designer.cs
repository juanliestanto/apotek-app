namespace apotek_app
{
    partial class RegisterForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            username = new TextBox();
            label4 = new Label();
            password = new TextBox();
            register = new Button();
            signin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.Location = new Point(322, 68);
            label1.Name = "label1";
            label1.Size = new Size(168, 37);
            label1.TabIndex = 1;
            label1.Text = "Apotek XYZ";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(360, 101);
            label2.Name = "label2";
            label2.Size = new Size(90, 28);
            label2.TabIndex = 2;
            label2.Text = "Register";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(239, 149);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 3;
            label3.Text = "username :";
            // 
            // username
            // 
            username.Anchor = AnchorStyles.None;
            username.Location = new Point(241, 178);
            username.Name = "username";
            username.Size = new Size(321, 27);
            username.TabIndex = 5;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(238, 211);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 6;
            label4.Text = "password :";
            // 
            // password
            // 
            password.Anchor = AnchorStyles.None;
            password.Location = new Point(241, 238);
            password.Name = "password";
            password.Size = new Size(321, 27);
            password.TabIndex = 7;
            // 
            // register
            // 
            register.Anchor = AnchorStyles.None;
            register.Location = new Point(290, 289);
            register.Name = "register";
            register.Size = new Size(94, 29);
            register.TabIndex = 8;
            register.Text = "Register";
            register.UseVisualStyleBackColor = true;
            register.Click += register_Click;
            // 
            // signin
            // 
            signin.Anchor = AnchorStyles.None;
            signin.Location = new Point(408, 289);
            signin.Name = "signin";
            signin.Size = new Size(94, 29);
            signin.TabIndex = 9;
            signin.Text = "Sign In";
            signin.UseVisualStyleBackColor = true;
            signin.Click += signin_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(signin);
            Controls.Add(register);
            Controls.Add(password);
            Controls.Add(label4);
            Controls.Add(username);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RegisterForm";
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox username;
        private Label label4;
        private TextBox password;
        private Button register;
        private Button signin;
    }
}