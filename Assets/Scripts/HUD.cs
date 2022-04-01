/*Autor: Diego Alejandro Balderas Tlahuitzo
 * A01745336
 * Manipular imagenes de vida para que representen la salud del personaje
 */
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    public static HUD instance;

    public Image image1;
    public Image image2;
    public Image image3;

    public TextMeshProUGUI txtMonedas;

    private void Awake()
    {
        instance = this;
    }

    public void Reanudar()
    {
        MenuPausa.instance.Pausar();
    }
    public void ActualizarVidas()
    {
        int vidas = vidaPersonaje.instance.vidas;
        switch (vidas)
        {
            case 0:
                image1.enabled = false;
                break;
            case 1:
                image2.enabled = false;
                break;
            case 2:
                image3.enabled = false;
                break;
        }
    }
    public void AcualizarContadorMonedas()
    {
        int monedas = vidaPersonaje.instance.monedas;
        txtMonedas.text = monedas.ToString();
    }

    
}
