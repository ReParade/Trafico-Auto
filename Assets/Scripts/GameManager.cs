using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public float velocidad = 10;

    //Carro en linea recta abajo
    public GameObject carroRojo;
    public GameObject carroAmarilloMini2;
    public GameObject carroNegro;
    public GameObject carroBlanco;

    //Carro en linea recta arriba
    public GameObject carroBlancoArr;
    public GameObject camionetaBlancoArr;
    public GameObject carroAmarilloArr;
    public GameObject carroAzulArr;
    public GameObject carroCelesteArr;

    //Carro en linea Vertical izquiera
    public GameObject carroAmarilloMini;
    public GameObject camionetaBlancaIzq;
    public GameObject carroAzulIzq;


    //Carro en linea Vertical derecha
    public GameObject carroRojoDer;
    public GameObject carroBlancoDer;

    public List<GameObject> vertical;
    public List<GameObject> horizontal;

    // Start is called before the first frame update
    void Start()
    {

        //Crear Carros en el mapa
        //Abajo
        horizontal.Add( Instantiate(carroRojo, new Vector2( -10.1f, -0.27f ), Quaternion.identity ) );
        horizontal.Add(Instantiate(carroAmarilloMini2, new Vector2( -15.5f, -0.27f ), Quaternion.identity));
        horizontal.Add(Instantiate(carroNegro, new Vector2(-20.5f, -0.27f), Quaternion.identity));
        horizontal.Add(Instantiate(carroBlanco, new Vector2(-25.5f, -0.27f), Quaternion.identity));

       //Arriba
        horizontal.Add(Instantiate(carroBlancoArr, new Vector2(-25.5f, -0.27f), Quaternion.identity));
        horizontal.Add(Instantiate(camionetaBlancoArr, new Vector2(-30.5f, -0.27f), Quaternion.identity));
        horizontal.Add(Instantiate(carroAmarilloArr, new Vector2(-35.5f, -0.27f), Quaternion.identity));
        horizontal.Add(Instantiate(carroAzulArr, new Vector2(-40.5f, -0.27f), Quaternion.identity));
        horizontal.Add(Instantiate(carroCelesteArr, new Vector2(-45.5f, -0.27f), Quaternion.identity));

        //Izquierda
        vertical.Add( Instantiate( carroAmarilloMini, new Vector2( -0.88f, -7.25f ), Quaternion.identity ) );
        vertical.Add(Instantiate(camionetaBlancaIzq, new Vector2(-0.88f, -14.25f), Quaternion.identity));
        vertical.Add(Instantiate(carroAzulIzq, new Vector2(-0.88f, -25.25f), Quaternion.identity));

        //Derecha
        vertical.Add(Instantiate(carroRojoDer, new Vector2(-0.88f, -30.25f), Quaternion.identity));
        vertical.Add(Instantiate(carroBlancoDer, new Vector2(-0.88f, -40.25f), Quaternion.identity));

    }

    // Update is called once per frame
    void Update()
    {

        //Mover Carro vertical izquiera
        for (int i = 0; i < vertical.Count; i++)
        {
            if (vertical[i].transform.position.y >= 20)
            {
                float randomCarros = Random.Range(-9.69f, -60.69f);
                vertical[i].transform.position = new Vector3( -0.88f, randomCarros, 0);
            }

            vertical[i].transform.position = vertical[i].transform.position - new Vector3(0, -1, 0) * Time.deltaTime * velocidad;
        }

        //Mover Carro vertical derecha
        for (int i = 0; i < vertical.Count; i++)
        {
            if (vertical[i].transform.position.y >= 20)
            {
                float randomCarros = Random.Range(-9.69f, -60.69f);
                vertical[i].transform.position = new Vector3(0.29f, randomCarros, 0);
            }

            vertical[i].transform.position = vertical[i].transform.position - new Vector3(0, -1, 0) * Time.deltaTime * velocidad;
        }

        //Mover Carro horizonta abajo
        for (int i = 0; i < horizontal.Count; i++)
        {
            if (horizontal[i].transform.position.x >= 20)
            {
                float randomCarros = Random.Range(-10.1f, -60.12f);
                horizontal[i].transform.position = new Vector3(randomCarros, -0.27f, 0);
            }

            horizontal[i].transform.position = horizontal[i].transform.position - new Vector3(-1, 0, 0) * Time.deltaTime * velocidad;
        }

        //Mover Carro horizonta arriba
        for (int i = 0; i < horizontal.Count; i++)
        {
            if (horizontal[i].transform.position.x >= 20)
            {
                float randomCarros = Random.Range(-10.1f, -60.12f);
                horizontal[i].transform.position = new Vector3(randomCarros, 1f, 0);
            }

            horizontal[i].transform.position = horizontal[i].transform.position - new Vector3(-1, 0, 0) * Time.deltaTime * velocidad;
        }

    }
}
