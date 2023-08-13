using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeadDisappear : MonoBehaviour
{
    //DisappearTime��ʾ�ƶ���ʧ״̬ά��ʱ�䣬KeepTime��ʾ����ά�ֿ���״̬��ʱ��
    public float DisappearTime, KeepTime;
    private float t1, t2;
    private bool isDisappear = false;
    private Vector3 defaultVector;

    private void Start()
    {
        defaultVector = transform.position;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.transform.position.y - collision.gameObject.transform.localScale.y/3 >= this.transform.position.y + this.transform.localScale.y / 2)
        {
            t1 = Time.time;
            isDisappear = true;

        }

    }

    private void Update()
    {
        if (isDisappear)
        {
            t2 = Time.time;
            
            if(t2-t1 >= KeepTime + DisappearTime)
            {
                isDisappear=false;
                transform.position = defaultVector;//���Ƴ���
            }
            else if(t2-t1 >=KeepTime)
            {
                transform.position = new Vector3(-1000,-1000,0);//��������ʧ
            }
        }

    }

}
