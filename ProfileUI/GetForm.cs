using ProfileSystem.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProfileUI
{
    /// <summary>
    /// The form provides an interface for getting a list of all employees.
    /// </summary>
    public partial class GetForm : Form
    {
        /// <summary>
        /// Object of the class for creating and sending a request to the server.
        /// </summary>
        GetAllWorkers GetWorkers;

        /// <summary>
        /// When creating a form, a request is sent immediately.
        /// </summary>
        public GetForm()
        {
            InitializeComponent();

            GetWorkers = new GetAllWorkers();
            List<Worker> result = GetWorkers.Get();
            foreach (var x in result)
            {
                dataGridView1.Rows.Add(x.Name, x.FirstName, x.Father, x.BirthDate.ToString()
                                       , x.Adress, x.Otdel, x.About);
            }

        }

        private void GetForm_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Processing of clicking the "update" button.
        /// Sends a repeated request to the server.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.Clear();
                List<Worker> result = GetWorkers.Get();
                if(result.Count == 0)
                {
                    MessageBox.Show("Newtwork error or no data", "", MessageBoxButtons.OK);
                }
                else
                {
                    foreach (var x in result)
                    {
                        dataGridView1.Rows.Add(x.Name, x.FirstName, x.Father, x.BirthDate.ToString()
                                               , x.Adress, x.Otdel, x.About);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK);
            }
        }
    }
}
