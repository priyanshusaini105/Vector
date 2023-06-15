using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    [SerializeField] private float parallaxEffectMultiplier;
    private Transform cameraTransform;
    private Vector3 lastCameraPosition;

    [SerializeField] private Transform characterTransform; // Reference to the character's transform

    private void Start()
    {
        cameraTransform = Camera.main.transform;
        lastCameraPosition = cameraTransform.position;
    }

    private void LateUpdate()
    {
        Vector3 deltaMovement = cameraTransform.position - lastCameraPosition;

        // Only apply parallax effect in the X direction
        Vector3 parallaxMovement = new Vector3(deltaMovement.x, 0f, 0f);

        transform.position += parallaxMovement * parallaxEffectMultiplier;


        lastCameraPosition = cameraTransform.position;
    }
}
