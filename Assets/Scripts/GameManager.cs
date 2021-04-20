using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public float velocidad = 2;

    //Carro en linea recta
    public GameObject carroRojo;
    //Carro en linea Vertical
    public GameObject carroAmarilloMini;

    public List<GameObject> CarroAmarillomini;
    public List<GameObject> Carrorojo;

    // Start is called before the first frame update
    void Start()
    {

        //Crear Carros en el mapa
        Carrorojo.Add( Instantiate( carroRojo, new Vector2( -10.1f, -0.27f ), Quaternion.identity ) );
        CarroAmarillomini.Add( Instantiate( carroAmarilloMini, new Vector2( -0.81f, -7.25f ), Quaternion.identity ) );

    }

    // Update is called once per frame
    void Update()
    {

        //Mover Carro Amarillo Mini
        for (int i = 0; i < CarroAmarillomini.Count; i++)
        {
            if (CarroAmarillomini[i].transform.position.y >= 10)
            {
                float randomCarros = Random.Range(-0.81f, -0.85f);
                CarroAmarillomini[i].transform.position = new Vector3( randomCarros, -7.25f, 0);
            }

            CarroAmarillomini[i].transform.position = CarroAmarillomini[i].transform.position - new Vector3(0, -1, 0) * Time.deltaTime * velocidad;
        }

        //Mover Carro Rojo
        for (int i = 0; i < Carrorojo.Count; i++)
        {
            if (Carrorojo[i].transform.position.x >= 12)
            {
                float randomCarros = Random.Range(-10.1f, -10.12f);
                Carrorojo[i].transform.position = new Vector3(randomCarros, -0.27f, 0);
            }

            Carrorojo[i].transform.position = Carrorojo[i].transform.position - new Vector3(-1, 0, 0) * Time.deltaTime * velocidad;
        }

    }
}
