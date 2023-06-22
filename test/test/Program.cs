using System;
using System.Collections.Generic;

class Program
{
    static List<int> Rotate(List<int> inputValue, int InputRotateCount)
    {
        int countArray = inputValue.Count;

        if(InputRotateCount > countArray - 1)
        {
            InputRotateCount %= countArray; 
        }

        List<int> result = inputValue.ToList();

        if(countArray != InputRotateCount)
        {
            for(int i =0 ; i < InputRotateCount; i++) 
            {
                // cara 1
                //int lastIndex = result[countArray - 1];
                //result.RemoveAt(countArray - 1);
                //result.Insert(0, lastIndex);

                // cara 2
                result[i] = inputValue[(countArray + i) - InputRotateCount];

                for (int j = 0; j < countArray - InputRotateCount; j++)
                {
                    result[InputRotateCount + j] = inputValue[j];
                }
            }
            
            return result;
        }
               
        return result;

    }

    static void Main(string[] args)
    {
        Console.WriteLine("input List Array dengan pemisah koma, Contoh 1,2,3,n");
        var input = Console.ReadLine();
        List<int> inputValue = new List<int>(Array.ConvertAll(input!.Split(','), int.Parse));

        Console.WriteLine("input Jumlah Rotasi");
        int InputRotateCount = int.Parse(Console.ReadLine()!);

        List<int> result = Rotate(inputValue, InputRotateCount);

        Console.WriteLine("Result: [" + string.Join(", ", result) + "]");
    }
}
