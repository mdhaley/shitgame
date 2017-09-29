using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Water : MonoBehaviour
{


    public int waterValue;
    public bool cooldown;
    public float cooldownTime;
    private int cooldownTimeDisplay;
    public Button b;
    public Slime slime;

    void Start()
    {
        WaterValue = 10;
        cooldown = false;
        cooldownTime = 10;
    }

    void Update()
    {
        if (cooldown == true)
        {
            cooldownTimeDisplay = (int)cooldownTime;
            b.GetComponentInChildren<Text>().text = "Water (" + cooldownTimeDisplay.ToString() + ")";
            cooldownTime = cooldownTime - Time.deltaTime;
        }
        slime.HealthString = slime.Health.ToString();
        if (cooldownTime < 0)
        {
            cooldownTime = 10;
            cooldown = false;
            b.GetComponentInChildren<Text>().text = "Water";
            b.interactable = true;
        }
    }



    public void water()
    {
        if (cooldown == false)
        {
            if (slime.Water < 100)
            {
                slime.Water = slime.Water + WaterValue;
                cooldown = true;
                b.interactable = false;
            }
        }

    }

   
    public int WaterValue
    {
        get
        {
            return waterValue;
        }
        set
        {
            waterValue = value;
        }
    }

}
