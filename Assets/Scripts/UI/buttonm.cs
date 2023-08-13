using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonm : MonoBehaviour
{
    public GameObject menuList;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Return()//∑µªÿ”Œœ∑
    {
        Debug.Log("f");
        menuList.SetActive(false);
        Time.timeScale = 1;
    }
}
