using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goal3 : MonoBehaviour
{
    Vector2 top_right_corner;
    Vector2 bottom_left_corner;

    [SerializeField]
    private GameObject b;

    [SerializeField]
    public GameObject g;

    private Collider2D[] results;
    bluedragon bdragon;
    greendragon gdragon;

    void Start()
    {
        top_right_corner = new Vector2(-8.66f, -4.45f);
        bottom_left_corner = new Vector2 (-6.13f,-3.94f);
        results = new Collider2D[5];
        bdragon = b.GetComponent<bluedragon>();
        gdragon = g.GetComponent<greendragon>();
    }
    
    
    private void Update()
    {

        int num_colliders = Physics2D.OverlapAreaNonAlloc(top_right_corner, bottom_left_corner, results);
        for (int i = 0; i < num_colliders; i++)
        {
            if (results[i].gameObject.name == "blue" | results[i].gameObject.name == "green")
            {
                if (i < num_colliders - 1)
                {
                    if (results[i + 1].gameObject.name == "blue" | results[i + 1].gameObject.name == "green")
                    {
                        if (bdragon.get() == 4 & gdragon.get() == 4)
                        {       
                            SceneManager.LoadScene("Celebrate");
                        }
                    }
                }
            }
        }

    }
}
