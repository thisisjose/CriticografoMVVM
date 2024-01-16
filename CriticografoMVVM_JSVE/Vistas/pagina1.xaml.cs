﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using CriticografoMVVM_JSVE.VistaModelo;
using CriticografoMVVM_JSVE.Vistas;
using CriticografoMVVM_JSVE;
using static CriticografoMVVM_JSVE.Vistas.pagina1;


namespace CriticografoMVVM_JSVE.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class pagina1 : ContentPage
    {
        public pagina1()
        {
            InitializeComponent();
            BindingContext = new VMpagina1(Navigation);
        }
    }
}