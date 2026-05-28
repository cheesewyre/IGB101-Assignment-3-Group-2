using UnityEngine;

public class Pickup8 : MonoBehaviour
{
    private GameManager8 gameManager;

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
        if (otherObject.CompareTag("Player"))
        {
            if (gameManager != null)
            {
                gameManager.currentPickups += 1;
            }

            Destroy(gameObject);
        }
    }
}