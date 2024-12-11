namespace Hospital
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtpassword11 = new System.Windows.Forms.TextBox();
            this.pass2 = new System.Windows.Forms.Label();
            this.txtpassword1 = new System.Windows.Forms.TextBox();
            this.txtusername1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 46);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hospital Online";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.txtpassword11);
            this.panel3.Controls.Add(this.pass2);
            this.panel3.Controls.Add(this.txtpassword1);
            this.panel3.Controls.Add(this.txtusername1);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.pass);
            this.panel3.Controls.Add(this.user);
            this.panel3.Location = new System.Drawing.Point(10, 61);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(347, 395);
            this.panel3.TabIndex = 3;
            // 
            // txtpassword11
            // 
            this.txtpassword11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtpassword11.Location = new System.Drawing.Point(10, 290);
            this.txtpassword11.Name = "txtpassword11";
            this.txtpassword11.Size = new System.Drawing.Size(337, 44);
            this.txtpassword11.TabIndex = 14;
            this.txtpassword11.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // pass2
            // 
            this.pass2.AutoSize = true;
            this.pass2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pass2.Location = new System.Drawing.Point(6, 250);
            this.pass2.Name = "pass2";
            this.pass2.Size = new System.Drawing.Size(311, 37);
            this.pass2.TabIndex = 13;
            this.pass2.Text = "Подтвердите пароль";
            // 
            // txtpassword1
            // 
            this.txtpassword1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtpassword1.Location = new System.Drawing.Point(7, 195);
            this.txtpassword1.Name = "txtpassword1";
            this.txtpassword1.Size = new System.Drawing.Size(337, 44);
            this.txtpassword1.TabIndex = 12;
            // 
            // txtusername1
            // 
            this.txtusername1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtusername1.Location = new System.Drawing.Point(7, 99);
            this.txtusername1.Name = "txtusername1";
            this.txtusername1.Size = new System.Drawing.Size(337, 44);
            this.txtusername1.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(25, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(289, 52);
            this.button1.TabIndex = 10;
            this.button1.Text = "Регистрация";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 37);
            this.label3.TabIndex = 0;
            this.label3.Text = "Регистрация";
            // 
            // pass
            // 
            this.pass.AutoSize = true;
            this.pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pass.Location = new System.Drawing.Point(3, 155);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(124, 37);
            this.pass.TabIndex = 7;
            this.pass.Text = "Пароль";
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.user.Location = new System.Drawing.Point(0, 59);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(98, 37);
            this.user.TabIndex = 5;
            this.user.Text = "Логин";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(972, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 46);
            this.button2.TabIndex = 1;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1100, 598);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label pass;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.TextBox txtpassword1;
        private System.Windows.Forms.TextBox txtusername1;
        private System.Windows.Forms.TextBox txtpassword11;
        private System.Windows.Forms.Label pass2;
        private System.Windows.Forms.Button button2;
    }
}