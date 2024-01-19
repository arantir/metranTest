using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metranTest
{
    internal class Test2Var
    {
        public static bool work = false;
        public static int var1;
        public static float var2;
        public static string error = "";
        public static string[] errCombinations = { "хрукий", "твёрдый", "мягкий" };
        public static bool success = false;
        public static string textToFile()
        {
            string res = "";
            res += "Тест 1\n\n";
            if (success)
            {
                res += "результат:\tуспешно\n";
            }
            else
            {
                res += "результат:\tошибка(" + error + ")\n";
            }
            res += "var1 =\t\t" + var1.ToString() + "\n";
            res += "var2 =\t\t" + var2.ToString();
            return res;
        }
    }
}
