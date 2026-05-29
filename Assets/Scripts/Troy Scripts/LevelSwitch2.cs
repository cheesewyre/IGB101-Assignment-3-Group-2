using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSwitch2 : MonoBehaviour
{
    private GameManager2 gameManager;
    public string nextLevel;

    void Start()
    {
        GameObject gmObject = GameObject.FindGameObjectWithTag("GameManager");

        if (gmObject != null)
        {
            gameManager = gmObject.GetComponent<GameManager2>();
        }
        else
        {
            Debug.LogError("No GameObject with the tag 'GameManager' was found.");
        }
    }

    void OnTriggerEnter(Collider otherObject)
    {
        if (otherObject.CompareTag("Player") && gameManager != null && gameManager.levelComplete)
        {
            SceneManager.LoadScene(nextLevel);
        }
    }
}