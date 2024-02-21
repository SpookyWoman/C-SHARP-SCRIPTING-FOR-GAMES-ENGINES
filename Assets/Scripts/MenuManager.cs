using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject m_controls_settings_panel;
    bool isCSPanelOpen = false;
    public void Openlevel(int Index)
    {
        SceneManager.LoadScene(Index);
        //print("Scene count: " + SceneManager.sceneCount);
        //for (int i = 0; i < SceneManager.sceneCount; i++)
        //{
        //   Scene scene = SceneManager.GetSceneAt(i);
        //    print($"Scene {i}: {scene.name}");
        //}
        //
        //SceneManager.LoadScene(sceneName);
        //SceneManager.LoadScene(Index);
    }
    public void OpenAndCloseSettingsPanel() 
    {
        //was gonna just make a box visable but decided just to make it, its own screen
        SceneManager.LoadScene(2);
    }
    public void QuitGame()
    {
        Application.Quit();
    }

}
