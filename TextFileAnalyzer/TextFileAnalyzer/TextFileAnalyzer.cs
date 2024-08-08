using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TextFileAnalyzer
{
    public class TextFileAnalyzer
    {
        TextReader tr;
        private string _filePath;
        public int SpaceNumber { get; set; } = 0;
        public int LettersNumber { get; set; } = 0;
        public TextFileAnalyzer(string filePath)
        {
            _filePath = filePath;
            calcilateLetter();
            calculateSpaces();
        }

        public void calculateSpaces()
        {
            tr = File.OpenText(_filePath);
            int i = 0;
            while ((i = tr.Read()) != -1)
            {
                if (i == ' ')
                {
                    SpaceNumber++;
                }
            }
            tr.Close();
        }

        public void calcilateLetter()
        {
            tr = File.OpenText(_filePath);
            int i = 0;
            while((i = tr.Read()) != -1)
            {
                if ((i >= 97 && i <= 122) || (i >= 65 && i <= 90))
                {
                    LettersNumber++;
                }
            }
            tr.Close();
        }
    }
}
