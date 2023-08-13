using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Restoration : MonoBehaviour
{
    public float DisappearTime;
    private bool isDisappear = false;
    private float t1,t2;
    private Vector2 defaultVector;

    private void Start()
    {
         defaultVector = transform.localScale;//记录初始缩放
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.GetComponent<Rigidbody2D>().transform.position.y - collision.gameObject.GetComponent<Rigidbody2D>().transform.localScale.y / 3 >= this.transform.position.y + this.transform.localScale.y / 2)
        {
            transform.localScale =new Vector2(0,0);
            t1  = Time.time;
            isDisappear = true;
        }

    }

    private void FixedUpdate()
    {
        //物体消失后复原
        if (isDisappear)
        {
            t2 = Time.time;
            if(t2-t1>=DisappearTime)
            {
                 transform.localScale = defaultVector;
            }
        }

    }
}
