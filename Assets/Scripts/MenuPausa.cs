using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*Autor: Diego Balderas
 * Comportamiento de la pantalla de Pausa
 */
public class MenuPausa : MonoBehaviour
{
    public GameObject panelPausa;
    public bool estaPausado = false;
    public static MenuPausa instance;

    private void Awake()
    {
        instance = this;
    }

    public void Pausar()
    {
        estaPausado = !estaPausado;
        panelPausa.SetActive(estaPausado);
        Time.timeScale = estaPausado ? 0 : 1;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Pausar();
        }
    }
}
