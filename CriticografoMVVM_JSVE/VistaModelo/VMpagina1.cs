using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using CriticografoMVVM_JSVE.VistaModelo;
using CriticografoMVVM_JSVE.Vistas;

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
        public void Mostrar()
        {
            var mensaje = new StringBuilder($"{nombre} es");

            if (esHombre || esMujer)
            {
                if (esHombre)
                {
                    BtnComa(mensaje, esAlto, "alto");
                    BtnComa(mensaje, esFeo, "feo");
                    BtnComa(mensaje, esListo, "listo");
                    BtnComa(mensaje, esExtrav, "extravagante");
                    BtnComa(mensaje, esRaro, "raro");
                    BtnComa(mensaje, esGrande, "grande");
                }
                else if (esMujer)
                {
                    BtnComa(mensaje, esAlto, "altita");
                    BtnComa(mensaje, esFeo, "feita");
                    BtnComa(mensaje, esListo, "lista");
                    BtnComa(mensaje, esExtrav, "extravagante");
                    BtnComa(mensaje, esRaro, "rarita");
                    BtnComa(mensaje, esGrande, "grandecita");
                }
            }

            string mensajeString = mensaje.ToString().TrimEnd(' ', ',');

            string[] partes = mensajeString.Split(new string[] { ", " }, StringSplitOptions.None);
            if (partes.Length > 1)
            {
                mensaje = new StringBuilder(string.Join(", ", partes.Take(partes.Length - 1)) + " y " + partes.Last());
            }

            resultado = mensaje.ToString() + ".";
        }

        private void BtnComa(StringBuilder mensaje, bool isChecked, string caracteristica)
        {
            if (isChecked)
            {
                if (mensaje.Length > 0)
                {
                    mensaje.Append(", ");
                }

                mensaje.Append(caracteristica);
            }
        }




        #endregion

        #region COMANDOS
        public ICommand MostrarCommand => new Command(Mostrar);

        #endregion
    }
}
