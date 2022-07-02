using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elevator : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform floor;
    //public Transform elevatorswitch;
    public Transform down;
    public Transform up;
    public float speed;
    public bool isele;
    //button m;
    /* //bool work = button.work;

     button m = new button();
     bool l;*/

    void Start()
    {
        //m = GetComponent<button>();

    }

    
       void Update()
    {
       //startelevator();
        //l = m.work;
        //Debug.Log(l);
        //float l = (player.transform.position - elevatorswitch.transform.position).magnitude;
        //h.text = l.ToString("F1");
    }

    public void startelevator()
    {
        //if (l==true)
        //{
        
        
        if (transform.position.y <= down.position.y)
        {
            isele = true;
        }
        else
        {
            if (transform.position.y >= up.position.y)
            {
                isele = false;
            }
        }
        //}
        if (isele)
        {
            transform.position = Vector2.MoveTowards(transform.position, up.position, speed * Time.deltaTime);
        }

        else
            transform.position = Vector2.MoveTowards(transform.position, down.position, speed * Time.deltaTime);
    }


}
