using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Target_Sistemas
{
    public class Fibonacci
    {
        
        public void Verifica(int valor)
        {


            int num1 = 0;
            int num2 = 1;
            int aux;
            Boolean boll = false;
            List<int> list = new List<int>();


            for (var i = 0; i < 60; i++)
            {
                aux = num1;
                num1 = num2;
                num2 = aux + num1;
                list.Add(num2);
            }

            list.ForEach(i =>
            {
                if (i == valor) boll = true;
            });

            if (boll) Console.WriteLine("O número pertence a Sequência de Fibonacci");
            else Console.WriteLine("O número não pertence a Sequência");
           
        }
    }
}
