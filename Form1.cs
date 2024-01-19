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

        //������ ������/����
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
                s.debugOut("������������� ������� �� ����� ���� ������");
            }
            else
            {
                if (trdWork)
                {
                    textBoxNameProduct.Enabled = true;
                    buttonTestsStart.Text = "������";
                    trdWork = false;
                    labelStatus.Text = "---";
                }
                else
                {
                    textBoxNameProduct.Enabled = false;
                    buttonTestsStart.Text = "����";
                    s.clearLabels();
                    s.clearVars();
                    //�������� ����� ���� ����� ���������
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

        //��� ������ �������������
        private void ThreadTask()
        {
            while (true)
            {
                //����, ������� �� ������ ������. ����� ����� break �������� ��� � �� ����������� ����.
                for (int y = 0; y < 1; y++)
                {
                    //��������� ����� �� ������ ������ ������������. �.�. ����� �������� ����� � ������������
                    //������ ���� �����������, ������������ ��� ���������� trdWork.
                    if (trdWork)
                    {
                        if (Test1Var.work)
                        {
                            labelStatus.Invoke(() => labelStatus.Text = "���������� ����� 1");
                            //����� ����� �����
                            for (int i = 0; i < s.rNum(1, 3) * 10; i++)
                            {
                                //��������� ����� �� ���������� ����. ���� ���������� ���� ���������.
                                if (trdWork)
                                {
                                    Thread.Sleep(100);
                                }
                                else
                                {
                                    break;
                                }
                            }
                            //���� ���� ��� ������� �� � ��������� ���������.
                            if (!trdWork)
                            {
                                break;
                            }
                            //���������� ����������
                            Test1Var.var1 = s.rNum(1, 100);
                            labelTest1Var1.Invoke(() => labelTest1Var1.Text = Test1Var.var1.ToString());
                            //���������� ���������
                            if (s.rNum(1, 2) == 1)
                            {
                                Test1Var.success = true;
                                labelTest1Result.Invoke(() => labelTest1Result.Text = "�������");
                            }
                            else
                            {
                                Test1Var.success = false;
                                Test1Var.error = Test1Var.errCombinations[s.rNum(0, Test1Var.errCombinations.Length - 1)];
                                labelTest1Result.Invoke(() => labelTest1Result.Text = "������(" + Test1Var.error + ")");
                            }
                            //������� ���������
                            s.resultFileCreate(Test1Var.textToFile());
                            Test1Var.work = false;
                        }

                        if (Test2Var.work)
                        {
                            labelStatus.Invoke(() => labelStatus.Text = "���������� ����� 2");
                            //����� ����� �����
                            for (int i = 0; i < s.rNum(1, 3) * 10; i++)
                            {
                                //��������� ����� �� ���������� ����. ���� ���������� ���� ���������.
                                if (trdWork)
                                {
                                    Thread.Sleep(100);
                                }
                                else
                                {
                                    break;
                                }
                            }
                            //���� ���� ��� ������� �� � ��������� ���������.
                            if (!trdWork)
                            {
                                break;
                            }
                            //���������� ����������
                            Test2Var.var1 = s.rNum(1, 100);
                            labelTest2Var1.Invoke(() => labelTest2Var1.Text = Test2Var.var1.ToString());
                            Test2Var.var2 = (float)s.rNum(1, 200) / 10 - 10;
                            labelTest2Var2.Invoke(() => labelTest2Var2.Text = Test2Var.var2.ToString());
                            //���������� ���������
                            if (s.rNum(1, 2) == 1)
                            {
                                Test2Var.success = true;
                                labelTest2Result.Invoke(() => labelTest2Result.Text = "�������");
                            }
                            else
                            {
                                Test2Var.success = false;
                                Test2Var.error = Test2Var.errCombinations[s.rNum(0, Test2Var.errCombinations.Length - 1)];
                                labelTest2Result.Invoke(() => labelTest2Result.Text = "������(" + Test2Var.error + ")");
                            }
                            //������� ���������
                            s.resultFileCreate(Test2Var.textToFile());
                            Test2Var.work = false;
                        }

                        if (Test3Var.work)
                        {
                            labelStatus.Invoke(() => labelStatus.Text = "���������� ����� 3");
                            //����� ����� �����
                            for (int i = 0; i < s.rNum(1, 3) * 10; i++)
                            {
                                //��������� ����� �� ���������� ����. ���� ���������� ���� ���������.
                                if (trdWork)
                                {
                                    Thread.Sleep(100);
                                }
                                else
                                {
                                    break;
                                }
                            }
                            //���� ���� ��� ������� �� � ��������� ���������.
                            if (!trdWork)
                            {
                                break;
                            }
                            //���������� ����������
                            Test3Var.var1 = s.rNum(1, 100);
                            labelTest3Var1.Invoke(() => labelTest3Var1.Text = Test3Var.var1.ToString());
                            Test3Var.var2 = (float)s.rNum(1, 200) / 10 - 10;
                            labelTest3Var2.Invoke(() => labelTest3Var2.Text = Test3Var.var2.ToString());
                            Test3Var.var3 = Test3Var.var3Combinations[s.rNum(0, Test3Var.var3Combinations.Length - 1)];
                            labelTest3Var3.Invoke(() => labelTest3Var3.Text = Test3Var.var3.ToString());
                            //���������� ���������
                            if (s.rNum(1, 2) == 1)
                            {
                                Test3Var.success = true;
                                labelTest3Result.Invoke(() => labelTest3Result.Text = "�������");
                            }
                            else
                            {
                                Test3Var.success = false;
                                Test3Var.error = Test3Var.errCombinations[s.rNum(0, Test3Var.errCombinations.Length - 1)];
                                labelTest3Result.Invoke(() => labelTest3Result.Text = "������(" + Test3Var.error + ")");
                            }
                            //������� ���������
                            s.resultFileCreate(Test3Var.textToFile());
                            Test3Var.work = false;
                        }

                        //��������� ������������. ��������� ������ � ���� �������. ������� ��� ����������� ����������.
                        textBoxNameProduct.Invoke(() => textBoxNameProduct.Enabled = true);
                        labelStatus.Invoke(() => labelStatus.Text = "---");
                        buttonTestsStart.Invoke(() => buttonTestsStart.Text = "������");
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