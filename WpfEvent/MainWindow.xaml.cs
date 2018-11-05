using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfEvent
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private FileCheck fileCheckEventSource;
        private bool IsWPFclosed = false;
        private Thread thrd;
        public MainWindow()
        {
            InitializeComponent();
            IsWPFclosed = false;
            fileCheckEventSource = new FileCheck();
            fileCheckEventSource.FileCheckEvent += new FileCheckEventHandler(OnFileChange);
            thrd = new Thread(new ThreadStart(fileCheckEventSource.MonitorFile));
            thrd.Start();
        }
        
        private void OnFileChange(object Sender, EventArgs e)
        {
            if (!IsWPFclosed)
            {
                this.ResultBox.Dispatcher.Invoke(
                new Action(delegate
                {
                    if (fileCheckEventSource.getBool())
                    {
                        this.ResultBox.Items.Add(DateTime.Now.ToString() + ": 目标文件被创建.");
                    }
                    else
                    {
                        this.ResultBox.Items.Add(DateTime.Now.ToString() + ": 目标文件被删除.");
                    }
                }
                    ));
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            IsWPFclosed = true;
        }

        private void TargetButton_ClickF(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Event test success!");
        }

       
    }
}
