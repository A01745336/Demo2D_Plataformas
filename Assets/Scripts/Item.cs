
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Autor: Diego Alejandro Balderas Tlahuitzo
//Detecta las coisiones con el personaje
public class Item : MonoBehaviour
{
    [SerializeField]
    private AudioSource efectoMoneda;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {

            //Destroy(collision.gameObject, 0.2f); //Destruye al personaje
            gameObject.transform.GetChild(0).gameObject.SetActive(true); //Es la  la explosion //gameObject.transform.Getchild(0) es transform de la explosion, gameObject.transform.Getchild(0).gameObject es la explosion
            GetComponent<SpriteRenderer>().enabled = false;

            Destroy(gameObject, 0.2f); //Destruye la moneda
            //Cuenta  monedas recolectadas
            vidaPersonaje.instance.monedas++;
            HUD.instance.AcualizarContadorMonedas();

            efectoMoneda.Play();
        }
    }
}
