using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Checklist : MonoBehaviour
{

    public Text userIDprint;

    public string IDGET;
    // Start is called before the first frame update
    void Start()
    {
        IDGET = PlayerPrefs.GetString("IDNUM");
        userIDprint.text = IDGET;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Menu");
        }
    }
}
