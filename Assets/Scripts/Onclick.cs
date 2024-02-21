using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Onclick : MonoBehaviour
{
    public void OpenBag()
    {
        SceneManager.LoadScene(2);
    }
    public void Run()
    {
        //ends battle
        SceneManager.LoadScene(1);
    }
    public void Openpokemon()
    {
        SceneManager.LoadScene(2);
    }

    public void fight()
    {
        SceneManager.LoadScene(2);
    }
}
