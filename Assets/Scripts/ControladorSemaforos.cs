using System.Collections.Generic;
using UnityEngine;

public class ControladorSemaforos : MonoBehaviour
{
    private const int verde = 0;
    private const int ambar = 1;
    private const int rojo = 2;
    private List<int> _estados = new List<int>() { 0 };
    
    private float _tiempoEntreEstadosSegundos = 10f;
    private float _tiempoVerde = 15f;
    private float _tiempoAmbar = 7f;
    private float _tiempoRojo = 10f;
    
    private float _cronometro = 0;

    [SerializeField] private GameObject[] semaforos;
    
    void Update()
    {
        if (_cronometro <= _tiempoEntreEstadosSegundos)
        {
            _cronometro += Time.deltaTime;
        }
        else
        {
            _cronometro = 0;
            switch(_estados[0])
            {
                case verde:
                    _estados[0] = ambar;
                    Debug.Log("Ambar");
                    semaforos[0].GetComponent<Semaforo>().CambiarEstado(verde);
                    semaforos[1].GetComponent<Semaforo>().CambiarEstado(ambar);
                    break;
                case ambar:
                    _estados[0] = rojo;
                    Debug.Log("Rojo");
                    semaforos[0].GetComponent<Semaforo>().CambiarEstado(ambar);
                    semaforos[1].GetComponent<Semaforo>().CambiarEstado(rojo);
                    break;
                case rojo:
                    _estados[0] = verde;
                    Debug.Log("Verde");
                    semaforos[0].GetComponent<Semaforo>().CambiarEstado(rojo);
                    semaforos[1].GetComponent<Semaforo>().CambiarEstado(verde);
                    break;
            }

            foreach (var carro in GameObject.FindGameObjectsWithTag("Carro"))
            {
                carro.GetComponent<Auto>().Avanzar();
            }
        }
    }
}