using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cartoon : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        Scene nowscene = SceneManager.GetActiveScene();
        Debug.Log(nowscene);
    }

    // Update is called once per frame
    void Update()
    {
        Scene nowscene = SceneManager.GetActiveScene();
        if (transform.position.x > 50&&SceneManager.sceneCount<2)
        {
            Time.timeScale = 0;
            SceneManager.LoadScene("cartool", LoadSceneMode.Additive);

        }
    }
    private void LateUpdate()
    {
        
    }
}
