using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class DoorControl : MonoBehaviour
{
    public GameObject intText;
    public float interactionDistance;
    public string doorOpenAnimName, doorCloseAnimName;
    public AudioClip doorAudio;
    public Animator playerAnim;
    // Update is called once per frame
    void Update()
    {
     Ray ray = new Ray(transform.position, transform.forward);

        RaycastHit hit;
    if (Physics.Raycast(ray, out hit, interactionDistance))
        {
            if (hit.collider.gameObject.tag == "Door")
            {
                GameObject doorParent = hit.collider.transform.root.gameObject;

                Animator doorAnim = doorParent.GetComponent<Animator>();

                AudioSource doorSound = hit.collider.gameObject.GetComponent<AudioSource>();

                intText.SetActive(true);

                if (Input.GetKeyDown(KeyCode.F))
                {
                    doorSound.Play();
                    

                    if (doorAnim.GetBool("Open") == false)
                    {
                        doorAnim.SetBool("Open", true);
                        
                        playerAnim.SetTrigger("Open");
                        
                    }
                    else
                    {
                        doorAnim.SetBool("Open", false);
                        playerAnim.SetTrigger("Close");
                        
                    }
                }
            
            }
            else
            {
                intText.SetActive(false);
                
               
            }
        }
            
        else
            {
                intText.SetActive(false);
            
        }
    }
    
        
 }

