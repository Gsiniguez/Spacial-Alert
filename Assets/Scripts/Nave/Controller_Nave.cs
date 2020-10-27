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

    private Rigidbody2D rigidbody;


    private void Awake()
    {

    }
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Impulsar();
        }

        Rotar();

        if (Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.Mouse0))
        {
            Disparar();
        }

    }

    private void FixedUpdate()
    {

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
        Instantiate(shotTypes[0], pointOfShot.transform.position, Quaternion.identity);
        _NaveDispara("Nave Dispara " + shotTypes[0].tag);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Asteroide")
        {
            _NaveColisiona("Nave Colisiono");
        }
    }
}
