using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    ScriptFelpudoPlayer PlayerScript;
    
    public int pontos = 0;

    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }
    void Save()
    {
        pontos = pontos + 1;
    }
    void ZerarPontos()
    {
        pontos = 0;
    }
}
