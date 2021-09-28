using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    int score = 0;
    private GameObject ScoreText;
    // Start is called before the first frame update
    void Start()
    {

        this.ScoreText = GameObject.Find("ScoreText");

    }

    // Update is called once per frame
    void Update()
    {
        this.ScoreText.GetComponent<Text>().text = "Score:"+ score.ToString() ;
    }
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "SmallStarTag")
        {
         score += 10;
        }

        if (collision.gameObject.tag == "LargeStarTag")
        {
            score += 20;
        }

        if (collision.gameObject.tag == "SmallCloudTag")
        {
            score += 10;
        }

        if (collision.gameObject.tag == "LrageCloudTag")
        {
            score += 20;
        }
    }
}
