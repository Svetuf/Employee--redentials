using System;
using System.Windows.Forms;

namespace ProfileUI
{
    /// <summary>
    /// The form provides an interface for add a new employee.
    /// </summary>
    public partial class AddForm : Form
    {
        /// <summary>
        /// To send API request.
        /// </summary>
        AddNewWorker addWorker;

        /// <summary>
        /// Constructor.
        /// </summary>
        public AddForm()
        {
            InitializeComponent();
            addWorker = new AddNewWorker();
        }

        /// <summary>
        /// Retrieves values from text boxes and sends 
        /// a create request for this employee to the server.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_ClickAsync(object sender, EventArgs e)
        {
            try
            {
                if (addWorker.Add(NameTextBox.Text, FirstNameTextBox.Text, FatherTextBox.Text,
                              dateTimePicker1.Value, AdressTextBox.Text, OtdelTextBox.Text, AboutTextBox.Text))
                {
                    MessageBox.Show("Запись успешно добавлена", "Информация", MessageBoxButtons.OK);
                    Close();
                }
                else
                {
                    MessageBox.Show("Network error", "Error", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
