namespace StockPortfolio
{
    partial class frmMain
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.currentHoldingsQueryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockdata = new StockPortfolio.stockdata();
            this.dividendsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.capitalReturnsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSummary = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabOrders = new System.Windows.Forms.TabPage();
            this.ordersDataGridView = new System.Windows.Forms.DataGridView();
            this.orderTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabDividends = new System.Windows.Forms.TabPage();
            this.dividendsDataGridView = new System.Windows.Forms.DataGridView();
            this.ordersTableAdapter = new StockPortfolio.stockdataTableAdapters.OrdersTableAdapter();
            this.tableAdapterManager = new StockPortfolio.stockdataTableAdapters.TableAdapterManager();
            this.currentUnitPricesTableAdapter = new StockPortfolio.stockdataTableAdapters.CurrentUnitPricesTableAdapter();
            this.dividendsTableAdapter = new StockPortfolio.stockdataTableAdapters.DividendsTableAdapter();
            this.orderTypesTableAdapter = new StockPortfolio.stockdataTableAdapters.OrderTypesTableAdapter();
            this.capital_ReturnsTableAdapter = new StockPortfolio.stockdataTableAdapters.Capital_ReturnsTableAdapter();
            this.current_Holdings_QueryTableAdapter = new StockPortfolio.stockdataTableAdapters.Current_Holdings_QueryTableAdapter();
            this.currentUnitPricesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.currentHoldingsQueryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockdata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dividendsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.capitalReturnsBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabSummary.SuspendLayout();
            this.tabOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            this.tabDividends.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dividendsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentUnitPricesBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // currentHoldingsQueryBindingSource
            // 
            this.currentHoldingsQueryBindingSource.DataMember = "Current Holdings Query";
            this.currentHoldingsQueryBindingSource.DataSource = this.stockdata;
            // 
            // stockdata
            // 
            this.stockdata.DataSetName = "stockdataHoldings";
            this.stockdata.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dividendsBindingSource
            // 
            this.dividendsBindingSource.DataMember = "Dividends";
            this.dividendsBindingSource.DataSource = this.stockdata;
            // 
            // capitalReturnsBindingSource
            // 
            this.capitalReturnsBindingSource.DataMember = "Capital Returns";
            this.capitalReturnsBindingSource.DataSource = this.stockdata;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabSummary);
            this.tabControl1.Controls.Add(this.tabOrders);
            this.tabControl1.Controls.Add(this.tabDividends);
            this.tabControl1.Location = new System.Drawing.Point(12, 36);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(851, 493);
            this.tabControl1.TabIndex = 0;
            // 
            // tabSummary
            // 
            this.tabSummary.Controls.Add(this.reportViewer1);
            this.tabSummary.Location = new System.Drawing.Point(4, 22);
            this.tabSummary.Name = "tabSummary";
            this.tabSummary.Padding = new System.Windows.Forms.Padding(3);
            this.tabSummary.Size = new System.Drawing.Size(843, 467);
            this.tabSummary.TabIndex = 0;
            this.tabSummary.Text = "Summary";
            this.tabSummary.UseVisualStyleBackColor = true;
            this.tabSummary.Enter += new System.EventHandler(this.tabSummary_Enter);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "datasetHoldings";
            reportDataSource1.Value = this.currentHoldingsQueryBindingSource;
            reportDataSource2.Name = "datasetDividends";
            reportDataSource2.Value = this.dividendsBindingSource;
            reportDataSource3.Name = "datasetReturns";
            reportDataSource3.Value = this.capitalReturnsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "StockPortfolio.SummaryReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(6, 6);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ShowToolBar = false;
            this.reportViewer1.Size = new System.Drawing.Size(831, 455);
            this.reportViewer1.TabIndex = 0;
            // 
            // tabOrders
            // 
            this.tabOrders.Controls.Add(this.ordersDataGridView);
            this.tabOrders.Location = new System.Drawing.Point(4, 22);
            this.tabOrders.Name = "tabOrders";
            this.tabOrders.Padding = new System.Windows.Forms.Padding(3);
            this.tabOrders.Size = new System.Drawing.Size(843, 467);
            this.tabOrders.TabIndex = 1;
            this.tabOrders.Text = "Orders";
            this.tabOrders.UseVisualStyleBackColor = true;
            // 
            // ordersDataGridView
            // 
            this.ordersDataGridView.AllowUserToOrderColumns = true;
            this.ordersDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ordersDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ordersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.OrderType,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn7});
            this.ordersDataGridView.DataSource = this.ordersBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ordersDataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.ordersDataGridView.Location = new System.Drawing.Point(6, 6);
            this.ordersDataGridView.Name = "ordersDataGridView";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ordersDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.ordersDataGridView.Size = new System.Drawing.Size(831, 455);
            this.ordersDataGridView.TabIndex = 0;
            this.ordersDataGridView.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.ordersDataGridView_UserAddedRow);
            this.ordersDataGridView.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.ordersDataGridView_UserDeletedRow);
            this.ordersDataGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.ordersDataGridView_UserDeletingRow);
            // 
            // orderTypesBindingSource
            // 
            this.orderTypesBindingSource.DataMember = "OrderTypes";
            this.orderTypesBindingSource.DataSource = this.stockdata;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.stockdata;
            // 
            // tabDividends
            // 
            this.tabDividends.Controls.Add(this.dividendsDataGridView);
            this.tabDividends.Location = new System.Drawing.Point(4, 22);
            this.tabDividends.Name = "tabDividends";
            this.tabDividends.Padding = new System.Windows.Forms.Padding(3);
            this.tabDividends.Size = new System.Drawing.Size(843, 467);
            this.tabDividends.TabIndex = 2;
            this.tabDividends.Text = "Dividends";
            this.tabDividends.UseVisualStyleBackColor = true;
            // 
            // dividendsDataGridView
            // 
            this.dividendsDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dividendsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dividendsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dividendsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.dividendsDataGridView.DataSource = this.dividendsBindingSource;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dividendsDataGridView.DefaultCellStyle = dataGridViewCellStyle11;
            this.dividendsDataGridView.Location = new System.Drawing.Point(6, 3);
            this.dividendsDataGridView.Name = "dividendsDataGridView";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dividendsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dividendsDataGridView.Size = new System.Drawing.Size(831, 458);
            this.dividendsDataGridView.TabIndex = 0;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CurrentUnitPricesTableAdapter = this.currentUnitPricesTableAdapter;
            this.tableAdapterManager.DividendsTableAdapter = this.dividendsTableAdapter;
            this.tableAdapterManager.OrdersTableAdapter = this.ordersTableAdapter;
            this.tableAdapterManager.OrderTypesTableAdapter = this.orderTypesTableAdapter;
            this.tableAdapterManager.UpdateOrder = StockPortfolio.stockdataTableAdapters.TableAdapterManager.UpdateOrderOption.UpdateInsertDelete;
            // 
            // currentUnitPricesTableAdapter
            // 
            this.currentUnitPricesTableAdapter.ClearBeforeFill = true;
            // 
            // dividendsTableAdapter
            // 
            this.dividendsTableAdapter.ClearBeforeFill = true;
            // 
            // orderTypesTableAdapter
            // 
            this.orderTypesTableAdapter.ClearBeforeFill = true;
            // 
            // capital_ReturnsTableAdapter
            // 
            this.capital_ReturnsTableAdapter.ClearBeforeFill = true;
            // 
            // current_Holdings_QueryTableAdapter
            // 
            this.current_Holdings_QueryTableAdapter.ClearBeforeFill = true;
            // 
            // currentUnitPricesBindingSource
            // 
            this.currentUnitPricesBindingSource.DataMember = "CurrentUnitPrices";
            this.currentUnitPricesBindingSource.DataSource = this.stockdata;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Code";
            this.dataGridViewTextBoxColumn6.HeaderText = "Code";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // OrderType
            // 
            this.OrderType.DataPropertyName = "OrderType";
            this.OrderType.DataSource = this.orderTypesBindingSource;
            this.OrderType.DisplayMember = "OrderType";
            this.OrderType.HeaderText = "Order Type";
            this.OrderType.Name = "OrderType";
            this.OrderType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.OrderType.ValueMember = "ID";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "OrderDate";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn4.HeaderText = "Order Date";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Qty";
            this.dataGridViewTextBoxColumn3.HeaderText = "Qty";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PricePerUnit";
            dataGridViewCellStyle3.Format = "C3";
            dataGridViewCellStyle3.NullValue = null;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn5.HeaderText = "Price Per Unit";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Brokerage";
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn7.HeaderText = "Brokerage";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Code";
            this.dataGridViewTextBoxColumn9.HeaderText = "Code";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Amount";
            dataGridViewCellStyle8.Format = "C2";
            dataGridViewCellStyle8.NullValue = null;
            this.dataGridViewTextBoxColumn10.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewTextBoxColumn10.HeaderText = "Amount";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "DividendDate";
            dataGridViewCellStyle9.Format = "d";
            dataGridViewCellStyle9.NullValue = null;
            this.dataGridViewTextBoxColumn11.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewTextBoxColumn11.HeaderText = "DividendDate";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Franking";
            dataGridViewCellStyle10.Format = "p";
            dataGridViewCellStyle10.NullValue = null;
            this.dataGridViewTextBoxColumn12.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewTextBoxColumn12.HeaderText = "Franking";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(883, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.toolStripSave_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 549);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.currentHoldingsQueryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockdata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dividendsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.capitalReturnsBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabSummary.ResumeLayout(false);
            this.tabOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            this.tabDividends.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dividendsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentUnitPricesBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSummary;
        private System.Windows.Forms.TabPage tabOrders;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.TabPage tabDividends;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private stockdata stockdata;
        private System.Windows.Forms.BindingSource currentHoldingsQueryBindingSource;
        private System.Windows.Forms.BindingSource capitalReturnsBindingSource;
        private System.Windows.Forms.BindingSource dividendsBindingSource;
        private System.Windows.Forms.DataGridView ordersDataGridView;
        private System.Windows.Forms.DataGridView dividendsDataGridView;
        private stockdataTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private stockdataTableAdapters.TableAdapterManager tableAdapterManager;
        private stockdataTableAdapters.DividendsTableAdapter dividendsTableAdapter;
        private stockdataTableAdapters.Capital_ReturnsTableAdapter capital_ReturnsTableAdapter;
        private stockdataTableAdapters.Current_Holdings_QueryTableAdapter current_Holdings_QueryTableAdapter;
        private System.Windows.Forms.BindingSource currentUnitPricesBindingSource;
        private stockdataTableAdapters.CurrentUnitPricesTableAdapter currentUnitPricesTableAdapter;
        private System.Windows.Forms.BindingSource orderTypesBindingSource;
        private stockdataTableAdapters.OrderTypesTableAdapter orderTypesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewComboBoxColumn OrderType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

