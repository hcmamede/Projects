using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Typing
{
    class clsTyping
    {
        public bool getKey(string sKey, int index, int lIndex)
        {

            string sLevel;
            sLevel = getsLine(lIndex);
            string[] sl = getKeyArray(sLevel);// { "A", "S", "D", "F", "G", "H", "J", "K", "L", ";" };
            bool sCor=false;
            if (sl[index] == sKey)
            {
                sCor = true;
            }
            return sCor;
        }

        public string getsLine(int iline)
        {
            string line="";
            string sline = "";
            string[] aline = new string[100];
            

            try
            {
                FileStream aFile = new FileStream("Typing.txt", FileMode.Open);
                StreamReader sr = new StreamReader(aFile);
                //line = sr.ReadLine();
                // Read data in line by line.
                int i = 0;
                while (line != null)
                {
                    // Console.WriteLine(line);
                  // sline = sline + "-" +line;
                    line = sr.ReadLine();
                    aline[i] = line;
                    i=i+1;
                }
                sr.Close();
            }
            catch (IOException e)
            {
                //Console.WriteLine("An IO exception has been thrown!");
                //Console.WriteLine(e.ToString());
                //return;
            }
           // iline = 1;
            sline = aline[iline];
            //sline = (i).ToString();
            return sline;
        }

        public string[] getKeyArray(string sLevel)
        {

            //string sLevel;
            //sLevel = test.getsLine(0);
            string[] letters = sLevel.Split('-');
            //txttest.Text = letters[0];
            string[] sl = { "A", "S", "D", "F", "G", "H", "J", "K", "L", ";" };
            //int i = 0;
            for (int i=0; i<10;i++)
            {
                sl[i] = (letters[i]).ToUpper();
                //i++;
            }
            return sl;
        }
    }
}
