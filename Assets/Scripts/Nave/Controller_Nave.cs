using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller_Nave : Events_Nave
{

    [SerializeField]
    float speed;

    Rigidbody2D rigidbody;

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
    }

    void Impulsar()
    {
        float mvm = 1;
        float move = mvm * speed;
        rigidbody.AddForce(new Vector2(rigidbody.velocity.x, move));
    }

    void Rotar()
    {

    }
}
