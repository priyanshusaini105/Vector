
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameController : MonoBehaviour
{
    
    private bool isPaused = false;
    // public GameObject QuitPanel;

    // void Start()
    // {   
    //     QuitPanel = parentObject.Find("QuitPanel").gameObject; 
    // }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            QuitGame();
        }
    }

    public void QuitGame()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }

    public void PauseGame()
    {
        isPaused = true;
        Time.timeScale = 0f;
    }

    public void ResumeGame()
    {
        isPaused = false;
        Time.timeScale = 1f;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Play(){
        SceneManager.LoadScene("Game");
    }

    public void LoadScene(string sceneName){
        SceneManager.LoadScene(sceneName);
    }
}