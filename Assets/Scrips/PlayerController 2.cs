using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Comentario de prueba
public class PlayerController2 : MonoBehaviour
{
    private Rigidbody2D Rigidbody2D;
    private float Horizontal;
    

    void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Horizontal = Input.GetAxisRaw("Horizontal");
    }

    void ProcesarMovimiento(){
        Rigidbody2D.velocity = new Vector2(Horizontal, Rigidbody2D.velocity.y);
    }

}
