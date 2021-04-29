using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public float velocidadHor= 10;
    public float velocidadVert = 10;

    //public bool clisionCarro = true;

    //Carro en linea recta abajo
    public GameObject carroRojo;
    public GameObject carroNegro;

    //Carro en linea Vertical izquiera
    public GameObject camionetaBlancaIzq;


    //Carro en linea Vertical derecha
    public GameObject carroRojoDer;

    public List<GameObject> vertical;
    public List<GameObject> horizontal;

    // Start is called before the first frame update
    void Start()
    {

        //Crear Carros en el mapa
        //Abajo
        horizontal.Add(Instantiate(carroNegro, new Vector2(-20.5f, -0.27f), Quaternion.identity));

        //Izquierda
        vertical.Add(Instantiate(camionetaBlancaIzq, new Vector2(-0.88f, -14.25f), Quaternion.identity));

    }

    // Update is called once per frame
    void Update()
    {


    }
}
