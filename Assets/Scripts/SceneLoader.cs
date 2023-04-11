using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void Level1()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void Level2()
    {
        SceneManager.LoadScene("Level 2");
    }

    public void Level3()
    {
        SceneManager.LoadScene("Level 3");
    }

    public void GameOver() 
    {
        SceneManager.LoadScene("GameOver");
    }

    public void LoadThisScene(string sceneToLoad)
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
