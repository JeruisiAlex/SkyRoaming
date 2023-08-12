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
         defaultVector = transform.localScale;//��¼��ʼ����
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        transform.localScale =new Vector2(0,0);
        t1  = Time.time;
        isDisappear = true;
    }

    private void FixedUpdate()
    {
        //������ʧ��ԭ
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
