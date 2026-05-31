namespace InformationSystems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.dims = new System.Windows.Forms.ToolStripDropDownButton();
            this.dimBooks = new System.Windows.Forms.ToolStripMenuItem();
            this.dimEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.dimClient = new System.Windows.Forms.ToolStripMenuItem();
            this.dimVipClient = new System.Windows.Forms.ToolStripMenuItem();
            this.dimProvider = new System.Windows.Forms.ToolStripMenuItem();
            this.facts = new System.Windows.Forms.ToolStripDropDownButton();
            this.ButtonFins = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonRentBook = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonSalary = new System.Windows.Forms.ToolStripMenuItem();
            this.штрафыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dimRetroBooks = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dims,
            this.facts});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // dims
            // 
            this.dims.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.dims.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dimBooks,
            this.dimEmployee,
            this.dimClient,
            this.dimVipClient,
            this.dimProvider,
            this.dimRetroBooks});
            this.dims.Image = ((System.Drawing.Image)(resources.GetObject("dims.Image")));
            this.dims.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.dims.Name = "dims";
            this.dims.Size = new System.Drawing.Size(95, 22);
            this.dims.Text = "Справочники";
            // 
            // dimBooks
            // 
            this.dimBooks.Name = "dimBooks";
            this.dimBooks.Size = new System.Drawing.Size(180, 22);
            this.dimBooks.Text = "Книги";
            this.dimBooks.Click += new System.EventHandler(this.dimBooks_Click);
            // 
            // dimEmployee
            // 
            this.dimEmployee.Name = "dimEmployee";
            this.dimEmployee.Size = new System.Drawing.Size(180, 22);
            this.dimEmployee.Text = "Сотрудники";
            this.dimEmployee.Click += new System.EventHandler(this.dimEmployee_Click);
            // 
            // dimClient
            // 
            this.dimClient.Name = "dimClient";
            this.dimClient.Size = new System.Drawing.Size(180, 22);
            this.dimClient.Text = "Клиенты";
            this.dimClient.Click += new System.EventHandler(this.dimClient_Click);
            // 
            // dimVipClient
            // 
            this.dimVipClient.Name = "dimVipClient";
            this.dimVipClient.Size = new System.Drawing.Size(180, 22);
            this.dimVipClient.Text = "VIP клиенты";
            this.dimVipClient.Click += new System.EventHandler(this.dimVipClient_Click);
            // 
            // dimProvider
            // 
            this.dimProvider.Name = "dimProvider";
            this.dimProvider.Size = new System.Drawing.Size(180, 22);
            this.dimProvider.Text = "Поставщики";
            // 
            // facts
            // 
            this.facts.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.facts.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ButtonFins,
            this.ButtonRentBook,
            this.ButtonSalary,
            this.штрафыToolStripMenuItem,
            this.заToolStripMenuItem});
            this.facts.Image = ((System.Drawing.Image)(resources.GetObject("facts.Image")));
            this.facts.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.facts.Name = "facts";
            this.facts.Size = new System.Drawing.Size(83, 22);
            this.facts.Text = "Документы";
            // 
            // ButtonFins
            // 
            this.ButtonFins.Name = "ButtonFins";
            this.ButtonFins.Size = new System.Drawing.Size(183, 22);
            this.ButtonFins.Text = "Штрафы";
            this.ButtonFins.Click += new System.EventHandler(this.ButtonFins_Click);
            // 
            // ButtonRentBook
            // 
            this.ButtonRentBook.Name = "ButtonRentBook";
            this.ButtonRentBook.Size = new System.Drawing.Size(183, 22);
            this.ButtonRentBook.Text = "Бронирование книг";
            this.ButtonRentBook.Click += new System.EventHandler(this.ButtonRentBook_Click);
            // 
            // ButtonSalary
            // 
            this.ButtonSalary.Name = "ButtonSalary";
            this.ButtonSalary.Size = new System.Drawing.Size(183, 22);
            this.ButtonSalary.Text = "Заработная плата";
            this.ButtonSalary.Click += new System.EventHandler(this.ButtonSalary_Click);
            // 
            // штрафыToolStripMenuItem
            // 
            this.штрафыToolStripMenuItem.Name = "штрафыToolStripMenuItem";
            this.штрафыToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.штрафыToolStripMenuItem.Text = "Доставка книг";
            // 
            // заToolStripMenuItem
            // 
            this.заToolStripMenuItem.Name = "заToolStripMenuItem";
            this.заToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.заToolStripMenuItem.Text = "Заявки";
            // 
            // dimRetroBooks
            // 
            this.dimRetroBooks.Name = "dimRetroBooks";
            this.dimRetroBooks.Size = new System.Drawing.Size(180, 22);
            this.dimRetroBooks.Text = "Раритетные книги";
            this.dimRetroBooks.Click += new System.EventHandler(this.dimRetroBooks_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton dims;
        private System.Windows.Forms.ToolStripMenuItem dimBooks;
        private System.Windows.Forms.ToolStripMenuItem dimEmployee;
        private System.Windows.Forms.ToolStripMenuItem dimClient;
        private System.Windows.Forms.ToolStripMenuItem dimVipClient;
        private System.Windows.Forms.ToolStripMenuItem dimProvider;
        private System.Windows.Forms.ToolStripDropDownButton facts;
        private System.Windows.Forms.ToolStripMenuItem ButtonFins;
        private System.Windows.Forms.ToolStripMenuItem ButtonRentBook;
        private System.Windows.Forms.ToolStripMenuItem ButtonSalary;
        private System.Windows.Forms.ToolStripMenuItem штрафыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dimRetroBooks;
    }
}

