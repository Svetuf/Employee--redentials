using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace ProfileUI
{
    /// <summary>
    /// The form provides an interface to delete emloyee from databases.
    /// </summary>
    public partial class DeleteForm : Form
    {
        /// <summary>
        /// To send and generate requests to the server.
        /// </summary>
        DeleteWorker delete;

        /// <summary>
        /// Constructor.
        /// </summary>
        public DeleteForm()
        {
            InitializeComponent();
            delete = new DeleteWorker();
        }

        /// <summary>
        /// Retrieves values from text boxes and 
        /// sends the corresponding deletion request to the server.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (delete.Delete(Name.Text, FirstName.Text, Father.Text))
                {
                    MessageBox.Show("Worker deleted", "", MessageBoxButtons.OK);
                    Close();
                }
                else
                {
                    MessageBox.Show("Network error", "", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }
    }
}
