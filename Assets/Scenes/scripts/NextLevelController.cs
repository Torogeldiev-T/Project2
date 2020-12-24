using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelController : MonoBehaviour
{
    collectableController cc;
    public void raz(){
        SceneManager.LoadScene(0);
    }
}
