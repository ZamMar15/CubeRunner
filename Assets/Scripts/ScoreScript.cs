using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public Text scoreText;
    public Text finalGameScore;
     int myScore = 0;
   
    // Update is called once per frame
    void Update()
    {

       scoreText.text = myScore.ToString();
        finalGameScore.text = "Score :"+ myScore.ToString();
     
    }
    public void addScore(int score)
    {
        myScore += score;
    }
}
