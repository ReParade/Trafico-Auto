using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Auto : MonoBehaviour
{
    public GameObject riel;
    public GameObject lateral;

    new Rigidbody2D rigidbody;
    private bool colision = false;

    [SerializeField] private bool vertical;
    private Vector2 posicionInicial;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        posicionInicial = rigidbody.position;
    }

    // Update is called once per frame
    void Update()
    {

        if (colision == false)
        {
            rigidbody.velocity = vertical ? new Vector2(0, 5) : new Vector2(5, 0);
        }
        
        if (colision)
        {
            rigidbody.velocity = new Vector2(0, 0);
        }

        if (rigidbody.transform.position.y >= 30 || rigidbody.transform.position.x >= 30)
        {
            rigidbody.transform.position = posicionInicial;
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Finish"))
        {
            colision = true;
        }
        if (collision.gameObject.CompareTag("GameController"))
        {
            colision = false;
        }
    }

    public void Detener()
    {
        colision = true;
    }

    public void Avanzar()
    {
        colision = false;
    }
}
