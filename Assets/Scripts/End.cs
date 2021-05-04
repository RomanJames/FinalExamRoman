using UnityEngine;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour
{
    public void RestartGame()
    {

        SceneManager.LoadScene("1Intro");
    }

    public void Quit()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }

}
