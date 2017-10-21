using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exit : MonoBehaviour {

	// Use this for initialization
	public void quit(){
		Debug.Log ("has quit game");
		Application.Quit ();
	}
}
