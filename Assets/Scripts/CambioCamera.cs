using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioCamera : MonoBehaviour
{

    [SerializeField] GameObject[] cameras;

    [SerializeField]
    [Range(0, 1)]
    private int contador;

    void Start()
    {
        contador=0;
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            contador += 1;
            if (contador > 1)
            {
                contador = 0;
            }
            
        }

        if (contador == 0)
        {
            cameras[1].SetActive(true);
            cameras[0].SetActive(false);
        }
        else
        {
            cameras[1].SetActive(false);
            cameras[0].SetActive(true);
        }
    }
}
