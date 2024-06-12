namespace _31._2_List_WF
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
            this.btAdd = new System.Windows.Forms.Button();
            this.btdelete = new System.Windows.Forms.Button();
            this.btsearch = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.tb3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.ListBox();
            this.lbName = new System.Windows.Forms.ListBox();
            this.lbDis = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(12, 21);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(243, 43);
            this.btAdd.TabIndex = 0;
            this.btAdd.Text = "Добавление нового события в список.";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btdelete
            // 
            this.btdelete.Location = new System.Drawing.Point(476, 23);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(312, 41);
            this.btdelete.TabIndex = 1;
            this.btdelete.Text = " Удаление события по его названию.";
            this.btdelete.UseVisualStyleBackColor = true;
           
            // 
            // btsearch
            // 
            this.btsearch.Location = new System.Drawing.Point(476, 81);
            this.btsearch.Name = "btsearch";
            this.btsearch.Size = new System.Drawing.Size(312, 43);
            this.btsearch.TabIndex = 2;
            this.btsearch.Text = "Поиск события по его названию, дате или описанию.";
            this.btsearch.UseVisualStyleBackColor = true;
            this.btsearch.Click += new System.EventHandler(this.btsearch_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(476, 149);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(312, 41);
            this.button4.TabIndex = 3;
            this.button4.Text = "● Вывод списка всех событий в календаре";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(12, 93);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(243, 20);
            this.tb1.TabIndex = 4;
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(12, 141);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(243, 20);
            this.tb2.TabIndex = 5;
            // 
            // tb3
            // 
            this.tb3.Location = new System.Drawing.Point(12, 193);
            this.tb3.Name = "tb3";
            this.tb3.Size = new System.Drawing.Size(243, 20);
            this.tb3.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Дата: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Название: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Описание";
            // 
            // lbDate
            // 
            this.lbDate.FormattingEnabled = true;
            this.lbDate.Location = new System.Drawing.Point(12, 304);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(120, 95);
            this.lbDate.TabIndex = 10;
            // 
            // lbName
            // 
            this.lbName.FormattingEnabled = true;
            this.lbName.Location = new System.Drawing.Point(159, 304);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(120, 95);
            this.lbName.TabIndex = 11;
            // 
            // lbDis
            // 
            this.lbDis.FormattingEnabled = true;
            this.lbDis.Location = new System.Drawing.Point(305, 304);
            this.lbDis.Name = "lbDis";
            this.lbDis.Size = new System.Drawing.Size(120, 95);
            this.lbDis.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(159, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(302, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 26);
            this.label6.TabIndex = 15;
            this.label6.Text = "\r\nDescription";
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(15, 233);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(100, 20);
            this.tbSearch.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbDis);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb3);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btsearch);
            this.Controls.Add(this.btdelete);
            this.Controls.Add(this.btAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btdelete;
        private System.Windows.Forms.Button btsearch;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.TextBox tb3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbDate;
        private System.Windows.Forms.ListBox lbName;
        private System.Windows.Forms.ListBox lbDis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbSearch;
    }
}

