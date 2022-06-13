using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        switch(other.gameObject.tag)
        {
            case "Friendly":
                Debug.Log("This thing is Friendly");
                break;  
            case "Finish":
                Debug.Log("Victory!");
                break;
            case "Fuel":
                Debug.Log("Fuel Acquired");
                break;
            default:
                ReloadLevel();
                break;   

        }
    }
    void ReloadLevel()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex );
    }
}
