using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    /// ButtonEvent.xaml 的交互逻辑
    /// </summary>
    public partial class ButtonEvent : UserControl
    {
        public ButtonEvent()
        {
            InitializeComponent();
        }

        /*public static readonly RoutedEvent clickEvent =
            EventManager.RegisterRoutedEvent("ClickF", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(MyUserButton));

        public event RoutedEventHandler ClickF
        {
            add
            {
                AddHandler(clickEvent, value);
            }

            remove
            {
                RemoveHandler(clickEvent, value);
            }
        }

        protected override void OnClick()
        {
            RoutedEventArgs args = new RoutedEventArgs(clickEvent, this);
            RaiseEvent(args);
        }*/

    }
}
