using UnityEngine.SceneManagement;
using UnityEngine;

public class Menu_Events : MonoBehaviour
{
    public void LoadLevel(int index)
    {
        SceneManager.LoadScene(index);
    }
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log(" Quit  ");
    }

 }
