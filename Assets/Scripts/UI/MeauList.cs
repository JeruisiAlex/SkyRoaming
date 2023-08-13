using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MeauList : MonoBehaviour
{
    public GameObject menuList;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)&& menuList.activeSelf == false)
        {
            menuList.SetActive(true);
            Time.timeScale = 0;//时间暂停
            
        }
        else if (Input.GetKeyDown(KeyCode.Escape)&&menuList.activeSelf==true)
        {
            menuList.SetActive(false);
            Time.timeScale = 1;//时间恢复
            
        }
        
        
    }
    public void Return()//返回游戏
    {
        Debug.Log("f");
        menuList.SetActive(false);
        Time.timeScale = 1;
    }
    public void Restart()
    {
        Debug.Log("f");
        SceneManager.LoadScene("choose");
       // menuList.SetActive(false);
        //Debug.Log(menuList.activeSelf);
        Time.timeScale = 1;
    }
    public void Exit()
    {
        Debug.Log("f");
        SceneManager.LoadScene("main");
        Time.timeScale = 1;
    }
}
