using System;
using SQLite4Unity3d;

public class SceneDTO
{
	[PrimaryKey]
	public int SceneID{ get; set;} 
	public int GameID{ get; set;}
	public string Name{ get; set;}
	public string Story{ get; set;}

	public override string ToString ()
	{
		return string.Format ("[Scene: SceneID={0}, GameID={1},  Name={2}, Story={3}]", SceneID, GameID, Name, Story);
	}
}
public class SceneToSceneDTO
{
	[PrimaryKey][AutoIncrement]
	public int Id{ get; set;} 
	public int FromSceneID{ get; set;} 
	public int ToSceneID{ get; set;} 
	public string Label {get; set; }
	public override string ToString ()
	{
		return string.Format ("[Scene: FromSceneID={0}, ToSceneID={1}", FromSceneID, ToSceneID);
	}
}

