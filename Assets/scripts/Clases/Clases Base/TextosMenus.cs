﻿using System;
using System.Collections.Generic;
using System.Collections;
using Oscuridad.Enumeraciones;

namespace Oscuridad.Clases
{
	/// <summary>
	/// Clase base para la Traduccion de los textos de los menus
	/// </summary>
	[System.Serializable]
	public class TextosMenus
	{
		private string btComenzar;
		public string BtComenzar 
		{
			get { return btComenzar; }
			set { btComenzar = value; }
		}

		private string btContinuar;
		public string BtContinuar 
		{
			get { return btContinuar; }
			set { btContinuar = value; }
		}

		private string btOpciones;
		public string BtOpciones 
		{
			get { return btOpciones; }
			set { btOpciones = value; }
		}

		private string btSalir;
		public string BtSalir 
		{
			get { return btSalir; }
			set { btSalir = value; }
		}

		private string btPartidaNueva;
		public string BtPartidaNueva 
		{
			get { return btPartidaNueva; }
			set { btPartidaNueva = value; }
		}

		private string toggleSonido;
		public string ToggleSonido 
		{
			get { return toggleSonido; }
			set { toggleSonido = value; }
		}

		private string toggleMusica;
		public string ToggleMusica 
		{
			get { return toggleMusica; }
			set { toggleMusica = value; }
		}

		private string btIdioma;
		public string BtIdioma 
		{
			get { return btIdioma; }
			set { btIdioma = value;	}
		}
		
		/// <summary>
		/// Constructor de la clase <see cref="TextosMenus"/>.
		/// </summary>
		public TextosMenus()
		{
			BtComenzar = string.Empty;
			BtContinuar = string.Empty;
			BtOpciones = string.Empty;
			BtSalir = string.Empty;
			BtPartidaNueva = string.Empty;
			ToggleSonido = string.Empty;
			ToggleMusica = string.Empty;
			BtIdioma = string.Empty;
		}

		public string DevolverTexto(string nombreControl)
		{
			string textoReturn = string.Empty;

			switch (nombreControl) 
			{
			case "btComenzar": 		textoReturn = BtComenzar.ToUpper();
									break;
			case "btContinuar": 	textoReturn = BtContinuar.ToUpper();
									break;
			case "btOpciones": 		textoReturn = BtOpciones.ToUpper();
									break;
			case "btSalir": 		textoReturn = BtSalir.ToUpper();
									break;
			case "btPartidaNueva": 	textoReturn = BtPartidaNueva.ToUpper();
									break;
			case "toggleSonido": 	textoReturn = ToggleSonido.ToUpper();
									break;
			case "toggleMusica": 	textoReturn = ToggleMusica.ToUpper();
									break;
			case "btIdioma": 		textoReturn = BtIdioma.ToUpper();
									break;
			}
			
			return textoReturn;
		}
	}
}