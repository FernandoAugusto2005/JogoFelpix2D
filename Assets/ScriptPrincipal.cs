using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptPrincipal : MonoBehaviour
{
    public GameObject objetoCanos;

    public Text textoMensagem;
    public Text textoPontuacao;
    public Text textoMensagemPontuacao;

    public int pontuacao;
    public bool terminouJogo;

    public GameObject savePoints;

    void Update()
    {     
        if(Input.GetButtonDown("Fire1")  && terminouJogo)
        {
            Application.LoadLevel("SampleScene");
        }
    }

    void Satrt()
    {
        textoPontuacao.gameObject.SetActive(false);
        textoMensagem.gameObject.SetActive(true);
        textoMensagemPontuacao.gameObject.SetActive(false);
    }
    public void ComecouJogo(){  
		InvokeRepeating("CriaCanos", 0f, 1.5f);
        textoPontuacao.gameObject.SetActive(true);
        textoMensagem.gameObject.SetActive(false);
        textoMensagemPontuacao.gameObject.SetActive(true);
    }
    void CriaCanos()
	{
		float randomPos = (3.0f * Random.value) - 1.5f;
		GameObject cano = Instantiate(objetoCanos);
		cano.transform.localScale = new Vector3(1.65f, 1.65f, 1.65f);
		cano.transform.position  = new Vector3(10, randomPos, 0);
	}
    public void FimDeJogo(){
		CancelInvoke("CriaCanos");
		savePoints.SendMessage("ZerarPontos");
        foreach (GameObject objeto in GameObject.FindGameObjectsWithTag("ImagemFundo"))
		{
			objeto.GetComponent<Rigidbody2D>().velocity = Vector2.zero; 
		}
		
		foreach (GameObject objeto in GameObject.FindGameObjectsWithTag("AreaVao"))
		{
			objeto.GetComponent<Rigidbody2D>().velocity = Vector2.zero; 
		}
        Invoke("setLabelsFinais", 2);
    }
    public void marcaPonto()
    {
        pontuacao++;
        textoPontuacao.text = pontuacao.ToString();
        savePoints.SendMessage("Save");
    }
    void setLabelsFinais()
    {
        textoMensagem.gameObject.SetActive(true);
        textoMensagem.text = "Toque para reiniciar";
        textoMensagem.color = new Color(0.15f, 0.35f, 0.55f, 1);
        terminouJogo = true;
    }
    public void ApertouMenu()
    {
        CancelInvoke("CriaCanos");
        foreach (GameObject objeto in GameObject.FindGameObjectsWithTag("ImagemFundo"))
		{
			objeto.GetComponent<Rigidbody2D>().velocity = Vector2.zero; 
		}
		foreach (GameObject objeto in GameObject.FindGameObjectsWithTag("AreaVao"))
		{
			objeto.GetComponent<Rigidbody2D>().velocity = Vector2.zero; 
		}   
    }
}
