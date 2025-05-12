
/*Практическое задание
Дан трёхмерный массив:
int[,,] mas = {
    { { 1, 2 }, { 3, 4 } },
    { { 4, 5 }, { 6, 7 } },
    { { 7, 8 }, { 9, 10 } },
    { { 10, 11 }, { 12, 13 } }
};
Вывести все элементы в формате:
text
{{{1 , 2} , {3 , 4}} , {{4 , 5} , {6 , 7}} , {{7 , 8}, {9 , 10}} , {{10 , 11} , {12 , 13}}}
*/

using System;

class Program
{
    static void Main()
    {
        int[,,] mas = {
            { { 1, 2 }, { 3, 4 } },
            { { 4, 5 }, { 6, 7 } },
            { { 7, 8 }, { 9, 10 } },
            { { 10, 11 }, { 12, 13 } }
        };

        Console.Write("{");

        int dim0 = mas.GetLength(0);
        int dim1 = mas.GetLength(1);
        int dim2 = mas.GetLength(2);

        for (int i = 0; i < dim0; i++)
        {
            Console.Write("{");

            for (int j = 0; j < dim1; j++)
            {
                Console.Write("{");

                for (int k = 0; k < dim2; k++)
                {
                    Console.Write(mas[i, j, k]);
                    if (k < dim2 - 1)
                        Console.Write(" , ");
                }

                Console.Write("}");

                if (j < dim1 - 1)
                    Console.Write(" , ");
            }

            Console.Write("}");

            if (i < dim0 - 1)
                Console.Write(" , ");
        }

        Console.WriteLine("}");
    }
}

