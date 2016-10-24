using UnityEngine;
using System.Collections;

public class DataServiceUtilities : MonoBehaviour {

	public void DeleteDB(){
		DataService _connection = new DataService();
		if(_connection.DbExists("GameNameDb")){
			_connection.deleteDatabaseFile();
		}
	}

	public void Save(){
		DataService _connection = new DataService();
		if(_connection.DbExists("GameNameDb")){
			_connection.Connect();
			_connection.SaveScenes();
		}
	}

	public void Load(){
		DataService _connection = new DataService();
		if(_connection.DbExists("GameNameDb")){
			_connection.Connect();
			_connection.LoadScenes();
		}
	}
}
