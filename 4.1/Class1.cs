using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._1
{
    internal class Class1
    {
        private string[] students = new string[5];
        private int[] students_mark = new int[5];
        private char[] g = new char[5];
        private int[] c = new int[5];
        public delegate void call_all();
        public void get_names()
        {
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine("Enter student " + i);
                students[i] = Console.ReadLine();
                Console.WriteLine("Enter student mark : ");
                students_mark[i] = Convert.ToInt32(Console.ReadLine());
                g[i] = students[i][0];
                c[i] = (int)g[i];
            }
        }
        public void action()
        {
            int n = students.Length;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (c[j] > c[j + 1])
                    {
                        // swap temp and arr[i]
                        int itemp = c[j];
                        c[j] = c[j + 1];
                        c[j + 1] = itemp;
                        string temp = students[j];
                        students[j] = students[j + 1];
                        students[j + 1] = temp;
                        int mtemp = students_mark[j];
                        students_mark[j] = students_mark[j + 1];
                        students_mark[j + 1] = mtemp;
                    }
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(students[i]);
                Console.WriteLine(students_mark[i]);
            }
        }
        public void find_highest_mark()
        {
            int maxvalue = students_mark.Max();
            int maxindex = students_mark.ToList().IndexOf(maxvalue);
            Console.WriteLine("highest mark " + students[maxindex]);
        }
    }
}
