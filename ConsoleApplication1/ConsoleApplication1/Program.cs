using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var strArr = new List<string>();

            using (var sr = new StreamReader(@"C:\Users\enera\Desktop\SimpleGlobish\ConsoleApplication1\ConsoleApplication1\New Text Document.txt"))
            {
                var count = 0;
                while (true)
                {
                    if (count == 1501)
                    {
                        break;
                    }
                    count++;
                    strArr.Add(sr.ReadLine());
                }
            }

            using (var sr = new StreamWriter(@"C:\Users\enera\Desktop\SimpleGlobish\ConsoleApplication1\ConsoleApplication1\New Text Document (2).txt"))
            {
                foreach (var item in strArr)
                {
                    var currentSplittedItem = item.Split(' ');
                    var key = currentSplittedItem[0];
                    string value = string.Empty;
                    for (int i = 1; i < currentSplittedItem.Length; i++)
                    {
                        value += currentSplittedItem[i] + " ";
                    }
                    value = value.TrimEnd();

                    sr.WriteLine(string.Format("<item name=\"{0}\">{1}</item>", key, value));
                }
            }
        }
    }
}
