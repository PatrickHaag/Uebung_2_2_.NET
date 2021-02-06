using System;

namespace Übung_02_2 // A1
{
    class Program
    {
        static void Main(string[] args)
        {
            ///////////////////////////////////////////////////////////////////////////////
            // create arrays - A2
            string[] daysArr = { "Montag", "Dienstag", "Mittwoch", "Donnerstag", "Freitag", "Samstag", "Sonntag" };
            int[] numbersArr = { 1, 2, 3, 4, 5, 6, 7 };
            string[,] bothArr = new string[7, 2];

            ///////////////////////////////////////////////////////////////////////////////
            // fill 2d Array and print it with for loop - A3 + A4
            int counter = 0;
            for (int i = 0; i < bothArr.GetLength(0); i++)
            {
                for (int j = 0; j < bothArr.GetLength(1); j++)
                {
                    // fill - A3
                    if (j == 0) bothArr[i, j] = Convert.ToString(numbersArr[counter]);
                    else bothArr[i, j] = daysArr[counter];

                    // print - A4
                    Console.Write(bothArr[i, j]);
                    if (j % 2 != 0) Console.Write("\r\n");
                    else Console.Write(" - ");
                }
                if (counter == daysArr.Length - 1) counter = 0;
                else counter++;
            }

            ///////////////////////////////////////////////////////////////////////////////
            // fill 2d Array with foreach loop - A5
            int x = 0, y = 0;
            foreach (var number in numbersArr)
            {
                bothArr[x, y] = Convert.ToString(number);
                y++;
                bothArr[x, y] = daysArr[x];
                y = 0; x++;
            }

            ///////////////////////////////////////////////////////////////////////////////
            // print 2d Array with foreach loop - A6
            Console.WriteLine("");
            bool beginning = true;
            foreach (var item in bothArr)
            {
                Console.Write(item);
                if (beginning == true)
                {
                    Console.Write(" - ");
                    beginning = false;
                }
                else
                {
                    Console.Write("\r\n");
                    beginning = true;

                }
            }

            ///////////////////////////////////////////////////////////////////////////////
            // copy 2d Arr in zielArray with copy method and print it - A7
            Console.WriteLine("");
            string[,] zielArray = new string[7, 2];

            // Copy
            Array.Copy(bothArr, 0, zielArray, 0, bothArr.GetLength(0) * bothArr.GetLength(1));

            // print
            for (int i = 0; i < zielArray.GetLength(0); i++)
            {
                for (int j = 0; j < zielArray.GetLength(1); j++)
                {
                    Console.Write(zielArray[i, j]);
                    if (j % 2 != 0) Console.Write("\r\n");
                    else Console.Write(" - ");
                }
            }

            // freeze console
            Console.ReadLine();
        }
    }
}
