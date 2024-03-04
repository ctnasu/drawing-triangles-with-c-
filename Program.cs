using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Üçgenin boyutunu girin: ");
        int boyut = Convert.ToInt32(Console.ReadLine());

        DrawTriangle(boyut);
    }

    static void DrawTriangle(int size)
    {
        for (int i = 1; i <= size; i++)
        {
            // Boşlukları ekleyerek üçgeni ortalamak için
            for (int j = 1; j <= size - i; j++)
            {
                Console.Write(" ");
            }

            // Yıldızları çizmek
            for (int k = 1; k <= 2 * i - 1; k++)
            {
                Console.Write("*");
            }

            Console.WriteLine(); // Bir sonraki satıra geçmek için
        }
    }
}
