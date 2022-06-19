using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIButtons : MonoBehaviour
{
    public void AppstoreBtn()
    {
        Debug.Log("Appstore Button Pressed");
        Application.OpenURL("https://apps.apple.com/us/app/cat-escape/id1536578421");
    }

    public void GooglePlayBtn()
    {
        Debug.Log("Google Play Btn pressed");
        Application.OpenURL("https://play.google.com/store/apps/details?id=gg.sunday.catescape&hl=en&gl=US");
    }

    public void Restart()
    {
        Debug.Log("Restart Btn Pressed");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
