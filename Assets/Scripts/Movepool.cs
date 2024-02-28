using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movepool : MonoBehaviour
{
    public int maxhealth = 100;
    public int currenthealth = 100;
    public (player health bar) healthbar;

    public void Ember()
    {
        string type = "Fire";
        if (Protect = false)
        {
            currenthealth = (currenthealth - 15);
            healthbar.fillAmount = (float)currenthealth / (float)maxhealth;
        }
        else
        {
            Protect = false;
        }
    }
    public void Tackle()
    {
        string type = "Normal";
        if (Protect = false)
        {
            currenthealth = (currenthealth - 15);
            healthbar.fillAmount = (float)currenthealth / (float)maxhealth;
        }

    }
    public void WildCharge()
    {
        string type = "Electric";
        if (Protect = false)
        {
            currenthealth = (currenthealth - 15);
            healthbar.fillAmount = (float)currenthealth / (float)maxhealth;
        }

    }

    public void Protect()
    {
        string type = "Normal";
        Protect = true;

    }

    public void healthdamage()
    {
        healthbar.fillAmount = (float)currenthealth / (float)maxhealth;
    }
}
