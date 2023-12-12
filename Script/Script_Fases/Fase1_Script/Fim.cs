using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Fim : MonoBehaviour
{
    public GameObject MuitoBom;
    public GameObject Magnifico;
    public GameObject Perfeito;
    public GameObject BtnProx;

    public GameObject GameOver;

    public string Restart;
   
    public string Next = "ModoJornada";

    void Awake()
    {
        MuitoBom.SetActive(false);
        Magnifico.SetActive(false);
        Perfeito.SetActive(false);
        BtnProx.SetActive(false);
        GameOver.SetActive(false);
    }

    void Start()
    {
        //Teste de Erros
        //PlayerPrefs.SetInt("Pontuacao", 7);
        //PlayerPrefs.SetInt("Acertos", 7);
        //PlayerPrefs.SetInt("Erros", 2);


        if (PlayerPrefs.GetInt("Erros") ==0)
        {
            MuitoBom.SetActive(false);
            Magnifico.SetActive(false);
            Perfeito.SetActive(true);
            BtnProx.SetActive(true);
            GameOver.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("Erros") >0 && PlayerPrefs.GetInt("Erros") <= 2)
        {
            MuitoBom.SetActive(false);
            Magnifico.SetActive(true);
            Perfeito.SetActive(false);
            BtnProx.SetActive(true);
            GameOver.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("Erros") > 2 && PlayerPrefs.GetInt("Erros") <= 4)
        {
            MuitoBom.SetActive(true);
            Magnifico.SetActive(false);
            Perfeito.SetActive(false);
            BtnProx.SetActive(true);
            GameOver.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("Erros") > 4 )
        {
            if(PlayerPrefs.GetInt("Fases") == 0)
            {
                MuitoBom.SetActive(true);
                Magnifico.SetActive(false);
                Perfeito.SetActive(false);
                BtnProx.SetActive(true);
                GameOver.SetActive(false);             
            }
            else if (PlayerPrefs.GetInt("Fases") != 0)
            {
                MuitoBom.SetActive(false);
                Magnifico.SetActive(false);
                Perfeito.SetActive(false);
                BtnProx.SetActive(false);
                GameOver.SetActive(true);
            }           
        }
    }
    public void Reset()
    {
        SceneManager.LoadScene(Restart);
    }
    
    public void Proximo()
    {
        SceneManager.LoadScene(Next);
    }
}
