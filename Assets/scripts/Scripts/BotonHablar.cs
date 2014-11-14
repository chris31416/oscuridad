﻿using UnityEngine;
using System.Collections;
using Oscuridad.Estados;

public class BotonHablar : MonoBehaviour 
{
	private PanelVentana panelVentanaRef;
	private PanelObjetos panelObjetosRef;

	void Start()
	{
		panelVentanaRef = GameObject.Find("PanelGuiVentana").GetComponent<PanelVentana> ();
		panelObjetosRef = GameObject.Find("PanelGuiObjetos").GetComponent<PanelObjetos> ();
	}

	void Update()
	{
		foreach (Touch touch in Input.touches)
		{
			if (this.guiTexture.HitTest(touch.position))
			{
				//Volvemos al estado del jugador EnEspera
				Hablar_Personaje();
				break;
			}
		}
	}

	void OnMouseDown() 
	{
		if (this.guiTexture.texture == panelObjetosRef.botonHablar) 
		{
			Hablar_Personaje();
		}
	}

	private void Hablar_Personaje()
	{
		//Activar ventana Conversaciones
		panelVentanaRef.Activar_Ventana_Conversaciones ();

		//Desactivamos el icono de Hablar
		panelObjetosRef.Desactivar_Opcion("BotonHablar");
		
		//Mostramos el Inicio de la pregunta
		panelVentanaRef.Lanzar_Hablar ();

		//Activamos el icono de Hablar
		panelObjetosRef.Activar_Opcion("BotonHablar");

		panelVentanaRef.Activar_Ventana_Descripciones ();
	}
}
