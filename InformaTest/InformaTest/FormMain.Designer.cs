using System.Drawing;
using System.Windows.Forms;

namespace InformaTest
{
    partial class FormMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.vStudentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.informaDBDataSet = new InformaTest.InformaDBDataSet();
            this.v_StudentsTableAdapter = new InformaTest.InformaDBDataSetTableAdapters.V_StudentsTableAdapter();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.studentIDCardDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameAndSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schoolNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryOfSchoolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTop = new System.Windows.Forms.Panel();
            this.pictureBoxSearch = new System.Windows.Forms.PictureBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.toolTipSearchBar = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBoxInforma = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.vStudentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.informaDBDataSet)).BeginInit();
            this.tableLayoutPanelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInforma)).BeginInit();
            this.SuspendLayout();
            // 
            // vStudentsBindingSource
            // 
            this.vStudentsBindingSource.DataMember = "V_Students";
            this.vStudentsBindingSource.DataSource = this.informaDBDataSet;
            // 
            // informaDBDataSet
            // 
            this.informaDBDataSet.DataSetName = "InformaDBDataSet";
            this.informaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // v_StudentsTableAdapter
            // 
            this.v_StudentsTableAdapter.ClearBeforeFill = true;
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelMain.Controls.Add(this.dataGridViewStudents, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.panelTop, 0, 0);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 2;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(547, 257);
            this.tableLayoutPanelMain.TabIndex = 5;
            // 
            // dataGridViewStudents
            // 
            this.dataGridViewStudents.AllowUserToAddRows = false;
            this.dataGridViewStudents.AllowUserToDeleteRows = false;
            this.dataGridViewStudents.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dataGridViewStudents.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewStudents.AutoGenerateColumns = false;
            this.dataGridViewStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewStudents.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewStudents.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewStudents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewStudents.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewStudents.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentIDCardDataGridViewTextBoxColumn,
            this.nameAndSurnameDataGridViewTextBoxColumn,
            this.schoolNameDataGridViewTextBoxColumn,
            this.countryOfSchoolDataGridViewTextBoxColumn});
            this.dataGridViewStudents.DataSource = this.vStudentsBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkTurquoise;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewStudents.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewStudents.EnableHeadersVisualStyles = false;
            this.dataGridViewStudents.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewStudents.Location = new System.Drawing.Point(3, 33);
            this.dataGridViewStudents.MultiSelect = false;
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewStudents.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewStudents.RowHeadersVisible = false;
            this.dataGridViewStudents.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewStudents.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewStudents.ShowEditingIcon = false;
            this.dataGridViewStudents.Size = new System.Drawing.Size(541, 221);
            this.dataGridViewStudents.TabIndex = 7;
            // 
            // studentIDCardDataGridViewTextBoxColumn
            // 
            this.studentIDCardDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.studentIDCardDataGridViewTextBoxColumn.DataPropertyName = "Student ID card";
            this.studentIDCardDataGridViewTextBoxColumn.HeaderText = "Student ID card";
            this.studentIDCardDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.studentIDCardDataGridViewTextBoxColumn.Name = "studentIDCardDataGridViewTextBoxColumn";
            this.studentIDCardDataGridViewTextBoxColumn.ReadOnly = true;
            this.studentIDCardDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // nameAndSurnameDataGridViewTextBoxColumn
            // 
            this.nameAndSurnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameAndSurnameDataGridViewTextBoxColumn.DataPropertyName = "Name and Surname";
            this.nameAndSurnameDataGridViewTextBoxColumn.HeaderText = "Name and Surname";
            this.nameAndSurnameDataGridViewTextBoxColumn.MinimumWidth = 130;
            this.nameAndSurnameDataGridViewTextBoxColumn.Name = "nameAndSurnameDataGridViewTextBoxColumn";
            this.nameAndSurnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameAndSurnameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // schoolNameDataGridViewTextBoxColumn
            // 
            this.schoolNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.schoolNameDataGridViewTextBoxColumn.DataPropertyName = "School name";
            this.schoolNameDataGridViewTextBoxColumn.HeaderText = "School name";
            this.schoolNameDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.schoolNameDataGridViewTextBoxColumn.Name = "schoolNameDataGridViewTextBoxColumn";
            this.schoolNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.schoolNameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // countryOfSchoolDataGridViewTextBoxColumn
            // 
            this.countryOfSchoolDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.countryOfSchoolDataGridViewTextBoxColumn.DataPropertyName = "Country of School";
            this.countryOfSchoolDataGridViewTextBoxColumn.HeaderText = "Country of School";
            this.countryOfSchoolDataGridViewTextBoxColumn.MinimumWidth = 120;
            this.countryOfSchoolDataGridViewTextBoxColumn.Name = "countryOfSchoolDataGridViewTextBoxColumn";
            this.countryOfSchoolDataGridViewTextBoxColumn.ReadOnly = true;
            this.countryOfSchoolDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // panelTop
            // 
            this.panelTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelTop.Controls.Add(this.pictureBoxInforma);
            this.panelTop.Controls.Add(this.pictureBoxSearch);
            this.panelTop.Controls.Add(this.textBoxSearch);
            this.panelTop.Location = new System.Drawing.Point(3, 3);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(541, 23);
            this.panelTop.TabIndex = 5;
            this.toolTipSearchBar.SetToolTip(this.panelTop, "Search by: Name, Surname");
            // 
            // pictureBoxSearch
            // 
            this.pictureBoxSearch.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSearch.Image")));
            this.pictureBoxSearch.Location = new System.Drawing.Point(114, 3);
            this.pictureBoxSearch.Name = "pictureBoxSearch";
            this.pictureBoxSearch.Size = new System.Drawing.Size(22, 19);
            this.pictureBoxSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSearch.TabIndex = 5;
            this.pictureBoxSearch.TabStop = false;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(1, 2);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(112, 20);
            this.textBoxSearch.TabIndex = 4;
            this.toolTipSearchBar.SetToolTip(this.textBoxSearch, "Search by: Name, Surname");
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // pictureBoxInforma
            // 
            this.pictureBoxInforma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxInforma.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxInforma.Image")));
            this.pictureBoxInforma.Location = new System.Drawing.Point(406, 0);
            this.pictureBoxInforma.Name = "pictureBoxInforma";
            this.pictureBoxInforma.Size = new System.Drawing.Size(106, 23);
            this.pictureBoxInforma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxInforma.TabIndex = 6;
            this.pictureBoxInforma.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 257);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.Text = "Informa Test";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vStudentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.informaDBDataSet)).EndInit();
            this.tableLayoutPanelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInforma)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private InformaDBDataSet informaDBDataSet;
        private System.Windows.Forms.BindingSource vStudentsBindingSource;
        private InformaDBDataSetTableAdapters.V_StudentsTableAdapter v_StudentsTableAdapter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.DataGridView dataGridViewStudents;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.PictureBox pictureBoxSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDCardDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameAndSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn schoolNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryOfSchoolDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolTip toolTipSearchBar;
        private PictureBox pictureBoxInforma;
    }
}