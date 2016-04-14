/*-----------------------------------------------------------------------------
* Author: Rayan Al-Hammami
* Date Created: 10/05/2015
* Purpose: This application sets up a test environment for most efficient exception
* handling
----------------------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void accountBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {

                this.Validate();
                this.accountBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.accountsDataSet);
            }
            catch (DBConcurrencyException ex)
            {
                //Show specific exception
                MessageBox.Show("Concurrency Error:" + ex.Message);
                //Refresh data
                this.accountTableAdapter.Fill(this.accountsDataSet.Account);
            }
            catch (Exception ex)
            {
                //Show specific exception
                MessageBox.Show("General Exception:" + ex.Message +
                    " of type " + ex.GetType().ToString());
                //Refresh data
                this.accountTableAdapter.Fill(this.accountsDataSet.Account);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'accountsDataSet.Account' table. You can move, or remove it, as needed.
            accountDataGridView.Sort(this.dataGridViewTextBoxColumn2, ListSortDirection.Ascending);
            this.accountTableAdapter.Fill(this.accountsDataSet.Account);

        }

        private void accountDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("data Error when updating " +
                (e.RowIndex + 1) + " and column" + (e.ColumnIndex + 1));
        }

    }
}
