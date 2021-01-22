using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace ChatBot_DINT
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Chats> chats;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void CommandBindingNuevaConver_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            chats.Clear();
        }
        private void CommandBindingNuevaConver_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (chats.Count > 0) e.CanExecute = true;
            else e.CanExecute = false;
        }
        private void CommandBindingGuardarConver_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            
        }
        private void CommandBindingGuardarConver_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (chats.Count > 0) e.CanExecute = true;
            else e.CanExecute = false;
        }
    }
}
