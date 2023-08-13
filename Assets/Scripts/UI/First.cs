using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class First : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Nextstart()
    {
        SceneManager.LoadScene("choose");
    }
    public void Exit()
    {
        Application.Quit();
        Debug.Log("ÍË³ö");
    }
}
