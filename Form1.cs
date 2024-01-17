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
            labelTest1Result.Text = labelTest2Result.Text = labelTest3Result.Text = "---";
            buttonTestsStart.Enabled = false;
            trdWork = true;
        }

        private void ThreadTask()
        {
            // Code that is executing when the thread is aborted.  
            Random rnd = new Random();
            int val;
            while (true)
            {
                if (trdWork)
                {

                    labelStatus.Invoke(() => labelStatus.Text = "Выполнение теста 1");
                    val = rnd.Next(1, 3);
                    Thread.Sleep(val * 1000);
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
                    val = rnd.Next(1, 3);
                    Thread.Sleep(val * 1000);
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
                    val = rnd.Next(1, 3);
                    Thread.Sleep(val * 1000);
                    val = rnd.Next(1, 3);
                    if (val == 1)
                    {
                        labelTest3Result.Invoke(() => labelTest3Result.Text = "Успешно");
                    }
                    else
                    {
                        labelTest3Result.Invoke(() => labelTest3Result.Text = "Ошибка");
                    }

                    labelStatus.Invoke(() => labelStatus.Text = "---");
                    buttonTestsStart.Invoke(() => buttonTestsStart.Enabled = true);
                    trdWork = false;
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