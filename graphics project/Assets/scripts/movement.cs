using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    Vector3 x;
    float speed=0;
    float adddpos = 0.5f;

    void Start()
    {
        x = transform.position;
    }
    public void Update()
    {
        float y = Mathf.Lerp(x.y,x.y+adddpos,Mathf.PingPong(Time.time,1));
        transform.position = new Vector3(x.x, y, x.z);

        float y1 = Mathf.Lerp(x.y+1, x.y, speed);
        transform.position = new Vector3(x.x, y, x.z);
    }


}

