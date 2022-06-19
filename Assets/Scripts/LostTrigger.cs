using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LostTrigger : MonoBehaviour
{

    public GameManager gameManager;

    AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (gameManager.isUIActive)
        {
            return;
        }
        
        if (other.gameObject.tag == "Player")
        {
            audioSource.Play();
            gameManager.GameLost();
        }
    }

}
