/*Autor: Diego Alejandro Balderas Tlahuitzo
 * A01745336
 * Comportamiento del enemigo 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            vidaPersonaje.instance.vidas--;
            HUD.instance.ActualizarVidas();
            
            if (vidaPersonaje.instance.vidas == 0)
            {
                Destroy(other.gameObject, 0.2f);
            }
        }
    }
}
