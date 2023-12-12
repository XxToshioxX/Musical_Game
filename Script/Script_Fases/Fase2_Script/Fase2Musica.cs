using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Fase2Musica : MonoBehaviour
{
    private GameManager Manager;

    public float TempoCadaNota = 0.5f;
    public float Delay = 1f;
    private bool Do = true;
    private bool Re = true;
    private bool Mi = true;
    private bool Fa = true;
    private bool Sol = true;
    private bool La = true;
    private bool Si = true;

    private bool Fim = false;
    public float TempoTotalMusica = 0f;
    public float SumirNota = 0.5f;

    private int CountMusic = 0;

    private bool Trava = false;

    private int NotaDo = 0;
    private int NotaRe = 0;
    private int NotaMi = 0;
    private int NotaFa = 0;
    private int NotaSol = 0;
    private int NotaLa = 0;
    private int NotaSi = 0;
    private int NotaDo1 = 0;
    private int NotaRe1 = 0;
    private int NotaMi1 = 0;
    private int NotaFa1 = 0;
    private int NotaSol1 = 0;

    public GameObject Demonstracao;
    public GameObject Imagem;
    public GameObject Gif;
    public GameObject Pontuacao;
   

    private int Acert = 0;

    public string SceneWin;
    void Start()
    {

        CountMusic = 0;
        GameStart();
        StartCoroutine(Musica());
        Manager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    void Update()
    {
        Acert = PlayerPrefs.GetInt("Acertos");

        if (CountMusic == 1 && NotaSi == 1)
        {
            AddScore();
            Manager.V_Si_A();
            CountMusic = 2;

            StartCoroutine(Timer());
            NotaSi = 0;
            Trava = true;

        }
        if (CountMusic == 2 && NotaLa == 1)
        {
            AddScore();
            Manager.V_La_A();
            CountMusic = 3;

            StartCoroutine(Timer());
            NotaLa = 0;
            Trava = true;

        }
        if (CountMusic == 3 && NotaSol == 1)
        {
            AddScore();
            Manager.V_Sol_A();
            CountMusic = 4;

            StartCoroutine(Timer());
            NotaSol = 0;
            Trava = true;

        }
        if (CountMusic == 4 && NotaFa == 1)
        {
            AddScore();
            Manager.V_Fa_A();
            CountMusic = 5;

            StartCoroutine(Timer());
            NotaFa = 0;
            Trava = true;

        }
        if (CountMusic == 5 && NotaMi == 1)
        {
            AddScore();
            Manager.V_Mi_A();
            CountMusic = 6;

            StartCoroutine(Timer());
            NotaMi = 0;
            Trava = true;

        }
        if (CountMusic == 6 && NotaRe == 1)
        {
            AddScore();
            Manager.V_Re_A();
            CountMusic = 7;

            StartCoroutine(Timer());
            NotaRe = 0;
            Trava = true;

        }
        if (CountMusic == 7 && NotaDo == 1)
        {
            AddScore();
            Manager.V_Do_A();
            CountMusic = 8;

            StartCoroutine(Timer());
            NotaDo = 0;
            Trava = true;

        }

    }
    public void AddScore()
    {
        PlayerPrefs.SetInt("Acertos", PlayerPrefs.GetInt("Acertos") + 1);

    }
    public void AddErro()
    {
        PlayerPrefs.SetInt("Erros", PlayerPrefs.GetInt("Erros") + 1);
    }


    public void GameStart() //Começo da Demonstração
    {
        StartCoroutine(NotasMusicas());
    }
    IEnumerator Musica() //Até o fim da musica 
    {
        yield return new WaitForSeconds(TempoTotalMusica);
        Fim = true;
        Demonstracao.SetActive(false);
        Gif.SetActive(false);
        Imagem.SetActive(true);
        Pontuacao.SetActive(true);
        
    }
    IEnumerator Timer() //Sumir Notas
    {
        yield return new WaitForSeconds(SumirNota);

        //Notas a ser Tocadas em Ordem
        if (CountMusic == 2 && Trava == true)
        {
            Manager.V_Si_A();
            Trava = false;
        }
        else if (CountMusic == 3 && Trava == true)
        {
            Manager.V_La_A();
            Trava = false;
        }
        else if (CountMusic == 4 && Trava == true)
        {
            Manager.V_Sol_A();
            Trava = false;
        }
        else if (CountMusic == 5 && Trava == true)
        {
            Manager.V_Fa_A();
            Trava = false;
        }
        else if (CountMusic == 6 && Trava == true)
        {
            Manager.V_Mi_A();
            Trava = false;
        }
        else if (CountMusic == 7 && Trava == true)
        {
            Manager.V_Re_A();
            Trava = false;
        }
        else if (CountMusic == 8 && Trava == true)
        {
            Manager.V_Do_A();
            Trava = false;

            SceneManager.LoadScene(SceneWin);

        }

        // Reset Erros
        else if (NotaDo == 1)
        {
            Manager.V_Do_E();
            NotaDo = 0;
        }
        else if (NotaRe == 1)
        {
            Manager.V_Re_E();
            NotaRe = 0;
        }
        else if (NotaMi == 1)
        {
            Manager.V_Mi_E();
            NotaMi = 0;
        }
        else if (NotaFa == 1)
        {
            Manager.V_Fa_E();
            NotaFa = 0;
        }
        else if (NotaSol == 1)
        {
            Manager.V_Sol_E();
            NotaSol = 0;
        }
        else if (NotaLa == 1)
        {
            Manager.V_La_E();
            NotaLa = 0;
        }
        else if (NotaSi == 1)
        {
            Manager.V_Si_E();
            NotaSi = 0;
        }
        else if (NotaDo1 == 1)
        {
            Manager.V_Do1_E();
            NotaDo1 = 0;
        }
        else if (NotaRe1 == 1)
        {
            Manager.V_Re1_E();
            NotaRe1 = 0;
        }
        else if (NotaMi1 == 1)
        {
            Manager.V_Mi1_E();
            NotaMi1 = 0;
        }
        else if (NotaFa1 == 1)
        {
            Manager.V_Fa1_E();
            NotaFa1 = 0;
        }
        else if (NotaSol1 == 1)
        {
            Manager.V_Sol1_E();
            NotaSol1 = 0;
        }


    }
    IEnumerator NotasMusicas() //Musica
    {
        Demonstracao.SetActive(true);
        Gif.SetActive(true);
        Imagem.SetActive(false);
        Pontuacao.SetActive(false);
       
        yield return new WaitForSeconds(TempoCadaNota);
        if (Si == true)
        {
            Manager.B_Note_Play();
            yield return new WaitForSeconds(Delay);
            Manager.V_Si_P();

        }

        yield return new WaitForSeconds(TempoCadaNota);
        if (La == true)
        {
            Manager.A_Note_Play();
            yield return new WaitForSeconds(Delay);
            Manager.V_Si_P();
            Manager.V_La_P();
            Si = false;

        }

        yield return new WaitForSeconds(TempoCadaNota);
        if (Sol == true)
        {
            Manager.G_Note_Play();
            yield return new WaitForSeconds(Delay);
            Manager.V_La_P();
            Manager.V_Sol_P();
            La = false;

        }

        yield return new WaitForSeconds(TempoCadaNota);
        if (Fa == true)
        {
            Manager.F_Note_Play();
            yield return new WaitForSeconds(Delay);
            Manager.V_Sol_P();
            Manager.V_Fa_P();
            Sol = false;

        }

        yield return new WaitForSeconds(TempoCadaNota);
        if (Mi == true)
        {
            Manager.E_Note_Play();
            yield return new WaitForSeconds(Delay);
            Manager.V_Fa_P();
            Manager.V_Mi_P();
            Fa = false;

        }

        yield return new WaitForSeconds(TempoCadaNota);
        if (Re == true)
        {
            Manager.D_Note_Play();
            yield return new WaitForSeconds(Delay);
            Manager.V_Mi_P();
            Manager.V_Re_P();
            Mi = false;

        }

        yield return new WaitForSeconds(TempoCadaNota);
        if (Do == true)
        {

            Manager.C_Note_Play();
            yield return new WaitForSeconds(Delay);
            Manager.V_Re_P();
            Manager.V_Do_P();
            Re = false;

        }

        yield return new WaitForSeconds(TempoCadaNota);
        Manager.V_Do_P();
        Do = false;
    }
    public void C_Note_Play()
    {
        if (Fim == true)
        {
            NotaDo = 1;
           

            Erros();
            Manager.C_Note.Play();
        }
    }
    public void D_Note_Play()
    {
        if (Fim == true)
        {
            NotaRe = 1;
            Erros();
            Manager.D_Note.Play();
        }
    }
    public void E_Note_Play()
    {
        if (Fim == true)
        {
            NotaMi = 1;
            Erros();
            Manager.E_Note.Play();
        }
    }
    public void F_Note_Play()
    {

        if (Fim == true)
        {
            NotaFa = 1;
            Erros();
            Manager.F_Note.Play();
        }
    }
    public void G_Note_Play()
    {

        if (Fim == true)
        {
            NotaSol = 1;
            Erros();
            Manager.G_Note.Play();
        }
    }
    public void A_Note_Play()
    {
        if (Fim == true)
        {
            NotaLa = 1;
            Erros();
            Manager.A_Note.Play();

        }
    }
    public void B_Note_Play()
    {
        if (Fim == true)
        {
            NotaSi = 1;
            if (CountMusic == 0)
            {
                CountMusic = 1;

            }
            Erros();
            Manager.B_Note.Play();
        }
    }
    public void C1_Note_Play()
    {
        if (Fim == true)
        {
            NotaDo1 = 1;
            Erros();
            Manager.C1_Note.Play();
        }
    }
    public void D1_Note_Play()
    {
        if (Fim == true)
        {
            NotaRe1 = 1;
            Erros();
            Manager.D1_Note.Play();
        }
    }
    public void E1_Note_Play()
    {
        if (Fim == true)
        {
            NotaMi1 = 1;
            Erros();
            Manager.E1_Note.Play();

        }
    }
    public void F1_Note_Play()
    {
        if (Fim == true)
        {
            NotaFa1 = 1;
            Erros();
            Manager.F1_Note.Play();
        }
    }
    public void G1_Note_Play()
    {
        if (Fim == true)
        {
            NotaSol1 = 1;
            Erros();
            Manager.G1_Note.Play();
        }
    }

    public void Erros()
    {
        if (NotaDo == 1 && CountMusic != 7)
        {
            AddErro();
            Manager.V_Do_E();
            StartCoroutine(Timer());
        }
        if (NotaRe == 1 && CountMusic != 6)
        {
            AddErro();
            Manager.V_Re_E();
            StartCoroutine(Timer());
        }
        else if (NotaMi == 1 && CountMusic != 5)
        {
            AddErro();
            Manager.V_Mi_E();
            StartCoroutine(Timer());
        }
        else if (NotaFa == 1 && CountMusic != 4)
        {
            AddErro();
            Manager.V_Fa_E();
            StartCoroutine(Timer());
        }
        else if (NotaSol == 1 && CountMusic != 3)
        {
            AddErro();
            Manager.V_Sol_E();
            StartCoroutine(Timer());
        }
        else if (NotaLa == 1 && CountMusic != 2)
        {
            AddErro();
            Manager.V_La_E();
            StartCoroutine(Timer());
        }
        else if (NotaSi == 1 && CountMusic != 1)
        {
            AddErro();
            Manager.V_Si_E();
            StartCoroutine(Timer());
        }
        else if (NotaDo1 == 1)
        {
            AddErro();
            Manager.V_Do1_E();
            StartCoroutine(Timer());
        }
        else if (NotaRe1 == 1)
        {
            AddErro();
            Manager.V_Re1_E();
            StartCoroutine(Timer());
        }
        else if (NotaMi1 == 1)
        {
            AddErro();
            Manager.V_Mi1_E();
            StartCoroutine(Timer());
        }
        else if (NotaFa1 == 1)
        {
            AddErro();
            Manager.V_Fa1_E();
            StartCoroutine(Timer());
        }
        else if (NotaSol1 == 1)
        {
            AddErro();
            Manager.V_Sol1_E();
            StartCoroutine(Timer());
        }
    }
}

