using System;
public class BasicSort
{
    public int[] Sort(int[] arrNumber)
    {
        for (int i = 0; i < arrNumber.Length; i++)
        {
            for (int j = i + 1; j < arrNumber.Length; j++)
            {
                if (arrNumber[i] > arrNumber[j])
                {
                    int temp = arrNumber[i];
                    arrNumber[i] = arrNumber[j];
                    arrNumber[j] = temp;
                }
            }
            foreach (var item in arrNumber)
            {
                Console.Write(item.ToString() + " ");
            }
            Console.WriteLine("");
        }
        return arrNumber;
    }
}
/*
04
34
21
91
01
1 34 21 91 4 
1 4 34 91 21 
1 4 21 91 34 
1 4 21 34 91 
1 4 21 34 91  */