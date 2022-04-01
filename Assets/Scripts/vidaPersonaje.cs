/*Autor: Diego Alejandro Balderas Tlahuitzo
 * A01745336
 * Mantiene la información de la vida*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vidaPersonaje : MonoBehaviour
{
    public int vidas = 3;
    public int monedas = 0;

    public static vidaPersonaje instance;

    private void Awake()
    {
        instance = this;
    }
}
