using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quit : MonoBehaviour
{
    public void QuitTheGame()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}
