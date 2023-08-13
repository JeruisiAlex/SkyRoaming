using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldCoin : MonoBehaviour
{
    // Start is called before the first frame update
    public int count;
    public int x;
    public int y;
    void Start()
    {
        count= 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (count > 0)
        {
            count--;
        }
        else if (count == 0)
        {
            transform.position = new Vector2(x,y);
        }
    }
}
