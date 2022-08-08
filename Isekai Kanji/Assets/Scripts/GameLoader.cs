using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameLoader : MonoBehaviour
{
    [SerializeField] Button start, quit;
    [SerializeField] ScoreManager scoreManager;
    string activeSceneName;
    // Start is called before the first frame update
    private void Awake()
    {
        activeSceneName = SceneManager.GetActiveScene().name;
    }
    void Start()
    {
        start.onClick.AddListener(LoadMainLevel);
        quit.onClick.AddListener(ExitGame);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            switch (activeSceneName)
            {
                case "MainGame":
                    LoadMainMenu();
                    break;
                case "GameOver":
                    LoadMainMenu();
                    break;
                default:
                    ExitGame();
                    break;
                    
            }
        }
        if (scoreManager != null && scoreManager.Lives == 0)
        {
            LoadGameOver();
        }
    }

    public void LoadMainLevel()
    {
        SceneManager.LoadScene("MainGame");
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Application Exited");
    }

    public void LoadGameOver()
    {
        SceneManager.LoadScene("GameOver");
    }
}
