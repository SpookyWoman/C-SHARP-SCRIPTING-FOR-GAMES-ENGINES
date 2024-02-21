using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Overlap : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Cave"))
        {
            SceneManager.LoadScene(4);
        }
        else if (collision.CompareTag("Encounter"))
        {
            Debug.Log("hit an encounter obj");
            float randomChance = Random.value;

            if (randomChance <= 0.01f)
            {
                Debug.Log("load the scene");
                SceneManager.LoadScene(3);
            }

        }
        else if (collision.CompareTag("CaveEncounter"))
        {
            Debug.Log("hit an encounter obj");
            float randomChance = Random.value;

            if (randomChance <= 0.009f)
            {
                Debug.Log("load the scene");
                SceneManager.LoadScene(3);
            }

        }
        if (collision.CompareTag("leavecave"))
        {
            SceneManager.LoadScene(1);
        }
    }

}