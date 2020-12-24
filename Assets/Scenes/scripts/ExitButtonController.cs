using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitButtonController : MonoBehaviour
{
    
    public void OnPlayButtonClicked(){
        Application.Quit();
    }
}
