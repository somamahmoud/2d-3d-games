using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lever : MonoBehaviour
{
    bool open;
    
    void Start()
    {

    }

    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("bluedrag") | collision.gameObject.CompareTag("greendrag"))
        {
            open = true;
        }
    }

    public bool get()
    {
        return open;
    }

}