using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controller_Game : Events_Game
{

    [SerializeField]
    float puntos;

    [SerializeField]
    int vida;

    [SerializeField]
    Text puntuacion;
    [SerializeField]
    Text vidaText;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        PuntosPorMilisegundo();

        puntuacion.text = "PUNTOS: " + puntos.ToString();
        vidaText.text = "VIDAS: " + vida.ToString();
    }

    private void OnEnable()
    {
        Events_Asteroide.OnAsteroideExplota += SumarPunto;
        Events_Nave.OnNavePierdeVida += RestarVida;
    }

    private void OnDisable()
    {
        Events_Asteroide.OnAsteroideExplota -= SumarPunto;
        Events_Nave.OnNavePierdeVida += RestarVida;
    }

    void RestarVida()
    {
        vida -= 1;
    }

    void SumarPunto(GameObject asteroide)
    {
        if (asteroide.gameObject.tag == "Asteroide_Chico")
        {
            puntos += 100;
        }
        if (asteroide.gameObject.tag == "Asteroide_Mediano")
        {
            puntos += 300;
        }
        if (asteroide.gameObject.tag == "Asteroide_Grande")
        {
            puntos += 500;
        }
    }

    void PuntosPorMilisegundo()
    {
        puntos += Time.deltaTime;
    }



}
