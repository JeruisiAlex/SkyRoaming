using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class tell : MonoBehaviour
{
    public GameObject ch1;
    public GameObject ch2;
    public GameObject ch3;
    public GameObject ch4;
    public GameObject ch5;
    public GameObject ch6;
    public GameObject m1;
    public GameObject m2;
    public GameObject m3;
    public GameObject m4;
    public GameObject m5;
    public GameObject m6;
    // Start is called before the first frame update
    void Start()
    {
        ch1.SetActive(true);
        m1.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) && ch1.activeSelf == false&&ch2.activeSelf == false&&ch3.activeSelf == false&& ch4.activeSelf == false && ch5.activeSelf == false&& ch6.activeSelf == false)
        {
           ch1.SetActive(true);
            m1.SetActive(true);
           
        }
        else if(Input.GetKeyDown(KeyCode.W)&& ch1.activeSelf==true)
        {
            ch1.SetActive(false);
            ch2.SetActive(true);
            m2.SetActive(true);
            m1.SetActive(false);

        }
        else if (Input.GetKeyDown(KeyCode.W) && ch2.activeSelf==true)
        {
            ch2.SetActive(false);
            ch3.SetActive(true);
            m2.SetActive(false);
            m3.SetActive(true);
        }
        else if (Input.GetKeyDown(KeyCode.W) && ch3.activeSelf == true)
        {
            ch3.SetActive(false);
            ch4.SetActive(true);
            m3.SetActive(false);
            m4.SetActive(true);
        }
        else if (Input.GetKeyDown(KeyCode.W) && ch4.activeSelf == true)
        {
            ch4.SetActive(false);
            ch5.SetActive(true);
            m4.SetActive(false);
            m5.SetActive(true);
        }
        else if (Input.GetKeyDown(KeyCode.W) && ch5.activeSelf == true)
        {
            ch5.SetActive(false);
            ch6.SetActive(true);
            m5.SetActive(false);
            m6.SetActive(true);
        }
        else if(Input.GetKeyDown(KeyCode.W) && ch6.activeSelf == true)
        {
            SceneManager.LoadScene("choose");
        }
    }
}
