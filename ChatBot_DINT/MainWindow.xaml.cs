using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
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
        Persona usuario;
        public MainWindow()
        {
            chats = new ObservableCollection<Chats>();
            InitializeComponent();
            
            usuario = Persona.Chico;
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
            string chatsString = "";
            foreach(Chats c in chats)
            {
                chatsString = chatsString + c.mensaje.ToString()+ "\n";
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if(saveFileDialog.ShowDialog() == true)
            {
                File.WriteAllText(saveFileDialog.FileName, chatsString);
            }
        }
        private void CommandBindingGuardarConver_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (chats.Count > 0) e.CanExecute = true;
            else e.CanExecute = false;
        }
        private void CommandBindingSalir_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void CommandBindingConfiguracion_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Configuracion conf = new Configuracion();
            conf.Owner = this;
            conf.ResizeMode = ResizeMode.NoResize;
            conf.colorFondo = Properties.Settings.Default.colorFondo;
            conf.colorUsuario = Properties.Settings.Default.colorUsuario;
            conf.colorRobot = Properties.Settings.Default.colorRobot;
            conf.sexoUsuario = Properties.Settings.Default.sexo;
            if(conf.ShowDialog() == true)
            {
                Properties.Settings.Default.colorFondo = conf.colorFondo;
                Properties.Settings.Default.colorUsuario = conf.colorUsuario;
                Properties.Settings.Default.colorRobot = conf.colorRobot;
                Properties.Settings.Default.sexo = conf.sexoUsuario;
            }
        }
        private void CommandBindingComprobarCon_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Conexion correcta", "Comprobar conexion", MessageBoxButton.OK);
        }
        private void CommandBindingEnviar_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            string mensaje = mensajeTextBox.Text;
            chats.Add(new Chats(usuario, mensaje));
            chats.Add(new Chats(Persona.Robot, "Lo siento, estoy muy cansado, luego hablamos"));
            mensajeTextBox.Text = "";
        }
        private void CommandBindingEnviar_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (mensajeTextBox != null && mensajeTextBox.Text != "") e.CanExecute = true;
            else e.CanExecute = false;
        }
    }
}
