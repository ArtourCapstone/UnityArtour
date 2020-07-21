using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogInPlayerPrefs : MonoBehaviour
{
    public GameObject idnum;

    public string IDnumber;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        IDnumber = idnum.GetComponent<InputField>().text;

        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (IDnumber != "")
            {
                EnterButton();
            }
            else
            {
                Debug.Log("Field is empty");
            }
        }

        if (IDnumber == "" && Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Menu");
        }
    }

    public void EnterButton()
    {
        if (IDnumber != "")
        {
            PlayerPrefs.SetString("IDNUM", IDnumber);
            SceneManager.LoadScene("Menu");
        }
        else
        {
            Debug.Log("Field is empty");
        }
    }
}
