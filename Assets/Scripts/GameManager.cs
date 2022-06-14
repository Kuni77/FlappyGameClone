using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject finJeuCanva;
    public GameObject finScoreUI;

    private void Start()
    {
        Time.timeScale = 1;
    }

    public void GameOver()
    {
        finScoreUI.SetActive(false);
        finJeuCanva.SetActive(true);
        Time.timeScale = 0;
    }

    public void Recommencer()
    {
        SceneManager.LoadScene(0);
    }
}
