using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float speed = 1f;  // Velocidad del jugador
    public int fire = 1;  // Poder de la bomba
    public int nBombs = 1;  // Numero de bombas
    public bool poison = false;  // Si el jugador esta envenenado
    public float time = 5.0f;  // Tiempo para la explosion
    public int xPos, yPos;  // Posicion del jugador

    public int curentBombs = 0;  // Numero de bombas que tiene el jugador
    public float poisonTime = 0f;  // Tiempo envenenado
}
