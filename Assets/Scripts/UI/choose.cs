using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class choose : MonoBehaviour
{
    public GameObject Prompt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Returns()
    {
        Debug.Log("aaa");
        SceneManager.LoadScene(0);
    }
    public void FirstPlay()
    {
        Debug.Log("1");
        SceneManager.LoadScene("Game1");
        Time.timeScale = 1;
    }
    public void SecondPlay()
    {
        Debug.Log("1");
        SceneManager.LoadScene("Game2");
        Time.timeScale = 1;
    }
    public void Otherp()
    {
        Prompt.SetActive(true);
    }
}
