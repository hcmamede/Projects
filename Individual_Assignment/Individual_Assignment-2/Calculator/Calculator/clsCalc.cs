using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Calculator
{
    class clsCalc
    {
        public string getBs(string sDisp)
        {
            string sBs;
            sBs = sDisp.Substring(0, (sDisp.Length - 1));
            return sBs;
        }
        public string getResult(string sDisp)
        {
            var expr = sDisp;
            var result = new DataTable().Compute(expr, null);
            string sResult;
            string sHist;
            
            sResult = result.ToString();
            return sResult;
        }
        public string getBracket(string sDisp)
        {
            string sBracket;
            int iLength;
            
            iLength = sDisp.Length-1;
            sBracket = "(";
            for (int i=0;i< (iLength);i++)
            {
                try
                {
                    if (sDisp.Substring(i, i + 1) == "(")
                    {
                        sBracket = ")";
                    }
                    if (sDisp.Substring(i, i + 1) == ")")
                    {
                        sBracket = "(";
                    }
                }
                catch (Exception e)

                {
                    //sBracket = "(";
                }
            }
            return sBracket;
        }
        public string getSign(string sDisp)
        {
            string sSign;
            string sReturn;
            sSign = sDisp.Substring(0, 1);
            if (sSign == "-")
            {
                sReturn = sDisp.Substring(1, sDisp.Length-1);
                return sReturn;
            }
            else
            {
                sReturn = "-" + sDisp;
                return sReturn;
            }
        }
    }
}
