using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Pascal Üçgeni Ama Aralarda Çizgi Olacak Mesela
/*
input = 4    4x7
- - - 1 - - -
- - 1 - 1 - -
- 1 - 2 - 1 -
1 - 3 - 3 - 1

*/

namespace SonSoruFinalOdevi
{
    public class Program
    {
        static void Main(String[] args)
        {
            Console.Write("Pascal ucgeninin kac satir olacagini giris yapiniz : ");
            int satirSayi = Convert.ToInt32(Console.ReadLine());
            int sutunSayi = satirSayi * 2 - 1;
            int[,] dizi = new int[satirSayi,sutunSayi];

            int sutunSil = satirSayi;
            int sutunSil2 = satirSayi;
            if (satirSayi % 2 == 0) {
                for (int i = 0; i < satirSayi; i++)
                {
                    for (int j = 0; j < sutunSayi; j++)
                    {
                        int sutunBaslangic = sutunSayi - sutunSil;   //210
                        int sutunBitis = sutunSayi - sutunSil2;      //456
                        if (i % 2 == 0)
                        {
                            if (j == sutunSayi - sutunSil)
                            {
                                dizi[i, j] = 1;
                                Console.Write(" " + dizi[i, j] + " ");
                                continue;
                            }
                            else if (j == sutunSayi - sutunSil2)
                            {
                                dizi[i, j] = 1;
                                Console.Write(" " + dizi[i, j] + " ");
                                continue;
                            }
                            else if (i > 1 && j % 2 == 1 && j > sutunBaslangic && j<sutunBitis)
                            {
                                dizi[i, j] = dizi[i-1,j-1] + dizi[i-1,j+1];
                                Console.Write(" " + dizi[i, j] + " ");
                                continue;
                            }
                        }
                        else {
                            if (j == sutunSayi - sutunSil)
                            {
                                dizi[i, j] = 1;
                                Console.Write(" " + dizi[i, j] + " ");
                                continue;
                            }
                            else if (j == sutunSayi - sutunSil2)
                            {
                                dizi[i, j] = 1;
                                Console.Write(" " + dizi[i, j] + " ");
                                continue;
                            }
                            else if (i > 1 && j % 2 == 0 && j > sutunBaslangic && j < sutunBitis)
                            {
                                dizi[i, j] = dizi[i - 1, j - 1] + dizi[i - 1, j + 1];
                                Console.Write(" " + dizi[i, j] + " ");
                                continue;
                            }
                        }
                        Console.Write(" - ");
                    }
                    sutunSil2--;
                    sutunSil++;
                    Console.WriteLine();
                }
            }
            else
            {
                for (int i = 0; i < satirSayi; i++)
                {
                    for (int j = 0; j < sutunSayi; j++)
                    {
                        int sutunBaslangic = sutunSayi - sutunSil;   //210
                        int sutunBitis = sutunSayi - sutunSil2;      //456
                        if (i % 2 == 0)
                        {
                            if (j == sutunSayi - sutunSil)
                            {
                                dizi[i, j] = 1;
                                Console.Write(" " + dizi[i, j] + " ");
                                continue;
                            }
                            else if (j == sutunSayi - sutunSil2)
                            {
                                dizi[i, j] = 1;
                                Console.Write(" " + dizi[i, j] + " ");
                                continue;
                            }
                            else if (i > 1 && j % 2 == 0 && j > sutunBaslangic && j < sutunBitis)
                            {
                                dizi[i, j] = dizi[i - 1, j - 1] + dizi[i - 1, j + 1];
                                Console.Write(" " + dizi[i, j] + " ");
                                continue;
                            }
                        }
                        else
                        {
                            if (j == sutunSayi - sutunSil)
                            {
                                dizi[i, j] = 1;
                                Console.Write(" " + dizi[i, j] + " ");
                                continue;
                            }
                            else if (j == sutunSayi - sutunSil2)
                            {
                                dizi[i, j] = 1;
                                Console.Write(" " + dizi[i, j] + " ");
                                continue;
                            }
                            else if (i > 1 && j % 2 == 1 && j > sutunBaslangic && j < sutunBitis)
                            {
                                dizi[i, j] = dizi[i - 1, j - 1] + dizi[i - 1, j + 1];
                                Console.Write(" " + dizi[i, j] + " ");
                                continue;
                            }
                        }
                        Console.Write(" - ");
                    }
                    sutunSil2--;
                    sutunSil++;
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
        }

        //public static void DiziBastir(int[,] dizi)
        //{
        //    int satirSayi = dizi.GetLength(0);
        //    int sutunSayi = dizi.GetLength(1);
        //    for(int i = 0; i < satirSayi; i++)
        //    {
        //        for (int j = 0; j < sutunSayi; j++)
        //        {
        //            Console.Write(dizi[i, j] + " - ");
        //        }
        //        Console.WriteLine("\n");
        //    }
        //}


    }
}
/*

- - - 1 - - -              3
- - 1 - 1 - -             2 4
- 1 - 2 - 1 -            1 3 5
1 - 3 - 3 - 1           0 2 4 6

*/