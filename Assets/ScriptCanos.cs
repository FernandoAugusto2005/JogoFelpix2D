using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptCanos : MonoBehaviour
{
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(-10, 0);
    }
    void Update()
    {
        if(transform.position.x < -10)
        {
            Destroy(gameObject);
        }
    }
}
