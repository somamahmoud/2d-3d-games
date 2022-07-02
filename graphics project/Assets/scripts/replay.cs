using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class replay : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnMouseDrag()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
