using System;
using static System.Console;

    class MainApp
    {
        static void Main()
        {
            int[] inputNum = new int[10];
            bool[] isCheck = new bool[43];

            int count = 0;

            for (int i = 0; i < inputNum.Length; i++)
            {
                inputNum[i] = int.Parse(ReadLine()) % 42;
                isCheck[inputNum[i]] = true;
            }

            for (int i = 0; i < isCheck.Length; i++)
            {
                if (isCheck[i]) count++;
            }
            WriteLine(count);
        }
    }