using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    private bool isPaused = false;
    public GameObject[] buildings;
    public GameObject player;

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

    public void Play()
    {
        SceneManager.LoadScene("Game");
    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Building"))
        {
            GameObject collidedBuilding = GetCollidedBuilding(other.gameObject);
            if (collidedBuilding != null)
            {
                CollidedWithBuilding(collidedBuilding);
            }
        }
    }

    private GameObject GetCollidedBuilding(GameObject colliderObject)
    {
        foreach (GameObject building in buildings)
        {
            if (building == colliderObject)
            {
                return building;
            }
        }
        return null;
    }

    private void CollidedWithBuilding(GameObject building)
    {
        Debug.Log("Player collided with a building: " + building.name);
        // Add your code here to perform actions when the player collides with a building
    }
}
