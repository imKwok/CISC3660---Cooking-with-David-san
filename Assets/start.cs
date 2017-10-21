using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start : MonoBehaviour {

	public void changeScene(string sceneName){
		Application.LoadLevel (sceneName);
	}

}
