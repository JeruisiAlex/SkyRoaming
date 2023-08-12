using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    public float x;
    public float y;
    public float z;
    public float width;
    public float height;
    public float minWidDistance;
    public float minHiDistance;
    private Vector3 p;
    private float wiDistance;
    private float heightDistance;
    void Start()
    {
        p = new Vector3(x, y, z);
        transform.position = p;
        wiDistance = width / 2 - minWidDistance;
        heightDistance = height / 2 - minHiDistance;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (transform.position.x + wiDistance < player.transform.position.x)
        {
            p.x = player.transform.position.x - wiDistance;
        }
        else if (transform.position.x - wiDistance > player.transform.position.x)
        {
            p.x = player.transform.position.x + wiDistance;
        }
        if (transform.position.y + heightDistance < player.transform.position.y)
        {
            p.y = player.transform.position.y - heightDistance;
        }
        else if (transform.position.y - heightDistance > player.transform.position.y)
        {
            p.y = player.transform.position.y + heightDistance;
        }
        transform.position = p;
    }
}
