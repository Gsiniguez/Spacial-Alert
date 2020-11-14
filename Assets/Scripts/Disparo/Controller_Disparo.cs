using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller_Disparo : Events_Disparo
{

    Rigidbody2D rb;
    [SerializeField]
    float speed;
    [SerializeField]
    float lifeTime;
    float lifeTimer;

    [SerializeField]
    float danio;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        lifeTimer = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        Impulsar();
        Destruirse();
    }

    void Impulsar()
    {
        rb.velocity = transform.up * speed;
    }

    void Destruirse()
    {
        lifeTimer += Time.deltaTime;

        if (lifeTimer > lifeTime)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.gameObject.tag);
        if (other.gameObject.tag == "Asteroide_Chico" || other.gameObject.tag == "Asteroide_Mediano" || other.gameObject.tag == "Asteroide_Grande")
        {
            //Emitir Evento
            _DisparoInpacta(other.gameObject, danio);

            //Destruir disparo
            Destroy(gameObject);
        }
    }
}
