using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Points : MonoBehaviour
{
    public Text Score;
    public int score;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Score.text = "Score: " + score;
    }

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "Obstacle")
        {
            score++;
        }
    }
}
