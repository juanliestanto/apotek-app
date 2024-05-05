namespace apotek_app
{
    partial class SignInForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            username = new TextBox();
            password = new TextBox();
            signin = new Button();
            register = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.Location = new Point(322, 53);
            label1.Name = "label1";
            label1.Size = new Size(168, 37);
            label1.TabIndex = 0;
            label1.Text = "Apotek XYZ";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(365, 90);
            label2.Name = "label2";
            label2.Size = new Size(77, 28);
            label2.TabIndex = 1;
            label2.Text = "Sign In";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(231, 146);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 2;
            label3.Text = "username :";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(231, 210);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 3;
            label4.Text = "password :";
            // 
            // username
            // 
            username.Anchor = AnchorStyles.None;
            username.Location = new Point(235, 177);
            username.Name = "username";
            username.Size = new Size(321, 27);
            username.TabIndex = 4;
            // 
            // password
            // 
            password.Anchor = AnchorStyles.None;
            password.Location = new Point(235, 242);
            password.Name = "password";
            password.Size = new Size(321, 27);
            password.TabIndex = 5;
            // 
            // signin
            // 
            signin.Anchor = AnchorStyles.None;
            signin.Location = new Point(406, 294);
            signin.Name = "signin";
            signin.Size = new Size(94, 29);
            signin.TabIndex = 6;
            signin.Text = "Sign In";
            signin.UseVisualStyleBackColor = true;
            signin.Click += signin_Click;
            // 
            // register
            // 
            register.Anchor = AnchorStyles.None;
            register.Location = new Point(291, 294);
            register.Name = "register";
            register.Size = new Size(94, 29);
            register.TabIndex = 7;
            register.Text = "Register";
            register.UseVisualStyleBackColor = true;
            register.Click += register_Click;
            // 
            // SignInForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 491);
            Controls.Add(register);
            Controls.Add(signin);
            Controls.Add(password);
            Controls.Add(username);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SignInForm";
            Text = "Sign In";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox username;
        private TextBox password;
        private Button signin;
        private Button register;
    }
}
