using System;
using static _4._1.Class1;

namespace _4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 obj1 = new Class1();
            call_all del_obj_og;
            call_all del_obj1 = new call_all(obj1.get_names);
            call_all del_obj2 = new call_all(obj1.action);
            call_all del_obj3 = new call_all(obj1.find_highest_mark);
            del_obj_og = del_obj1;
            del_obj_og += del_obj2;
            del_obj_og += del_obj3;
            del_obj_og();
        }
    }
}