using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Target_Sistemas
{
    public class Estados
    {
        public void Porcentagens() 
        {

            double SP = 67836.43;
            double RJ = 36678.66;
            double MG = 29229.88;
            double ES = 27165.48;
            double Outros = 19849.53;
            double total = SP + RJ + MG + ES + Outros;

            double porSP = (SP * 100) / total;
            double porRJ = (RJ * 100) / total;
            double porMG = (MG * 100) / total;
            double porES = (ES * 100) / total;
            double porOutros = (Outros * 100) / total;

            Console.WriteLine($"Porcentagem de SP: {porSP.ToString("N3", new CultureInfo("pt-BR"))}%") ;
            Console.WriteLine($"Porcentagem de RJ: {porRJ.ToString("N3", new CultureInfo("pt-BR"))}%");
            Console.WriteLine($"Porcentagem de MG: {porMG.ToString("N3", new CultureInfo("pt-BR"))}%");
            Console.WriteLine($"Porcentagem de ES: {porES.ToString("N3", new CultureInfo("pt-BR"))}%");
            Console.WriteLine($"Porcentagem de Outros Estados: {porOutros.ToString("N3", new CultureInfo("pt-BR"))}%");
        }
    }
}
