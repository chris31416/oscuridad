﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using Oscuridad.Enumeraciones;

public class PanelPreguntasOpciones : MonoBehaviour 
{
	public RectTransform scrollRectTransform;
	public RectTransform rectPanelPreguntas;
	public float y;
	
	void Start()
	{
		if (GameCenter.InstanceRef != null) 
			GameCenter.InstanceRef.controladoraGUI.panelPreguntasOpciones = gameObject.GetComponent<PanelPreguntasOpciones>();

		y = rectPanelPreguntas.localPosition.y;
		GameCenter.InstanceRef.controladoraGUI.panelPreguntasOpciones.gameObject.SetActive (false);
	}
	
	void OnEnable()
	{
		//if (GameCenter.InstanceRef != null) 
			//Reiniciar_Texto ();
	}
	
	void OnDisable()
	{
		scrollRectTransform.GetComponent<ScrollRect>().vertical = true;
		Posicion_Inicial_Caja ();
	}
	
	void Update()
	{
		Debug.Log ("y: " + y);
		if (GameCenter.InstanceRef.controladoraJugador.EstadoJugador.Equals (EstadosJugador.enEspera) || GameCenter.InstanceRef.controladoraJugador.EstadoJugador.Equals (EstadosJugador.enZoomEspera)) 
		{
			if (GameCenter.InstanceRef.controladoraJuego.objetoPulsado == null) 
			{
				Debug.Log ("rectPanelPreguntas.rect.height: " + rectPanelPreguntas.rect.height.ToString () + " - scrollRectTransform.rect.height: " + scrollRectTransform.rect.height.ToString ());    
				if (rectPanelPreguntas.rect.height > scrollRectTransform.rect.height) 
				{
					scrollRectTransform.GetComponent<ScrollRect> ().vertical = true;
					
					Debug.Log ("rectrectPanelPreguntas.localposition.y: " + rectPanelPreguntas.localPosition.y.ToString ());
					if (rectPanelPreguntas.localPosition.y < y) 
						Posicion_Inicial_Caja ();
					
					Debug.Log ("rectrectPanelPreguntas.localposition.y: " + rectPanelPreguntas.localPosition.y + " - rectPanelPreguntas.rect.height: " + rectPanelPreguntas.rect.height.ToString ());
					if (rectPanelPreguntas.localPosition.y > rectPanelPreguntas.rect.height) 
						rectPanelPreguntas.localPosition = new Vector2 (0, rectPanelPreguntas.rect.height);
				} 
				else 
					scrollRectTransform.GetComponent<ScrollRect> ().vertical = false;
			} 
		}
	}
	
	public void Posicion_Inicial_Caja()
	{
		rectPanelPreguntas.localPosition = new Vector2 (0, y);
	}
}