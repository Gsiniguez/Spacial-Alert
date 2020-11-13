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
            Destroy(gameObject);
        }
    }

    void explotar(){
        _AsteroideExplota();
    }

    
    void impactar(){
        _AsteroideImpactar();  
    }

}
