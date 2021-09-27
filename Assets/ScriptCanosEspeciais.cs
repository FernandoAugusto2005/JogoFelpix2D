using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptCanosEspeciais : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKey(KeyCode.K))
        {
            transform.localScale = Vector3.Lerp(transform.localScale, new Vector3(1f, 4f, 1f), Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.G))
        {
            transform.localScale = Vector3.Lerp(transform.localScale, new Vector3(1f, 1f, 1f), Time.deltaTime);
        }
    }
}
