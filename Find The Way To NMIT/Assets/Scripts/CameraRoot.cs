using UnityEngine;
using System.Collections;

public class CameraRoot : MonoBehaviour {
	void Awake(){
		DontDestroyOnLoad(gameObject);
	}

	// Use this for initialization
	void Start () {
		GameModel.makeScenes();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
