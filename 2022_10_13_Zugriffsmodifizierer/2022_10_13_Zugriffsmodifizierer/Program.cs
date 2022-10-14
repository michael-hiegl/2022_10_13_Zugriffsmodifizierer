//Imports######################################################
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//#############################################################

//Classes######################################################
class Auto
{
    private int Reifen;
    private double Motor;
    private string Türen;

    public void SetReifen(int Reifengröße)
    {
        if (Reifengröße < 15 || Reifengröße > 20)
        {
            Reifen = 0;
        }
        else
        {
            Reifen = Reifengröße;
        }
    }
}
//#############################################################

namespace _2022_10_13_Zugriffsmodifizierer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Code#############################################
            Auto meinAuto = new Auto();

            meinAuto.SetReifen(21);

            Console.WriteLine("Zulässige Reifengröße");
            //#################################################

            Console.WriteLine("Press ENTER to exit...");
            Console.ReadKey();
        }
    }
}
