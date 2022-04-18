using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private CharacterController player;  //Controlador del Player
    private Vector movement;  // movimento del vector
    private float xMov, zMov;  // Movimiento de X y de Y
    
    void Start()
    {
        player = GetComponent<CharacterController>();
    }

    void Update()
    {
        xMov = Input.GetAxisRaw("Horizontal") * speed;
        zMov = Input.GetAxisRaw("Vertical") * speed;

        movement = new Vector3(xMov, 0, zMov);
        movement = movement.normalized * Time.deltaTime;

        player.Move(movement);  // Movimiento del jugador
    }
}
