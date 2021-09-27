using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FasesMan : MonoBehaviour
{
    public GameObject buttonMenu;
    public GameObject buttonResume;
    
    public GameObject gameEngine;
    
    public GameObject felpudo;

    public bool pausado = false;

    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            pausado = true;
        }
        if(pausado)
        {
            Configuration();
            gameEngine.SendMessage("ApertouMenu");
            felpudo.GetComponent<Rigidbody2D>().gravityScale = 0;
            felpudo.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            felpudo.GetComponent<Rigidbody2D>().isKinematic = true;
        }
    }

    void Start()
    {
        buttonMenu.SetActive(false);
        buttonResume.SetActive(false);
    }

    public void loadFase1()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void Configuration()
    {
        buttonMenu.SetActive(true);
        buttonResume.SetActive(true);
    }
    public void GoToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    //IEnumerate resumeToGame()
    //{
      //  yield return new WaitForSecond(3f);
    //}
    public void Resume()
    {
        StartCoroutine(resume());
    }
    IEnumerator resume()
    {
        yield return new WaitForSeconds(3f);

    }
}
