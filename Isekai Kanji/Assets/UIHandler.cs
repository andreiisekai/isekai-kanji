using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIHandler : MonoBehaviour
{
    [SerializeField] SceneLoader sceneLoader;
    private GameObject mainMenu, options, hiragana, katakana, jlptn5;
    string activeSceneName;

    void Awake()
    {
        activeSceneName = SceneManager.GetActiveScene().name;
    }

    private void Start()
    {
        mainMenu = GameObject.Find("MainMenuCanvas");
        options = GameObject.Find("OptionsCanvas");
        Debug.Log("mainMenu = " + mainMenu);
        Debug.Log("options = " + options);
        if (options != null)
        {
            options.SetActive(false);
        }
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
                case "MainMenu":
                    if (options.activeSelf == true)
                    {
                        ShowMainMenu();
                    }
                    else
                    {
                        QuitGame();
                    }
                    break;
                default:
                    QuitGame();
                    break;

            }
        }
    }

    public void StartGame()
    {
        sceneLoader.LoadMainLevel();
    }

    public void QuitGame()
    {
        sceneLoader.ExitGame();
    }

    public void ShowOptions()
    {
        mainMenu.SetActive(false);
        options.SetActive(true);
    }

    public void LoadMainMenu()
    {
        sceneLoader.LoadMainMenu();
    }
    public void ShowMainMenu()
    {
        options.SetActive(false);
        mainMenu.SetActive(true);
    }

    public void JLPTN5Help()
    {

    }

}
