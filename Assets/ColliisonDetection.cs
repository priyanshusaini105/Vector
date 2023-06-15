using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ColliisonDetection : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("EdgeColliderTag"))
        {
            lose();
        }
    }

    public void lose(string isLose="Lose")
    {
        SceneManager.LoadScene(isLose);
    }
}

