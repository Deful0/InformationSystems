namespace InformationSystems.NHibernate.Entites
{
    partial class RetroBookListUnit
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RetroBookListUnit));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_create = new System.Windows.Forms.ToolStripButton();
            this.tsb_update = new System.Windows.Forms.ToolStripButton();
            this.tsb_delete = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.dgv_RetroBooks = new System.Windows.Forms.DataGridView();
            this.retroBookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booknameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.retrobookpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookauthorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookcountlistDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookexistDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.retrobooknameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_RetroBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.retroBookBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_create,
            this.tsb_update,
            this.tsb_delete,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(958, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsb_create
            // 
            this.tsb_create.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_create.Image = ((System.Drawing.Image)(resources.GetObject("tsb_create.Image")));
            this.tsb_create.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_create.Name = "tsb_create";
            this.tsb_create.Size = new System.Drawing.Size(54, 22);
            this.tsb_create.Text = "Создать";
            this.tsb_create.Click += new System.EventHandler(this.tsb_create_Click);
            // 
            // tsb_update
            // 
            this.tsb_update.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_update.Image = ((System.Drawing.Image)(resources.GetObject("tsb_update.Image")));
            this.tsb_update.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_update.Name = "tsb_update";
            this.tsb_update.Size = new System.Drawing.Size(65, 22);
            this.tsb_update.Text = "Изменить";
            this.tsb_update.Click += new System.EventHandler(this.tsb_update_Click);
            // 
            // tsb_delete
            // 
            this.tsb_delete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_delete.Image = ((System.Drawing.Image)(resources.GetObject("tsb_delete.Image")));
            this.tsb_delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_delete.Name = "tsb_delete";
            this.tsb_delete.Size = new System.Drawing.Size(55, 22);
            this.tsb_delete.Text = "Удалить";
            this.tsb_delete.Click += new System.EventHandler(this.tsb_delete_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(67, 22);
            this.toolStripButton4.Text = "Вернуться";
            this.toolStripButton4.ToolTipText = "tb_back";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // dgv_RetroBooks
            // 
            this.dgv_RetroBooks.AutoGenerateColumns = false;
            this.dgv_RetroBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_RetroBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookidDataGridViewTextBoxColumn,
            this.booknameDataGridViewTextBoxColumn,
            this.retrobookpriceDataGridViewTextBoxColumn,
            this.bookauthorDataGridViewTextBoxColumn,
            this.bookdateDataGridViewTextBoxColumn,
            this.bookcountlistDataGridViewTextBoxColumn,
            this.bookexistDataGridViewCheckBoxColumn,
            this.retrobooknameDataGridViewTextBoxColumn});
            this.dgv_RetroBooks.DataSource = this.retroBookBindingSource;
            this.dgv_RetroBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_RetroBooks.Location = new System.Drawing.Point(0, 25);
            this.dgv_RetroBooks.Name = "dgv_RetroBooks";
            this.dgv_RetroBooks.Size = new System.Drawing.Size(958, 425);
            this.dgv_RetroBooks.TabIndex = 1;
            // 
            // retroBookBindingSource
            // 
            this.retroBookBindingSource.DataSource = typeof(InformationSystems.NHibernate.Entites.RetroBook);
            // 
            // bookidDataGridViewTextBoxColumn
            // 
            this.bookidDataGridViewTextBoxColumn.DataPropertyName = "book_id";
            this.bookidDataGridViewTextBoxColumn.HeaderText = "ID книги";
            this.bookidDataGridViewTextBoxColumn.Name = "bookidDataGridViewTextBoxColumn";
            // 
            // booknameDataGridViewTextBoxColumn
            // 
            this.booknameDataGridViewTextBoxColumn.DataPropertyName = "book_name";
            this.booknameDataGridViewTextBoxColumn.HeaderText = "Название книги (тег)";
            this.booknameDataGridViewTextBoxColumn.Name = "booknameDataGridViewTextBoxColumn";
            // 
            // retrobookpriceDataGridViewTextBoxColumn
            // 
            this.retrobookpriceDataGridViewTextBoxColumn.DataPropertyName = "retro_book_price";
            this.retrobookpriceDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.retrobookpriceDataGridViewTextBoxColumn.Name = "retrobookpriceDataGridViewTextBoxColumn";
            // 
            // bookauthorDataGridViewTextBoxColumn
            // 
            this.bookauthorDataGridViewTextBoxColumn.DataPropertyName = "book_author";
            this.bookauthorDataGridViewTextBoxColumn.HeaderText = "Автор";
            this.bookauthorDataGridViewTextBoxColumn.Name = "bookauthorDataGridViewTextBoxColumn";
            // 
            // bookdateDataGridViewTextBoxColumn
            // 
            this.bookdateDataGridViewTextBoxColumn.DataPropertyName = "book_date";
            this.bookdateDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.bookdateDataGridViewTextBoxColumn.Name = "bookdateDataGridViewTextBoxColumn";
            // 
            // bookcountlistDataGridViewTextBoxColumn
            // 
            this.bookcountlistDataGridViewTextBoxColumn.DataPropertyName = "book_count_list";
            this.bookcountlistDataGridViewTextBoxColumn.HeaderText = "Кол-во страниц";
            this.bookcountlistDataGridViewTextBoxColumn.Name = "bookcountlistDataGridViewTextBoxColumn";
            // 
            // bookexistDataGridViewCheckBoxColumn
            // 
            this.bookexistDataGridViewCheckBoxColumn.DataPropertyName = "book_exist";
            this.bookexistDataGridViewCheckBoxColumn.HeaderText = "Наличие";
            this.bookexistDataGridViewCheckBoxColumn.Name = "bookexistDataGridViewCheckBoxColumn";
            // 
            // retrobooknameDataGridViewTextBoxColumn
            // 
            this.retrobooknameDataGridViewTextBoxColumn.DataPropertyName = "retro_book_name";
            this.retrobooknameDataGridViewTextBoxColumn.HeaderText = "Название книги";
            this.retrobooknameDataGridViewTextBoxColumn.Name = "retrobooknameDataGridViewTextBoxColumn";
            // 
            // RetroBookListUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 450);
            this.Controls.Add(this.dgv_RetroBooks);
            this.Controls.Add(this.toolStrip1);
            this.Name = "RetroBookListUnit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RetroBookListUnit";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_RetroBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.retroBookBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_create;
        private System.Windows.Forms.ToolStripButton tsb_update;
        private System.Windows.Forms.ToolStripButton tsb_delete;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.DataGridView dgv_RetroBooks;
        private System.Windows.Forms.BindingSource retroBookBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn booknameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn retrobookpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookauthorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookcountlistDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bookexistDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn retrobooknameDataGridViewTextBoxColumn;
    }
}