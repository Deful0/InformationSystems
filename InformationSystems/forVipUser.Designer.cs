namespace InformationSystems
{
    partial class forVipUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(forVipUser));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_create = new System.Windows.Forms.ToolStripButton();
            this.tsb_change = new System.Windows.Forms.ToolStripButton();
            this.tsb_delete = new System.Windows.Forms.ToolStripButton();
            this.tsb_back = new System.Windows.Forms.ToolStripButton();
            this.dgv_vipuser = new System.Windows.Forms.DataGridView();
            this.vipUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vipuseridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vipusernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vipuserdatestartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vipuser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vipUserBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_create,
            this.tsb_change,
            this.tsb_delete,
            this.tsb_back});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
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
            // tsb_change
            // 
            this.tsb_change.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_change.Image = ((System.Drawing.Image)(resources.GetObject("tsb_change.Image")));
            this.tsb_change.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_change.Name = "tsb_change";
            this.tsb_change.Size = new System.Drawing.Size(65, 22);
            this.tsb_change.Text = "Изменить";
            this.tsb_change.Click += new System.EventHandler(this.tsb_change_Click);
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
            // dgv_vipuser
            // 
            this.dgv_vipuser.AutoGenerateColumns = false;
            this.dgv_vipuser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_vipuser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vipuseridDataGridViewTextBoxColumn,
            this.vipusernameDataGridViewTextBoxColumn,
            this.user_mail,
            this.vipuserdatestartDataGridViewTextBoxColumn});
            this.dgv_vipuser.DataSource = this.vipUserBindingSource;
            this.dgv_vipuser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_vipuser.Location = new System.Drawing.Point(0, 25);
            this.dgv_vipuser.Name = "dgv_vipuser";
            this.dgv_vipuser.Size = new System.Drawing.Size(800, 425);
            this.dgv_vipuser.TabIndex = 1;
            // 
            // vipUserBindingSource
            // 
            this.vipUserBindingSource.DataSource = typeof(InformationSystems.NHibernate.Entites.VipUser);
            // 
            // vipuseridDataGridViewTextBoxColumn
            // 
            this.vipuseridDataGridViewTextBoxColumn.DataPropertyName = "vip_user_id";
            this.vipuseridDataGridViewTextBoxColumn.HeaderText = "ID vip пользователя";
            this.vipuseridDataGridViewTextBoxColumn.Name = "vipuseridDataGridViewTextBoxColumn";
            // 
            // vipusernameDataGridViewTextBoxColumn
            // 
            this.vipusernameDataGridViewTextBoxColumn.DataPropertyName = "vip_user_name";
            this.vipusernameDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.vipusernameDataGridViewTextBoxColumn.Name = "vipusernameDataGridViewTextBoxColumn";
            // 
            // user_mail
            // 
            this.user_mail.DataPropertyName = "user_mail";
            this.user_mail.HeaderText = "Почта";
            this.user_mail.Name = "user_mail";
            // 
            // vipuserdatestartDataGridViewTextBoxColumn
            // 
            this.vipuserdatestartDataGridViewTextBoxColumn.DataPropertyName = "vip_user_date_start";
            this.vipuserdatestartDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.vipuserdatestartDataGridViewTextBoxColumn.Name = "vipuserdatestartDataGridViewTextBoxColumn";
            // 
            // forVipUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_vipuser);
            this.Controls.Add(this.toolStrip1);
            this.Name = "forVipUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "forVipUser";
            this.Load += new System.EventHandler(this.forVipUser_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vipuser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vipUserBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridView dgv_vipuser;
        private System.Windows.Forms.ToolStripButton tsb_create;
        private System.Windows.Forms.ToolStripButton tsb_change;
        private System.Windows.Forms.ToolStripButton tsb_delete;
        private System.Windows.Forms.ToolStripButton tsb_back;
        private System.Windows.Forms.BindingSource vipUserBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn vipuseridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vipusernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn vipuserdatestartDataGridViewTextBoxColumn;
    }
}