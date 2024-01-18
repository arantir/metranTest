namespace metranTest
{
    public partial class Form1 : Form
    {
        private Thread trd;
        bool trdWork = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonTestsStart_Click(object sender, EventArgs e)
        {
            if (trdWork)
            {
                buttonTestsStart.Text = "запуск";
                trdWork = false;
                labelStatus.Text = labelTest1Result.Text = labelTest2Result.Text = labelTest3Result.Text = "---";
            }
            else
            {
                buttonTestsStart.Text = "стоп";
                labelStatus.Text = labelTest1Result.Text = labelTest2Result.Text = labelTest3Result.Text = "---";
                trdWork = true;
            }
        }

        //Код потока тестрирования
        private void ThreadTask()
        {
            //Для случайных чисел
            Random rnd = new Random();
            int val;
            while (true)
            {
                //Цикл, который не делает ничего. Нужен чтобы break прерывал его а не бесконечный цикл.
                for (int y = 0; y < 1; y++)
                {
                    //Проверяем нужно ли сейчас делать тестирование. Т.к. поток работает вечно а тестирование
                    //должно быть управляемым, контролируем его переменной trdWork.
                    if (trdWork)
                    {
                        labelStatus.Invoke(() => labelStatus.Text = "Выполнение теста 1");
                        //Задаём время теста
                        val = rnd.Next(1, 4);
                        for (int i = 0; i < val * 10; i++)
                        {
                            //Проверяем нужно ли продолжать тест. Либо продолжаем либо прерываем.
                            if (trdWork)
                            {
                                Thread.Sleep(100);
                            }
                            else
                            {
                                break;
                            }
                        }
                        //Если тест был прерван то и остальные прерываем.
                        if (!trdWork)
                        {
                            break;
                        }
                        //Генерируем переменные
                        Test1Var.var1 = rnd.Next(1, 101);
                        labelTest1Var1.Invoke(() => labelTest1Var1.Text = Test1Var.var1.ToString());
                        //Генерируем результат
                        val = rnd.Next(1, 3);
                        if (val == 1)
                        {
                            labelTest1Result.Invoke(() => labelTest1Result.Text = "Успешно");
                        }
                        else
                        {
                            labelTest1Result.Invoke(() => labelTest1Result.Text = "Ошибка");
                        }

                        labelStatus.Invoke(() => labelStatus.Text = "Выполнение теста 2");
                        //Задаём время теста
                        val = rnd.Next(1, 4);
                        for (int i = 0; i < val * 10; i++)
                        {
                            //Проверяем нужно ли продолжать тест. Либо продолжаем либо прерываем.
                            if (trdWork)
                            {
                                Thread.Sleep(100);
                            }
                            else
                            {
                                break;
                            }
                        }
                        //Если тест был прерван то и остальные прерываем.
                        if (!trdWork)
                        {
                            break;
                        }
                        //Генерируем переменные
                        Test2Var.var1 = rnd.Next(1, 101);
                        labelTest2Var1.Invoke(() => labelTest2Var1.Text = Test2Var.var1.ToString());
                        Test2Var.var2 = (float)rnd.Next(1, 201)/10 - 10;
                        labelTest2Var2.Invoke(() => labelTest2Var2.Text = Test2Var.var2.ToString());
                        //Генерируем результат
                        val = rnd.Next(1, 3);
                        if (val == 1)
                        {
                            labelTest2Result.Invoke(() => labelTest2Result.Text = "Успешно");
                        }
                        else
                        {
                            labelTest2Result.Invoke(() => labelTest2Result.Text = "Ошибка");
                        }

                        labelStatus.Invoke(() => labelStatus.Text = "Выполнение теста 3");
                        //Задаём время теста
                        val = rnd.Next(1, 4);
                        for (int i = 0; i < val * 10; i++)
                        {
                            //Проверяем нужно ли продолжать тест. Либо продолжаем либо прерываем.
                            if (trdWork)
                            {
                                Thread.Sleep(100);
                            }
                            else
                            {
                                break;
                            }
                        }
                        //Если тест был прерван то и остальные прерываем.
                        if (!trdWork)
                        {
                            break;
                        }
                        //Генерируем переменные
                        Test3Var.var1 = rnd.Next(1, 101);
                        labelTest3Var1.Invoke(() => labelTest3Var1.Text = Test3Var.var1.ToString());
                        Test3Var.var2 = (float)rnd.Next(1, 201) / 10 - 10;
                        labelTest3Var2.Invoke(() => labelTest3Var2.Text = Test3Var.var2.ToString());
                        Test3Var.var3 = Test3Var.var3Combinations[rnd.Next(0, Test3Var.var3Combinations.Length)];
                        labelTest3Var3.Invoke(() => labelTest3Var3.Text = Test3Var.var3.ToString());
                        //Генерируем результат
                        val = rnd.Next(1, 3);
                        if (val == 1)
                        {
                            labelTest3Result.Invoke(() => labelTest3Result.Text = "Успешно");
                        }
                        else
                        {
                            labelTest3Result.Invoke(() => labelTest3Result.Text = "Ошибка");
                        }

                        //Завершаем тестирование. Выключаем работу с этим потоком. Выводим всю необходимую информацию.
                        labelStatus.Invoke(() => labelStatus.Text = "---");
                        buttonTestsStart.Invoke(() => buttonTestsStart.Text = "запуск");
                        trdWork = false;
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            trd = new Thread(new ThreadStart(this.ThreadTask));
            trd.IsBackground = true;
            trd.Start();
        }
        private void debugOut(string str)
        {
            MessageBox.Show(
                str,
                " ",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
        }
        private void errorOut(string str)
        {
            MessageBox.Show(
                str,
                " ",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
        }

    }
}