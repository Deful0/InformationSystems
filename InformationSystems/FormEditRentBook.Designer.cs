namespace InformationSystems
{
    partial class FormEditRentBook
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.booksTableAdapter = new InformationSystems.DBDataSetTableAdapters.booksTableAdapter();
            this.usersTableAdapter = new InformationSystems.DBDataSetTableAdapters.usersTableAdapter();
            this.rentsTableAdapter = new InformationSystems.DBDataSetTableAdapters.rentsTableAdapter();
            this.workersTableAdapter = new InformationSystems.DBDataSetTableAdapters.workersTableAdapter();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBDataSet1 = new InformationSystems.DBDataSet();
            this.rentsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxBook = new System.Windows.Forms.ComboBox();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rentsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxUser = new System.Windows.Forms.ComboBox();
            this.workersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBDataSet = new InformationSystems.DBDataSet();
            this.rentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimePickerRentDate = new System.Windows.Forms.DateTimePicker();
            this.comboBoxWorker = new System.Windows.Forms.ComboBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(201, 247);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(191, 55);
            this.buttonCancel.TabIndex = 47;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // rentsTableAdapter
            // 
            this.rentsTableAdapter.ClearBeforeFill = true;
            // 
            // workersTableAdapter
            // 
            this.workersTableAdapter.ClearBeforeFill = true;
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "books";
            this.booksBindingSource.DataSource = this.dBDataSet1;
            // 
            // dBDataSet1
            // 
            this.dBDataSet1.DataSetName = "DBDataSet";
            this.dBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rentsBindingSource2
            // 
            this.rentsBindingSource2.DataMember = "rents";
            this.rentsBindingSource2.DataSource = this.dBDataSet1;
            // 
            // comboBoxBook
            // 
            this.comboBoxBook.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.rentsBindingSource2, "book_id", true));
            this.comboBoxBook.DataSource = this.booksBindingSource;
            this.comboBoxBook.DisplayMember = "book_name";
            this.comboBoxBook.FormattingEnabled = true;
            this.comboBoxBook.Location = new System.Drawing.Point(153, 103);
            this.comboBoxBook.Name = "comboBoxBook";
            this.comboBoxBook.Size = new System.Drawing.Size(239, 21);
            this.comboBoxBook.TabIndex = 45;
            this.comboBoxBook.ValueMember = "book_id";
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.dBDataSet1;
            // 
            // rentsBindingSource1
            // 
            this.rentsBindingSource1.DataMember = "rents";
            this.rentsBindingSource1.DataSource = this.dBDataSet1;
            // 
            // comboBoxUser
            // 
            this.comboBoxUser.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.rentsBindingSource1, "user_id", true));
            this.comboBoxUser.DataSource = this.usersBindingSource;
            this.comboBoxUser.DisplayMember = "user_name";
            this.comboBoxUser.FormattingEnabled = true;
            this.comboBoxUser.Location = new System.Drawing.Point(153, 58);
            this.comboBoxUser.Name = "comboBoxUser";
            this.comboBoxUser.Size = new System.Drawing.Size(239, 21);
            this.comboBoxUser.TabIndex = 44;
            this.comboBoxUser.ValueMember = "user_id";
            // 
            // workersBindingSource
            // 
            this.workersBindingSource.DataMember = "workers";
            this.workersBindingSource.DataSource = this.dBDataSet;
            // 
            // dBDataSet
            // 
            this.dBDataSet.DataSetName = "DBDataSet";
            this.dBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rentsBindingSource
            // 
            this.rentsBindingSource.DataMember = "rents";
            this.rentsBindingSource.DataSource = this.dBDataSet;
            // 
            // dateTimePickerRentDate
            // 
            this.dateTimePickerRentDate.Location = new System.Drawing.Point(153, 155);
            this.dateTimePickerRentDate.Name = "dateTimePickerRentDate";
            this.dateTimePickerRentDate.Size = new System.Drawing.Size(239, 20);
            this.dateTimePickerRentDate.TabIndex = 46;
            // 
            // comboBoxWorker
            // 
            this.comboBoxWorker.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.rentsBindingSource, "worker_id", true));
            this.comboBoxWorker.DataSource = this.workersBindingSource;
            this.comboBoxWorker.DisplayMember = "worker_name";
            this.comboBoxWorker.FormattingEnabled = true;
            this.comboBoxWorker.Location = new System.Drawing.Point(153, 15);
            this.comboBoxWorker.Name = "comboBoxWorker";
            this.comboBoxWorker.Size = new System.Drawing.Size(239, 21);
            this.comboBoxWorker.TabIndex = 43;
            this.comboBoxWorker.ValueMember = "worker_id";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(12, 247);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(183, 55);
            this.buttonSave.TabIndex = 42;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Дата начала аренды";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "ID книги";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "ID клиента";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "ID работника";
            // 
            // FormEditRentBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 314);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.comboBoxBook);
            this.Controls.Add(this.comboBoxUser);
            this.Controls.Add(this.dateTimePickerRentDate);
            this.Controls.Add(this.comboBoxWorker);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormEditRentBook";
            this.Text = "FormEditRentBook";
            this.Load += new System.EventHandler(this.FormEditRentBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private DBDataSetTableAdapters.booksTableAdapter booksTableAdapter;
        private DBDataSetTableAdapters.usersTableAdapter usersTableAdapter;
        private DBDataSetTableAdapters.rentsTableAdapter rentsTableAdapter;
        private DBDataSetTableAdapters.workersTableAdapter workersTableAdapter;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private DBDataSet dBDataSet1;
        private System.Windows.Forms.BindingSource rentsBindingSource2;
        private System.Windows.Forms.ComboBox comboBoxBook;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private System.Windows.Forms.BindingSource rentsBindingSource1;
        private System.Windows.Forms.ComboBox comboBoxUser;
        private System.Windows.Forms.BindingSource workersBindingSource;
        private DBDataSet dBDataSet;
        private System.Windows.Forms.BindingSource rentsBindingSource;
        private System.Windows.Forms.DateTimePicker dateTimePickerRentDate;
        private System.Windows.Forms.ComboBox comboBoxWorker;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}