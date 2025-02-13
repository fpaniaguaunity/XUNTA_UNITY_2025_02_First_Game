using System;
using UnityEngine;

public class ForwardMover : MonoBehaviour
{
    [Range(0.1f, 10f)] //Genera un deslizador para hacer la entrada
    public float speed = 1f;

    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}