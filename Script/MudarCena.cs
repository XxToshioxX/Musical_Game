using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MudarCena : MonoBehaviour
{
    public string NomeCena;
    public string NomeCena2;

    public string[] Dificuldade;

    public string[] Fase;
   

    public void Cena1()
    {
        SceneManager.LoadScene(NomeCena);
    }
    public void Cena2()
    {
        SceneManager.LoadScene(NomeCena2);
    }

    //Fase1
    public void Dificuldade_Fase1()
    {
        SceneManager.LoadScene(Dificuldade[0]);
    }
    public void Fase1_Facil()
    {
        SceneManager.LoadScene(Fase[0]);
        PlayerPrefs.SetInt("Fases",0);
    }
    public void Fase1_Medio()
    {
        SceneManager.LoadScene(Fase[1]);
        PlayerPrefs.SetInt("Fases",1);
    }
    public void Fase1_Dificil()
    {
        SceneManager.LoadScene(Fase[2]);
        PlayerPrefs.SetInt("Fases",2);
    }

    //Fase2
    public void Dificuldade_Fase2()
    {
        SceneManager.LoadScene(Dificuldade[1]);
    }
    public void Fase2_Facil()
    {
        SceneManager.LoadScene(Fase[3]);
        PlayerPrefs.SetInt("Fases", 3);
    }
    public void Fase2_Medio()
    {
        SceneManager.LoadScene(Fase[4]);
        PlayerPrefs.SetInt("Fases", 4);
    }
    public void Fase2_Dificil()
    {
        SceneManager.LoadScene(Fase[5]);
        PlayerPrefs.SetInt("Fases", 5);
    }

    //Fase3
    public void Dificuldade_Fase3()
    {
        SceneManager.LoadScene(Dificuldade[2]);
    }
    public void Fase3_Facil()
    {
        SceneManager.LoadScene(Fase[6]);
        PlayerPrefs.SetInt("Fases", 6);
    }
    public void Fase3_Medio()
    {
        SceneManager.LoadScene(Fase[7]);
        PlayerPrefs.SetInt("Fases", 7);
    }
    public void Fase3_Dificil()
    {
        SceneManager.LoadScene(Fase[8]);
        PlayerPrefs.SetInt("Fases", 8);
    }

    //Fase4
    public void Dificuldade_Fase4()
    {
        SceneManager.LoadScene(Dificuldade[3]);
    }
    public void Fase4_Facil()
    {
        SceneManager.LoadScene(Fase[9]);
        PlayerPrefs.SetInt("Fases", 9);
    }
    public void Fase4_Medio()
    {
        SceneManager.LoadScene(Fase[10]);
        PlayerPrefs.SetInt("Fases", 10);
    }
    public void Fase4_Dificil()
    {
        SceneManager.LoadScene(Fase[11]);
        PlayerPrefs.SetInt("Fases", 11);
    }

    //Fase5
    public void Dificuldade_Fase5()
    {
        SceneManager.LoadScene(Dificuldade[4]);
    }
    public void Fase5_Facil()
    {
        SceneManager.LoadScene(Fase[12]);
        PlayerPrefs.SetInt("Fases", 12);
    }
    public void Fase5_Medio()
    {
        SceneManager.LoadScene(Fase[13]);
        PlayerPrefs.SetInt("Fases", 13);
    }
    public void Fase5_Dificil()
    {
        SceneManager.LoadScene(Fase[14]);
        PlayerPrefs.SetInt("Fases", 14);
    }

    //Fase6
    public void Dificuldade_Fase6()
    {
        SceneManager.LoadScene(Dificuldade[5]);
    }
    public void Fase6_Facil()
    {
        SceneManager.LoadScene(Fase[15]);
        PlayerPrefs.SetInt("Fases", 15);
    }
    public void Fase6_Medio()
    {
        SceneManager.LoadScene(Fase[16]);
        PlayerPrefs.SetInt("Fases", 16);
    }
    public void Fase6_Dificil()
    {
        SceneManager.LoadScene(Fase[17]);
        PlayerPrefs.SetInt("Fases", 17);
    }

    //Fase7
    public void Dificuldade_Fase7()
    {
        SceneManager.LoadScene(Dificuldade[6]);
    }
    public void Fase7_Facil()
    {
        SceneManager.LoadScene(Fase[18]);
        PlayerPrefs.SetInt("Fases", 18);
    }
    public void Fase7_Medio()
    {
        SceneManager.LoadScene(Fase[19]);
        PlayerPrefs.SetInt("Fases", 19);
    }
    public void Fase7_Dificil()
    {
        SceneManager.LoadScene(Fase[20]);
        PlayerPrefs.SetInt("Fases", 20);
    }

    //Fase8
    public void Dificuldade_Fase8()
    {
        SceneManager.LoadScene(Dificuldade[7]);
    }
    public void Fase8_Facil()
    {
        SceneManager.LoadScene(Fase[21]);
        PlayerPrefs.SetInt("Fases", 21);
    }
    public void Fase8_Medio()
    {
        SceneManager.LoadScene(Fase[22]);
        PlayerPrefs.SetInt("Fases", 22);
    }
    public void Fase8_Dificil()
    {
        SceneManager.LoadScene(Fase[23]);
        PlayerPrefs.SetInt("Fases", 23);
    }
}
