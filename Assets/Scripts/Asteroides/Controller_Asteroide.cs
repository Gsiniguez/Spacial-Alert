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

    private void OnEnable()
    {
        Events_Disparo.OnDisparoInpacta += DisparoImpacto;
    }
    private void OnDisable()
    {
        Events_Disparo.OnDisparoInpacta -= DisparoImpacto;
    }

    //Listener de Evento OnDisparoInpacta
    void DisparoImpacto(GameObject asteroide, float danio)
    {
        if (asteroide == gameObject)
        {
            PerderVida(danio);
        }
    }


    void PerderVida(float danio)
    {
        vida -= danio;

        if (vida <= 0)
        {
            Explotar();
            Destroy(gameObject);
        }
    }

    void Explotar(){
        //Emite evento de Explocion
        _AsteroideExplota(gameObject);
    }

    
    void Impactar(){
        //Emitir evento de impactar con nave
        _AsteroideImpactar();
        //Se destruye una vez que impacto con nave
        Destroy(gameObject);
    }

}
