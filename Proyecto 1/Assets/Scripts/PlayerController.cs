using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Velocidad de movimiento
    private float speed = 25f;
    // Velocidad de giro
    private float turnSpeed = 20f;

    public float horizontalInput;
    public float verticalInput;

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        // Movimiento hacia delante.
        transform.Translate(translation: Vector3.forward * Time.deltaTime * speed * verticalInput);
        // Rotacion horizontal.
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);
    }
}
