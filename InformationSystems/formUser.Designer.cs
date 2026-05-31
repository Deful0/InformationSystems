namespace InformationSystems
{
    partial class formUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formUser));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_create = new System.Windows.Forms.ToolStripButton();
            this.tsb_update = new System.Windows.Forms.ToolStripButton();
            this.tsb_delete = new System.Windows.Forms.ToolStripButton();
            this.tsb_back = new System.Windows.Forms.ToolStripButton();
            this.dgv_users = new System.Windows.Forms.DataGridView();
            this.useridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usermailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userphoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userregistrationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_users)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_create,
            this.tsb_update,
            this.tsb_delete,
            this.tsb_back});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
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
            // tsb_back
            // 
            this.tsb_back.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_back.Image = ((System.Drawing.Image)(resources.GetObject("tsb_back.Image")));
            this.tsb_back.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_back.Name = "tsb_back";
            this.tsb_back.Size = new System.Drawing.Size(67, 22);
            this.tsb_back.Text = "Вернуться";
            this.tsb_back.Click += new System.EventHandler(this.tsb_back_Click);
            // 
            // dgv_users
            // 
            this.dgv_users.AutoGenerateColumns = false;
            this.dgv_users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_users.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.useridDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.usermailDataGridViewTextBoxColumn,
            this.userphoneDataGridViewTextBoxColumn,
            this.userregistrationDataGridViewTextBoxColumn});
            this.dgv_users.DataSource = this.userBindingSource;
            this.dgv_users.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_users.Location = new System.Drawing.Point(0, 25);
            this.dgv_users.Name = "dgv_users";
            this.dgv_users.Size = new System.Drawing.Size(800, 425);
            this.dgv_users.TabIndex = 2;
            // 
            // useridDataGridViewTextBoxColumn
            // 
            this.useridDataGridViewTextBoxColumn.DataPropertyName = "user_id";
            this.useridDataGridViewTextBoxColumn.HeaderText = "user_id";
            this.useridDataGridViewTextBoxColumn.Name = "useridDataGridViewTextBoxColumn";
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "user_name";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "user_name";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // usermailDataGridViewTextBoxColumn
            // 
            this.usermailDataGridViewTextBoxColumn.DataPropertyName = "user_mail";
            this.usermailDataGridViewTextBoxColumn.HeaderText = "user_mail";
            this.usermailDataGridViewTextBoxColumn.Name = "usermailDataGridViewTextBoxColumn";
            // 
            // userphoneDataGridViewTextBoxColumn
            // 
            this.userphoneDataGridViewTextBoxColumn.DataPropertyName = "user_phone";
            this.userphoneDataGridViewTextBoxColumn.HeaderText = "user_phone";
            this.userphoneDataGridViewTextBoxColumn.Name = "userphoneDataGridViewTextBoxColumn";
            // 
            // userregistrationDataGridViewTextBoxColumn
            // 
            this.userregistrationDataGridViewTextBoxColumn.DataPropertyName = "user_registration";
            this.userregistrationDataGridViewTextBoxColumn.HeaderText = "user_registration";
            this.userregistrationDataGridViewTextBoxColumn.Name = "userregistrationDataGridViewTextBoxColumn";
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(InformationSystems.NHibernate.Entites.User);
            // 
            // formUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_users);
            this.Controls.Add(this.toolStrip1);
            this.Name = "formUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formUser";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_users)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_create;
        private System.Windows.Forms.ToolStripButton tsb_update;
        private System.Windows.Forms.ToolStripButton tsb_delete;
        private System.Windows.Forms.ToolStripButton tsb_back;
        private System.Windows.Forms.DataGridView dgv_users;
        private System.Windows.Forms.DataGridViewTextBoxColumn useridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usermailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userphoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userregistrationDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource userBindingSource;
    }
}