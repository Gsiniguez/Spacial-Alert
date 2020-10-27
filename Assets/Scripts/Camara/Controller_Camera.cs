using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller_Camera : MonoBehaviour
{

    [SerializeField]
    GameObject nave;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        SeguirNave();
    }


    void SeguirNave()
    {
        transform.position = new Vector3(nave.transform.position.x, nave.transform.position.y, -10);
    }
}
