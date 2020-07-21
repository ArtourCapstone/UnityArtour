using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Menu : MonoBehaviour
{
    public GameObject canvasMenu, canvasNouser;
    public Text userIDprint;

    public string IDGET;

    // Start is called before the first frame update
    void Start()
    {
        IDGET = PlayerPrefs.GetString("IDNUM");
        userIDprint.text = IDGET;
        canvasMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (IDGET != "")
        {
            canvasMenu.SetActive(true);
            canvasNouser.SetActive(false);
        }
        else
        {
            canvasMenu.SetActive(false);
            canvasNouser.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Quit the game");
            Application.Quit();
        }
    }

    public void Starts()
    {
        SceneManager.LoadScene("ActualScene");
    }

    public void Register()
    {
        SceneManager.LoadScene("LogIn");
    }

    public void LogInAsVisitor()
    {
        SceneManager.LoadScene("ActualScene");
    }

    public void ExitApp()
    {
        Debug.Log("Quit the game");
        Application.Quit();
    }

    public void ChangeUserYes()
    {
        SceneManager.LoadScene("LogIn");
        PlayerPrefs.DeleteAll();
    }

    public void Checklist()
    {
        SceneManager.LoadScene("Checklist");
    }
}
