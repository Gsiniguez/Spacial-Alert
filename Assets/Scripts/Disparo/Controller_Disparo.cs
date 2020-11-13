using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller_Disparo : Events_Disparo
{

    Rigidbody2D rb;
    [SerializeField]
    float speed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Impulsar();
    }

    void Impulsar()
    {
        rb.velocity = transform.up * speed;
    }
}
