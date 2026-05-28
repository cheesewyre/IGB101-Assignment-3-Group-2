using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSwitch8 : MonoBehaviour
{
    private GameManager8 gameManager;
    public string nextLevel;

    void Start()
    {
        GameObject gmObject = GameObject.FindGameObjectWithTag("GameController");

        if (gmObject != null)
        {
            gameManager = gmObject.GetComponent<GameManager8>();
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