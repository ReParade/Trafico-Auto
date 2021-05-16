using System.Collections.Generic;
using UnityEngine;

public class ControladorSemaforos : MonoBehaviour
{
    private const int verde = 0;
    private const int ambar = 1;
    private const int rojo = 2;
    private List<int> _estados = new List<int>() { 0 };
    
    private float _tiempoEntreEstadosSegundos = 10f;
    private float _cronometro = 0;
    
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
                    break;
                case ambar:
                    _estados[0] = rojo;
                    Debug.Log("Rojo"); 
                    break;
                case rojo:
                    _estados[0] = verde;
                    Debug.Log("Verde");
                    break;
            }
        }
    }
}