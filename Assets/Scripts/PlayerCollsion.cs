using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class PlayerCollsion : MonoBehaviour
{
    public ScoreScript scoreScript;
    public PlayerScript playerScript;
    public GameController gameController;
    public AudioSource audioSource;
    public AudioSource audioSource1;
   
  
  

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Collectables")
        {
            audioSource.Play();
            
            scoreScript.addScore(1);
            Destroy(other.gameObject);
        }
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            audioSource1.Play();
           gameController.GameOver();
             
            playerScript.enabled = false;
        }
    }
}
