using InformaTest.Resource;
using InformaTest.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            var searchedText = textBoxSearch.Text;
            //extracting date operator
            var dateOperator = Validation.ExtractDataOperator(searchedText);
            if (dateOperator != string.Empty)
            {
                //if has a first number has been already set
                if (searchedText.Any(char.IsDigit))
                {
                    try
                    {
                        vStudentsBindingSource.Filter = "[Date of Birth] " + dateOperator + "'" + Validation.AutoFillDate(searchedText.Trim().Replace(dateOperator, "")) + "'";
                    }
                    catch
                    {
                        MessageBox.Show(CONST.INVALID_DATE);
                    }
                }
            }
            else
            {
                vStudentsBindingSource.Filter = "    [Name and Surname] Like '%" + searchedText + "%'"
                                              + " or [School name] Like '%" + searchedText + "%'"
                                              + " or [Country of School] Like '%" + searchedText + "%'";
            }
           
        }
    }
}

