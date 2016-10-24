using System;
using System.Collections.Generic;

	[Serializable]
	public class Scene
	{
		private Players _players = new Players();
		private Scene[] _connected_scenes = new Scene[4];
		private string _description = "default"; 
		private int _id;
		public static List<Scene> AllScenes = new List<Scene>();
		
		public int ID {
			get{ 
				return _id;
			}
			set{
				_id = value;
			}
		}

    // Description Property 
    public string Description
    {
        get
        {
            return _description;
        }
        set
        {
            _description = value;
        }
    }

    // North Property 
    public Scene North
    {
        get
        {
            return _connected_scenes[(int)GameModel.DIRECTION.North];
        }
        set
        {
            _connected_scenes[(int)GameModel.DIRECTION.North] = value;
        }
    }

    // South Property 
    public Scene South
    {
        get
        {
            return _connected_scenes[(int)GameModel.DIRECTION.South];
        }
        set
        {
            _connected_scenes[(int)GameModel.DIRECTION.South] = value;
        }
    }

    // East Property
    public Scene East
    {
        get
        {
            return _connected_scenes[(int)GameModel.DIRECTION.East];
        }
        set
        {
            _connected_scenes[(int)GameModel.DIRECTION.East] = value;
        }
    }

    // West Property 
    public Scene West
    {
        get
        {
            return _connected_scenes[(int)GameModel.DIRECTION.West];
        }
        set
        {
            _connected_scenes[(int)GameModel.DIRECTION.West] = value;
        }
    }
    public Scene ()
		{
			Scene.AllScenes.Add(this);
		}
	    
	    
	}


