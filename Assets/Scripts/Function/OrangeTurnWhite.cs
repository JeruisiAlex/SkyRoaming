using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrangeTurnWhite : MonoBehaviour
{
    public GameObject upcomingWhite;//��Ծ�󼴽����ֵİ���
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.transform.position.y - collision.gameObject.transform.localScale.y / 3 >= this.transform.position.y + this.transform.localScale.y / 2)
        {
            upcomingWhite.SetActive(true);
            this.gameObject.SetActive(false);
        }

    }
}
