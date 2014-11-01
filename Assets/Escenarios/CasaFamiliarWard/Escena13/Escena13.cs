﻿using UnityEngine;
using System.Collections;
using System.IO;
using Oscuridad.Interfaces;
using Oscuridad.Enumeraciones;
using Oscuridad.Clases;
using System.Collections.Generic;

namespace Oscuridad.Estados
{
	public class Escena13: IEscenario
	{
		private ControladoraEscenas manager;

		public Escena13(ControladoraEscenas managerRef)
		{
			manager = managerRef;

			if(Application.loadedLevelName != EstadoJuego.Escena13.ToString())
			{
				Application.LoadLevel(EstadoJuego.Escena13.ToString());
			}

			InicializarDatos ();
		}

		public void InicializarDatos()
		{
			GameCenter.InstanceRef.controladoraGUI.Activar_Cargando();
		}

		public void EstadoUpdate()
		{
		}
		
		public void Mostrar()
		{
		}

		public void NivelCargado()
		{
			//Cargamos Datos Serializados
			GameCenter.InstanceRef.controladoraJuego.escenaActual = GameCenter.InstanceRef.controladoraJuego.Cargar_Escena(Escenas.Escena13);

			//Inicializamos la escena
			GameCenter.InstanceRef.controladoraGUI.Devolver_Pantalla_Carga().comenzarFade = true;
			GameCenter.InstanceRef.Inicializar_Escenario ();
		}
	}
}
