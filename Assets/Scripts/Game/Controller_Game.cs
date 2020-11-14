using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controller_Game : Events_Game
{

    [SerializeField]
    float puntos;

    [SerializeField]
    Text puntuacion;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        PuntosPorMilisegundo();

        puntuacion.text = "PUNTOS: "+puntos.ToString();
    }

    private void OnEnable()
    {
        Events_Asteroide.OnAsteroideExplota += SumarPunto;
    }

    private void OnDisable()
    {
        Events_Asteroide.OnAsteroideExplota -= SumarPunto;
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
