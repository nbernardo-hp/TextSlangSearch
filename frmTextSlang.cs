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
    public partial class frmTextSlang : Form
    {
        Slang slangSearch = new Slang();
        public frmTextSlang()
        {
            InitializeComponent();
        }

        //Closes the application
        private void tsmExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Verify if the user wants to close the application or not
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you wish to exit the program?", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        //Shows the about form
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout showAbout = new frmAbout();
            showAbout.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int index = -1;
            try
            {
                /*Search for the text slang based on whether the abbreviation or meaning radio button is 
                 *selected.  If the text slang term is not found the program searches for the abbrevations
                 *or meanings that include the string provided.*/
                if(radAbbreviation.Checked)
                {
                    index = slangSearch.searchAbbreviation(txtSearch.Text.ToLower());
                    if (index >= 0)
                    {
                        displaySlangInformation(index);
                    } else //if no abbreviation match is found prevent the panel from showing and search for similar phrases
                    {
                        pnlShowInformation.Visible = false;
                        List<SimilarSlang> similar = new List<SimilarSlang>();
                        similar = slangSearch.findSimilar(txtSearch.Text.ToLower(), true);
                        if(similar.Count > 0) //call the selectSimilarSlang method if items have been added to the list
                        {
                            index = selectSimilarSlang(similar);
                            if(index >= 0) { displaySlangInformation(index); }
                        }
                    }
                } else //Searches by meaning using the same functionality as searching by abbreviation
                {
                    index = slangSearch.searchMeaning(txtSearch.Text.ToLower());
                    if(index >= 0)
                    {
                        displaySlangInformation(index);
                    }
                    else //if no meaning match is found prevent the panel from showing and search for similar phrases
                    {
                        pnlShowInformation.Visible = false;
                        List<SimilarSlang> similar = new List<SimilarSlang>();
                        similar = slangSearch.findSimilar(txtSearch.Text.ToLower(), false);
                        if (similar.Count > 0) //call the selectSimilarSlang method if items have been added to the list
                        {
                            index = selectSimilarSlang(similar);
                            if (index >= 0) { displaySlangInformation(index); }
                        }
                    }
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } finally
            { //Determine which concatenated message to display if no term is returned
                if (index == -1)
                {
                    string radButtonSelected = "abbreviation";
                    if(radMeaning.Checked) { radButtonSelected = "meaning"; }
                    MessageBox.Show("Invalid Entry: No " + radButtonSelected + " found", "None Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        /*Displays the searched for text slang information in the panel.  Makes the panel visible
         *so the information can be viewed*/
        private void displaySlangInformation(int index)
        {
            lblAbbreviation.Text = slangSearch.getSlangAbbreviation(index);
            lblMeaning.Text = slangSearch.getSlangMeaning(index);
            pnlShowInformation.Visible = true;
        }

        /*Creates a new frmSimilar object and displays the items from the List object in the
         *DataGridView.  If the DialogResult from the form comes back as OK call frmSimilar's
         *public getIndex() function to select the appropriate text slang term.*/
        private int selectSimilarSlang(List<SimilarSlang> similar)
        {
            int index = -1;
            frmSimilar newSimilarSlangForm = new frmSimilar(similar);
            if(newSimilarSlangForm.ShowDialog() == DialogResult.OK)
            {
                return newSimilarSlangForm.getIndex();
            }
            return index;
        }

        //Used to show the phrase list for testing and demonstration purposes
        private void tsmPhraseList_Click(object sender, EventArgs e)
        {
            frmPhraseList showPhraseList = new frmPhraseList(slangSearch.getAbbreviationList(), slangSearch.getMeaningList());
            showPhraseList.Show();
        }
    }
}
