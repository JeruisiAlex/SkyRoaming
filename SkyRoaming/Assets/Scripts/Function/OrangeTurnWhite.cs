using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrangeTurnWhite : MonoBehaviour
{
    public GameObject upcomingWhite;//��Ծ�󼴽����ֵİ���
    private void OnCollisionEnter2D(Collision2D collision)
    {
        upcomingWhite.SetActive(true);
        this.gameObject.SetActive(false);
    }
}
