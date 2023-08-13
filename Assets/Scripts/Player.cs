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
    private Rigidbody2D rb;
    private bool isJump;
    private float offset;
    private bool turn;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        isJump = false;
        offset = 0;
        turn = true;
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
        if(!turn && f.x>0) Flip();
        else if(turn && f.x<0) Flip();
        if (f.x * offset > 0) f.x = 0;
        if (isJump == true)
        {
            f.y = Input.GetAxisRaw("Vertical") * jump;
        }
        else
        {
            f.y = rb.velocity.y;
        }
        //Debug.Log(f.x + " "+f.y);
        rb.velocity = new Vector2(f.x, f.y);
        rb.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
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
            Debug.Log(collision.gameObject.transform.position.y + " " + collision.gameObject.transform.localScale.y / 2);
            Debug.Log(rb.transform.position.y+" "+ rb.transform.localScale.y / 2);
            if (collision.gameObject.transform.position.y + collision.gameObject.transform.localScale.y / 2 <= rb.transform.position.y - rb.transform.localScale.y / 2)
            {
                //Debug.Log("001");
                isJump = true;
                offset = 0;
            }
            else
            {
                isJump = false;
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
        if (collision.gameObject.CompareTag("PlatForm") || collision.gameObject.CompareTag("Bead"))
        {
            isJump = false;
            offset = 0;
        }
    }

    private void BackToOrigin()
    {
        rb.transform.position = new Vector2(x, y);
    }
}
