using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CanvasManager : MonoBehaviour
{
    public bool isPaused;
    [SerializeField] private Button _continueBtn;
    [SerializeField] private Button _mainMenuBtn;
    [SerializeField] private Button _quitBtn;
    
    public void QuitGame()
    {
#if UNITY_EDITOR
        EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
    
    
    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    
    public void PauseGame()
    {
        if (!isPaused)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                    
                Time.timeScale = 0.0f;
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.None;
                _continueBtn.gameObject.SetActive(true);
                _mainMenuBtn.gameObject.SetActive(true);
                _quitBtn.gameObject.SetActive(true);
                isPaused = true;
            }
        }
    }

    public void UnPauseGame()
    {
        Time.timeScale = 1.0f;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Locked;
        _continueBtn.gameObject.SetActive(false);
        _mainMenuBtn.gameObject.SetActive(false);
        _quitBtn.gameObject.SetActive(false);
        isPaused = false;
    }
    
    
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        _continueBtn.gameObject.SetActive(false);
        _mainMenuBtn.gameObject.SetActive(false);
        _mainMenuBtn.onClick.AddListener(GoToMainMenu);
        _continueBtn.onClick.AddListener(UnPauseGame);
        _mainMenuBtn.onClick.AddListener(QuitGame);
        _quitBtn.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        PauseGame();
    }
}
