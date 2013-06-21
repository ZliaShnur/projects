using System;

internal class PermutationsOfN
{
    private static void Main()
    {
        int n = 3;
        int[] arr = new int[n];
        for (int i = 1; i <= n; i++) // filling the array with elements. They can be whatever you want
        {
            arr[i-1] = i;
        }
        Permute(0,arr);
    }

    private static void Permute(int index,int[] output)
    {
        if (index==output.Length-1)
        {
            Console.WriteLine(string.Join("",output));
        }
        else
        {
            for (int i = index; i < output.Length; i++)
            {
                int swap = output[index];
                output[index] = output[i];
                output[i] = swap;

                Permute(index + 1, output);

                swap = output[index];
                output[index] = output[i];
                output[i] = swap;                                
            }
        }        
    }
}
