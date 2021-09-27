using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptMataParticula : MonoBehaviour
{
    void Start()
    {
        Invoke("MataParticula", 2.5f);
    }
    void MataParticula()
    {
        Destroy(gameObject);
    }
}
