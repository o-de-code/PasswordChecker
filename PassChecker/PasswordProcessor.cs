using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassChecker
{
    internal class PasswordProcessor
    {
        public PasswordProcessor(string[] dataArray)
        {
            this.dataArray = dataArray;
        }

        private string[] dataArray;

        public int GetValidPasswordsNum()
        {
            int validPasswords = 0;
            
            if(dataArray != null)
            {
                for (int i = 0; i < dataArray.Length; i++)
                {
                    var line = dataArray[i];

                    var decomposed = line.Split(' ');

                    char pattern = decomposed[0][0];

                    var charAmount = decomposed[1].Split('-');
                    
                    var min = Convert.ToInt32(charAmount[0]);
                    var max = 0;
                    if (charAmount.Length > 1)
                    {
                        max = Convert.ToInt32(charAmount[1]);
                    }
                    else
                    {
                        max = min;
                    }
                        
                    var containsPattern = decomposed[2].ToCharArray().Count(x => x == pattern);

                    if (Enumerable.Range(min, max).Contains(containsPattern))
                        validPasswords++;

                }
            }
            

            return validPasswords;
        }
        
    }
}
