using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//ui 관련 라이브러리
using UnityEngine.SceneManagement;// 씬 관리 관련 라이브러리

public class GameManager : MonoBehaviour
{
    public GameObject gameoverText;
    public Text timeText;
    public Text recordText;

    private float surviveTime;
    private bool isGameover;
    // Start is called before the first frame update
    void Start()
    {
        surviveTime = 0;
        isGameover = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isGameover)
        {
            surviveTime += Time.deltaTime;
            timeText.text = "Time:" + (int)surviveTime;
        }
        else
        {
            if(Input.GetKeyDown(KeyCode.R)
                {
                SceneManager.LoadScene("SampleScene");
                    }
        }
    }
}
