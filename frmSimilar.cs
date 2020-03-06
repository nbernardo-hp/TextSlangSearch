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
    public partial class frmSimilar : Form
    {
        public frmSimilar()
        {
            InitializeComponent();
        }

        //Constructor that sets the DataGridView to the items in the similarAbbreviation and similarMeaning list
        public frmSimilar(List<SimilarSlang> similar)
        {
            InitializeComponent();

            dgvSimilar.Columns.Add("Index", "Index");
            dgvSimilar.Columns[0].Visible = false;
            dgvSimilar.Columns.Add("Abbreviation", "Abbreviation");
            dgvSimilar.Columns.Add("Meaning", "Meaning");
            foreach(var item in similar)
            {
                dgvSimilar.Rows.Add(item.getIndex(), item.getAbbreviation(), item.getMeaning());
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public int getIndex()
        {
            return Convert.ToInt32(dgvSimilar.SelectedRows[0].Cells[0].Value);
        }
        
        private void dgvSimilar_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnOK.PerformClick();
        }
    }
}
