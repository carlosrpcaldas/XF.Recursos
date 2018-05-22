﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XF.Recursos
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}


        private async void btnListSimples_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Lista.SimplesView());
        }

        private async void btnListClasse_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Lista.ClasseView());
        }

        private async void btnListProduto_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Lista.ProdutoView());
        }

        private async void btnListaCards_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Lista.ListaCards());
        }
        #region Estilo
        private async void btnSimples_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Estilo.SimplesView());
        }
        private async void btnGlobal_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Estilo.GeralView());
        }
        private async void btnDinamico_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Estilo.DinamicoView());
        }
        private async void btnTriggers_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Estilo.TriggersView());
        }
        #endregion
    }
}
