using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreUi : MonoBehaviour
{
    public ScoreSystem scoreSystem;

    public TMPro.TextMeshProUGUI uiLabel;

    // Update is called once per frame
    public void Update()
    {
        uiLabel.text = "Score: " + scoreSystem.score;
    }
}
