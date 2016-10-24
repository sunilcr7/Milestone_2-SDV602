using System;
	[Serializable]
	public class Player
	{
		// Class
		private static int _player_number = 0;
		
		// Instance
		private int _number = (Player._player_number++); 
		private string _name;
		private Item[] _inventory;    // is this the right type?
		private Scene _currentScene;
	   
		public Scene CurrentScene
		{ 
			get{
				return _currentScene;
			} 
			set{
				_currentScene = value;
			}
		}
		public String Name
		{ 
			get{
				return _name;
			} 
			set{
				_name = value;
			}
		}
		private void AddExperience(){
			Persist.control.Experience = Persist.control.Experience + 1;
		}
		public void Move(GameModel.DIRECTION pDirection){
			
			switch(pDirection){
				case GameModel.DIRECTION.North: // but what do we do??
					 
						if( _currentScene.North != null)
						{
							_currentScene =  _currentScene.North;
							AddExperience();
						}
						break;
                case GameModel.DIRECTION.South:
                        if (_currentScene.South != null)
                        {
                        _currentScene = _currentScene.South;
                        }
                        break;

                case GameModel.DIRECTION.East:
                        if (_currentScene.East != null)
                        {
                            _currentScene = _currentScene.East;
                        }
                        break;

                case GameModel.DIRECTION.West:
                        if (_currentScene.West != null)
                        {
                            _currentScene = _currentScene.West;
                        }
                        break;
        }
		}

		public void InitialisePlayerState(){
			if(Persist.control != null){
				Persist.control.Experience = 0;
				Persist.control.Health = 5;
			}
		}
		public Player ()
		{
			//InitialisePlayerState();
		}
	}


