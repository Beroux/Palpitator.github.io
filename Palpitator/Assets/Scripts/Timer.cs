using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {
	public string levelToLoad;
	public float startTime = 60f;
	private Text timerText;

	// Use this for initialization
	void Start () {
		timerText = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		startTime -= Time.deltaTime;
		timerText.text = startTime.ToString ("f0");
			if (startTime <= 0)
			{
			SceneManager.LoadScene (levelToLoad);
		}
	}
}
