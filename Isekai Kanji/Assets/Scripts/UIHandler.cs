using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIHandler : MonoBehaviour
{
    [SerializeField] SceneLoader sceneLoader;
    private GameObject mainMenu, options, helpCanvas, kanjiCardCanvas;
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
        kanjiCardCanvas = GameObject.Find("KanjiCardCanvas");
        Debug.Log("mainMenu = " + mainMenu);
        Debug.Log("options = " + options);
        Debug.Log("helpCanvas = " + helpCanvas);
        Debug.Log("kanjiCardCanvas = " + kanjiCardCanvas);

        if (options != null)
        {
            options.SetActive(false);
        }

        if (helpCanvas != null)
        {
            helpCanvas.SetActive(false);
        }
        if (kanjiCardCanvas != null)
        {
            kanjiCardCanvas.SetActive(false);
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
                    
                    if (helpCanvas.activeSelf == true)
                    {
                        helpCanvas.SetActive(false);
                        ShowOptions();
                    }

                    if (kanjiCardCanvas.activeSelf == true)
                    {
                        kanjiCardCanvas.SetActive(false);
                        ShowHelpCanvas();
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

    public KanjiCard ShowKanjiCardCanvas()
    {
        kanjiCardCanvas.SetActive(true);
        return kanjiCardCanvas.GetComponentInChildren<KanjiCard>();
    }

}
