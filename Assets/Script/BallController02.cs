using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BallController02 : MonoBehaviour {

    private GameObject scoreText;

    int score = 0; 
    int[] points = { 10, 20, 30, 40 };
           
    
	// Use this for initialization
	void Start () {

        this.scoreText = GameObject.Find("ScoreText");
        this.scoreText.GetComponent<Text>().text = "Score: " + score;

                           
	}
	
	// Update is called once per frame
	void Update () {

        this.scoreText.GetComponent<Text>().text = "Score: " + score;

    }

    void OnCollisionEnter(Collision other)
    {
        
        if (other.gameObject.tag == "SmallStarTag")
        {
            this.score += points[0];

        }
        else if (other.gameObject.tag == "LargeStarTag")
        {
            this.score += points[1];

        }
        else if (other.gameObject.tag == "SmallCloudTag")
        {
            this.score += points[2];

        }
        else if (other.gameObject.tag == "LargeCloudTag")
        {
            this.score += points[3];
        }
    }
}
