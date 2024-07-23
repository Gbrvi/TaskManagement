namespace TaskManagmentGUI
{
    partial class Cadastro
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
            tb_SINGuser = new TextBox();
            tb_SINGpass = new TextBox();
            label4 = new Label();
            btn_singUp = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(276, 53);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(240, 64);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 1;
            label2.Text = "username";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(242, 132);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 2;
            label3.Text = "password";
            label3.Click += label3_Click;
            // 
            // tb_SINGuser
            // 
            tb_SINGuser.Location = new Point(242, 82);
            tb_SINGuser.Name = "tb_SINGuser";
            tb_SINGuser.Size = new Size(158, 23);
            tb_SINGuser.TabIndex = 3;
            // 
            // tb_SINGpass
            // 
            tb_SINGpass.Location = new Point(242, 150);
            tb_SINGpass.Name = "tb_SINGpass";
            tb_SINGpass.Size = new Size(158, 23);
            tb_SINGpass.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label4.Location = new Point(260, 16);
            label4.Name = "label4";
            label4.Size = new Size(125, 37);
            label4.TabIndex = 5;
            label4.Text = "SING UP";
            label4.Click += label4_Click;
            // 
            // btn_singUp
            // 
            btn_singUp.BackColor = SystemColors.Control;
            btn_singUp.Font = new Font("Segoe UI", 10F);
            btn_singUp.Location = new Point(276, 196);
            btn_singUp.Name = "btn_singUp";
            btn_singUp.Size = new Size(77, 28);
            btn_singUp.TabIndex = 6;
            btn_singUp.Text = "Sing up";
            btn_singUp.UseVisualStyleBackColor = false;
            btn_singUp.Click += btn_singUp_Click;
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_singUp);
            Controls.Add(label4);
            Controls.Add(tb_SINGpass);
            Controls.Add(tb_SINGuser);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Cadastro";
            Text = "Cadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tb_SINGuser;
        private TextBox tb_SINGpass;
        private Label label4;
        private Button btn_singUp;
    }
}