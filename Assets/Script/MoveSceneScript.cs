﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveSceneScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //ゲームクリアのとき
    public void MoveGameClear()
    {
        SceneManager.LoadScene("Scene1");
    }

    //ゲームオバーの時
    public void MoveGameOver()
    {
        SceneManager.LoadScene("Scene2");
    }
}
