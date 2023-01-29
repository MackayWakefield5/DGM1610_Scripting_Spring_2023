using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Condiionals : MonoBehaviour
{

    int time = 304;

    public string weather = "clear";

    bool isStopLightRed = false;

    float gpa = 3.2f;

    public double temperature = 101.45d; 



    // Start is called before the first frame update
    void Start()
    {
        //Check time
        if(time >= 200)
        {
            Debug.Log("Rise and Shine!");
        }    
        else
        {
            Debug.Log("It's too early, go back to bed");
        }

        //Check Weather
        if(weather == "cloudy")
        {
            Debug.Log("It is cloudy outside");
        }
        else if(weather == "raining")
        {
            Debug.Log("It is raining outside!");
        }
        else if(weather == "clear")
        {
            Debug.Log("It is a beautiful day outsie!");
        }
        else if(weather == "ThunderLightning")
        {
            Debug.Log("It is thunder and lightning outside, stay inside!!!!");
        }
        else if(weather == "snowing")
        {
            Debug.Log("It is snowing outside, bundle up it is cold");
        }
        else
        {
            Debug.Log("Do what you want, it is a day!");
        }

        //Stop light
        if(isStopLightRed == true)
        {
            Debug.Log("Stop!");
        }
        else
        {
            Debug.Log("Go!");
        }

        //Gpa
        if(gpa >= 3.4)
        {
            Debug.Log("Well done! You're doing great");
        }
        else
        {
            Debug.Log("Work Harder!");
        }

        if(temperature >= 100)
        {
            Debug.Log("It is hot, bring lot's of water!");
        }
        else if(temperature <= 32)
        {
            Debug.Log("It's cold bring a coat!");
        }
        else if(temperature <= 99)
        {
            Debug.Log("It's a beautiful day!");
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
