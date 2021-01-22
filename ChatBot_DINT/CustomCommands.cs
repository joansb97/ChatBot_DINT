using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ChatBot_DINT
{
    public static class CustomCommands
    {
        public static readonly RoutedUICommand nuevaConversacion = new RoutedUICommand(
            "nuevaConversacion",
            "nuevaConversacion",
            typeof(CustomCommands),
            new InputGestureCollection
            {
                new KeyGesture(Key.N,ModifierKeys.Control)
            }
            );
        public static readonly RoutedUICommand guardarConversacion = new RoutedUICommand(
            "guardarConversacion",
            "guardarConversacion",
            typeof(CustomCommands),
            new InputGestureCollection
            {
                new KeyGesture(Key.G,ModifierKeys.Control)
            }
            );
        public static readonly RoutedUICommand salir = new RoutedUICommand(
            "salir",
            "salir",
            typeof(CustomCommands),
            new InputGestureCollection
            {
                new KeyGesture(Key.S,ModifierKeys.Control)
            }
            );
        public static readonly RoutedUICommand configuracion = new RoutedUICommand(
            "configuracion",
            "configuracion",
            typeof(CustomCommands),
            new InputGestureCollection
            {
                new KeyGesture(Key.C,ModifierKeys.Control)
            }
            );
        public static readonly RoutedUICommand comprobarConexion = new RoutedUICommand(
            "comprobarConexion",
            "comprobarConexion",
            typeof(CustomCommands),
            new InputGestureCollection
            {
                new KeyGesture(Key.O,ModifierKeys.Control)
            }
            );
        public static readonly RoutedUICommand enviar = new RoutedUICommand(
            "enviar",
            "enviar",
            typeof(CustomCommands),
            new InputGestureCollection
            {
                new KeyGesture(Key.E,ModifierKeys.Control)
            }
            );
    }
}
