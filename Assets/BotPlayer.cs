using UnityEngine;
using UnityEngine.SceneManagement;

public class BotPlayer : MonoBehaviour
{
    public Transform mainPlayer;

    public float minSpeed = 4f; // Minimum movement speed
    public float maxSpeed = 6.8f; // Maximum movement speed

    private float movementSpeed;

    void Start()
    {
        // Generate a random movement speed between the specified range
        movementSpeed = Random.Range(minSpeed, maxSpeed);
    }

    void Update()
    {
        if (mainPlayer != null)
        {
            // Calculate the direction from the bot player to the main player
            Vector3 direction = mainPlayer.position - transform.position;

            // Normalize the direction vector to get a consistent movement speed
            direction.Normalize();

            // Move the bot player towards the main player
            transform.position += direction * movementSpeed * Time.deltaTime;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene("EndGame");
        }
    }
}
