using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class GameManager : MonoBehaviour
{
    public Text inputFieldText;
    
    public void StartGame()
    {
        if(GameData.Instance != null)
        {
            GameData.Instance.currentPlayer = inputFieldText.text;
        }
        SceneManager.LoadScene(1);
    }
    public void ExitGame()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); // original code to quit Unity player
#endif
    }
    public void CleanBestScore()
    {
        if (GameData.Instance != null)
        {
            GameData.Instance.bestScore = 0;
            GameData.Instance.playerName = " ";
            GameData.Instance.SaveHighScoreText();
            GameData.Instance.LoadHighScoreText();
            Debug.Log(GameData.Instance.bestScore + GameData.Instance.playerName);
        }
        
    }

}
