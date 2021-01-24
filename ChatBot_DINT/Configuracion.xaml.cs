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
using System.Windows.Shapes;

namespace ChatBot_DINT
{
    /// <summary>
    /// Lógica de interacción para Configuracion.xaml
    /// </summary>
    public partial class Configuracion : Window
    {
        List<string> sexo;
        public string colorUsuario;
        public string colorFondo;
        public string colorRobot;
        public string sexoUsuario;
        public Configuracion()
        {
            InitializeComponent();
            this.DataContext = this;
            sexo = new List<string>() { "Hombre", "Mujer" };
            sexo_ComboBox.ItemsSource = sexo;
            coloresFondo_ComboBox.ItemsSource = typeof(Colors).GetProperties();
            coloresUsuario_ComboBox.ItemsSource = typeof(Colors).GetProperties();
            coloresRobot_ComboBox.ItemsSource = typeof(Colors).GetProperties();
        }
        private void aceptarButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
        private void cancelarButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
