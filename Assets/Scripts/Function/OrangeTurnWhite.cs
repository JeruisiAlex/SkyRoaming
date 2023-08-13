using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrangeTurnWhite : MonoBehaviour
{
    public GameObject upcomingWhite;//跳跃后即将出现的白云
    private float t1, t2;
    private bool isJump = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if(collision.gameObject.GetComponent<Rigidbody2D>().transform.position.y - collision.gameObject.GetComponent<Rigidbody2D>().transform.localScale.y / 2 >= this.transform.position.y )
        {
            isJump = true;
            t1 = Time.time;
        }

    }
    private void Update()
    {
        if(isJump)
        {
            t2 = Time.time;
            if (t2 - t1 >= 0.1)
            {
                upcomingWhite.SetActive(true);
                this.gameObject.SetActive(false);
            }
        }
    }
}
