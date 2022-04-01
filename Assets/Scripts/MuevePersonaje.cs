using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuevePersonaje : MonoBehaviour
{
    // Velocidades
    public float velocidadX = 0;
    public float velocidadY = 0;

    // Regidbody
    private Rigidbody2D rb;
    //Animator
    private Animator ani;
    //Renderer
    private SpriteRenderer rendPersonaje;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();
        rendPersonaje = GetComponent<SpriteRenderer>();
    }

    private void FixedUpdate()
    {
        //Caminar
        float movHorizontal = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(movHorizontal * velocidadX, rb.velocity.y);
        //Saltar
        float movVertical = Input.GetAxis("Vertical");
        if (movVertical > 0)
        {
            rb.velocity = new Vector2(rb.velocity.x, movVertical * velocidadY);
        }
        //Animator
        float velocidad = Mathf.Abs(rb.velocity.x);
        ani.SetFloat("velocidad", velocidad);
        //Direccion Adecuada
        rendPersonaje.flipX = rb.velocity.x < 0;
        //Parametro para animación de saltar
        ani.SetBool("saltando", PruebaPiso.estaEnPiso);
    }
}
