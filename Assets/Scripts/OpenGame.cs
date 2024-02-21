using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenGame : MonoBehaviour
{

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
}
