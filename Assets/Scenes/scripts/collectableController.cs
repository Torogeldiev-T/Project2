using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class collectableController : MonoBehaviour
{
    public Text score;
    int currentScore = 0;
    public GameObject obj;
    public GameObject prefap;
    void Start()
    {
         score.text = currentScore.ToString();
    }

    void OnCollisionEnter(Collision collision) {
        GameObject gameObject = collision.gameObject;
        if(gameObject.CompareTag("Player")){
            Destroy(obj);
            currentScore = int.Parse(score.text);
            currentScore++;
            float x = Random.Range(-3,3f);
            float y = Random.Range(5f,5.5f);
            float z = Random.Range(-3f,3f);
            Instantiate(prefap,new Vector3(x,y,z),Quaternion.Euler(0.0f, 5f, 133f));
            score.text = currentScore.ToString();
        }
                
    }

    void Update()
    {
        
    }
}
