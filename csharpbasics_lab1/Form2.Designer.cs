
namespace csharpbasics_lab1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.t_fname = new System.Windows.Forms.TextBox();
            this.t_sname = new System.Windows.Forms.TextBox();
            this.t_tname = new System.Windows.Forms.TextBox();
            this.t_adress = new System.Windows.Forms.TextBox();
            this.b_ok = new System.Windows.Forms.Button();
            this.b_cancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Фамилия:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Отчество:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Адрес:";
            // 
            // t_fname
            // 
            this.t_fname.Location = new System.Drawing.Point(81, 13);
            this.t_fname.Name = "t_fname";
            this.t_fname.Size = new System.Drawing.Size(208, 20);
            this.t_fname.TabIndex = 4;
            // 
            // t_sname
            // 
            this.t_sname.Location = new System.Drawing.Point(81, 35);
            this.t_sname.Name = "t_sname";
            this.t_sname.Size = new System.Drawing.Size(208, 20);
            this.t_sname.TabIndex = 5;
            // 
            // t_tname
            // 
            this.t_tname.Location = new System.Drawing.Point(81, 58);
            this.t_tname.Name = "t_tname";
            this.t_tname.Size = new System.Drawing.Size(208, 20);
            this.t_tname.TabIndex = 6;
            // 
            // t_adress
            // 
            this.t_adress.Location = new System.Drawing.Point(81, 80);
            this.t_adress.Name = "t_adress";
            this.t_adress.Size = new System.Drawing.Size(208, 20);
            this.t_adress.TabIndex = 7;
            // 
            // b_ok
            // 
            this.b_ok.Location = new System.Drawing.Point(12, 135);
            this.b_ok.Name = "b_ok";
            this.b_ok.Size = new System.Drawing.Size(75, 23);
            this.b_ok.TabIndex = 8;
            this.b_ok.Text = "Ок";
            this.b_ok.UseVisualStyleBackColor = true;
            this.b_ok.Click += new System.EventHandler(this.b_ok_Click);
            // 
            // b_cancel
            // 
            this.b_cancel.Location = new System.Drawing.Point(209, 135);
            this.b_cancel.Name = "b_cancel";
            this.b_cancel.Size = new System.Drawing.Size(75, 23);
            this.b_cancel.TabIndex = 9;
            this.b_cancel.Text = "Отмена";
            this.b_cancel.UseVisualStyleBackColor = true;
            this.b_cancel.Click += new System.EventHandler(this.b_cancel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(280, 26);
            this.label5.TabIndex = 10;
            this.label5.Text = "Введите от 2 до 20 символов в первых 3 полях и от 5 \r\nдо 30 в четвёртом.";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 171);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.b_cancel);
            this.Controls.Add(this.b_ok);
            this.Controls.Add(this.t_adress);
            this.Controls.Add(this.t_tname);
            this.Controls.Add(this.t_sname);
            this.Controls.Add(this.t_fname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(320, 210);
            this.MinimumSize = new System.Drawing.Size(320, 210);
            this.Name = "Form2";
            this.Text = "Добавление покупателя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox t_fname;
        private System.Windows.Forms.TextBox t_sname;
        private System.Windows.Forms.TextBox t_tname;
        private System.Windows.Forms.TextBox t_adress;
        private System.Windows.Forms.Button b_ok;
        private System.Windows.Forms.Button b_cancel;
        private System.Windows.Forms.Label label5;
    }
}