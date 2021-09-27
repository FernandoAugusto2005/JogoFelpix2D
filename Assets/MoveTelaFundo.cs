using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTelaFundo : MonoBehaviour
{
    public Rigidbody2D rb;

    void Start()
    {
       GetComponent<Rigidbody2D>().velocity = new Vector2(-3, 0);
    }
    void Update()
    {    
        if(transform.position.x <=-1)
        {
            transform.position = new Vector2(12.69f, 0);
        }
    }
}
