using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptDados : MonoBehaviour
{
    public string _nome;
    public string _email;
    

    public Text nomeTexto;
    public Text emailTexto;
    public Button butao;
    public InputField escreverNome;
    public InputField escreverEmail;

    void Start()
    {
        butao.onClick = new Button.ButtonClickedEvent();
        butao.onClick.AddListener(() => Credenciais(escreverNome, escreverEmail));
    }
    
    public void Credenciais(InputField nome, InputField email)
    {
        nomeTexto.text = nome.ToString();
        emailTexto.text = email.ToString();
    }
}
