using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Target_Sistemas
{
    public class RevertString
    {
        public void Revert(string msg) 
        {
        
        char[] chars = new char[msg.Length];
        int j = msg.Length - 1;
            for(var i = 0; i < chars.Length; i++)
            {

                chars[i] = msg[j];
                j--;
            }

            string revertida = new string(chars);
            Console.WriteLine($"String Original: {msg}");
            Console.WriteLine($"String Invertida: {revertida}");
        }

       
    }
}
