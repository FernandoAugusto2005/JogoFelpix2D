using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{
    public Button butao1;
    public GameObject objeto1;
 
    public Button butao2;
    public bool ativarObjeto;
    public GameObject objeto2;

    public Button butao3;
    public InputField input1;
    public InputField input2;
    public Text textoResposta;

    void Start()
    {
        butao1.onClick = new Button.ButtonClickedEvent();
        butao1.onClick.AddListener(() => Funcao1());

        butao2.onClick = new Button.ButtonClickedEvent();
        butao2.onClick.AddListener(() => Funcao2(ativarObjeto));
    
        butao3.onClick = new Button.ButtonClickedEvent();
        butao3.onClick.AddListener(() => Multiplicacao(input1, input2, textoResposta));
    }
    
    public void Funcao1()
    {
        objeto1.gameObject.SetActive(!objeto1.gameObject.activeInHierarchy);
    }

    public void Funcao2(bool condicao)
    {
        objeto2.gameObject.SetActive(condicao);
    }
    public void Multiplicacao(InputField valor1, InputField valor2, Text resposta)
    {
        float _valor1 = float.Parse(valor1.text);
        float _valor2 = float.Parse(valor2.text);
        float multiplicacao = _valor2 * _valor1;
        resposta.text = multiplicacao.ToString();       
    }
}
