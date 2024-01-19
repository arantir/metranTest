using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace metranTest
{
    internal class Some
    {
        Form1 form;
        Random rnd = new Random();
        int val;

        public Some(Form1 form)
        {
            this.form = form;
        }

        //Вывод сообщения
        public void debugOut(string str)
        {
            MessageBox.Show(
                str,
                " ",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
        }
        //Вывод ошибки
        public void errorOut(string str)
        {
            MessageBox.Show(
                str,
                " ",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
        }
        //Очищение надписей
        public void clearLabels()
        {
            form.labelStatus.Text = "---";

            form.labelTest1Result.Text = "---";
            form.labelTest2Result.Text = "---";
            form.labelTest3Result.Text = "---";

            form.labelTest1Var1.Text = "---";
            form.labelTest2Var1.Text = "---";
            form.labelTest2Var2.Text = "---";
            form.labelTest3Var1.Text = "---";
            form.labelTest3Var2.Text = "---";
            form.labelTest3Var3.Text = "---";
        }
        //Очищение переменных
        public void clearVars()
        {
            Test1Var.work = false;
            Test1Var.var1 = 0;

            Test2Var.work = false;
            Test2Var.var1 = 0;
            Test2Var.var2 = 0;

            Test3Var.work = false;
            Test3Var.var1 = 0;
            Test3Var.var2 = 0;
            Test3Var.var3 = "";
        }
        //Случайное число в диапазоне от a до b
        public int rNum(int a, int b)
        {
            //Почему то правая граница всегда не включается, для корректной генерации приходится
            //увеличивать правую границу на 1.
            val = rnd.Next(a, b + 1);
            return val;
        }

        //Создаём папку и файл. Записываем в файл результаты теста.
        public void resultFileCreate(string text)
        {
            string path = form.textBoxPath.Text;
            // Создаём путь, если он ещё не создан.
            if (!Directory.Exists(path)){Directory.CreateDirectory(path);}
            // открываем файл (стираем содержимое файла)
            using (FileStream fileStream = File.Open(path + "\\" + form.textBoxNameProduct.Text + ".txt", FileMode.Create))
            {
                using (StreamWriter output = new StreamWriter(fileStream))
                {
                    // записываем текст в поток
                    output.Write(text);
                }
            }
        }
    }
}
