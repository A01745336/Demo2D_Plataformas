using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    //Se ejecuta cuando el usuario da click sobre el bot�n jugar
    public void Jugar()
    {
        //cargar la escna de Mario
        SceneManager.LoadScene("SampleScene");
    }
}
