using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Restoration : MonoBehaviour
{
    //����ɫ�����⣬�����ƶ���϶�����ʧ�ٸ�ԭ
    public float DisappearTime;
    private bool isDisappear = false;
    private float t1,t2;
    private Vector2 defaultVector;

    private void Start()
    {
         defaultVector = transform.localScale;//��¼��ʼ���Ŵ�С
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //����������ƶ��Ϸ�ʱ����������
        if(collision.gameObject.GetComponent<Rigidbody2D>().transform.position.y - collision.gameObject.GetComponent<Rigidbody2D>().transform.localScale.y / 2 >= this.transform.position.y)
        {
            transform.localScale =new Vector2(0,0);//������ʧ
            t1  = Time.time;
            isDisappear = true;
        }

    }

    private void FixedUpdate()
    {
        //������ʧ��ԭ
        if (isDisappear)
        {
            t2 = Time.time;
            if(t2-t1>=DisappearTime)//���������ʧһ��ʱ�䣬��ԭ
            {
                 transform.localScale = defaultVector;
            }
        }

    }
}
