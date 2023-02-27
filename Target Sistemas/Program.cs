// See https://aka.ms/new-console-template for more information


using Target_Sistemas;

public class Example
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Digite um valor do Menu:");
        Console.WriteLine("1-Faturamento");
        Console.WriteLine("2-Porcentagem dos Estados");
        Console.WriteLine("3-Fibonacci");
        Console.WriteLine("4-Reverter String");
        

        string val = Console.ReadLine();

        if(val == "1") 
        { 
        
        Faturamento fat = new Faturamento();
            fat.FaturamentoResults();
        
        }
        if(val == "2") 
        { 
        
            Estados est = new Estados();
            est.Porcentagens();
        
        }
        if(val == "3") 
        {
            Console.WriteLine("Digite um número:");
            int num = Int32.Parse(Console.ReadLine());
            Fibonacci fibonacci= new Fibonacci();
            fibonacci.Verifica(num);
        }
        if(val == "4") 
        {

            Console.WriteLine("Digite a String que quer reverter");
            string s = Console.ReadLine();
            RevertString revert= new RevertString();
            revert.Revert(s);
        
        }
    }
}


