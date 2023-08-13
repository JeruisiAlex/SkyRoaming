using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public float jump;
    public float x;
    public float y;
    private int isJump = 1;
    private Rigidbody2D rb;
    private float offset;
    private bool turn;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        offset = 0;
        turn = true;
        isJump = 1;
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        Move();
    }
    private void Move()
    {
        Vector2 f;
        f.x = Input.GetAxis("Horizontal") * speed;
        Debug.Log(isJump);
        if (!turn && f.x>0) Flip();
        else if(turn && f.x<0) Flip();
        if (f.x * offset > 0) f.x = 0;
        if (isJump == 1 )
        {
            f.y = Input.GetAxisRaw("Vertical") * jump;
            if (f.y > 0)
            {
                isJump = 0;
            }
        }
        else
        {
            f.y = rb.velocity.y;
        }
        //Debug.Log(f.x + " "+f.y);
        rb.velocity = new Vector2(f.x, f.y);
        rb.transform.eulerAngles = Vector3.zero;
    }
    private void Flip()
    {
        Vector3 playerScale = rb.transform.localScale;
        playerScale.x *= -1;
        rb.transform.localScale = playerScale;
        turn = !turn;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("PlatForm") || collision.gameObject.CompareTag("Bead"))
        {
            //Debug.Log("002");
            //Debug.Log(collision.gameObject.transform.position.y + " " + collision.gameObject.transform.localScale.y / 2);
            //Debug.Log(rb.transform.position.y+" "+ rb.transform.localScale.y / 2);
            if (collision.gameObject.transform.position.y + collision.gameObject.transform.localScale.y / 2 <= rb.transform.position.y - rb.transform.localScale.y / 2)
            {
                //Debug.Log("001");
                if(isJump == 0) isJump = 1;
                offset = 0;
            }
            else
            {
                offset = collision.gameObject.transform.position.x - rb.transform.position.x;
            }
        }
        else if (collision.gameObject.CompareTag("Ground"))
        {
            BackToOrigin();
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        //Debug.Log("003");
        if (collision.gameObject.CompareTag("PlatForm") || collision.gameObject.CompareTag("Bead"))
        {
            isJump = 0;
            offset = 0;
        }
    }

    private void BackToOrigin()
    {
        rb.transform.position = new Vector2(x, y);
    }
}
