using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class StartController : MonoBehaviour
{
    public Image img;

    public void StartGame()
    {
        SceneManager.LoadScene(1);
        //To Animation Later
        Debug.Log("DED");
    }
}
