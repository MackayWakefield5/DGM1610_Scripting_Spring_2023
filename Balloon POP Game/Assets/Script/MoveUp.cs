using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUp : MonoBehaviour
{
    public float moveSpeed = 2.0f;

    public float upperBound = 15f;

    public ScoreManager scoreManager; // A reference to scoreManager

    public Balloon balloon; // Reference to balloon script to get score

    
    // Start is called before the first frame update
    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();

        balloon = GetComponent<Balloon>();
    }

    // Update is called once per frame
    void Update()
    {
        //Make balloon float upward
        transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);

        if(transform.position.y > upperBound)
        {
            scoreManager.DecreaseScoreText(balloon.scoreToGive); //Reduces score for allowing balloon to leave screen

            Destroy(gameObject); //pops balloon
        }
    }
}
