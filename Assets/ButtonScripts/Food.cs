using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Food : MonoBehaviour
{


    public int feedValue;
    public bool cooldown;
    public float cooldownTime;
    private int cooldownTimeDisplay;
    public Button b;
    public Slime slime;

    void Start()
    {
        FeedValue = 10;
        cooldown = false;
        cooldownTime = 10;
    }

    void Update()
    {
        if (cooldown == true)
        {
            cooldownTimeDisplay = (int)cooldownTime;
            b.GetComponentInChildren<Text>().text = "Feed (" + cooldownTimeDisplay.ToString() + ")";
            cooldownTime = cooldownTime - Time.deltaTime;
        }
        slime.HealthString = slime.Health.ToString();
        if (cooldownTime < 0)
        {
            cooldownTime = 10;
            cooldown = false;
            b.GetComponentInChildren<Text>().text = "Feed";
            b.interactable = true;
        }
    }



    public void feed()
    {
        if (cooldown == false)
        {
            if (slime.Food < 100)
            {
                slime.Food = slime.Food + FeedValue;
                cooldown = true;
                b.interactable = false;
            }
        }

    }

   


    public int FeedValue
    {
        get
        {
            return feedValue;
        }
        set
        {
            feedValue = value;
        }
    }

}
