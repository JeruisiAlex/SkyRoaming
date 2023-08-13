using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Restoration : MonoBehaviour
{
    //除橘色碎云外，所有云朵踩上都会消失再复原
    public float DisappearTime;
    private bool isDisappear = false;
    private float t1,t2;
    private Vector2 defaultVector;

    private void Start()
    {
         defaultVector = transform.localScale;//记录初始缩放大小
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //仅当玩家在云朵上方时，触发功能
        if(collision.gameObject.GetComponent<Rigidbody2D>().transform.position.y - collision.gameObject.GetComponent<Rigidbody2D>().transform.localScale.y / 2 >= this.transform.position.y)
        {
            transform.localScale =new Vector2(0,0);//碎云消失
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
            if(t2-t1>=DisappearTime)//如果碎云消失一定时间，则复原
            {
                 transform.localScale = defaultVector;
            }
        }

    }
}
