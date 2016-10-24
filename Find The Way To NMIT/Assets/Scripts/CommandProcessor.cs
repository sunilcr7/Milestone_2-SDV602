using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

using System.IO;

public delegate void aDisplayer( String value );

public class CommandProcessor
{
		public CommandProcessor ()
		{
		}
		
	    public void Parse(String pCmdStr, aDisplayer display){  
			String strResult = "Do not understand"; 

			char[] charSeparators = new char[] {' '};
			pCmdStr = pCmdStr.ToLower();
			String[] parts = pCmdStr.Split(charSeparators,StringSplitOptions.RemoveEmptyEntries); // tokenise the command

        // process the tokens
        if (parts.Length < 1) //checking whether the array "parts" consists of elements or not
        {
            display(" do not understand");
        }
        else
            // process the takens
            switch (parts[0])
            {
                case "pick":
                    if (parts[1] == "up")
                    {
                        Debug.Log("Got Pick up");
                        strResult = "Got Pick up";

                        if (parts.Length == 3)
                        {
                            String param = parts[2];
                        }// do pick up command
                         // GameModel.Pickup();
                    }
                    break;

                case "go":
                    switch (parts[1])
                    {
                        case "north":
                            Debug.Log("Got go North");
                            //strResult = "Got Go North";
                            GameModel.go(GameModel.DIRECTION.North);
                            break;

                        case "south":
                            Debug.Log("Got go South");
                            //strResult = "Got Go South";
                            GameModel.go(GameModel.DIRECTION.South);
                            break;

                        case "east":
                            Debug.Log("Got go east");
                            //strResult = "Got Go South";
                            GameModel.go(GameModel.DIRECTION.East);
                            break;

                        case "west":
                            Debug.Log("Got go west");
                            //strResult = "Got Go South";
                            GameModel.go(GameModel.DIRECTION.West);
                            break;

                        default:
                            Debug.Log(" do not know how to go there");
                            strResult = "Do not know how to go there";
                            break;
                    }// end switch "go"

                    strResult = GameModel.currentPlayer.CurrentScene.Description;
			            display(strResult);
					break;
				default:
			        Debug.Log("Do not understand");
					strResult = "Do not understand";
					break;
			         
			}// end switch
		    
			// return strResult;

		}// Parse
}


