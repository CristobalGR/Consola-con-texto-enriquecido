using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextoEnriquecido : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		Debug.Log ("Este es un ejemplo de texto enriquecido <b>con negrita.</b>");
		Debug.Log ("Este es un ejemplo de texto <b><i>con negrita y cursiva.</i></b>");
		Debug.Log ("Este es un ejemplo de texto <i><color=red>con cursiva y en rojo.</color></i>");
		Debug.Log ("Este es un ejemplo de texto <color=red><b> con negrita y en rojo.</b></color>");
		Debug.Log ("Este es un ejemplo de texto <color=green><size=20>en verde y a 20 pixeles</size></color>");
	}
}
