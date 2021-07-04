using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Seguimiento del enemigo por Tag.
public class Follow : MonoBehaviour
{
    public float velocidad;   // velocidad de desplazamiento
    Transform target;        // mi objetivo.
    void Start()
    {
                // guardo mi objeto con el tag player y su Transform
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    void Update()
    {
        // si la distancia es mayor a la del objetivo
        if(Vector2.Distance(transform.position, target.position) > 3)
        {
            // hago el seguimiento.   / mover hacia
            transform.position = Vector2.MoveTowards(transform.position, target.position, velocidad*Time.deltaTime);
        }
    }
}
