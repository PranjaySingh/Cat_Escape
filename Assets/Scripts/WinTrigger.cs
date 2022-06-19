using UnityEngine;

public class WinTrigger : MonoBehaviour
{
    public GameManager gameManager;

    AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter()
    {
        if (gameManager.isUIActive)
        {
            return;
        }

        audioSource.Play();
        gameManager.GameWon();
    }
}
