using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class fim5_medio : MonoBehaviour
{
    public GameObject MuitoBom;
    public GameObject Magnifico;
    public GameObject Perfeito;
    public GameObject BtnProx;

    public GameObject GameOver;


    public string Restart;

    public string Next = "ModoJornada";

    public GameObject Facil;
    public GameObject Medio;
    public GameObject Dificil;


    void Awake()
    {
        if (PlayerPrefs.GetInt("Fases") == 13)
        {
            Facil.SetActive(false);
            Medio.SetActive(true);
            Dificil.SetActive(false);
        }
    }

    void Start()
    {
        //Teste de Erros
        //PlayerPrefs.SetInt("Pontuacao", 7);
        //PlayerPrefs.SetInt("Acertos", 7);
        //PlayerPrefs.SetInt("Erros", 2);

        //Facil
        {
            if (PlayerPrefs.GetInt("Erros") <= 2)
            {
                MuitoBom.SetActive(false);
                Magnifico.SetActive(false);
                Perfeito.SetActive(true);
                BtnProx.SetActive(true);
                GameOver.SetActive(false);
            }
            else if (PlayerPrefs.GetInt("Erros") > 2 && PlayerPrefs.GetInt("Erros") <= 15)
            {
                MuitoBom.SetActive(false);
                Magnifico.SetActive(true);
                Perfeito.SetActive(false);
                BtnProx.SetActive(true);
                GameOver.SetActive(false);
            }
            else if (PlayerPrefs.GetInt("Erros") > 15 && PlayerPrefs.GetInt("Erros") <= 10 )
            {
                MuitoBom.SetActive(true);
                Magnifico.SetActive(false);
                Perfeito.SetActive(false);
                BtnProx.SetActive(true);
                GameOver.SetActive(false);
            }
            else if (PlayerPrefs.GetInt("Erros") > 10)
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
