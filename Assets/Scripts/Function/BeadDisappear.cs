using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeadDisappear : MonoBehaviour
{
    //DisappearTime��ʾ�ƶ���ʧ״̬ά��ʱ�䣬KeepTime��ʾ����ά�ֿ���״̬��ʱ��
    public float DisappearTime,KeepTime;
    private float t1, t2;
    private bool isDisappear = false;
    private Vector2 defaultVector;

    private void Start()
    {
        defaultVector = transform.localScale;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        t1 = Time.time;
        isDisappear = true;
    }

    private void Update()
    {
        if (isDisappear)
        {
            t2 = Time.time;
            if(t2-t1 >=KeepTime)
            {
                transform.localScale = new Vector2(0,0);//��������ʧ
            }
            if(t2-t1 >= KeepTime + DisappearTime)
            {
                isDisappear=false;
                transform.localScale = defaultVector;//���Ƴ���
            }
        }

    }

}