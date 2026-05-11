using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Doortest : MonoBehaviour
{
    Animation dooranimation;
    // Start is called before the first frame update
    void Start()
    {
        dooranimation = GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("f"));
        dooranimation.Play();

    }
}
