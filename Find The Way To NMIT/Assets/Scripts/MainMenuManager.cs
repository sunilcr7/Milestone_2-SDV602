using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class MainMenuManager : MonoBehaviour {

    public Canvas FirstScreen;
    public Canvas SecondScreen;
    public Canvas ThirdScreen;
    public Canvas FourScreen;

    public void LoadScene(string pSceneName){
		SceneManager.LoadScene(pSceneName);
	}

	public void ShowCanvas(Canvas pCanvas){
		
		pCanvas.gameObject.SetActive(true);
		Debug.Log(gameObject.name);
		Canvas[] canvases = gameObject.GetComponentsInChildren<Canvas>(true);

		foreach(Canvas cnv in canvases){
		 	if(cnv.name != pCanvas.name){
		 		cnv.gameObject.SetActive(false);
			}
		}
		 
	}

    public void ShowHelp()
    {
        var menuPanel = GameObject.FindGameObjectWithTag("MainMenuPanel");
        menuPanel.SetActive(false);

        var helpPanel = GameObject.FindGameObjectWithTag("MainMenuHelpPanel");
        helpPanel.SetActive(true);
    }

    public void HideHelp()
    {
        var menuPanel = GameObject.FindGameObjectWithTag("MainMenuPanel");
        menuPanel.SetActive(true);

        var helpPanel = GameObject.FindGameObjectWithTag("MainMenuHelpPanel");
        helpPanel.SetActive(false);
    }

    public void Login()
    {
        GameObject goLogin = GameObject.FindGameObjectWithTag("Login");
        //InputField aText = aName.GetComponent<InputField>() ;
        string name = goLogin.GetComponent<InputField>().text;//  aText.text;

        GameObject goPassword = GameObject.FindGameObjectWithTag("Password");
        //aText = aPassword.GetComponent<InputField>();
        string password = goPassword.GetComponent<InputField>().text;// aText.text;

        DataService aDS = new DataService();

        //aDS.MakeAnTestAccount("sunil", "real123");
        //aDS.MakeAnTestAccount("todd", "sdv602");

        if (aDS.CheckLogin(name, password))
        {
            // LOGIN OK
            ShowCanvas(SecondScreen);
        }
    }
}

