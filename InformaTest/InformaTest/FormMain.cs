using InformaTest.Resource;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InformaTest
{
    public partial class FormMain : Form
    {
        /// <summary>
        /// Constructor for main Form
        /// </summary>
        public FormMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event Handler for loading Form
        /// </summary>
        /// <param name="sender">raising object</param>
        /// <param name="e">event</param>
        private void FormMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'informaDBDataSet.V_Students' table. You can move, or remove it, as needed.
            this.v_StudentsTableAdapter.Fill(this.informaDBDataSet.V_Students);

        }

        /// <summary>
        /// Event Handler for searching bar
        /// </summary>
        /// <param name="sender">raising object</param>
        /// <param name="e">event</param>
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            vStudentsBindingSource.Filter = "[Name and Surname] Like '%" + textBoxSearch.Text + "%'"; 
        }
    }
}

