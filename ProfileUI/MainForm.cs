using System;
using System.Windows.Forms;

namespace ProfileUI
{
    /// <summary>
    /// A main window. Represents the entire functionality of the app.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Set a default server adress.
        /// Initialize all components.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            ServerAdress.Adress = "http://localhost:44364";
            WebAdress.Text = ServerAdress.Adress;   
        }

        /// <summary>
        /// Method for processing clicks on the "Add" button. Creates and displays a form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                AddForm newWindow = new AddForm();
                newWindow.Show();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// Method for processing clicks on the "Get" button. Creates and displays a form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                GetForm getForm = new GetForm();
                getForm.Show();
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// Method for processing clicks on the "Delete" button. Creates and displays a form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DeleteForm form = new DeleteForm();
                form.Show();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// Method for processing clicks on the "Change" button. Creates and displays a form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                ChangeForm form = new ChangeForm();
                form.Show();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// Method for processing changes to the server address text. 
        /// Changes the value of ServerAdress.Adress
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WebAdress_TextChanged(object sender, EventArgs e)
        {
            ServerAdress.Adress = WebAdress.Text;
        }
    }
}
