using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class Persist : MonoBehaviour {
	public static Persist control; 
	private float health = 100; 
	private float experience = 0;
	public Text HealthText;
	public Text ExperienceText;

	public float Health{
		get{
			return health;
		}
		set{
			health = value;
			HealthText.text = "Health = "+ health.ToString();
		}

	}

	public float Experience{
		get{
			return experience;
		}
		set{
			experience = value;
			ExperienceText.text = "Experience = "+ experience.ToString();
		}

	}
	// Use this for initialization
	void Start () {
		// PLAYER PREFS
		// PlayerPrefs.SetInt("health",21);
		//int health = PlayerPrefs.GetInt("health");

		// DontDestroyOnLoad
		//DontDestroyOnLoad(gameObject);



	}

	// Now there can be only one of
	void Awake(){
		if( control == null){
			DontDestroyOnLoad(gameObject);
			control = this;
		}
		else if(control!= this){
			Destroy(gameObject);
		}

		// SINGLETON ^^^^

	}

	// Serialisation

	// Unity Serialisation

	// Update is called once per frame
	//void Update () {
	
	//}

	public void Save(){
		BinaryFormatter bf = new BinaryFormatter();
		FileStream file = File.Create(Application.persistentDataPath + "/playerInfo.dat");

		String path = Application.persistentDataPath ;
		PlayerData data  = new PlayerData();
		data.health = Health;
		data.experience = Experience;

		bf.Serialize(file,data);

		file.Close();
	}

	public void Load(){
		if(File.Exists(Application.persistentDataPath + "/playerInfo.dat"))
		{
			BinaryFormatter bf = new BinaryFormatter();
			FileStream file = File.Open(Application.persistentDataPath + "/playerInfo.dat",FileMode.Open);
			PlayerData data = (PlayerData)bf.Deserialize(file);
			file.Close();

			Health = data.health;
			Experience = data.experience;
		}
	}
}

[Serializable]
class PlayerData
{
	public float health;
	public float experience;
}