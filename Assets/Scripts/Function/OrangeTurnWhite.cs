using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrangeTurnWhite : MonoBehaviour
{
    public GameObject upcomingWhite;//��Ծ�󼴽����ֵİ���
    private float t1, t2;
    private bool isJump = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.transform.position.y - collision.gameObject.transform.localScale.y / 3 >= this.transform.position.y + this.transform.localScale.y / 2)
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
