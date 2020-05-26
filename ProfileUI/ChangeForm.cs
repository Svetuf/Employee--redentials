using System;
using System.Windows.Forms;

namespace ProfileUI
{
    /// <summary>
    /// The form provides an interface for change a employee.
    /// </summary>
    public partial class ChangeForm : Form
    {
        /// <summary>
        /// To send API request.
        /// </summary>
        PutWorker put;

        /// <summary>
        /// Constructor.
        /// </summary>
        public ChangeForm()
        {
            InitializeComponent();
            put = new PutWorker();
        }

        /// <summary>
        /// Retrieves values from text boxes and sends 
        /// a change request for this employee to the server.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (put.Put(NameTextBox.Text, FirstNameTextBox.Text, FatherTextBox.Text,
                             dateTimePicker1.Value, AdressTextBox.Text, OtdelTextBox.Text, AboutTextBox.Text))
                {
                    MessageBox.Show("Запись успешно изменена", "Информация", MessageBoxButtons.OK);
                    Close();
                }
                else
                {
                    MessageBox.Show("Network error", "Error", MessageBoxButtons.OK);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }
    }
}
