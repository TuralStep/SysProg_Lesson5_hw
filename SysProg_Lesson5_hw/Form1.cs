using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Reflection;

namespace SysProg_Lesson5_hw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            createdThreads = new();
            waitingThreads = new();
            workingThreads = new();

            upDownCount = upDown_places.Value;
            availableThreadsCount = 3;
            threadNumber = 1;

            _semaphore = new(availableThreadsCount, 10, "semaphore");

            lb_created.DataSource = createdThreads;
            lb_waiting.DataSource = waitingThreads;
            lb_working.DataSource = workingThreads;
        }

        public BindingList<Thread> createdThreads { get; set; }
        public BindingList<Thread> waitingThreads { get; set; }
        public BindingList<Thread> workingThreads { get; set; }
        private Semaphore _semaphore;
        private decimal upDownCount;
        private int availableThreadsCount;
        private int threadNumber;


        private void ShowData()
        {
            lb_created.DataSource = createdThreads;
            lb_waiting.DataSource = waitingThreads;
            lb_working.DataSource = workingThreads;
            lb_created.DisplayMember = "Name";
            lb_waiting.DisplayMember = "Name";
            lb_working.DisplayMember = "Name";
        }


        private void btn_createThread_Click(object sender, EventArgs e)
        {
            var t = new Thread(ThreadSimulation);
            t.Name = "Thread number " + threadNumber++;

            createdThreads.Add(t);
            ShowData();
        }


        private void ThreadSimulation(object? semaphore)
        {
            if (semaphore is Semaphore sema)
            {
                Thread.Sleep(3000);

                if (sema.WaitOne())
                {
                    var t = Thread.CurrentThread;

                    waitingThreads.Remove(t);
                    workingThreads.Add(t);
                    ShowData();

                    availableThreadsCount--;
                    var workTime = Random.Shared.Next(3, 6);

                    while (workTime > 0)
                    {
                        Thread.Sleep(1000);
                        workTime--;
                    }

                    workingThreads.Remove(t);
                    ShowData();
                    availableThreadsCount++;
                    sema.Release();
                }
            }
        }

        private void lb_created_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lb_created.SelectedItem is Thread t)
            {
                createdThreads.Remove(t);
                waitingThreads.Add(t);
                ShowData();

                t.Start(_semaphore);
            }
        }

        private void upDown_places_ValueChanged(object sender, EventArgs e)
        {
            if (sender is NumericUpDown upDown)
            {
                if (upDownCount > upDown.Value)
                {
                    if (availableThreadsCount == 0)
                    {
                        upDown.Value = upDownCount;
                        return;
                    }

                    availableThreadsCount--;
                    _semaphore?.WaitOne();
                }
                else
                {
                    _semaphore?.Release();
                    availableThreadsCount++;
                }

                upDownCount = upDown.Value;
            }
        }
    }
}