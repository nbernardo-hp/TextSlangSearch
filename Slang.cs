using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextSlangSearch
{
    class Slang
    {
        private string[] slangAbbreviation = {"b4", "gf", "HOAS", "L8", "MMB", "msg", "MYOB", "NP", "OMG", "OMW", "sec", "SMS", "Sry", "TBC", "TY", "u", "w/", "w/o", "2", "BTW", "NSFW", "thx", "TBR", "IDK", "Ermahgerd", "FTW", "hw", "lolz", "NC", "WDYM", "LOL" };
        private string[] slangMeaning = { "Before", "Girlfriend", "Hold on a second", "Late", "Message me back", "Message", "Mind your own business", "No problem", "Oh my gosh", "On my way", "Second", "Short Message Service", "Sorry", "To be continued", "Thank you", "You", "With", "Without", "To", "By the way", "Not safe for work", "Thanks", "To be rude", "I don't know", "Oh my gosh", "For the win", "Homework", "Laugh out louds", "No comment", "What do you mean?", "Laughing out loud" };
        
        public string getSlangAbbreviation(int index) { return slangAbbreviation[index]; }
        public string getSlangMeaning(int index) { return slangMeaning[index]; }

        /*Searches the abbreviation array to determine if the user input is contained in the array.
         * If it is found, returns the index at which the string was found.  Else returns -1 to
         * indicate the term was not found*/
        public int searchAbbreviation(string userEntry)
        {
            int index = -1;
            for(int i = 0; i < slangAbbreviation.Length; i++)
            {
                if(userEntry.Equals(slangAbbreviation[i].ToLower()))
                {
                    return i;
                }
            }
            return index;
        }

        /*Searches the meaning array to determine if the user input is contained in the array.
         * If it is found, returns the index at which the string was found.  Else returns -1 to
         * indicate the term was not found*/
        public int searchMeaning(string userEntry)
        {
            int index = -1;
            for (int i = 0; i < slangMeaning.Length; i++)
            {
                if (userEntry.Equals(slangMeaning[i].ToLower()))
                {
                    return i;
                }
            }
            return index;
        }

        /*Searches through the arrays if no exact match was found as entries in the arrays.
         *Uses a boolean to determine if the abbreviation or meaning RadioButton was selected.  Adds
         *the similar item to the List object to be returned to the calling function*/
        public List<SimilarSlang> findSimilar(string userEntry, bool abbreviationChecked)
        {
            List<SimilarSlang> similar = new List<SimilarSlang>();
            for(int i = 0; i < slangAbbreviation.Length && i < slangMeaning.Length; i++)
            {
                if (abbreviationChecked == true && slangAbbreviation[i].ToLower().Contains(userEntry))
                {
                    similar.Add(new SimilarSlang(i, slangAbbreviation[i], slangMeaning[i]));
                } else if(abbreviationChecked == false && slangMeaning[i].ToLower().Contains(userEntry))
                {
                    similar.Add(new SimilarSlang(i, slangAbbreviation[i], slangMeaning[i]));
                }
            }
            
            return similar;
        }

        /*Used to get the full list of abbreviations and meanings for the phrase list form.
         *Used only for testing and demonstration purposes*/
        public string[] getAbbreviationList() { return slangAbbreviation; }
        public string[] getMeaningList() { return slangMeaning; }
    }
}
