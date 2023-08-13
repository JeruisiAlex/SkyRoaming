using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class play2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < 1.8 && transform.position.y > 23 & SceneManager.sceneCount < 2)
        {
            Time.timeScale = 0;
            SceneManager.LoadScene("choose");

        }
    }
}
