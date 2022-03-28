using System;

namespace _28mart
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 1; i++)
            {

                string no;
                int studentlimit;

                Console.WriteLine("No deyerini daxil edin:");
                no = Console.ReadLine();
                for (int j = 2; j < 4; j++)
                {
                    while (char.IsUpper(no[0]) == false || char.IsUpper(no[1]) == false || char.IsDigit(no[j]) == false || no.Length > 5)
                    {
                        Console.WriteLine("NO deyerini duzgun daxil edin!!!!");
                        no = Console.ReadLine();
                    }
                }

                Console.WriteLine("Sagird sayini daxil edin :");
                studentlimit = Convert.ToInt32(Console.ReadLine());
                if (studentlimit <= 0 || studentlimit > 20)
                {
                    Console.WriteLine("Sagird sayin duzgun daxil et!!!");
                }
            }
            while (studentlimit <= 0 && studentlimit > 20) ;
            Group group = new Group(no, studentlimit);
        }
        
    }
}