using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;

class Solution
{

    // Complete the countingSort function below.
    static int[] countingSort(int[] arr)
    {
        int maxValue = 100;
        int[] countArray = new int[maxValue];

        foreach (var item in arr)
        {
            countArray[item]++;
        }

        return countArray;
    }

    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        int[] result = countingSort(arr);

        Console.WriteLine(string.Join(" ", result));

        Console.ReadLine();

        //textWriter.Flush();
        //textWriter.Close();
    }
}
