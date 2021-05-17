using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Semaforo : MonoBehaviour
{
    [SerializeField] private GameObject collider2D;
    [SerializeField] private GameObject imagenVerde;
    [SerializeField] private GameObject imagenAmbar;
    [SerializeField] private GameObject imagenRojo;
    
    private const int verde = 0;
    private const int ambar = 1;
    private const int rojo = 2;

    private void Awake()
    {
        collider2D.SetActive(false);
    }

    public void CambiarEstado(int estado)
    {
        switch (estado)
        {
            case verde: 
                imagenAmbar.SetActive(false);
                imagenRojo.SetActive(false);
                imagenVerde.SetActive(true);
                collider2D.SetActive(false);
                break;
            case ambar:
                imagenAmbar.SetActive(true);
                imagenVerde.SetActive(false);
                imagenRojo.SetActive(false);
                collider2D.SetActive(false);
                break;
            case rojo:
                imagenAmbar.SetActive(false);
                imagenVerde.SetActive(false);
                imagenRojo.SetActive(true);
                collider2D.SetActive(true);
                break;
        }
    }
}
