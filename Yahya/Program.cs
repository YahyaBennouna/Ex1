using System;
class Yahya
{
    public static void Main(string[] args)
    {
        int r;
        bool co = false;

        Console.WriteLine("Entrer le nombre ");
        int n = Convert.ToInt32(Console.ReadLine());
        for (int i = 2; i < n; i++)
        {
            r = n % i;
            i++;
            if (r == 0)
            {
                co = true;
            }
        }
        if (co == true)

            Console.WriteLine("votre nombre n est pas premier ");
        else
        {
            Console.WriteLine("votre nombre est  premier ");
        }
    }
}
