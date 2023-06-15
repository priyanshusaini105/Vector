using UnityEngine;

public class BotPlayer : MonoBehaviour
{
    public Transform mainPlayer;

    public float movementSpeed = 5f;

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
}
