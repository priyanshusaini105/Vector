using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ColliisonDetection : MonoBehaviour
{
    void Start()
    {
     Debug.Log("Start");   
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
            Debug.Log("Lose");
        if (other.CompareTag("EdgeColliderTag"))
        {
            Lose();
        }
    }

    public void Lose(string isLose="Lose")
    {
        SceneManager.LoadScene(isLose);
    }
}

