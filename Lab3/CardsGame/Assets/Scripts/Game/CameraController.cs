﻿using UnityEngine;

/// <summary>
/// Controls the camera's movement and rotation based on player input.
/// </summary>
public class CameraController : MonoBehaviour
{
    /// <summary>
    /// The speed at which the camera moves.
    /// </summary>
    public float moveSpeed = 5.0f;

    /// <summary>
    /// The speed at which the camera rotates.
    /// </summary>
    public float rotationSpeed = 3.0f;

    /// <summary>
    /// Update is called once per frame to handle camera movement and rotation.
    /// </summary>
    void Update()
    {
        if (GameBoardController.Instance.canWalk)
        {
            float horizontalInput = Input.GetAxis("Horizontal");
            float verticalInput = Input.GetAxis("Vertical");

            Vector3 moveDirection = new Vector3(horizontalInput, 0, verticalInput);
            transform.Translate(moveDirection * moveSpeed * Time.deltaTime);

            if (Input.GetKey(KeyCode.Q))
            {
                transform.Rotate(Vector3.up, -rotationSpeed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.E))
            {
                transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
            }
        }
    }
}
