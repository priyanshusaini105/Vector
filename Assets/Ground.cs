using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ground : MonoBehaviour
{
     private Rigidbody2D player;

    void Start()
    {
        player = GameObject.FindWithTag("Player").GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            EndGame();
        }
    }

    

    void Log(string msg)
    {
        Debug.Log(msg);
    }

    void EndGame()
    {
        SceneManager.LoadScene("EndGame");
    }
}
