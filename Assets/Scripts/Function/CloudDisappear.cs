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

    private void Start()
    {
        //获取玩家身上挂载的Rigidbody组件
        player = GameObject.FindWithTag("Player");
        rig = player.GetComponent<Rigidbody2D>();
        score = 0;
        //获取UI的文本信息
        panel = GameObject.FindWithTag("Score");

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {   
        //如果玩家在云朵的上方（如果玩家踩到的是云朵的左右和下方，则不会引起跳跃）
        if(collision.gameObject.transform.position.y + collision.gameObject.transform.localScale.y/2 <= player.transform.position.y - player.transform.localScale.y / 3)
        {
            //白色碎云：一踩就散，踩后复原，可借力跳跃
            if (collision.collider.tag == "White")
            {
                rig.velocity = new Vector2(0,DefaultJumpSpeed);
            }
            //浅黄色碎云：基本特性与白色碎云相似，但踩上会跳更高
            if (collision.collider.tag == "LightYellow")
            {
                rig.velocity = new Vector2(0, HighestJumpSpeed);
            }
            //深黄色碎云：基本特性与白色碎云相似，但踩上会跳更低
            if(collision.collider.tag == "DarkYellow")
            {
                rig.velocity = new Vector2(0, LowestJumpSpeed);
            }
            //橘色碎云：踩到会冒出奇妙的字母金币
            if( collision.collider.tag == "Orange")
            {
                score++;
                panel.GetComponent<TextMeshProUGUI>().text = score.ToString();
                rig.velocity = new Vector2(0, DefaultJumpSpeed);
            }
            //珠云：往往以连串紧凑的方式出现，可作为桥梁或阶梯（与平台相比，会消失；与白色碎云相比，不会跳跃）
        }
        
    }

}
