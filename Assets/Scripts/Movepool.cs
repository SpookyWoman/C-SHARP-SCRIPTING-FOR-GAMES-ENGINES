using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movepool : MonoBehaviour
{
    public int maxhealth = 100;
    public int currenthealth = 100;
    public image healthbar;

    public void Ember()
    {
        string type = "Fire";
        if (boolean Protect = false)
        {
            currenthealth = currenthealth - 15;
            healthbar.fillAmount = (float)currenthealth / (float)maxhealth;
        }
        else
        {
            boolean Protect = false
        }
    }
    public void Tackle()
    {
        string type = "Normal";
        if (boolean Protect = false)
        {
            currenthealth = currenthealth - 15;
            healthbar.fillAmount = (float)currenthealth / (float)maxhealth;
        }

    }
    public void WildCharge()
    {
        string type = "Electric";
        if (boolean Protect = false)
        {
            currenthealth = currenthealth - 15;
            healthbar.fillAmount = (float)currenthealth / (float)maxhealth;
        }

    }

    public void Protect()
    {
        string type = "Normal";
        boolean Protect = true

    }

    public void healthdamage()
    {
        healthbar.fillAmount = (float)currenthealth / (float)maxhealth;
    }
}
