using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_1108
{
    class MinhaString
    {
        string s;
        int i;
        string srt;
        public MinhaString() {}
      
        public MinhaString(string str)
        {
            s = srt;
        }


        public string Substring(int inicio)
        {
            string pedaco = "";
            for (var i = inicio; i < s.Length; i++)
            {
                pedaco += s[i];                          
            }

            return pedaco;
        }

        public string Substring(int inicio, int final)
        {
            string pedaco = "";
            for(int i = inicio; i <= final; i++)
            {
                pedaco += s[i];
            }

            return pedaco;
        }

        public string[] Split(string s)
        {
            string [] partes = new string[10];

            string pedaco = "";
            for (int i = 0; i < s.Length; i++)
            {
               
                //pedaco;
            }

            return partes;
        }

    }
}
