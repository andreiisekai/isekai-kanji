using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIHandler : MonoBehaviour
{
    [SerializeField] SceneLoader sceneLoader;
    private GameObject mainMenu, options, helpCanvas;
    string activeSceneName;


    void Awake()
    {
        activeSceneName = SceneManager.GetActiveScene().name;
    }

    private void Start()
    {
        mainMenu = GameObject.Find("MainMenuCanvas");
        options = GameObject.Find("OptionsCanvas");
        helpCanvas = GameObject.Find("HelpCanvas");
        Debug.Log("mainMenu = " + mainMenu);
        Debug.Log("options = " + options);
        Debug.Log("helpCanvas = " + helpCanvas);
        if (options != null)
        {
            options.SetActive(false);
        }

        if (helpCanvas != null)
        {
            helpCanvas.SetActive(false);
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
                    if (options.activeSelf == true && helpCanvas.activeSelf == false)
                    {
                        ShowMainMenu();
                    }
                    else if (options.activeSelf == false && helpCanvas.activeSelf == true)
                    {
                        helpCanvas.SetActive(false);
                        ShowOptions();
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

    public void ShowHelpCanvas()
    {
        options.SetActive(false);
        helpCanvas.SetActive(true);
    }

}