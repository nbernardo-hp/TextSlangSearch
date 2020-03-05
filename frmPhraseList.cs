using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextSlangSearch
{
    public partial class frmPhraseList : Form
    {
        //Default no argument constructor
        public frmPhraseList()
        {
            InitializeComponent();
        }

        //Two argument constructor.  Uses the arguments to call the fillDataGrid method
        public frmPhraseList(string[] abbreviations, string[] meaning)
        {
            InitializeComponent();
            fillDataGrid(abbreviations, meaning);
        }

        //Fills the DataGridView with the information from the arrays
        public void fillDataGrid(string[] abbreviations, string[] meaning)
        {
            dgvPhraseList.Columns.Add("Index", "Index");
            dgvPhraseList.Columns.Add("Abbreviation", "Abbreviation");
            dgvPhraseList.Columns.Add("Meaning", "Meaning");
            dgvPhraseList.Columns[0].Width = 40;
            dgvPhraseList.Columns[1].Width = 80;
            dgvPhraseList.Columns[2].Width = 150;
            for (int i = 0; i < abbreviations.Length; i++)
            {
                dgvPhraseList.Rows.Add(i, abbreviations[i], meaning[i]);
            }
        }

        //Closes the Phrase List form
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
