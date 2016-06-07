using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {
	
	public void LoadLevel(string name){
		Debug.Log ("Level load requsted for: " + name );
		Application.LoadLevel(name);
	}
	
	public void QuitRequest(){
		Debug.Log ("I Want to quit!" + name);
		Application.Quit();
	}
	
	public void LoadNextLevel(){
		Application.LoadLevel(Application.loadedLevel + 1);
	
	}
}
