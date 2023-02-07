using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    public int clickToPop = 3; // How many clicks before pop

    public float scaleToIncrease = 0.10f; // Scale increase when balloon is clicked   

    public ScoreManager scoreManager; // A reference to the score manager

    public int scoreToGive = 100;

    // Start is called before the first frame update
    void Start()
    {
        //Get ScoreManager Component
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }

    void OnMouseDown()
    {
        //Reduce clicks by 1
        clickToPop -= 1;

        //Inflate balloon
        transform.localScale += Vector3.one * scaleToIncrease;

        //Check to see if clickToPop has reached 0. Check to see if baloon pops
        if(clickToPop == 0)
        {
            //Tell the scoremanager to increase score by a certain amount
            scoreManager.IncreaseScoreText(scoreToGive);

            Destroy(gameObject); //Destroy and remove popped balloon
        }

    }
}
