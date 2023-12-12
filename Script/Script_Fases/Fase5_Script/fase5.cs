using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class fase5 : MonoBehaviour
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
    private bool Do1 = true;
    private bool Re1 = true;
    private bool Mi1 = true;
    private bool Fa1 = true;

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

        if (CountMusic == 1 && NotaSol == 1)
        {
            AddScore();
            Manager.V_Sol_A();
            

            StartCoroutine(Timer());
           
            NotaSol = 0;
            Trava = true;
            CountMusic = 2;
        }
        else if (CountMusic == 2 && NotaSol == 1)
        {
            AddScore();
            Manager.V_Sol_A();
            

           //StartCoroutine(Timer());
            
            NotaSol = 0;
            Trava = true;
            CountMusic = 3;
        }
        else if (CountMusic == 3 && NotaRe1 == 1)
        {
            NotaRe1 = 0;
            AddScore();
            Manager.V_Re1_A();
            

            StartCoroutine(Timer());
            
            
            Trava = true;
            CountMusic = 4;
        }
        else if(CountMusic == 4 && NotaRe1 == 1)
        {
            NotaRe1 = 0;
            AddScore();
            Manager.V_Re1_A();
            
           // StartCoroutine(Timer());
            
            
            Trava = true;
            CountMusic = 5;
        }
        else if(CountMusic == 5 && NotaMi1 == 1)
        {
            AddScore();
            Manager.V_Mi1_A();
            

           StartCoroutine(Timer());
            
            NotaMi1 = 0;
            Trava = true;
            CountMusic = 6;
        }
        else if (CountMusic == 6 && NotaMi1 == 1)
        {
            AddScore();
            Manager.V_Mi1_A();
            
            //StartCoroutine(Timer());
            
            NotaMi1 = 0;
            Trava = true;
            CountMusic = 7;
        }
        else if(CountMusic == 7 && NotaRe1 == 1)
        {
            AddScore();
            Manager.V_Re1_A();
            

            StartCoroutine(Timer());
           
            NotaRe1 = 0;
            Trava = true;
            CountMusic = 8;
        }
        else if(CountMusic == 8 && NotaDo1 == 1)
        {
            AddScore();
            Manager.V_Do1_A();
            

            StartCoroutine(Timer());
            
            NotaDo1 = 0;
            Trava = true;
            CountMusic = 9;
        }
        else if(CountMusic == 9 && NotaDo1 == 1)
        {
            AddScore();
            Manager.V_Do1_A();
            

            //StartCoroutine(Timer());
            
            NotaDo1 = 0;
            Trava = true;
            CountMusic = 10;
        }
        else if (CountMusic == 10 && NotaSi == 1)
        {
            AddScore();
            Manager.V_Si_A();

            StartCoroutine(Timer());

            Trava = true;
            NotaSi = 0;
            CountMusic = 11;
           
        }

        
        else if (PlayerPrefs.GetInt("Fases") == 13 || PlayerPrefs.GetInt("Fases") == 14)
        {
            if (CountMusic == 11 && NotaSi == 1)
            {
                AddScore();
                Manager.V_Si_A();


                 StartCoroutine(Timer());
                NotaSi = 0;
                Trava = true;
                CountMusic = 12;
            }
            else if (CountMusic == 12 && NotaLa == 1)
            {
                AddScore();
                Manager.V_La_A();


                //StartCoroutine(Timer());
                NotaLa = 0;
                Trava = true;
                CountMusic = 13;
            }
            else if (CountMusic == 13 && NotaSol == 1)
            {
                AddScore();
                Manager.V_Sol_A();


                // StartCoroutine(Timer());
                NotaSol = 0;
                Trava = true;
                CountMusic = 14;
            }
            else if (CountMusic == 14 && NotaRe1 == 1)
            {
                AddScore();
                Manager.V_Re1_A();


                //StartCoroutine(Timer());
                NotaRe1 = 0;
                Trava = true;
                CountMusic = 15;
            }
            else if (CountMusic == 15 && NotaRe1 == 1)
            {
                AddScore();
                Manager.V_Re1_A();


                // StartCoroutine(Timer());
                NotaRe1 = 0;
                Trava = true;
                CountMusic = 16;

            }
            else if (CountMusic == 16 && NotaDo1 == 1)
            {
                AddScore();
                Manager.V_Do1_A();


                StartCoroutine(Timer());
                NotaDo1 = 0;
                Trava = true;
                CountMusic = 17;
            }
            else if (CountMusic == 17 && NotaDo1 == 1)
            {
                AddScore();
                Manager.V_Do1_A();


                // StartCoroutine(Timer());
                NotaDo1 = 0;
                Trava = true;
                CountMusic = 18;
            }
            else if (CountMusic == 18 && NotaSi == 1)
            {
                AddScore();
                Manager.V_Si_A();


                StartCoroutine(Timer());
                NotaSi = 0;
                Trava = true;
                CountMusic = 19;
            }
            else if (CountMusic == 19 && NotaSi == 1)
            {
                AddScore();
                Manager.V_Si_A();


                // StartCoroutine(Timer());
                NotaSi = 0;
                Trava = true;
                CountMusic = 20;
            }
            else if (CountMusic == 20 && NotaLa == 1)
            {
                AddScore();
                Manager.V_La_A();


                StartCoroutine(Timer());
                NotaLa = 0;
                Trava = true;
                CountMusic = 21;
            }
            if (PlayerPrefs.GetInt("Fases") == 14)
            {

                 if (CountMusic == 21 && NotaRe1 == 1)
                {
                    AddScore();
                    Manager.V_Re1_A();


                    StartCoroutine(Timer());
                    NotaRe1 = 0;
                    Trava = true;
                    CountMusic = 22;
                }
                else if (CountMusic == 22 && NotaRe1 == 1)
                {
                    AddScore();
                    Manager.V_Re1_A();


                    //  StartCoroutine(Timer());
                    NotaRe1 = 0;
                    Trava = true;
                    CountMusic = 23;
                }
                else if (CountMusic == 23 && NotaDo1 == 1)
                {
                    AddScore();
                    Manager.V_Do1_A();


                    StartCoroutine(Timer());
                    NotaDo1 = 0;
                    Trava = true;
                    CountMusic = 24;
                }
                else if (CountMusic == 24 && NotaDo1 == 1)
                {
                    AddScore();
                    Manager.V_Do1_A();


                    // StartCoroutine(Timer());
                    NotaDo1 = 0;
                    Trava = true;
                    CountMusic = 25;
                }
                else if (CountMusic == 25 && NotaSi == 1)
                {
                    AddScore();
                    Manager.V_Si_A();


                    StartCoroutine(Timer());
                    NotaSi = 0;
                    Trava = true;
                    CountMusic = 26;
                }
                else if (CountMusic == 26 && NotaSi == 1)
                {
                    AddScore();
                    Manager.V_Si_A();


                    // StartCoroutine(Timer());
                    NotaSi = 0;
                    Trava = true;
                    CountMusic = 27;
                }
                else if (CountMusic == 27 && NotaLa == 1)
                {
                    AddScore();
                    Manager.V_La_A();


                    StartCoroutine(Timer());
                    NotaLa = 0;
                    Trava = true;
                    CountMusic = 28;
                }
                else if (CountMusic == 28 && NotaSol == 1)
                {
                    AddScore();
                    Manager.V_Sol_A();


                    StartCoroutine(Timer());
                    NotaSol = 0;
                    Trava = true;
                    CountMusic = 29;
                }
                else if (CountMusic == 29 && NotaSol == 1)
                {
                    AddScore();
                    Manager.V_Sol_A();


                    // StartCoroutine(Timer());
                    NotaSol = 0;
                    Trava = true;
                    CountMusic = 30;
                }
                else if (CountMusic == 30 && NotaRe1 == 1)
                {
                    AddScore();
                    Manager.V_Re1_A();


                    StartCoroutine(Timer());
                    NotaRe1 = 0;
                    Trava = true;
                    CountMusic = 31;
                }
                else if (CountMusic == 31 && NotaRe1 == 1)
                {
                    AddScore();
                    Manager.V_Re1_A();


                    // StartCoroutine(Timer());
                    NotaRe1 = 0;
                    Trava = true;
                    CountMusic = 32;
                }
                else if (CountMusic == 32 && NotaMi1 == 1)
                {
                    AddScore();
                    Manager.V_Mi1_A();


                    StartCoroutine(Timer());
                    NotaMi1 = 0;
                    Trava = true;
                    CountMusic = 33;
                }
                else if (CountMusic == 33 && NotaMi1 == 1)
                {
                    AddScore();
                    Manager.V_Mi1_A();


                    // StartCoroutine(Timer());
                    NotaMi1 = 0;
                    Trava = true;
                    CountMusic = 34;
                }
                else if (CountMusic == 34 && NotaRe1 == 1)
                {
                    AddScore();
                    Manager.V_Re1_A();


                    StartCoroutine(Timer());
                    NotaRe1 = 0;
                    Trava = true;
                    CountMusic = 35;
                }
                else if (CountMusic == 35 && NotaDo1 == 1)
                {
                    AddScore();
                    Manager.V_Do1_A();


                    StartCoroutine(Timer());
                    NotaDo1 = 0;
                    Trava = true;
                    CountMusic = 36;
                }
                else if (CountMusic == 36 && NotaDo1 == 1)
                {
                    AddScore();
                    Manager.V_Do1_A();


                    //StartCoroutine(Timer());
                    NotaDo1 = 0;
                    Trava = true;
                    CountMusic = 37;
                }
                else if (CountMusic == 37 && NotaSi == 1)
                {
                    AddScore();
                    Manager.V_Si_A();


                    StartCoroutine(Timer());
                    NotaSi = 0;
                    Trava = true;
                    CountMusic = 38;
                }
                else if (CountMusic == 38 && NotaSi == 1)
                {
                    AddScore();
                    Manager.V_Si_A();


                    // StartCoroutine(Timer());
                    NotaSi = 0;
                    Trava = true;
                    CountMusic = 39;
                }
                else if (CountMusic == 39 && NotaLa == 1)
                {
                    AddScore();
                    Manager.V_La_A();


                    StartCoroutine(Timer());
                    NotaLa = 0;
                    Trava = true;
                    CountMusic = 40;
                }
                else if (CountMusic == 40 && NotaSol == 1)
                {
                    AddScore();
                    Manager.V_Sol_A();


                    StartCoroutine(Timer());
                    NotaSol = 0;
                    Trava = true;
                    CountMusic = 41;
                }
            }
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
        if (CountMusic == 1 && Trava == true)
        {
            Manager.V_Sol_A();
            NotaSol = 0;
            Trava = false;
        }
        else if (CountMusic == 2 && Trava == true)
        {
            Manager.V_Sol_A();
            NotaSol = 0;
            Trava = false;
        }
        
        else if (CountMusic == 3 && Trava == true)
        {
            Manager.V_Re1_A();
            NotaRe1 = 0;
            Trava = false;
        }
        else if (CountMusic ==4 && Trava == true)
        {
            Manager.V_Re1_A();
            NotaRe1 = 0;
            Trava = false;
        }
        else if (CountMusic == 5 && Trava == true)
        {
            Manager.V_Mi1_A();
            NotaMi1 = 0;
            Trava = false;
        }
        else if (CountMusic == 6 && Trava == true)
        {
            Manager.V_Mi1_A();
            NotaMi1 = 0;
            Trava = false;
        }
        else if (CountMusic == 7 && Trava == true)
        {
            Manager.V_Re1_A();
            NotaRe1 = 0;
            Trava = false;
        }
        else if (CountMusic == 8 && Trava == true)
        {
            Manager.V_Do1_A();
            NotaDo1 = 0;
            Trava = false;
        }
        else if (CountMusic == 9 && Trava == true)
        {
            Manager.V_Do1_A();
            NotaDo1 = 0;
            Trava = false;
        }
        else if (CountMusic == 10 && Trava == true)
        {
            
            Manager.V_Si_A();
            NotaSi = 0;
            Trava = false;
            if (PlayerPrefs.GetInt("Fases") == 12)
            {
                SceneManager.LoadScene(SceneWin);
            }
        }
        else if (CountMusic == 11 && Trava == true)
        {
            Manager.V_Si_A();
            NotaSi = 0;
            Trava = false;
        }
        else if (CountMusic == 12 && Trava == true)
        {
            Manager.V_La_A();
            NotaLa = 0;
            Trava = false;
        }
        else if (CountMusic == 13 && Trava == true)
        {
            Manager.V_Sol_A();
            NotaSol = 0;
            Trava = false;
        }
        else if (CountMusic == 14 && Trava == true)
        {
            Manager.V_Re1_A();
            NotaRe1 = 0;
            Trava = false;
        }
        else if (CountMusic == 15 && Trava == true)
        {
            Manager.V_Re1_A();
            NotaRe1 = 0;
            Trava = false;
        }
        else if (CountMusic == 16 && Trava == true)
        {
            Manager.V_Do1_A();
            Trava = false;
        }
        else if (CountMusic == 17 && Trava == true)
        {
            Manager.V_Do1_A();
            Trava = false;
        }
        else if (CountMusic == 18 && Trava == true)
        {
            Manager.V_Si_A();
            Trava = false;
        }
        else if (CountMusic == 19 && Trava == true)
        {
            Manager.V_Si_A();
            Trava = false;
        }
        else if (CountMusic == 20 && Trava == true)
        {
            Manager.V_La_A();
            Trava = false;
            if (PlayerPrefs.GetInt("Fases") == 13)
            {
                SceneManager.LoadScene(SceneWin);
            }
        }
        else if (CountMusic == 21 && Trava == true)
        {
            Manager.V_Re1_A();
            Trava = false;
        }
        else if (CountMusic == 22 && Trava == true)
        {
            Manager.V_Re1_A();
            Trava = false;
        }
        else if (CountMusic == 23 && Trava == true)
        {
            Manager.V_Do1_A();
            Trava = false;
        }
        else if (CountMusic == 24 && Trava == true)
        {
            Manager.V_Do1_A();
            Trava = false;
        }
        else if (CountMusic == 25 && Trava == true)
        {
            Manager.V_Si_A();
            Trava = false;
        }
        else if (CountMusic == 26 && Trava == true)
        {
            Manager.V_Si_A();
            Trava = false;
        }
        else if (CountMusic == 27 && Trava == true)
        {
            Manager.V_La_A();
            Trava = false;
        }
        
        else if (CountMusic == 28 && Trava == true)
        {
            Manager.V_Sol_A();
            Trava = false;
        }
        else if (CountMusic == 29 && Trava == true)
        {
            Manager.V_Sol_A();
            Trava = false;
        }
        else if (CountMusic == 30 && Trava == true)
        {
            Manager.V_Re1_A();
            Trava = false;
        }
        else if (CountMusic == 31 && Trava == true)
        {
            Manager.V_Re1_A();
            Trava = false;
        }
        else if (CountMusic == 32 && Trava == true)
        {
            Manager.V_Mi1_A();
            Trava = false;
        }
        else if (CountMusic == 33 && Trava == true)
        {
            Manager.V_Mi1_A();
            Trava = false;
        }
        else if (CountMusic == 34 && Trava == true)
        {
            Manager.V_Re1_A();
            Trava = false;
        }
        else if (CountMusic == 35 && Trava == true)
        {
            Manager.V_Do1_A();
            Trava = false;
        }
        else if (CountMusic == 36 && Trava == true)
        {
            Manager.V_Do1_A();
            Trava = false;
        }
        else if (CountMusic == 37 && Trava == true)
        {
            Manager.V_Si_A();
            Trava = false;
        }
        else if (CountMusic == 38 && Trava == true)
        {
            Manager.V_Si_A();
            Trava = false;
        }
        else if (CountMusic == 39 && Trava == true)
        {
            Manager.V_La_A();
            Trava = false;
        }
        else if (CountMusic == 40 && Trava == true)
        {
            Manager.V_Sol_A();
            Trava = false;


            if (PlayerPrefs.GetInt("Fases") == 14)
            {
                SceneManager.LoadScene(SceneWin);
            }

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
        if (Sol == true)
        {
            Manager.G_Note_Play();
            yield return new WaitForSeconds(Delay);
            Manager.V_Sol_P();

        }

        yield return new WaitForSeconds(TempoCadaNota);
        if (Sol == true)
        {
            Manager.G_Note_Play();
            yield return new WaitForSeconds(Delay);
          
          
           // Sol = false;

        }

        yield return new WaitForSeconds(TempoCadaNota);
        if (Re1 == true)
        {
            Manager.D1_Note_Play();
            yield return new WaitForSeconds(Delay);
            Manager.V_Sol_P();
            Manager.V_Re1_P();
           // Sol = false;

        }

        yield return new WaitForSeconds(TempoCadaNota);
        if (Re1 == true)
        {
            Manager.D1_Note_Play();
            yield return new WaitForSeconds(Delay);
          
         
           //Re = false;

        }

        yield return new WaitForSeconds(TempoCadaNota);
        if (Mi1 == true)
        {
            Manager.E1_Note_Play();
            yield return new WaitForSeconds(Delay);
            Manager.V_Re1_P();
            Manager.V_Mi1_P();
           // Re = false;

        }

        yield return new WaitForSeconds(TempoCadaNota);
        if (Mi1 == true)
        {
            Manager.E1_Note_Play();
            yield return new WaitForSeconds(Delay);
           
            //Mi = false;

        }

        yield return new WaitForSeconds(TempoCadaNota);
        if (Re1 == true)
        {
            Manager.D1_Note_Play();
            yield return new WaitForSeconds(Delay);
            Manager.V_Mi1_P();
            Manager.V_Re1_P();
          //  Mi = false;

        }

        yield return new WaitForSeconds(TempoCadaNota);
        if (Do1 == true)
        {
            Manager.C1_Note_Play();
            yield return new WaitForSeconds(Delay);
            Manager.V_Re1_P();
            Manager.V_Do1_P();
           // Re = false;

        }

        yield return new WaitForSeconds(TempoCadaNota);
        if (Do1 == true)
        {
            Manager.C1_Note_Play();
            yield return new WaitForSeconds(Delay);
           
            //Do = false;

        }

        yield return new WaitForSeconds(TempoCadaNota);
        if (Si == true)
        {

            Manager.B_Note_Play();
            yield return new WaitForSeconds(Delay);
            Manager.V_Do1_P();
            Manager.V_Si_P();
           // Do = false;

        }
           
        yield return new WaitForSeconds(TempoCadaNota);
        Manager.V_Si_P();
        if (PlayerPrefs.GetInt("Fases") >= 13)
        {

            if (Si == true)
            {

                Manager.B_Note_Play();
                yield return new WaitForSeconds(Delay);
                Manager.V_Si_P();
                // Si = false;

            }
            yield return new WaitForSeconds(TempoCadaNota);
            if (La == true)
            {

                Manager.A_Note_Play();
                yield return new WaitForSeconds(Delay);
                Manager.V_Si_P();
                Manager.V_La_P();
                // Si = false;

            }
            yield return new WaitForSeconds(TempoCadaNota);
            if (Sol == true)
            {

                Manager.G_Note_Play();
                yield return new WaitForSeconds(Delay);
                Manager.V_Sol_P();
                Manager.V_La_P();
                // La = false;

            }

            yield return new WaitForSeconds(TempoCadaNota);
            if (Re1 == true)
            {

                Manager.D1_Note_Play();
                yield return new WaitForSeconds(Delay);
                Manager.V_Re1_P();
                Manager.V_Sol_P();
                // La = false;

            }
            yield return new WaitForSeconds(TempoCadaNota);
            if (Re1 == true)
            {

                Manager.D1_Note_Play();
                yield return new WaitForSeconds(Delay);
                // Manager.V_Re_P();
                // Manager.V_Sol_P();
                // La = false;
            }

            yield return new WaitForSeconds(TempoCadaNota);
            if (Do1 == true)
            {

                Manager.C1_Note_Play();
                yield return new WaitForSeconds(Delay);
                Manager.V_Do1_P();
                Manager.V_Re1_P();
                // La = false;
            }
            yield return new WaitForSeconds(TempoCadaNota);
            if (Do1 == true)
            {

                Manager.C1_Note_Play();
                yield return new WaitForSeconds(Delay);
                //  Manager.V_Do_P();
                // Manager.V_Re_P();
                // La = false;
            }
            yield return new WaitForSeconds(TempoCadaNota);
            if (Si == true)
            {

                Manager.B_Note_Play();
                yield return new WaitForSeconds(Delay);
                Manager.V_Si_P();
                Manager.V_Do1_P();
                // La = false;
            }
            yield return new WaitForSeconds(TempoCadaNota);
            if (Si == true)
            {

                Manager.B_Note_Play();
                yield return new WaitForSeconds(Delay);
                //Manager.V_Si_P();
                //Manager.V_Do_P();
                // La = false;
            }
            yield return new WaitForSeconds(TempoCadaNota);
            if (La == true)
            {

                Manager.A_Note_Play();
                yield return new WaitForSeconds(Delay);
                Manager.V_La_P();
                Manager.V_Si_P();
                // La = false;
            }
            
                yield return new WaitForSeconds(TempoCadaNota);
                Manager.V_La_P();
            if (PlayerPrefs.GetInt("Fases") >= 14)
            {
                if (Re1 == true)
                {

                    Manager.D1_Note_Play();
                    yield return new WaitForSeconds(Delay);
                   
                    Manager.V_Re1_P();
                    // La = false;
                }
                yield return new WaitForSeconds(TempoCadaNota);
                if (Re1 == true)
                {

                    Manager.D1_Note_Play();
                    yield return new WaitForSeconds(Delay);
                    //Manager.V_La_P();
                    // Manager.V_Re_P();
                    // La = false;
                }
                yield return new WaitForSeconds(TempoCadaNota);
                if (Do1 == true)
                {

                    Manager.C1_Note_Play();
                    yield return new WaitForSeconds(Delay);
                    Manager.V_Do1_P();
                    Manager.V_Re1_P();
                    // La = false;
                }
                yield return new WaitForSeconds(TempoCadaNota);
                if (Do1 == true)
                {

                    Manager.C1_Note_Play();
                    yield return new WaitForSeconds(Delay);
                    //  Manager.V_Do_P();
                    // Manager.V_Re_P();
                    // La = false;
                }
                yield return new WaitForSeconds(TempoCadaNota);
                if (Si == true)
                {

                    Manager.B_Note_Play();
                    yield return new WaitForSeconds(Delay);
                    Manager.V_Si_P();
                    Manager.V_Do1_P();
                    // La = false;
                }
                yield return new WaitForSeconds(TempoCadaNota);
                if (Si == true)
                {

                    Manager.B_Note_Play();
                    yield return new WaitForSeconds(Delay);
                    //Manager.V_Si_P();
                    //Manager.V_Do_P();
                    // La = false;
                }
                yield return new WaitForSeconds(TempoCadaNota);
                if (La == true)
                {

                    Manager.A_Note_Play();
                    yield return new WaitForSeconds(Delay);
                    Manager.V_La_P();
                    Manager.V_Si_P();
                    // La = false;
                }
                yield return new WaitForSeconds(TempoCadaNota);
                if (Sol == true)
                {
                    Manager.G_Note_Play();
                    yield return new WaitForSeconds(Delay);
                    Manager.V_Sol_P();
                    Manager.V_La_P();

                }

                yield return new WaitForSeconds(TempoCadaNota);
                if (Sol == true)
                {
                    Manager.G_Note_Play();
                    yield return new WaitForSeconds(Delay);


                    // Sol = false;

                }

                yield return new WaitForSeconds(TempoCadaNota);
                if (Re1 == true)
                {
                    Manager.D1_Note_Play();
                    yield return new WaitForSeconds(Delay);
                    Manager.V_Sol_P();
                    Manager.V_Re1_P();
                    // Sol = false;

                }

                yield return new WaitForSeconds(TempoCadaNota);
                if (Re1 == true)
                {
                    Manager.D1_Note_Play();
                    yield return new WaitForSeconds(Delay);


                    //Re = false;

                }

                yield return new WaitForSeconds(TempoCadaNota);
                if (Mi1 == true)
                {
                    Manager.E1_Note_Play();
                    yield return new WaitForSeconds(Delay);
                    Manager.V_Re1_P();
                    Manager.V_Mi1_P();
                    // Re = false;

                }

                yield return new WaitForSeconds(TempoCadaNota);
                if (Mi1 == true)
                {
                    Manager.E1_Note_Play();
                    yield return new WaitForSeconds(Delay);

                    //Mi = false;

                }

                yield return new WaitForSeconds(TempoCadaNota);
                if (Re1 == true)
                {
                    Manager.D1_Note_Play();
                    yield return new WaitForSeconds(Delay);
                    Manager.V_Mi1_P();
                    Manager.V_Re1_P();
                    //  Mi = false;

                }

                yield return new WaitForSeconds(TempoCadaNota);
                if (Do1 == true)
                {
                    Manager.C1_Note_Play();
                    yield return new WaitForSeconds(Delay);
                    Manager.V_Re1_P();
                    Manager.V_Do1_P();
                    // Re = false;

                }

                yield return new WaitForSeconds(TempoCadaNota);
                if (Do1 == true)
                {
                    Manager.C1_Note_Play();
                    yield return new WaitForSeconds(Delay);

                    //Do = false;

                }

                yield return new WaitForSeconds(TempoCadaNota);
                if (Si == true)
                {

                    Manager.B_Note_Play();
                    yield return new WaitForSeconds(Delay);
                    Manager.V_Do1_P();
                    Manager.V_Si_P();
                    // Do = false;

                }

                yield return new WaitForSeconds(TempoCadaNota);
                if (Si == true)
                {

                    Manager.B_Note_Play();
                    yield return new WaitForSeconds(Delay);

                    // Si = false;

                }
                yield return new WaitForSeconds(TempoCadaNota);
                if (La == true)
                {

                    Manager.A_Note_Play();
                    yield return new WaitForSeconds(Delay);
                    Manager.V_Si_P();
                    Manager.V_La_P();
                    // Si = false;

                }
                yield return new WaitForSeconds(TempoCadaNota);
                if (Sol == true)
                {

                    Manager.G_Note_Play();
                    yield return new WaitForSeconds(Delay);
                    Manager.V_Sol_P();
                    Manager.V_La_P();
                    // La = false;

                }



                yield return new WaitForSeconds(TempoCadaNota);
                Manager.V_Sol_P();
                // Sol = false;
            }
        }
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
            if (CountMusic == 0)
            {
                CountMusic = 1;

            }
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
        if (NotaDo1 == 1 && CountMusic != 8 && CountMusic != 9 && CountMusic != 16 && CountMusic != 17 && CountMusic != 23 && CountMusic != 24 && CountMusic != 35 && CountMusic != 36)
        {
            AddErro();
            Manager.V_Do1_E();
            StartCoroutine(Timer());
        }
        else if (NotaRe1 == 1 && CountMusic != 3 && CountMusic != 4 && CountMusic != 7 && CountMusic != 14 && CountMusic != 15 && CountMusic != 21 && CountMusic != 22 && CountMusic != 30 && CountMusic != 31 && CountMusic != 34 )
        {
            AddErro();
            Manager.V_Re1_E();
            StartCoroutine(Timer());
        }
        else if (NotaMi1 == 1 && CountMusic != 5 && CountMusic != 6 && CountMusic != 32 && CountMusic != 33)
        {
            AddErro();
            Manager.V_Mi1_E();
            StartCoroutine(Timer());
        }
      
        else if (NotaSol == 1 && CountMusic != 1 && CountMusic != 2 && CountMusic != 13 && CountMusic != 28 && CountMusic != 29 && CountMusic != 40)
        {
            AddErro();
            Manager.V_Sol_E();
            StartCoroutine(Timer());
        }
        else if (NotaLa == 1 && CountMusic != 12 && CountMusic != 20 && CountMusic != 27 && CountMusic != 39)
        {
            AddErro();
            Manager.V_La_E();
            StartCoroutine(Timer());
        }
        else if (NotaSi == 1 && CountMusic != 10 && CountMusic != 11 && CountMusic != 18 && CountMusic != 19 && CountMusic != 25 && CountMusic != 26   && CountMusic != 37 && CountMusic != 38)
        {
            AddErro();
            Manager.V_Si_E();
            StartCoroutine(Timer());
        }
        else if (NotaDo == 1)
        {
            AddErro();
            Manager.V_Do_E();
            StartCoroutine(Timer());
        }
        else if (NotaRe == 1)
        {
            AddErro();
            Manager.V_Re_E();
            StartCoroutine(Timer());
        }
        else if (NotaMi == 1)
        {
            AddErro();
            Manager.V_Mi_E();
            StartCoroutine(Timer());
        }
        else if (NotaFa1 == 1)
        {
            AddErro();
            Manager.V_Fa1_E();
            StartCoroutine(Timer());
        }
        else if (NotaFa == 1)
        {
            AddErro();
            Manager.V_Fa_E();
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

