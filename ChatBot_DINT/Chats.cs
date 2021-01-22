using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBot_DINT
{
    enum Persona
    {
        Chico, Chica, Robot
    }
    class Chats : INotifyPropertyChanged
    {
        private Persona _persona;
        private Persona persona
        {
            get { return this._persona; }
            set
            {
                if(this._persona != value)
                {
                    this._persona = value;
                    this.NotifyPropertyChanged("persona");
                }
            }
        }
        private string _mensaje;
        private string mensaje
        {
            get { return this._mensaje; }
            set
            {
                if(this._mensaje != value)
                {
                    this._mensaje = value;
                    this.NotifyPropertyChanged("mensaje");
                }
            }
        }

        public Chats() { }

        public Chats(Persona persona, string mensaje)
        {
            this.persona = persona;
            this.mensaje = mensaje;
        }



        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
