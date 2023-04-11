using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace DanDan
{
    public class Flag : MonoBehaviour
    {
        [SerializeField] private SceneLoader sceneLoader;
        [SerializeField] private string nameOfSceneToLoad; 

        private void Start()
        {
            sceneLoader = GameObject.Find("SceneManager").GetComponent<SceneLoader>();
        }
        private void OnTriggerStay2D(Collider2D collider)
        {
            Debug.Log(collider.name + " Entered Flag ");
            if (collider.CompareTag("Player"))
            {
                if(PlayerFlagManager.playersInFlags == 2)
                {
                    Debug.Log("tag wpork");
                    sceneLoader.LoadThisScene(nameOfSceneToLoad);
                }
                
            }
        }
        private void OnTriggerEnter2D(Collider2D collision)
        {
            PlayerFlagManager.playersInFlags++;
        }

        private void OnTriggerExit2D(Collider2D collision)
        {
            PlayerFlagManager.playersInFlags--;
        }
    }

}
