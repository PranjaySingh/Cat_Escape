using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject gameWinPanel;
    public GameObject gameOverPanel;
    public GameObject timeUpPanel;

    public GameObject tutorialPanel;

    public bool isUIActive;
    public float gameplayTime;

    [SerializeField] Animator animationController;


    public void Start()
    {
        gameWinPanel.SetActive(false);
        timeUpPanel.SetActive(false);
        gameOverPanel.SetActive(false);
        isUIActive = false;
        gameplayTime = 20.0f;
        
    }

    public void GameWon()
    {
        Debug.Log(".....Game Win.....");
        gameWinPanel.SetActive(true);
        animationController.SetBool("IsMoving", false);
        isUIActive = true;
    }

    public void GameLost()
    {
        gameOverPanel.SetActive(true);
        animationController.SetBool("IsMoving", false);
        isUIActive = true;
    }

    public void TimeUP()
    {
        timeUpPanel.SetActive(true);
        animationController.SetBool("IsMoving", false);
        isUIActive = true;
    }

    private void Update()
    {
        if (isUIActive)
        {
            return;
        }


        if (gameplayTime > 0)
        {
            gameplayTime -= Time.deltaTime;
        }
        else
        {
            TimeUP();
        }
    }

}
