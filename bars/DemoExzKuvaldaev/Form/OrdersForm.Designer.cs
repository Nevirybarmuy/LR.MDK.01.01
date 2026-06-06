namespace DemoExzKuvaldaev
{
    partial class OrdersForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnViewItems;
        private System.Windows.Forms.Button btnUpdateStatus;
        private System.Windows.Forms.Button btnHideItems;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnViewItems = new System.Windows.Forms.Button();
            this.btnUpdateStatus = new System.Windows.Forms.Button();
            this.btnHideItems = new System.Windows.Forms.Button();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer.Location = new System.Drawing.Point(9, 41);
            this.splitContainer.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.dgvOrders);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.label1);
            this.splitContainer.Panel2.Controls.Add(this.dgvItems);
            this.splitContainer.Panel2Collapsed = true;
            this.splitContainer.Size = new System.Drawing.Size(645, 366);
            this.splitContainer.SplitterDistance = 250;
            this.splitContainer.SplitterWidth = 3;
            this.splitContainer.TabIndex = 0;
            // 
            // dgvOrders
            // 
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.AllowUserToDeleteRows = false;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrders.Location = new System.Drawing.Point(0, 0);
            this.dgvOrders.Margin = new System.Windows.Forms.Padding(2);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.RowHeadersWidth = 51;
            this.dgvOrders.RowTemplate.Height = 24;
            this.dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrders.Size = new System.Drawing.Size(645, 366);
            this.dgvOrders.TabIndex = 0;
            this.dgvOrders.SelectionChanged += new System.EventHandler(this.dgvOrders_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Состав заказа:";
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItems.Location = new System.Drawing.Point(0, 0);
            this.dgvItems.Margin = new System.Windows.Forms.Padding(2);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.RowHeadersWidth = 51;
            this.dgvItems.RowTemplate.Height = 24;
            this.dgvItems.Size = new System.Drawing.Size(150, 46);
            this.dgvItems.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnRefresh.Location = new System.Drawing.Point(9, 10);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 24);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Обновить";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnViewItems
            // 
            this.btnViewItems.BackColor = System.Drawing.Color.Blue;
            this.btnViewItems.Location = new System.Drawing.Point(88, 10);
            this.btnViewItems.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewItems.Name = "btnViewItems";
            this.btnViewItems.Size = new System.Drawing.Size(112, 24);
            this.btnViewItems.TabIndex = 2;
            this.btnViewItems.Text = "Показать состав";
            this.btnViewItems.UseVisualStyleBackColor = false;
            this.btnViewItems.Click += new System.EventHandler(this.btnViewItems_Click);
            // 
            // btnUpdateStatus
            // 
            this.btnUpdateStatus.BackColor = System.Drawing.Color.PeachPuff;
            this.btnUpdateStatus.Location = new System.Drawing.Point(300, 10);
            this.btnUpdateStatus.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateStatus.Name = "btnUpdateStatus";
            this.btnUpdateStatus.Size = new System.Drawing.Size(90, 24);
            this.btnUpdateStatus.TabIndex = 3;
            this.btnUpdateStatus.Text = "Изменить статус";
            this.btnUpdateStatus.UseVisualStyleBackColor = false;
            this.btnUpdateStatus.Click += new System.EventHandler(this.btnUpdateStatus_Click);
            // 
            // btnHideItems
            // 
            this.btnHideItems.BackColor = System.Drawing.Color.Red;
            this.btnHideItems.Location = new System.Drawing.Point(206, 10);
            this.btnHideItems.Margin = new System.Windows.Forms.Padding(2);
            this.btnHideItems.Name = "btnHideItems";
            this.btnHideItems.Size = new System.Drawing.Size(90, 24);
            this.btnHideItems.TabIndex = 7;
            this.btnHideItems.Text = "Скрыть состав";
            this.btnHideItems.UseVisualStyleBackColor = false;
            this.btnHideItems.Click += new System.EventHandler(this.btnHideItems_Click);
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Items.AddRange(new object[] {
            "Новый",
            "В обработке",
            "Завершен",
            "Отменен"});
            this.cmbStatus.Location = new System.Drawing.Point(485, 11);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(2);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(91, 21);
            this.cmbStatus.TabIndex = 4;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(401, 15);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(80, 13);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Новый статус:";
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 415);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.btnHideItems);
            this.Controls.Add(this.btnUpdateStatus);
            this.Controls.Add(this.btnViewItems);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.splitContainer);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "OrdersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Управление заказами";
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}