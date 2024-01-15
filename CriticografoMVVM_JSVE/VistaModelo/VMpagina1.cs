using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace CriticografoMVVM_JSVE.VistaModelo
{
    public class VMpagina1 : BaseViewModel
    {
        #region VARIABLES
        private string _nombre;
        private bool _esHombre;
        private bool _esMujer;
        private bool _esAlto;
        private bool _esFeo;
        private bool _esListo;
        private bool _esExtrav;
        private bool _esRaro;
        private bool _esGrande;
        private string _resultado;
        #endregion

        #region CONSTRUCTOR
        public VMpagina1(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion

        #region OBJETOS
        public string nombre
        {
            get { return _nombre; }
            set { SetValue(ref _nombre, value); }
        }
        public bool esHombre
        {
            get { return _esHombre; }
            set { SetValue(ref _esHombre, value); }
        }
        public bool esMujer
        {
            get { return _esMujer; }
            set { SetValue(ref _esMujer, value); }
        }
        public bool esAlto
        {
            get { return _esAlto; }
            set { SetValue(ref _esAlto, value); }
        }
        public bool esFeo
        {
            get { return _esFeo; }
            set { SetValue(ref _esFeo, value); }
        }
        public bool esListo
        {
            get { return _esListo; }
            set { SetValue(ref _esListo, value); }
        } 
        public bool esExtrav
        {
            get { return _esExtrav; }
            set { SetValue(ref _esExtrav, value); }
        }
        public bool esRaro
        {
            get { return _esRaro; }
            set { SetValue(ref _esRaro, value); }
        }
        public bool esGrande
        {
            get { return _esGrande; }
            set { SetValue(ref _esGrande, value); }
        }
        public string resultado
        {
            get { return _resultado; }
            set { SetValue(ref _resultado, value); }
        }
        #endregion

        #region PROCESOS
        public async Task Procesoasync()
        {

        }

        public void Sumar()
        {
            
        }

        #endregion

        #region COMANDOS
        public ICommand Procesoasynccommand => new Command(async () => await Procesoasync());
        public ICommand Suymarcommand => new Command(Sumar);
        #endregion
    }
}
