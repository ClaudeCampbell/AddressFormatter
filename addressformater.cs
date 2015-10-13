using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text.RegularExpressions;

namespace Erik_CreditAccelerator.Models
{
    public static class cUtil
    {

        public static String formatAddress(string address) //this method takes an address given in the parser's format and parses it 
        {                                                    //into a address with proper format
            string[] lines = Regex.Split(address, "   ");
            int length = lines.GetLength(0);
            if (length > 3) //for addresses with huge amount of spaces
            {
                string[] pieces = new string[5];
                int k = 0;
                for (int i = 0; i < length; i++)
                {

                    if (lines[i] != "")
                    {
                        pieces[k] = lines[i];
                        k++;
                    }
                }
                string formAdd = "";
                if (pieces[3] == null)
                {
                    formAdd = pieces[0].Trim() + "\n" + pieces[1].Trim() + ", " + pieces[2].Trim();
                }
                else
                {
                    formAdd = pieces[0].Trim() + "\n" + pieces[1].Trim() + "\n" + pieces[2].Trim() + ", " + pieces[3].Trim();
                }
                return formAdd;
            }
            else //for addresses with mostly normal spaces, but one double
            {
                string formAdd = address.Replace("  ", "\n");
                return formAdd;
            }
        }

    }
}