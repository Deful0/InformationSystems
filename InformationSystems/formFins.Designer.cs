namespace InformationSystems
{
    partial class formFins
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.finsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBDataSet = new InformationSystems.DBDataSet();
            this.finsTableAdapter = new InformationSystems.DBDataSetTableAdapters.finsTableAdapter();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new InformationSystems.DBDataSetTableAdapters.usersTableAdapter();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.booksTableAdapter = new InformationSystems.DBDataSetTableAdapters.booksTableAdapter();
            this.fineidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.useridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bookidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.fineamountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finecommentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finepaydateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(620, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "Вернуться";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fineidDataGridViewTextBoxColumn,
            this.useridDataGridViewTextBoxColumn,
            this.bookidDataGridViewTextBoxColumn,
            this.fineamountDataGridViewTextBoxColumn,
            this.finecommentDataGridViewTextBoxColumn,
            this.finepaydateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.finsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 352);
            this.dataGridView1.TabIndex = 1;
            // 
            // finsBindingSource
            // 
            this.finsBindingSource.DataMember = "fins";
            this.finsBindingSource.DataSource = this.dBDataSet;
            // 
            // dBDataSet
            // 
            this.dBDataSet.DataSetName = "DBDataSet";
            this.dBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // finsTableAdapter
            // 
            this.finsTableAdapter.ClearBeforeFill = true;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.dBDataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "books";
            this.booksBindingSource.DataSource = this.dBDataSet;
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // fineidDataGridViewTextBoxColumn
            // 
            this.fineidDataGridViewTextBoxColumn.DataPropertyName = "fine_id";
            this.fineidDataGridViewTextBoxColumn.HeaderText = "fine_id";
            this.fineidDataGridViewTextBoxColumn.Name = "fineidDataGridViewTextBoxColumn";
            // 
            // useridDataGridViewTextBoxColumn
            // 
            this.useridDataGridViewTextBoxColumn.DataPropertyName = "user_id";
            this.useridDataGridViewTextBoxColumn.DataSource = this.usersBindingSource;
            this.useridDataGridViewTextBoxColumn.DisplayMember = "user_name";
            this.useridDataGridViewTextBoxColumn.HeaderText = "user_id";
            this.useridDataGridViewTextBoxColumn.Name = "useridDataGridViewTextBoxColumn";
            this.useridDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.useridDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.useridDataGridViewTextBoxColumn.ValueMember = "user_id";
            // 
            // bookidDataGridViewTextBoxColumn
            // 
            this.bookidDataGridViewTextBoxColumn.DataPropertyName = "book_id";
            this.bookidDataGridViewTextBoxColumn.DataSource = this.booksBindingSource;
            this.bookidDataGridViewTextBoxColumn.DisplayMember = "book_name";
            this.bookidDataGridViewTextBoxColumn.HeaderText = "book_id";
            this.bookidDataGridViewTextBoxColumn.Name = "bookidDataGridViewTextBoxColumn";
            this.bookidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.bookidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.bookidDataGridViewTextBoxColumn.ValueMember = "book_id";
            // 
            // fineamountDataGridViewTextBoxColumn
            // 
            this.fineamountDataGridViewTextBoxColumn.DataPropertyName = "fine_amount";
            this.fineamountDataGridViewTextBoxColumn.HeaderText = "fine_amount";
            this.fineamountDataGridViewTextBoxColumn.Name = "fineamountDataGridViewTextBoxColumn";
            // 
            // finecommentDataGridViewTextBoxColumn
            // 
            this.finecommentDataGridViewTextBoxColumn.DataPropertyName = "fine_comment";
            this.finecommentDataGridViewTextBoxColumn.HeaderText = "fine_comment";
            this.finecommentDataGridViewTextBoxColumn.Name = "finecommentDataGridViewTextBoxColumn";
            // 
            // finepaydateDataGridViewTextBoxColumn
            // 
            this.finepaydateDataGridViewTextBoxColumn.DataPropertyName = "fine_pay_date";
            this.finepaydateDataGridViewTextBoxColumn.HeaderText = "fine_pay_date";
            this.finepaydateDataGridViewTextBoxColumn.Name = "finepaydateDataGridViewTextBoxColumn";
            // 
            // formFins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "formFins";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formFins";
            this.Load += new System.EventHandler(this.formFins_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DBDataSet dBDataSet;
        private System.Windows.Forms.BindingSource finsBindingSource;
        private DBDataSetTableAdapters.finsTableAdapter finsTableAdapter;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private DBDataSetTableAdapters.usersTableAdapter usersTableAdapter;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private DBDataSetTableAdapters.booksTableAdapter booksTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fineidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn useridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn bookidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fineamountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finecommentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finepaydateDataGridViewTextBoxColumn;
    }
}