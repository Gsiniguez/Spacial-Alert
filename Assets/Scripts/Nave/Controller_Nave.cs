using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller_Nave : Events_Nave
{

    [SerializeField]
    float speed;
    [SerializeField]
    float rotationSpeed;
    [SerializeField]
    GameObject pointOfShot;
    [SerializeField]
    GameObject[] shotTypes;

    [SerializeField]
    float attackRate;
    float attackTimer = 0f;

    GameObject shotTypeSelected;

    private Rigidbody2D rigidbody;


    private void Awake()
    {

    }
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        shotTypeSelected = shotTypes[0];
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Impulsar();
        }

        Rotar();

        //Tiempo entre ataques
        attackTimer += Time.deltaTime;
        if (Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.Mouse0))
        {
            if (attackTimer >= attackRate)
            {
                Disparar();
                attackTimer = 0f;
            }
        }

    }

    private void OnEnable()
    {
        Events_Asteroide.onAsteroideImpactar += ImapctoConAsteroide;
    }

    private void OnDisable()
    {
        Events_Asteroide.onAsteroideImpactar -= ImapctoConAsteroide;
    }

    void ImapctoConAsteroide()
    {
        PerderVida();
    }

    void PerderVida()
    {
        _NavePierdeVida();
    }

    void Explotar()
    {
        _NaveExplota();
        Destroy(gameObject);
    }

    void Impulsar()
    {
        float mvm = 1;
        float move = mvm * speed;
        rigidbody.velocity = transform.up * move;
    }

    void Rotar()
    {
        float mvm = Input.GetAxisRaw("Horizontal");
        float move = mvm * rotationSpeed;
        rigidbody.angularVelocity = -move;
    }

    void Disparar()
    {
        Instantiate(shotTypeSelected, pointOfShot.transform.position, pointOfShot.transform.rotation);
    }

    public void AsignarTipoDisparo(int tipo)
    {
        /*
        0 -> Disparo Normal
        */

        shotTypeSelected = shotTypes[tipo];
    }

}
