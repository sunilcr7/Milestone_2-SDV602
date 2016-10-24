using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Login : MonoBehaviour
{
    public Text Name;
    public Text Password;
    public Canvas SecondCanvas;

    // Use this for initialization
    public void login()
    {
        //GameObject aName = GameObject.Find("IFUserName");
        //InputField aText = aName.GetComponent<InputField>() ;
        string name = Name.text;//  aText.text;

        //GameObject aPassword = GameObject.Find("IFPassword");
        //aText = aPassword.GetComponent<InputField>();
        string password = Password.text;// aText.text;

        DataService aDS = new DataService();

        //aDS.MakeAnTestAccount("sunil", "real123");
        //aDS.MakeAnTestAccount("todd", "sdv602");

        if (aDS.CheckLogin(name, password))
        {
            // LOGIN OK
            ShowCanvas(SecondCanvas);
        }
    }

    public void ShowCanvas(Canvas pCanvas)
    {
        pCanvas.gameObject.SetActive(true);
        Debug.Log(gameObject.name);
        Canvas[] canvases = gameObject.GetComponents<Canvas>();

        foreach (Canvas cnv in canvases)
        {
            if (cnv.name != pCanvas.name)
            {
                cnv.gameObject.SetActive(false);
            }
        }

    }
}