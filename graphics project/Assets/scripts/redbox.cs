using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class redbox : MonoBehaviour
{
    [SerializeField]
    private GameObject lever;
    lever box;
    
    // Start is called before the first frame update
    void Start()
    {
        box = lever.GetComponent<lever>();
    }

    // Update is called once per frame
    void Update()
    {
        bool n = box.get();
        if (n == true)
            Destroy(gameObject);
    }

    /*private void open()
    {
        bool n=box.get();
        if (n == true)
            Destroy(gameObject);

    }
   */
}
