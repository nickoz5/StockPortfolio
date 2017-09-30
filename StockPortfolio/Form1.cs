using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StockPortfolio
{
    public partial class frmMain : Form
    {
        bool m_bSaveChanges = false;

        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.orderTypesTableAdapter.Fill(this.stockdata.OrderTypes);
            this.ordersTableAdapter.Fill(this.stockdata.Orders);
            this.dividendsTableAdapter.Fill(this.stockdata.Dividends);

            List<string> lstSymbols = new List<string>();

            // update the current unit prices..
            this.currentUnitPricesTableAdapter.DeleteAllRows();
            for (int i = 0; i < stockdata.Orders.Rows.Count; i++)
            {
                DataRow orderRow = stockdata.Orders.Rows[i];
                String symbol = orderRow["Code"].ToString();

                bool found = false;
                foreach (string sym in lstSymbols)
                {
                    if (symbol == sym)
                    {
                        found = true;
                        break;
                    }
                }

                if (!found)
                    lstSymbols.Add(symbol);
            }

            foreach (string sym in lstSymbols)
            {
                // get the price from the StockPrices class..
                StockPrices stockPrices = new StockPrices();
                stockPrices.UpdateSymbol(sym + ".AX");

                // add new row to the unit prices table
                DataRow newUnitPriceRow = stockdata.CurrentUnitPrices.NewRow();
                newUnitPriceRow["Code"] = sym;
                newUnitPriceRow["Price"] = stockPrices.LastPrice;
                stockdata.CurrentUnitPrices.Rows.Add(newUnitPriceRow);
            }
            this.currentUnitPricesTableAdapter.Update(stockdata.CurrentUnitPrices);
            //this.currentUnitPricesTableAdapter.Fill(this.stockdata.CurrentUnitPrices);

            this.capital_ReturnsTableAdapter.Fill(this.stockdata.Capital_Returns);
            this.current_Holdings_QueryTableAdapter.Fill(this.stockdata.Current_Holdings_Query);
            this.currentUnitPricesTableAdapter.Fill(this.stockdata.CurrentUnitPrices);
        }

        private void toolStripSave_Click(object sender, EventArgs e)
        {
            //dividendsTableAdapter.Update(this.stockdata.Dividends);
            tableAdapterManager.UpdateAll(stockdata);
            m_bSaveChanges = false;
        }

        private void toolStripOpen_Click(object sender, EventArgs e)
        {
        }

        private void tabSummary_Enter(object sender, EventArgs e)
        {
            //currentHoldingsQueryBindingSource
            this.capital_ReturnsTableAdapter.Fill(this.stockdata.Capital_Returns);
            this.current_Holdings_QueryTableAdapter.Fill(this.stockdata.Current_Holdings_Query);
            this.reportViewer1.RefreshReport();
        }

        private void dividendsDataGridView_Validating(object sender, CancelEventArgs e)
        {
        }

        private void ordersDataGridView_Validating(object sender, CancelEventArgs e)
        {
        }

        private void ordersDataGridView_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            m_bSaveChanges = true;
        }

        private void ordersDataGridView_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            m_bSaveChanges = true;
        }

        private void ordersDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            m_bSaveChanges = true;
        }
        private void dividendsDataGridView_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            m_bSaveChanges = true;
        }

        private void dividendsDataGridView_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            m_bSaveChanges = true;
        }

        private void dividendsDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            m_bSaveChanges = true;
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (m_bSaveChanges)
            {
                DialogResult iResult = MessageBox.Show("Save changes?", "", MessageBoxButtons.YesNoCancel);
                if (iResult == DialogResult.Cancel)
                    e.Cancel = true;
                if (iResult == DialogResult.Yes)
                    toolStripSave_Click(sender, new EventArgs());
            }
        }

        private void ordersBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dividendsDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you wish to delete the selected row(s)?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
                e.Cancel = true;
        }

        private void ordersDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you wish to delete the selected row(s)?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
                e.Cancel = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
