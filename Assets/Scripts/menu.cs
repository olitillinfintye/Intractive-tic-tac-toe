using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public void play(){
        SceneManager.LoadScene("Main");
    }
    public void home(){
        SceneManager.LoadScene("menu");
    }


    public void about(){
        // SceneManager.LoadScene("about");
    }
    public void exit(){
        Application.Quit();
        Debug.Log("exiting...");
    }
}
