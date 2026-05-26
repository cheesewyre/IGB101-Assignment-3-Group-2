using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSwitchPat9 : MonoBehaviour
{
    private GameManager9 gameManager;
    public string nextLevel;

    void Start()
    {
        GameObject gmObject = GameObject.FindGameObjectWithTag("GameManager");

        if (gmObject != null)
        {
            gameManager = gmObject.GetComponent<GameManager9>();
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