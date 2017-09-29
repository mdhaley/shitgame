using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slime : MonoBehaviour {

    public Text lvl;
    public int lvlValue;

    public Text exp;
    public Text expC;
    public float expCap;
    public int expValue;

    public Text health;
    public Text hunger;
    public int healthValue;
    public int hungerValue;

    public Text water;
    public int waterValue;
    public int thirst;

    public Text food;
    public int foodValue;

    public Text energy;
    public int energyValue;

    public int spcAtk;

    public int spcDef;

    public int speed;

    public int crit;

    public int critDam;

    public float levelTimer;


    void Start()
    {
        Health = 50;
        Food = 50;
        Water = 50;
        Lvl = 1;
        Exp = 0;
        ExpCap = 10;
        levelTimer = 2;
        
    }

    void Update()
    {
        levelTimer = levelTimer - Time.deltaTime;

        if (levelTimer < 0)
        {
            Exp += 1 * Lvl;
            if (Exp >= ExpCap)
            {
                Exp = 0;
                ExpCap = Mathf.RoundToInt(ExpCap * (float) 1.25 * (float) Lvl);
                Lvl++;
            }
            if (Food > Hunger && Water > Thirst)
            {

            }
                levelTimer = 2;
            
        }
    }

    //-------------Lvl-------------------------------------------

    public int Lvl
    {
        get
        {
            return lvlValue;
        }
        set
        {
            lvlValue = value;
            LvlString = value.ToString();
        }

    }

    public string LvlString
    {
        get
        {
            return lvlValue.ToString();
        }
        set
        {
            lvl.text = value;
        }
    }

    //-------------Exp-------------------------------------------

    public int Exp
    {
        get
        {
            return expValue;
        }
        set
        {
            expValue = value;
            EXPString = value.ToString();
        }
    }

    public string EXPString
    {
        get
        {
            return expValue.ToString();
        }
        set
        {
            exp.text = value;
        }
    }

    public float ExpCap
    {
        get
        {
            return expCap;
        }
        set
        {
            expCap = value;
            ExpCapString = value.ToString();
        }
    }

    public string ExpCapString
    {
        get
        {
            return expCap.ToString();
        }
        set
        {
            expC.text = value;
        }
    }

    //-------------Health-------------------------------------------

    public int Health
    {
        get
        {
            return healthValue;
        }
        set
        {
            healthValue = value;
            HealthString = value.ToString();
        }
    }

    public string HealthString
    {
        get
        {
            return healthValue.ToString();
        }
        set
        {
            health.text = value;
        }
    }

    public void takeDamage(int amount)
    {
        Health = Health - amount;
        HealthString = Health.ToString();
    }

    //-------------Water-------------------------------------------

    public int Water
    {
        get
        {
            return waterValue;
        }
        set
        {
            waterValue = value;
            WaterString = value.ToString();
        }
    }

    public string WaterString
    {
        get
        {
            return waterValue.ToString();
        }
        set
        {
            water.text = value;
           
        }
    }

    //-------------Food-------------------------------------------

    public int Food
    {
        get
        {
            return foodValue;
        }
        set
        {
            foodValue = value;
            FoodString = value.ToString();
        }
    }

    public string FoodString
    {
        get
        {
            return foodValue.ToString();
        }
        set
        {
            food.text = value;
        }
    }

    //-------------Energy-------------------------------------------

    public int Energy
    {
        get
        {
            return energyValue;
        }
        set
        {
            energyValue = value;
        }
    }

    public string EnergyString
    {
        get
        {
            return energyValue.ToString();
        }
        set
        {
            energy.text = value;
        }
    }

    //-------------WIP-------------------------------------------

    public int SpecialAtk
    {
        get
        {
            return spcAtk;
        }
        set
        {
            spcAtk = value;
        }
    }

    public int SpecialDef
    {
        get
        {
            return spcDef;
        }
        set
        {
            spcDef = value;
        }
    }

    public int Speed
    {
        get
        {
            return speed;
        }
        set
        {
            speed = value;
        }
    }
}
