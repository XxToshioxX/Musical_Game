using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public GameObject TelaPause;
    public string NomeCena;
    public string CenaAtual;

   public void Start()
    {
        Time.timeScale = 1;
    }
   public void Pausar()
    {
        Time.timeScale = 0;
        TelaPause.SetActive(true);
    }

    public void UnPause()
    {
        Time.timeScale = 1;
        TelaPause.SetActive(false);
    }
    public void MudarCena()
    {
        SceneManager.LoadScene(NomeCena);
    }
    public void Restart()
    {
        SceneManager.LoadScene(CenaAtual);
    }
}
