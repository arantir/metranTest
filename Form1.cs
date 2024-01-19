namespace metranTest
{
    public partial class Form1 : Form
    {
        private Thread trd;
        private Some s;
        bool trdWork = false;
        public Form1()
        {
            InitializeComponent();
        }

        //Кнопка запуск/стоп
        private void buttonTestsStart_Click(object sender, EventArgs e)
        {
            /*
            string str = "";
            for (int i = 0; i < 100; i++)
            {
                str += s.rNum(0, Test3Var.var3Combinations.Length - 1) + ";";
            }
            s.debugOut(str);
            */
            string nameProduct = textBoxNameProduct.Text;
            if (nameProduct == "")
            {
                s.debugOut("Идентификатор изделия не может быть пустым");
            }
            else
            {
                if (trdWork)
                {
                    textBoxNameProduct.Enabled = true;
                    buttonTestsStart.Text = "запуск";
                    trdWork = false;
                    labelStatus.Text = "---";
                }
                else
                {
                    textBoxNameProduct.Enabled = false;
                    buttonTestsStart.Text = "стоп";
                    s.clearLabels();
                    s.clearVars();
                    //Выясняем какой тест нужно запустить
                    switch (comboBoxTests.SelectedIndex)
                    {
                        case 0:
                            Test1Var.work = true;
                            break;
                        case 1:
                            Test2Var.work = true;
                            break;
                        case 2:
                            Test3Var.work = true;
                            break;
                        default:
                            break;
                    }
                    trdWork = true;
                }
            }
        }

        //Код потока тестрирования
        private void ThreadTask()
        {
            while (true)
            {
                //Цикл, который не делает ничего. Нужен чтобы break прерывал его а не бесконечный цикл.
                for (int y = 0; y < 1; y++)
                {
                    //Проверяем нужно ли сейчас делать тестирование. Т.к. поток работает вечно а тестирование
                    //должно быть управляемым, контролируем его переменной trdWork.
                    if (trdWork)
                    {
                        if (Test1Var.work)
                        {
                            labelStatus.Invoke(() => labelStatus.Text = "Выполнение теста 1");
                            //Задаём время теста
                            for (int i = 0; i < s.rNum(1, 3) * 10; i++)
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
                            Test1Var.var1 = s.rNum(1, 100);
                            labelTest1Var1.Invoke(() => labelTest1Var1.Text = Test1Var.var1.ToString());
                            //Генерируем результат
                            if (s.rNum(1, 2) == 1)
                            {
                                Test1Var.success = true;
                                labelTest1Result.Invoke(() => labelTest1Result.Text = "Успешно");
                            }
                            else
                            {
                                Test1Var.success = false;
                                Test1Var.error = Test1Var.errCombinations[s.rNum(0, Test1Var.errCombinations.Length - 1)];
                                labelTest1Result.Invoke(() => labelTest1Result.Text = "Ошибка(" + Test1Var.error + ")");
                            }
                            //Выводим результат
                            s.resultFileCreate(Test1Var.textToFile());
                            Test1Var.work = false;
                        }

                        if (Test2Var.work)
                        {
                            labelStatus.Invoke(() => labelStatus.Text = "Выполнение теста 2");
                            //Задаём время теста
                            for (int i = 0; i < s.rNum(1, 3) * 10; i++)
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
                            Test2Var.var1 = s.rNum(1, 100);
                            labelTest2Var1.Invoke(() => labelTest2Var1.Text = Test2Var.var1.ToString());
                            Test2Var.var2 = (float)s.rNum(1, 200) / 10 - 10;
                            labelTest2Var2.Invoke(() => labelTest2Var2.Text = Test2Var.var2.ToString());
                            //Генерируем результат
                            if (s.rNum(1, 2) == 1)
                            {
                                Test2Var.success = true;
                                labelTest2Result.Invoke(() => labelTest2Result.Text = "Успешно");
                            }
                            else
                            {
                                Test2Var.success = false;
                                Test2Var.error = Test2Var.errCombinations[s.rNum(0, Test2Var.errCombinations.Length - 1)];
                                labelTest2Result.Invoke(() => labelTest2Result.Text = "Ошибка(" + Test2Var.error + ")");
                            }
                            //Выводим результат
                            s.resultFileCreate(Test2Var.textToFile());
                            Test2Var.work = false;
                        }

                        if (Test3Var.work)
                        {
                            labelStatus.Invoke(() => labelStatus.Text = "Выполнение теста 3");
                            //Задаём время теста
                            for (int i = 0; i < s.rNum(1, 3) * 10; i++)
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
                            Test3Var.var1 = s.rNum(1, 100);
                            labelTest3Var1.Invoke(() => labelTest3Var1.Text = Test3Var.var1.ToString());
                            Test3Var.var2 = (float)s.rNum(1, 200) / 10 - 10;
                            labelTest3Var2.Invoke(() => labelTest3Var2.Text = Test3Var.var2.ToString());
                            Test3Var.var3 = Test3Var.var3Combinations[s.rNum(0, Test3Var.var3Combinations.Length - 1)];
                            labelTest3Var3.Invoke(() => labelTest3Var3.Text = Test3Var.var3.ToString());
                            //Генерируем результат
                            if (s.rNum(1, 2) == 1)
                            {
                                Test3Var.success = true;
                                labelTest3Result.Invoke(() => labelTest3Result.Text = "Успешно");
                            }
                            else
                            {
                                Test3Var.success = false;
                                Test3Var.error = Test3Var.errCombinations[s.rNum(0, Test3Var.errCombinations.Length - 1)];
                                labelTest3Result.Invoke(() => labelTest3Result.Text = "Ошибка(" + Test3Var.error + ")");
                            }
                            //Выводим результат
                            s.resultFileCreate(Test3Var.textToFile());
                            Test3Var.work = false;
                        }

                        //Завершаем тестирование. Выключаем работу с этим потоком. Выводим всю необходимую информацию.
                        textBoxNameProduct.Invoke(() => textBoxNameProduct.Enabled = true);
                        labelStatus.Invoke(() => labelStatus.Text = "---");
                        buttonTestsStart.Invoke(() => buttonTestsStart.Text = "запуск");
                        trdWork = false;
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxTests.SelectedIndex = 0;
            s = new Some(this);
            trd = new Thread(new ThreadStart(this.ThreadTask));
            trd.IsBackground = true;
            trd.Start();
        }
    }
}