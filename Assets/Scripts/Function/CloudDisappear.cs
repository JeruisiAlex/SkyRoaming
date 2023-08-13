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
        player = GameObject.FindWithTag("Player");
        rig = player.GetComponent<Rigidbody2D>();
        score = 0;
        //找到计分UI
        panel = GameObject.FindWithTag("Score");

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {   
        //玩家仅站在平台上方时可以触发跳跃buff
        if(collision.gameObject.transform.position.y<= rig.transform.position.y - rig.transform.localScale.y / 2)
        {
            if(collision.collider.tag != "PlatForm" && collision.collider.tag != "Bead" ) collision.gameObject.GetComponent<AudioSource>().Play();
            //白色碎云：一踩就跳
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
            if (collision.collider.tag == "DarkYellow")
            {
                
                rig.velocity = new Vector2(0, LowestJumpSpeed);
            }
            //橘色碎云：踩到会冒出奇妙的金币，并在计分UI上计分。橘云一踩则消失，消失后永久变为白色碎云。
            if ( collision.collider.tag == "Orange")
            {
                rig.velocity = new Vector2(0, DefaultJumpSpeed);
                score++;
                panel.GetComponent<TextMeshProUGUI>().text = score.ToString() + "/" + NumberOfOrange.ToString();                
            }
            //珠云：往往以连串紧凑的方式出现，可作为桥梁或阶梯
        }

    }

}
