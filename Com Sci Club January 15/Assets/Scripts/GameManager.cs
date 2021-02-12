using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI text;

    public void FinishedGame()
    {
        Debug.Log("FinishedGame");
        Invoke("LoadingNextLevel", 2f);
    }

    public void LoadingNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void GameOver()
    {
        Debug.Log("Game Over");
        Invoke("Restart", 2f);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void UpdateScore(double score)
    {
        text.text = "Score: " + score.ToString(".0");
    }
}
