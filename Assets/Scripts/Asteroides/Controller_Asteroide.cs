using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller_Asteroide : Events_Asteroide
{

    [SerializeField]
    float vida;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.gameObject.tag);
        if (other.gameObject.tag == "Disparo")
        {
            //Obtener Danio
            float danio = other.GetComponent<Controller_Disparo>().ObtenerDanio();

            PerderVida(danio);

            Destroy(other.gameObject);
        }
    }


    void PerderVida(float danio)
    {
        vida -= danio;


        if (vida <= 0)
        {
            Destroy(gameObject);
        }
    }

}
