using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carro3 : MonoBehaviour
{

    public GameObject riel;
    public GameObject lateral;

    new Rigidbody2D rigidbody;

    public bool colision = false;

    // Start is called before the first frame update
    void Start()
    {

        rigidbody = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {

        if (colision == false)
        {
            rigidbody.velocity = new Vector2(5, 0);
        }
        if (colision == true)
        {
            rigidbody.velocity = new Vector2(0, 0);
        }

        if (rigidbody.transform.position.x >= 18)
        {
            rigidbody.transform.position = new Vector3(-15.21f, 0.93f, 0);
        }

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Finish")
        {
            //Debug.Log("Colision");
            colision = true;
        }
        if (collision.gameObject.tag == "GameController")
        {
            //Debug.Log("No Colsion");
            colision = false;
        }

    }

}
