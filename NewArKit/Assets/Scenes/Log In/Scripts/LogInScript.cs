using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class LogInScript : MonoBehaviour
{
    public GameObject canvasLogin, canvasMenu;

    public GameObject idnum;
    private string IDnumber;
    private string form;

    //public InputField inputUserID;
    //string textLog;

    // Start is called before the first frame update
    void Start()
    {
        canvasMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    { 
        IDnumber = idnum.GetComponent<InputField>().text;

        if(Input.GetKeyDown(KeyCode.Return))
        {
            if(IDnumber != "")
            {
                EnterButton();
            }
            else
            {
                Debug.Log("Field is empty");
            }
        }
    }

    public void EnterButton()
    {
        bool IDNUM = false;

        if(IDnumber != "")
        {
            if (!System.IO.File.Exists(@"C:/Users/User/Downloads/" + IDnumber + ".txt"))
            {
                IDNUM = true;
            }
            else
            {
                Debug.Log("ID Number Recognized");
                idnum.GetComponent<InputField>().text = "";
                canvasLogin.SetActive(false);
                canvasMenu.SetActive(true);
            }
        }
        else
        {
            Debug.Log("Field is empty");
        }
        
        if(IDNUM == true)
        {
            Debug.Log("Registration Complete" + " " + " - " + "ID number:" + " " + IDnumber);
            form = (IDnumber);
            System.IO.File.WriteAllText(@"C:/Users/User/Downloads/" + IDnumber + ".txt", form);
            idnum.GetComponent<InputField>().text = "";
            canvasLogin.SetActive(false);
            canvasMenu.SetActive(true);
        }
        
    }

    public void ChangeUser()
    {
        canvasLogin.SetActive(true);
        canvasMenu.SetActive(false);
    }

    public void ExitApplication()
    {
        Application.Quit();
    }
}
