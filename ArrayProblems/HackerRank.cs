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
using System.Activities.Expressions;

public class Result
{
    public static void miniMaxSum(List<int> arr)
    {
        arr.Sort();
        ulong minsum =(ulong) arr[0];
        ulong maxsum = (ulong)arr[4];

        for (int i = 1; i < arr.Count - 1; i++)
        {
            minsum += (ulong) arr[i];
            maxsum += (ulong) arr[i];
        }
        Console.WriteLine("{0} {1}", minsum, maxsum);
    }

    public static string timeConversion(string s)
    {
        StringBuilder time = new StringBuilder();
        string hours = s.Substring(0, 2);
        string am_pm = s.Substring(s.Length - 2, 2);
        if (am_pm == "AM" && hours == "12")
        {
            time.Append("00");
        }
        else if (am_pm == "AM")
        {
            time.Append(hours);
        }
        else if (am_pm == "PM")
        {
            int hrs = Int32.Parse(hours);
            time.Append((hrs + 12).ToString().PadLeft('0'));
        }

        time.Append(s.Substring(2));
        time.Remove(s.Length - 2, 2);
        return time.ToString();
    }


}

