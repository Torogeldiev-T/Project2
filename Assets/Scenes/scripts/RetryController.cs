﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class RetryController : MonoBehaviour
{

    public void OnPlayButtonClicked(){
        SceneManager.LoadScene(2);
    }
}