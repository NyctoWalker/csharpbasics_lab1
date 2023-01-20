
namespace csharpbasics_lab1
{
    partial class Form3
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.b_ok = new System.Windows.Forms.Button();
            this.t_adress = new System.Windows.Forms.TextBox();
            this.t_tname = new System.Windows.Forms.TextBox();
            this.t_sname = new System.Windows.Forms.TextBox();
            this.t_fname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.t_ID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.t_iscard = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.t_discount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Адрес:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Отчество:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Фамилия:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Имя:";
            // 
            // b_ok
            // 
            this.b_ok.Location = new System.Drawing.Point(15, 184);
            this.b_ok.Name = "b_ok";
            this.b_ok.Size = new System.Drawing.Size(75, 23);
            this.b_ok.TabIndex = 9;
            this.b_ok.Text = "Ок";
            this.b_ok.UseVisualStyleBackColor = true;
            this.b_ok.Click += new System.EventHandler(this.b_ok_Click);
            // 
            // t_adress
            // 
            this.t_adress.Location = new System.Drawing.Point(73, 76);
            this.t_adress.Name = "t_adress";
            this.t_adress.ReadOnly = true;
            this.t_adress.Size = new System.Drawing.Size(208, 20);
            this.t_adress.TabIndex = 13;
            // 
            // t_tname
            // 
            this.t_tname.Location = new System.Drawing.Point(73, 54);
            this.t_tname.Name = "t_tname";
            this.t_tname.ReadOnly = true;
            this.t_tname.Size = new System.Drawing.Size(208, 20);
            this.t_tname.TabIndex = 12;
            // 
            // t_sname
            // 
            this.t_sname.Location = new System.Drawing.Point(73, 31);
            this.t_sname.Name = "t_sname";
            this.t_sname.ReadOnly = true;
            this.t_sname.Size = new System.Drawing.Size(208, 20);
            this.t_sname.TabIndex = 11;
            // 
            // t_fname
            // 
            this.t_fname.Location = new System.Drawing.Point(73, 9);
            this.t_fname.Name = "t_fname";
            this.t_fname.ReadOnly = true;
            this.t_fname.Size = new System.Drawing.Size(208, 20);
            this.t_fname.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "ID:";
            // 
            // t_ID
            // 
            this.t_ID.Location = new System.Drawing.Point(73, 99);
            this.t_ID.Name = "t_ID";
            this.t_ID.ReadOnly = true;
            this.t_ID.Size = new System.Drawing.Size(53, 20);
            this.t_ID.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Карта:";
            // 
            // t_iscard
            // 
            this.t_iscard.Location = new System.Drawing.Point(73, 128);
            this.t_iscard.Name = "t_iscard";
            this.t_iscard.ReadOnly = true;
            this.t_iscard.Size = new System.Drawing.Size(53, 20);
            this.t_iscard.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(153, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Скидка:";
            // 
            // t_discount
            // 
            this.t_discount.Location = new System.Drawing.Point(206, 128);
            this.t_discount.Name = "t_discount";
            this.t_discount.ReadOnly = true;
            this.t_discount.Size = new System.Drawing.Size(36, 20);
            this.t_discount.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(248, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "%";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 219);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.t_discount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.t_iscard);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.t_ID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.t_adress);
            this.Controls.Add(this.t_tname);
            this.Controls.Add(this.t_sname);
            this.Controls.Add(this.t_fname);
            this.Controls.Add(this.b_ok);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Информация о покупателе";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b_ok;
        private System.Windows.Forms.TextBox t_adress;
        private System.Windows.Forms.TextBox t_tname;
        private System.Windows.Forms.TextBox t_sname;
        private System.Windows.Forms.TextBox t_fname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox t_ID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox t_iscard;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox t_discount;
        private System.Windows.Forms.Label label8;
    }
}