﻿using System;
using System.Collections.Generic;
using Oscuridad.Enumeraciones;

namespace Oscuridad.Clases
{
    /// <summary>
    /// Clase Base para Descripcion con Tirada de dados
    /// </summary>
	[System.Serializable]
    public class InteractuableTiradaBase
    {
		#region VARIABLES

        private string textoDescriptivo;
        /// <summary>
        /// texto de la descripcion del Objeto
        /// </summary>
        /// <value>
        /// cadena descriptiva del objeto
        /// </value>
        public string TextoDescriptivo
        {
            get { return textoDescriptivo; }
            set { textoDescriptivo = value; }
        }

        private Habilidades habilidadTirada;
        /// <summary>
        /// Habilidad para la tirada en la descripcion
        /// </summary>
        /// <value>
        /// enum de tipo Habilidades
        /// </value>
        public Habilidades HabilidadTirada
        {
            get { return habilidadTirada; }
            set { habilidadTirada = value; }
        }

        private bool comprobacion;
        /// <summary>
        /// Valor para saber si hay una comprobacion para mostrar la descripcion.
        /// </summary>
        /// <value>
        ///   <c>true</c> si hay comprobacion; sino hay comprobacion, <c>false</c>.
        /// </value>
        public bool Comprobacion
        {
            get { return comprobacion; }
            set { comprobacion = value; }
        }

        private Escenas escenaComprobacion;
        /// <summary>
        /// Obtiene la escena de comprobacion
        /// </summary>
        /// <value>
        /// valor tipo enum Escenas
        /// </value>
        public Escenas EscenaComprobacion
        {
            get { return escenaComprobacion; }
            set { escenaComprobacion = value; }
        }

        private Interactuables interactuableComprobacion;
        /// <summary>
        /// Obtiene el interactuable para la comprobacion
        /// </summary>
        /// <value>
        /// valor tipo enum Interactuables
        /// </value>
        public Interactuables InteractuableComprobacion
        {
            get { return interactuableComprobacion; }
            set { interactuableComprobacion = value; }
        }

        private bool accion;
        /// <summary>
        /// comprobacion si la descripcion tiene una accion posterior a su muestreo
        /// </summary>
        /// <value>
        ///   <c>true</c> si existe una accion posterior; sino existe accion, <c>false</c>.
        /// </value>
        public bool Accion
        {
            get { return accion; }
            set { accion = value; }
        }

        private List<Localizaciones> localizacionAccion;
        /// <summary>
        /// Lista de localizaciones a desbloquear
        /// </summary>
        /// <value>
        /// Lista generica de tipo enum Localizaciones
        /// </value>
        public List<Localizaciones> LocalizacionAccion
        {
            get { return localizacionAccion; }
            set { localizacionAccion = value; }
        }

		private List<Acciones> accionesAccion;
		/// <summary>
		/// Lista de acciones a realizar
		/// </summary>
		/// <value>
		/// Lista generica de tipo enum Acciones
		/// </value>
		public List<Acciones> AccionesAccion
		{
			get { return accionesAccion; }
			set { accionesAccion = value; }
		}

		#endregion

		#region CONSTRUCTORES

        /// <summary>
        /// Constructor de la clase <see cref="InteractuableTiradaBase"/>.
        /// </summary>
		public InteractuableTiradaBase()
        {
			Inicializar_Listas ();
        }

        /// <summary>
        /// Constructor de la clase <see cref="InteractuableTiradaBase"/>
        /// </summary>
        /// <param name="texto">texto descriptivo del objeto</param>
		public InteractuableTiradaBase(string texto)
        {
			Inicializar_Listas ();

            textoDescriptivo = texto;
        }

        /// <summary>
        /// Constructor de la clase <see cref="InteractuableTiradaBase"/>
        /// </summary>
        /// <param name="habilidad">enum de tipo Habilidades</param>
		public InteractuableTiradaBase(Habilidades habilidad)
        {
			Inicializar_Listas ();

            habilidadTirada = habilidad;
        }

        /// <summary>
        /// Constructor de la clase <see cref="InteractuableTiradaBase"/>
        /// </summary>
        /// <param name="texto">texto de la descripcion del objeto</param>
        /// <param name="habilidad">enum de tipo Habilidades</param>
		public InteractuableTiradaBase(string texto, Habilidades habilidad)
        {
			Inicializar_Listas ();

            textoDescriptivo = texto;
            habilidadTirada = habilidad;
        }

        /// <summary>
        /// Constructor de la clase <see cref="InteractuableTiradaBase"/>
        /// </summary>
        /// <param name="texto">texto de la descripcion del objeto</param>
        /// <param name="habilidad">enum de tipo Habilidades</param>
        /// <param name="comp">comprobacion de descripcion</param>
        /// <param name="escena">enum de tipo Escenas</param>
        /// <param name="objeto">enum de tipo Interactuables</param>
        /// <param name="action">comprobacion de accion posterior</param>
        /// <param name="localizacion">array de enum de tipo Localizaciones</param>
		public InteractuableTiradaBase(string texto, Habilidades habilidad, bool comp, Escenas escena, Interactuables objeto, bool action, Localizaciones[] localizacion)
        {
			Inicializar_Listas ();

            textoDescriptivo = texto;
            habilidadTirada = habilidad;
            comprobacion = comp;
            escenaComprobacion = escena;
            interactuableComprobacion = objeto;
            accion = action;
            localizacionAccion.AddRange(localizacion);
        }

		#endregion

		#region METODOS

		/// <summary>
		/// Inicializa las listas de la clase
		/// </summary>
		private void Inicializar_Listas()
		{
			localizacionAccion = new List<Localizaciones>();
			accionesAccion = new List<Acciones> ();
		}

		#endregion
    }
}