using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [Header("Player")]
    public GameObject player;

    [Header("Pickup Logic")]
    public int currentPickups = 0;
    public int maxPickups = 3;
    public bool levelComplete = false;

    [Header("UI")]
    public Text pickupCounter;

    [Header("Audio Proximity")]
    public AudioSource[] audioSources;
    public float audioProximity = 5f;

    void Update()
    {
        LevelCompleteCheck();
        UpdateGUI();
        PlayAudioSamples();
    }

    void LevelCompleteCheck()
    {
        if (currentPickups >= maxPickups)
        {
            levelComplete = true;
        }
        else
        {
            levelComplete = false;
        }
    }

    void UpdateGUI()
    {
        if (pickupCounter != null)
        {
            pickupCounter.text = "Pickups: " + currentPickups + "/" + maxPickups;
        }
    }

    void PlayAudioSamples()
    {
        if (player == null || audioSources == null)
        {
            return;
        }

        for (int i = 0; i < audioSources.Length; i++)
        {
            if (audioSources[i] == null)
            {
                continue;
            }

            float distanceToSample = Vector3.Distance(
                player.transform.position,
                audioSources[i].transform.position
            );

            if (distanceToSample <= audioProximity)
            {
                if (!audioSources[i].isPlaying)
                {
                    audioSources[i].Play();
                }
            }
        }
    }
}