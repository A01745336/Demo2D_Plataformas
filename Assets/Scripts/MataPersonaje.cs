using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Autor: Diego Alejandro Balderas Tlahuitzo
//Detecta las coisiones con el personaje
public class MataPersonaje : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collateral)
    {
        if (collateral.gameObject.CompareTag("Player"))
        {

            Destroy(collateral.gameObject, 0.2f); //Destruye al personaje

        }
    }
}
