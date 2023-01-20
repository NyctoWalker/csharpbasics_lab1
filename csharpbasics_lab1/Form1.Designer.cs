
namespace csharpbasics_lab1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.b_addconsumer = new System.Windows.Forms.Button();
            this.b_deleteconsumer = new System.Windows.Forms.Button();
            this.b_checkinfo = new System.Windows.Forms.Button();
            this.b_loyaltycard = new System.Windows.Forms.Button();
            this.b_changediscount = new System.Windows.Forms.Button();
            this.b_calculatesum = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.l_sumval = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.l_discval = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // b_addconsumer
            // 
            this.b_addconsumer.Location = new System.Drawing.Point(12, 367);
            this.b_addconsumer.Name = "b_addconsumer";
            this.b_addconsumer.Size = new System.Drawing.Size(127, 23);
            this.b_addconsumer.TabIndex = 0;
            this.b_addconsumer.Text = "Добавить покупателя";
            this.b_addconsumer.UseVisualStyleBackColor = true;
            this.b_addconsumer.Click += new System.EventHandler(this.b_addconsumer_Click);
            // 
            // b_deleteconsumer
            // 
            this.b_deleteconsumer.Location = new System.Drawing.Point(12, 406);
            this.b_deleteconsumer.Name = "b_deleteconsumer";
            this.b_deleteconsumer.Size = new System.Drawing.Size(127, 23);
            this.b_deleteconsumer.TabIndex = 1;
            this.b_deleteconsumer.Text = "Удалить покупателя";
            this.b_deleteconsumer.UseVisualStyleBackColor = true;
            this.b_deleteconsumer.Click += new System.EventHandler(this.button1_Click);
            // 
            // b_checkinfo
            // 
            this.b_checkinfo.Location = new System.Drawing.Point(324, 367);
            this.b_checkinfo.Name = "b_checkinfo";
            this.b_checkinfo.Size = new System.Drawing.Size(174, 23);
            this.b_checkinfo.TabIndex = 2;
            this.b_checkinfo.Text = "Информация о покупателе";
            this.b_checkinfo.UseVisualStyleBackColor = true;
            this.b_checkinfo.Click += new System.EventHandler(this.b_checkinfo_Click);
            // 
            // b_loyaltycard
            // 
            this.b_loyaltycard.Location = new System.Drawing.Point(145, 367);
            this.b_loyaltycard.Name = "b_loyaltycard";
            this.b_loyaltycard.Size = new System.Drawing.Size(156, 23);
            this.b_loyaltycard.TabIndex = 3;
            this.b_loyaltycard.Text = "Выдать карту лояльности";
            this.b_loyaltycard.UseVisualStyleBackColor = true;
            this.b_loyaltycard.Click += new System.EventHandler(this.b_loyaltycard_Click);
            // 
            // b_changediscount
            // 
            this.b_changediscount.Location = new System.Drawing.Point(145, 406);
            this.b_changediscount.Name = "b_changediscount";
            this.b_changediscount.Size = new System.Drawing.Size(156, 23);
            this.b_changediscount.TabIndex = 4;
            this.b_changediscount.Text = "Изменить процент скидки";
            this.b_changediscount.UseVisualStyleBackColor = true;
            this.b_changediscount.Click += new System.EventHandler(this.b_changediscount_Click);
            // 
            // b_calculatesum
            // 
            this.b_calculatesum.Location = new System.Drawing.Point(324, 406);
            this.b_calculatesum.Name = "b_calculatesum";
            this.b_calculatesum.Size = new System.Drawing.Size(174, 23);
            this.b_calculatesum.TabIndex = 5;
            this.b_calculatesum.Text = "Рассчитать стоимость товаров";
            this.b_calculatesum.UseVisualStyleBackColor = true;
            this.b_calculatesum.Click += new System.EventHandler(this.b_calculatesum_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Покупатели";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(320, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Товары";
            // 
            // l_sumval
            // 
            this.l_sumval.AutoSize = true;
            this.l_sumval.Location = new System.Drawing.Point(504, 380);
            this.l_sumval.Name = "l_sumval";
            this.l_sumval.Size = new System.Drawing.Size(13, 13);
            this.l_sumval.TabIndex = 9;
            this.l_sumval.Text = "0";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(324, 77);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox1.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(504, 367);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Сумма без скидки:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(505, 406);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Сумма со скидкой:";
            // 
            // l_discval
            // 
            this.l_discval.AutoSize = true;
            this.l_discval.Location = new System.Drawing.Point(505, 419);
            this.l_discval.Name = "l_discval";
            this.l_discval.Size = new System.Drawing.Size(13, 13);
            this.l_discval.TabIndex = 13;
            this.l_discval.Text = "0";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(16, 64);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel1.TabIndex = 14;
            this.flowLayoutPanel1.Visible = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(16, 202);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 15;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.l_discval);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.l_sumval);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.b_calculatesum);
            this.Controls.Add(this.b_changediscount);
            this.Controls.Add(this.b_loyaltycard);
            this.Controls.Add(this.b_checkinfo);
            this.Controls.Add(this.b_deleteconsumer);
            this.Controls.Add(this.b_addconsumer);
            this.MaximumSize = new System.Drawing.Size(640, 480);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "Form1";
            this.Text = "Shop";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_addconsumer;
        private System.Windows.Forms.Button b_deleteconsumer;
        private System.Windows.Forms.Button b_checkinfo;
        private System.Windows.Forms.Button b_loyaltycard;
        private System.Windows.Forms.Button b_changediscount;
        private System.Windows.Forms.Button b_calculatesum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label l_sumval;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label l_discval;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

