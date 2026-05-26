using UnityEngine;

public class Pickup2 : MonoBehaviour
{
    private GameManager2 gameManager;

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