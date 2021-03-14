/*###########################################
 * Einsendeaufgabe 3.1
 ############################################*/


using System;


namespace Einsendeaufgabe3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int jahresZahl;

            Console.Write("Geben Sie bitte gewünschte Jahreszahl: "); //Please enter the desired year
            jahresZahl = Convert.ToInt32(Console.ReadLine());

            if ((jahresZahl % 4 == 0) && (jahresZahl % 100 != 0))
            {
                Console.WriteLine("Herzlichen glückwunsch das ist ein Schaltjahr.");// Herzlichen glückwunsch das ist ein Schaltjahr

            }
            else if ((jahresZahl % 4 == 0) && (jahresZahl % 100 == 0) && (jahresZahl % 400 == 0))
            {
                Console.WriteLine("Herzlichen glückwunsch das ist ein Schaltjahr."); //Herzlichen glückwunsch das ist ein Schaltjahr
            }
            else
            {
                Console.WriteLine("Leider das ist kein Schaltjahr."); //Unfortunately this is not a leap year
            }
            Console.ReadLine();
        }
    }
}
