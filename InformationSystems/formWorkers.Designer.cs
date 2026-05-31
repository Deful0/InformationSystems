namespace InformationSystems
{
    partial class formWorkers
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.workeridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workstartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workendDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workersalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workerstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBDataSet = new InformationSystems.DBDataSet();
            this.workersTableAdapter = new InformationSystems.DBDataSetTableAdapters.workersTableAdapter();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonAddWork = new System.Windows.Forms.Button();
            this.buttonEditWork = new System.Windows.Forms.Button();
            this.buttonDeleteWork = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.workeridDataGridViewTextBoxColumn,
            this.workernameDataGridViewTextBoxColumn,
            this.workstartDataGridViewTextBoxColumn,
            this.workendDataGridViewTextBoxColumn,
            this.workersalaryDataGridViewTextBoxColumn,
            this.workerstatusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.workersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 378);
            this.dataGridView1.TabIndex = 0;
            // 
            // workeridDataGridViewTextBoxColumn
            // 
            this.workeridDataGridViewTextBoxColumn.DataPropertyName = "worker_id";
            this.workeridDataGridViewTextBoxColumn.HeaderText = "worker_id";
            this.workeridDataGridViewTextBoxColumn.Name = "workeridDataGridViewTextBoxColumn";
            // 
            // workernameDataGridViewTextBoxColumn
            // 
            this.workernameDataGridViewTextBoxColumn.DataPropertyName = "worker_name";
            this.workernameDataGridViewTextBoxColumn.HeaderText = "worker_name";
            this.workernameDataGridViewTextBoxColumn.Name = "workernameDataGridViewTextBoxColumn";
            // 
            // workstartDataGridViewTextBoxColumn
            // 
            this.workstartDataGridViewTextBoxColumn.DataPropertyName = "work_start";
            this.workstartDataGridViewTextBoxColumn.HeaderText = "work_start";
            this.workstartDataGridViewTextBoxColumn.Name = "workstartDataGridViewTextBoxColumn";
            // 
            // workendDataGridViewTextBoxColumn
            // 
            this.workendDataGridViewTextBoxColumn.DataPropertyName = "work_end";
            this.workendDataGridViewTextBoxColumn.HeaderText = "work_end";
            this.workendDataGridViewTextBoxColumn.Name = "workendDataGridViewTextBoxColumn";
            // 
            // workersalaryDataGridViewTextBoxColumn
            // 
            this.workersalaryDataGridViewTextBoxColumn.DataPropertyName = "worker_salary";
            this.workersalaryDataGridViewTextBoxColumn.HeaderText = "worker_salary";
            this.workersalaryDataGridViewTextBoxColumn.Name = "workersalaryDataGridViewTextBoxColumn";
            // 
            // workerstatusDataGridViewTextBoxColumn
            // 
            this.workerstatusDataGridViewTextBoxColumn.DataPropertyName = "worker_status";
            this.workerstatusDataGridViewTextBoxColumn.HeaderText = "worker_status";
            this.workerstatusDataGridViewTextBoxColumn.Name = "workerstatusDataGridViewTextBoxColumn";
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
            // workersTableAdapter
            // 
            this.workersTableAdapter.ClearBeforeFill = true;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(632, 6);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(156, 48);
            this.buttonBack.TabIndex = 1;
            this.buttonBack.Text = "Вернуться";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonAddWork
            // 
            this.buttonAddWork.Location = new System.Drawing.Point(12, 6);
            this.buttonAddWork.Name = "buttonAddWork";
            this.buttonAddWork.Size = new System.Drawing.Size(109, 48);
            this.buttonAddWork.TabIndex = 2;
            this.buttonAddWork.Text = "Добавить";
            this.buttonAddWork.UseVisualStyleBackColor = true;
            this.buttonAddWork.Click += new System.EventHandler(this.buttonAddWork_Click);
            // 
            // buttonEditWork
            // 
            this.buttonEditWork.Location = new System.Drawing.Point(142, 6);
            this.buttonEditWork.Name = "buttonEditWork";
            this.buttonEditWork.Size = new System.Drawing.Size(114, 48);
            this.buttonEditWork.TabIndex = 3;
            this.buttonEditWork.Text = "Изменить";
            this.buttonEditWork.UseVisualStyleBackColor = true;
            this.buttonEditWork.Click += new System.EventHandler(this.buttonEditWork_Click);
            // 
            // buttonDeleteWork
            // 
            this.buttonDeleteWork.Location = new System.Drawing.Point(285, 6);
            this.buttonDeleteWork.Name = "buttonDeleteWork";
            this.buttonDeleteWork.Size = new System.Drawing.Size(117, 48);
            this.buttonDeleteWork.TabIndex = 4;
            this.buttonDeleteWork.Text = "Удалить";
            this.buttonDeleteWork.UseVisualStyleBackColor = true;
            this.buttonDeleteWork.Click += new System.EventHandler(this.buttonDeleteWork_Click);
            // 
            // formWorkers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDeleteWork);
            this.Controls.Add(this.buttonEditWork);
            this.Controls.Add(this.buttonAddWork);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.dataGridView1);
            this.Name = "formWorkers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formWorkers";
            this.Load += new System.EventHandler(this.formWorkers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DBDataSet dBDataSet;
        private System.Windows.Forms.BindingSource workersBindingSource;
        private DBDataSetTableAdapters.workersTableAdapter workersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn workeridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workstartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workendDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workersalaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workerstatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonAddWork;
        private System.Windows.Forms.Button buttonEditWork;
        private System.Windows.Forms.Button buttonDeleteWork;
    }
}