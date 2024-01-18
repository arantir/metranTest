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
                buttonTestsStart.Text = "������";
                trdWork = false;
                labelStatus.Text = labelTest1Result.Text = labelTest2Result.Text = labelTest3Result.Text = "---";
            }
            else
            {
                buttonTestsStart.Text = "����";
                labelStatus.Text = labelTest1Result.Text = labelTest2Result.Text = labelTest3Result.Text = "---";
                trdWork = true;
            }
        }

        //��� ������ �������������
        private void ThreadTask()
        {
            //��� ��������� �����
            Random rnd = new Random();
            int val;
            while (true)
            {
                //����, ������� �� ������ ������. ����� ����� break �������� ��� � �� ����������� ����.
                for (int y = 0; y < 1; y++)
                {
                    //��������� ����� �� ������ ������ ������������. �.�. ����� �������� ����� � ������������
                    //������ ���� �����������, ������������ ��� ���������� trdWork.
                    if (trdWork)
                    {
                        labelStatus.Invoke(() => labelStatus.Text = "���������� ����� 1");
                        //����� ����� �����
                        val = rnd.Next(1, 4);
                        for (int i = 0; i < val * 10; i++)
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
                        Test1Var.var1 = rnd.Next(1, 101);
                        labelTest1Var1.Invoke(() => labelTest1Var1.Text = Test1Var.var1.ToString());
                        //���������� ���������
                        val = rnd.Next(1, 3);
                        if (val == 1)
                        {
                            labelTest1Result.Invoke(() => labelTest1Result.Text = "�������");
                        }
                        else
                        {
                            labelTest1Result.Invoke(() => labelTest1Result.Text = "������");
                        }

                        labelStatus.Invoke(() => labelStatus.Text = "���������� ����� 2");
                        //����� ����� �����
                        val = rnd.Next(1, 4);
                        for (int i = 0; i < val * 10; i++)
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
                        Test2Var.var1 = rnd.Next(1, 101);
                        labelTest2Var1.Invoke(() => labelTest2Var1.Text = Test2Var.var1.ToString());
                        Test2Var.var2 = (float)rnd.Next(1, 201)/10 - 10;
                        labelTest2Var2.Invoke(() => labelTest2Var2.Text = Test2Var.var2.ToString());
                        //���������� ���������
                        val = rnd.Next(1, 3);
                        if (val == 1)
                        {
                            labelTest2Result.Invoke(() => labelTest2Result.Text = "�������");
                        }
                        else
                        {
                            labelTest2Result.Invoke(() => labelTest2Result.Text = "������");
                        }

                        labelStatus.Invoke(() => labelStatus.Text = "���������� ����� 3");
                        //����� ����� �����
                        val = rnd.Next(1, 4);
                        for (int i = 0; i < val * 10; i++)
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
                        Test3Var.var1 = rnd.Next(1, 101);
                        labelTest3Var1.Invoke(() => labelTest3Var1.Text = Test3Var.var1.ToString());
                        Test3Var.var2 = (float)rnd.Next(1, 201) / 10 - 10;
                        labelTest3Var2.Invoke(() => labelTest3Var2.Text = Test3Var.var2.ToString());
                        Test3Var.var3 = Test3Var.var3Combinations[rnd.Next(0, Test3Var.var3Combinations.Length)];
                        labelTest3Var3.Invoke(() => labelTest3Var3.Text = Test3Var.var3.ToString());
                        //���������� ���������
                        val = rnd.Next(1, 3);
                        if (val == 1)
                        {
                            labelTest3Result.Invoke(() => labelTest3Result.Text = "�������");
                        }
                        else
                        {
                            labelTest3Result.Invoke(() => labelTest3Result.Text = "������");
                        }

                        //��������� ������������. ��������� ������ � ���� �������. ������� ��� ����������� ����������.
                        labelStatus.Invoke(() => labelStatus.Text = "---");
                        buttonTestsStart.Invoke(() => buttonTestsStart.Text = "������");
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