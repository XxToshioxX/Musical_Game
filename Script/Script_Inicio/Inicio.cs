using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Inicio : MonoBehaviour
{
    public string cena;
    public GameObject Background;

    public Animator anim;

    public void Start()
    {
        PlayerPrefs.SetInt("ModoJogo", 0);
        anim = GetComponent<Animator>();
        PlayerPrefs.SetInt("Fases", 0);
    }
    public void MudarCena()
    {
        StartCoroutine(Delay());
            
    }
    IEnumerator Delay()
    {
        Background.SetActive(true);
        anim.SetBool("Start", true);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(cena);

    }
}
