using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller_Game : Events_Game
{

    [SerializeField]
    float puntos;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    void PuntosPorMilisegundo()
    {
        puntos += Time.deltaTime;
    }
}
