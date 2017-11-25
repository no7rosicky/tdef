using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenu : MonoBehaviour {

	public string levelToLoad = "MainScene";

	// Use this for initialization
	public void Play () {
		SceneManager.LoadScene(levelToLoad);
		
	}
	
	// Update is called once per frame
	public void Quit () {
		Debug.Log("Quit");
		Application.Quit();
	}
}
