﻿using System;
using System.Collections.Generic;
using System.Collections;
using Oscuridad.Enumeraciones;
using UnityEngine;

namespace Oscuridad.Clases
{
	/// <summary>
	/// Clase base para Configuracion del Juego
	/// </summary>
	[System.Serializable]
	public class Config
	{
		private Idioma idiomaJuego;
		/// <summary>
		/// Idioma del juego
		/// </summary>
		/// <value>
		/// enumeracion con el idioma dle juego
		/// </value>
		public Idioma IdiomaJuego
		{
			get { return idiomaJuego; }
			set { idiomaJuego = value; }
		}

		private bool sonidoActivado;
		/// <summary>
		/// booleana para control de activacion/desactivacion de sonido en el juego
		/// </summary>
		/// <value>
		/// true activado, false desactivado
		/// </value>
		public bool SonidoActivado 
		{
			get { return sonidoActivado; }
			set { sonidoActivado = value; }
		}

		private float volumenSonido;
		/// <summary>
		/// Control del volumen del sonido
		/// </summary>
		/// <value>
		/// valor tipo float con el valor del volumen del sonido
		/// </value>
		public float VolumenSonido 
		{
			get { return volumenSonido; }
			set { volumenSonido = value; }
		}

		private bool musicaActivada;
		/// <summary>
		/// Control de la activacion/desactivacion de la musica
		/// </summary>
		/// <value>
		/// true activada, false desactivada
		/// </value>
		public bool MusicaActivada 
		{
			get { return musicaActivada; }
			set { musicaActivada = value; }
		}

		private float volumenMusica;
		/// <summary>
		/// Control del volumen de la musica
		/// </summary>
		/// <value>
		/// valor float con el volumen de la musica
		/// </value>
		public float VolumenMusica 
		{
			get { return volumenMusica;	}
			set { volumenMusica = value; }
		}

		/// <summary>
		/// Constructor de la clase <see cref="Config"/>.
		/// </summary>
		public Config()
		{
		}
		
		/// <summary>
		/// Constructor de la clase <see cref="Config"/>.
		/// </summary>
		/// <param name="idiomaCapturado">enum con el idioma capturado en la plataforma</param>
		public Config(SystemLanguage idiomaCapturado)
		{
			IdiomaJuego = CapturarIdioma (idiomaCapturado);
		}
		
		/// <summary>
		/// Captura el idioma del dispositivo
		/// </summary>
		/// <param name="idioma">enum con el nuevo idioma</param>
		public Idioma CapturarIdioma(SystemLanguage idioma)
		{
			switch (idioma) 
			{
				case SystemLanguage.English : return Idioma.eng;
				case SystemLanguage.French : return Idioma.fr;
				case SystemLanguage.Spanish : return Idioma.spa;
				default: return Idioma.eng;
			}
		}
	}
}