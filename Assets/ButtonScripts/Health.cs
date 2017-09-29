using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour {

    
    public int healValue;
    public bool cooldown;
    public float cooldownTime;
    private int cooldownTimeDisplay;
    public Button b;
    public Slime slime;

    void Start()
    {
        HealValue = 10;
        cooldown = false;
        cooldownTime = 10;
    }
   
    void Update()
    {
        if (cooldown == true)
        {
            cooldownTimeDisplay = (int)cooldownTime;
            b.GetComponentInChildren<Text>().text = "Heal ("+ cooldownTimeDisplay.ToString() +")";
            cooldownTime = cooldownTime - Time.deltaTime;
        }
        slime.HealthString = slime.Health.ToString();
        if (cooldownTime < 0)
        {
            cooldownTime = 10;
            cooldown = false;
            b.GetComponentInChildren<Text>().text = "Heal";
            b.interactable = true;
        }
    }

    

   public void heal()
    {
        if (cooldown == false) {
            if (slime.Health < 100)
            {
                slime.Health = slime.Health + HealValue;
                cooldown = true;
                b.interactable = false;
            }
        }

    }

    public string formatHealth(int change)
    {
        return "Health: " + change.ToString();
    }

   
    public int HealValue
    {
        get{
            return healValue;
        }
        set
        {
            healValue = value;
        }
    }
   
}
