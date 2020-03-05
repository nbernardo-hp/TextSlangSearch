using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextSlangSearch
{
    public class SimilarSlang
    {
        private int index;
        private string abbreviation;
        private string meaning;
        public SimilarSlang()
        {
            index = 0;
            abbreviation = "NA";
            meaning = "NA";
        }
        public SimilarSlang(int index, string abbreviation, string meaning)
        {
            this.index = index;
            this.abbreviation = abbreviation;
            this.meaning = meaning;
        }

        //Get methods
        public int getIndex() { return index; }
        public string getAbbreviation() { return abbreviation; }
        public string getMeaning() { return meaning; }

        //Set methods
        public void setIndex(int index) {
            try
            {
                this.index = index;
            } catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void setAbbreviation(string abbreviation) { this.abbreviation = abbreviation; }
        public void setMeaning(string meaning) { this.meaning = meaning; }
    }
}
