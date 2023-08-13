using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CloudDisappear : MonoBehaviour
{
    private int score;
    private GameObject player,panel;
    private Rigidbody2D rig;
    public float HighestJumpSpeed;
    public float LowestJumpSpeed;
    public float DefaultJumpSpeed;
    public int NumberOfOrange;

    private void Start()
    {
        //��ȡ������Ϲ��ص�Rigidbody���
        player = GameObject.FindWithTag("Player");
        rig = player.GetComponent<Rigidbody2D>();
        score = 0;
        //��ȡUI���ı���Ϣ
        panel = GameObject.FindWithTag("Score");

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {   
        //���������ƶ���Ϸ��������Ҳȵ������ƶ�����Һ��·����򲻻�������Ծ��
        if(collision.gameObject.transform.position.y<= rig.transform.position.y - rig.transform.localScale.y / 2)
        {
            Debug.Log("001");
            //��ɫ���ƣ�һ�Ⱦ�ɢ���Ⱥ�ԭ���ɽ�����Ծ
            if (collision.collider.tag == "White")
            {
                rig.velocity = new Vector2(0,DefaultJumpSpeed);
            }
            //ǳ��ɫ���ƣ������������ɫ�������ƣ������ϻ�������
            if (collision.collider.tag == "LightYellow")
            {
                rig.velocity = new Vector2(0, HighestJumpSpeed);
            }
            //���ɫ���ƣ������������ɫ�������ƣ������ϻ�������
            if(collision.collider.tag == "DarkYellow")
            {
                
                rig.velocity = new Vector2(0, LowestJumpSpeed);
            }
            //��ɫ���ƣ��ȵ���ð���������ĸ���
            if( collision.collider.tag == "Orange")
            {
                rig.velocity = new Vector2(0, DefaultJumpSpeed);
                score++;
                panel.GetComponent<TextMeshProUGUI>().text = score.ToString() + "/" + NumberOfOrange.ToString();                
            }
            //���ƣ��������������յķ�ʽ���֣�����Ϊ��������ݣ���ƽ̨��ȣ�����ʧ�����ɫ������ȣ�������Ծ��
        }
        
    }

}
