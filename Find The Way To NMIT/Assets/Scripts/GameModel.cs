using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

using System.IO;



using System.Text;

// Is this a factory?
public static class GameModel
{

	private static String _name;
	private static Player _player = new Player();
	public enum DIRECTION  {North, South, East, West};
	private static Scene _start_scene; // ??
	public static Players PlayersInGame = new Players();

	public static Scene Start_scene{
		get 
		{ 
			return _start_scene;  
		}
		set{
			_start_scene = value; 
		}

	}

	public static string Name{
		get 
		{ 
			return _name;  
		}
		set{
			_name = value; 
		}

	}

	public static Player currentPlayer
	{
		get
		{
			return _player;
		}
		set
		{
			_player = value;
		}

	}
	public static void go(DIRECTION pDirection)
	{
		currentPlayer.Move(pDirection);
	}

	public static void makeScenes()
	{
		Scene tmp; 
		DataService theService = new DataService();

		// uncomment the following two lines to start with an empty database
		//if(theService.DbExists("GameNameDb"))
		//	theService.deleteDatabaseFile();

		// Watch out DbExists has a side effect!
		if(theService.DbExists("GameNameDb"))
		{
			theService.Connect();
			theService.LoadScenes();
			currentPlayer.InitialisePlayerState();
			currentPlayer.CurrentScene = Scene.AllScenes[0];
		}
		else
		{
	
            Start_scene = new Scene();
            Start_scene.ID = 1;
            Start_scene.Description = " You are arrived in city centre and you lost way to NMIT";

            tmp = new Scene();
            tmp.ID = 2;
            tmp.Description = " You might get trouble because north way dont have exit";
            tmp.South = Start_scene;
            Start_scene.North = tmp;

            tmp = new Scene();
            tmp.ID = 3;
            tmp.Description = " It takes long time and very diffuclt to figure out arriving NMIT before Class";
            tmp.East = Start_scene;
            Start_scene.West = tmp;

            tmp = new Scene();
            tmp.ID = 4;
            tmp.Description = " Hip of Traffic becauce car crashs near city centre ";
            tmp.North = Start_scene;
            Start_scene.South = tmp;

            tmp = new Scene();
            tmp.ID = 5;
            tmp.Description = " You are infront of state Cinema";
            tmp.West = Start_scene;
            Start_scene.East = tmp;

            tmp = new Scene();
            tmp.ID = 6;
            tmp.Description = " Ask some one who can help you to get your way";
            tmp.South = Start_scene.East;
            Start_scene.East.North = tmp;

            tmp = new Scene();
            tmp.ID = 7;
            tmp.Description = " You can see around for taking rest ";
            tmp.West = Start_scene.East;
            Start_scene.East.East = tmp;

            tmp = new Scene();
            tmp.ID = 8;
            tmp.Description = " You are near to supermarket if you are hungrey by some food";
            tmp.North = Start_scene.East;
            Start_scene.East.South = tmp;

            tmp = new Scene();
            tmp.ID = 9;
            tmp.Description = " lots of traffic";
            tmp.West = Start_scene.South;
            Start_scene.East.South.East = tmp;

            tmp = new Scene();
            tmp.ID = 10;
            tmp.Description = "Way to forest";
            tmp.North = Start_scene.East.South;
            Start_scene.East.South.South = tmp;

            tmp = new Scene();
            tmp.ID = 11;
            tmp.Description = " Yes your beside ANZ bank it is not long way from that palce";
            tmp.East = Start_scene.East.South;
            Start_scene.East.South.West = tmp;

            tmp = new Scene();
            tmp.ID = 12;
            tmp.Description = " No Exist";
            tmp.North = Start_scene.East.South.West;
            Start_scene.East.South.West.South = tmp;

            tmp = new Scene();
            tmp.ID = 13;
            tmp.Description = " Road is on under construction";
            tmp.East = Start_scene.East.South.West;
            Start_scene.East.South.West.West = tmp;

            tmp = new Scene();
            tmp.ID = 14;
            tmp.Description = " You infront of church which is most popular in Nelson and it look like Tower of Nelson";
            tmp.South = Start_scene.East.South.West;
            Start_scene.East.South.West.North = tmp;

            tmp = new Scene();
            tmp.ID = 15;
            tmp.Description = " You are now in Nmit but their is big wall from this direction";
            tmp.East = Start_scene.East.South.West.North;
            Start_scene.East.South.West.North.West = tmp;

            tmp = new Scene();
            tmp.ID = 16;
            tmp.Description = " Do not  have entry door from this direction  it might be hassel to you";
            tmp.South = Start_scene.East.South.West.North;
            Start_scene.East.South.West.North.North = tmp;

            tmp = new Scene();
            tmp.ID = 17;
            tmp.Description = " Yes you find the way and your in time and also your didn't lots class";
            tmp.West = Start_scene.East.South.West.North;
            Start_scene.East.South.West.North.East = tmp;

            currentPlayer.InitialisePlayerState();
            currentPlayer.CurrentScene = Start_scene;


            theService.Connect();
			theService.SaveScenes();
		}

	}


}

