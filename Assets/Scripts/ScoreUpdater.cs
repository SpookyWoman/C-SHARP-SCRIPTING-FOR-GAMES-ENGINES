using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreUpdater : MonoBehaviour
{
    public ScoreSystem scoreSystem;

    public TMPro.TextMeshProUGUI uiLabel;

    public void AddScore()
    {
        scoreSystem.score += 10;

        uiLabel.text = "Score: " + scoreSystem.score;

    }
}
