using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager_Modo_Jogo : MonoBehaviour
{
    public GameObject Cena1;
    public GameObject Balao1;
    public GameObject Balao2;

    public GameObject Cena2;
    void Start()
    {
        if(PlayerPrefs.GetInt("ModoJogo") == 0)
        {
            CutScene1();
            PlayerPrefs.SetInt("ModoJogo",1);
        }
        else if(PlayerPrefs.GetInt("ModoJogo") == 1)
        {
            CutScene3();
        }
       
    }
    void Update()
    {

    }
    public void CutScene1()
    {
        Cena1.SetActive(true);
        Balao1.SetActive(true);
        Balao2.SetActive(false);
        Cena2.SetActive(false);
        StartCoroutine(MudarCutScene1());
    }
    IEnumerator MudarCutScene1()
    {
        yield return new WaitForSeconds(2);
        CutScene2();
    }
    public void CutScene2()
    {
        Cena1.SetActive(true);
        Balao1.SetActive(false);
        Balao2.SetActive(true);
        Cena2.SetActive(false);
        StartCoroutine(MudarCutScene2());
    }
    IEnumerator MudarCutScene2()
    {
        yield return new WaitForSeconds(4);
        CutScene3();
    }
    public void CutScene3()
    {
        Cena1.SetActive(false);
        Balao1.SetActive(false);
        Balao2.SetActive(false);
        Cena2.SetActive(true);
    }
}
