namespace SYSTEM
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Login = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnLogin = new Button();
            btnOut = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btnReg = new Button();
            Login.SuspendLayout();
            SuspendLayout();
            // 
            // Login
            // 
            Login.Controls.Add(btnReg);
            Login.Controls.Add(textBox2);
            Login.Controls.Add(textBox1);
            Login.Controls.Add(btnOut);
            Login.Controls.Add(btnLogin);
            Login.Controls.Add(label4);
            Login.Controls.Add(label3);
            Login.Controls.Add(label2);
            Login.Controls.Add(label1);
            Login.Location = new Point(72, 99);
            Login.Name = "Login";
            Login.Size = new Size(333, 514);
            Login.TabIndex = 0;
            Login.Tag = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 25F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(21, 75);
            label1.Name = "label1";
            label1.Size = new Size(191, 40);
            label1.TabIndex = 0;
            label1.Text = "WELCOME!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 25F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(67, 115);
            label2.Name = "label2";
            label2.Size = new Size(253, 40);
            label2.TabIndex = 1;
            label2.Text = "FITNESS GOAL";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(67, 246);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 2;
            label3.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(44, 294);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 3;
            label4.Text = "Password:";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(67, 400);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(111, 43);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "LOG IN";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // btnOut
            // 
            btnOut.Location = new Point(132, 459);
            btnOut.Name = "btnOut";
            btnOut.Size = new Size(80, 30);
            btnOut.TabIndex = 5;
            btnOut.Text = "OUT";
            btnOut.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(112, 243);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(144, 23);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(112, 291);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(144, 23);
            textBox2.TabIndex = 7;
            // 
            // btnReg
            // 
            btnReg.Location = new Point(184, 400);
            btnReg.Name = "btnReg";
            btnReg.Size = new Size(111, 43);
            btnReg.TabIndex = 8;
            btnReg.Text = "REGISTER";
            btnReg.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(470, 817);
            Controls.Add(Login);
            Name = "Form1";
            Text = "Form1";
            Login.ResumeLayout(false);
            Login.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel Login;
        private Label label2;
        private Label label1;
        private Button btnReg;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button btnOut;
        private Button btnLogin;
        private Label label4;
        private Label label3;
    }
}
