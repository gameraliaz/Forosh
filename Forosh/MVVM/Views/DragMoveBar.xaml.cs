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

namespace Forosh.MVVM.Views
{
    /// <summary>
    /// Interaction logic for DragMoveBar.xaml
    /// </summary>
    public partial class DragMoveBar : UserControl
    {
        public DragMoveBar()
        {
            InitializeComponent();
        }

        private void DragMoveMouseDown(object sender, MouseButtonEventArgs e)
        {
            var myWindow = Window.GetWindow(this);
            myWindow.DragMove();
        }
    }
}
