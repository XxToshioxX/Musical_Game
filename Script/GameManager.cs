using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{

    //Som das Notas
    public AudioSource C_Note;
    public AudioSource D_Note;
    public AudioSource E_Note;
    public AudioSource F_Note;
    public AudioSource G_Note;
    public AudioSource A_Note;
    public AudioSource B_Note;
    public AudioSource C1_Note;
    public AudioSource D1_Note;
    public AudioSource E1_Note;
    public AudioSource F1_Note;
    public AudioSource G1_Note;
    //public AudioSource CS_Note;
    //public AudioSource DS_Note;
    //public AudioSource FS_Note;
    //public AudioSource GS_Note;
    //public AudioSource Bb_Note;
    //public AudioSource CS1_Note;
    //public AudioSource DS1_Note;
    //public AudioSource FS1_Note;


    //Musicas
    //public AudioSource[] Music;
    //private AudioSource Musica1;
    //private AudioSource Musica2;
    //private AudioSource Musica3;
    //private AudioSource Musica4;
    //private AudioSource Musica5;
    //private AudioSource Musica6;
    //private AudioSource Musica7;



    //Jogo
    //Acertos
    public GameObject[] Acertos;
    private GameObject DoA;
    private GameObject ReA;
    private GameObject MiA;
    private GameObject FaA;
    private GameObject SolA;
    private GameObject LaA;
    private GameObject SiA;
    private GameObject Do1A;
    private GameObject Re1A;
    private GameObject Mi1A;
    private GameObject Fa1A;
    private GameObject Sol1A;

    //Erros
    public GameObject[] Erro;
    private GameObject DoE;
    private GameObject ReE;
    private GameObject MiE;
    private GameObject FaE;
    private GameObject SolE;
    private GameObject LaE;
    private GameObject SiE;
    private GameObject Do1E;
    private GameObject Re1E;
    private GameObject Mi1E;
    private GameObject Fa1E;
    private GameObject Sol1E;

    //Pressionar
    public GameObject[] Press;
    private GameObject DoP;
    private GameObject ReP;
    private GameObject MiP;
    private GameObject FaP;
    private GameObject SolP;
    private GameObject LaP;
    private GameObject SiP;
    private GameObject Do1P;
    private GameObject Re1P;
    private GameObject Mi1P;
    private GameObject Fa1P;
    private GameObject Sol1P;

    //Aparecer/Sumir

    //Acertos
    private bool CondDoA = false;
    private bool CondReA = false;
    private bool CondMiA = false;
    private bool CondFaA = false;
    private bool CondSolA = false;
    private bool CondLaA = false;
    private bool CondSiA = false;
    private bool CondDo1A = false;
    private bool CondRe1A = false;
    private bool CondMi1A = false;
    private bool CondFa1A = false;
    private bool CondSol1A = false;

    //Erro
    private bool CondDoE = false;
    private bool CondReE = false;
    private bool CondMiE = false;
    private bool CondFaE = false;
    private bool CondSolE = false;
    private bool CondLaE = false;
    private bool CondSiE = false;
    private bool CondDo1E = false;
    private bool CondRe1E = false;
    private bool CondMi1E = false;
    private bool CondFa1E = false;
    private bool CondSol1E = false;

    //Pressionado
    private bool CondDoP = false;
    private bool CondReP = false;
    private bool CondMiP = false;
    private bool CondFaP = false;
    private bool CondSolP = false;
    private bool CondLaP = false;
    private bool CondSiP = false;
    private bool CondDo1P = false;
    private bool CondRe1P = false;
    private bool CondMi1P = false;
    private bool CondFa1P = false;
    private bool CondSol1P = false;

    
    
    void Start()
    {
      
        PlayerPrefs.SetInt("Pontuacao",0);
        PlayerPrefs.SetInt("Acertos",0);
        PlayerPrefs.SetInt("Erros",0);


        //Musicas
        //if(Music[0] != null)
        //{
        //    Musica1 = Music[0];
        //}
        //if(Music[1] != null)
        //{
        //    Musica2 = Music[1];
        //}       
        //if (Music[2] != null)
        //{
        //    Musica3 = Music[2];
        //}  
        //if (Music[3]!= null)
        //{
        //    Musica4 = Music[3];

        //}
        //if (Music[4] != null)
        //{
        //    Musica5 = Music[4];
        //}
        //if (Music[5] != null)
        //{
        //    Musica6 = Music[5];
        //}
        //if (Music[6] != null)
        //{
        //    Musica7 = Music[6];
        //}



    }
    void Update()
    {
        //print(PlayerPrefs.GetInt("Erros"));
        //print(PlayerPrefs.GetInt("Acertos"));
        AtualizarNotas();

        
    }
    IEnumerator AttNotaNormalA()
    {
        yield return new WaitForSeconds(1);
        if (CondDoA == true)
        {
            DoA.SetActive(false);
            CondDoA = false;
        }
        if (CondReA == true)
        {
            ReA.SetActive(false);
            CondReA = false;
        }
        if (CondMiA == true)
        {
            MiA.SetActive(false);
            CondMiA = false;
        }
        if (CondFaA == true)
        {
            FaA.SetActive(false);
            CondFaA = false;
        }
        if (CondSolA == true)
        {
            SolA.SetActive(false);
            CondSolA = false;
        }
        if (CondLaA == true)
        {
            LaA.SetActive(false);
            CondLaA = false;
        }
         if (CondSiA == true)
        {
            SiA.SetActive(false);
            CondSiA = false;
        }
        if (CondDo1A == true)
        {
            Do1A.SetActive(false);
            CondDo1A = false;
        }
        if (CondRe1A == true)
        {
            Re1A.SetActive(false);
            CondRe1A = false;
        }
        if (CondMi1A == true)
        {
            Mi1A.SetActive(false);
            CondMi1A = false;
        }
        if (CondFa1A == true)
        {
            Fa1A.SetActive(false);
            CondFa1A = false;
        }
        if (CondSol1A == true)
        {
            Sol1A.SetActive(false);
            CondSol1A = false;
        }
    }
        IEnumerator AttNotaNormalE()
    {
        yield return new WaitForSeconds(1);
        if (CondDoE == true)
        {
            DoE.SetActive(false);
            CondDoE = false;
        }
        if (CondReE == true)
        {
            ReE.SetActive(false);
            CondReE = false;
        }
        if (CondMiE == true)
        {
            MiE.SetActive(false);
            CondMiE = false;
        }
        if (CondFaE == true)
        {
            FaE.SetActive(false);
            CondFaE = false;
        }
        if (CondSolE == true)
        {
            SolE.SetActive(false);
            CondSolE = false;
        }
        if (CondLaE == true)
        {
            LaE.SetActive(false);
            CondLaE = false;
        }
        if (CondSiE == true)
        {
            SiE.SetActive(false);
            CondSiE = false;
        }
        if (CondDo1E == true)
        {
            Do1E.SetActive(false);
            CondDo1E = false;
        }
        if (CondRe1E == true)
        {
            Re1E.SetActive(false);
            CondRe1E = false;
        }
        if (CondMi1E == true)
        {
            Mi1E.SetActive(false);
            CondMi1E = false;
        }
        if (CondFa1E == true)
        {
            Fa1E.SetActive(false);
            CondFa1E = false;
           
        }
        if (CondSol1E == true)
        {
            Sol1E.SetActive(false);
            CondSol1E = false;
        }
    }


    public void AtualizarNotas()
    {
        //Notas Acertos
        DoA = Acertos[0];
        ReA = Acertos[1];
        MiA = Acertos[2];
        FaA = Acertos[3];
        SolA = Acertos[4];
        LaA = Acertos[5];
        SiA = Acertos[6];
        Do1A = Acertos[7];
        Re1A = Acertos[8];
        Mi1A = Acertos[9];
        Fa1A = Acertos[10];
        Sol1A = Acertos[11];

        //Notas Erros
        DoE = Erro[0];
        ReE = Erro[1];
        MiE = Erro[2];
        FaE = Erro[3];
        SolE = Erro[4];
        LaE = Erro[5];
        SiE = Erro[6];
        Do1E = Erro[7];
        Re1E = Erro[8];
        Mi1E = Erro[9];
        Fa1E = Erro[10];
        Sol1E = Erro[11];

        //Notas Pressionar
        DoP = Press[0];
        ReP = Press[1];
        MiP = Press[2];
        FaP = Press[3];
        SolP = Press[4];
        LaP = Press[5];
        SiP = Press[6];
        Do1P = Press[7];
        Re1P = Press[8];
        Mi1P = Press[9];
        Fa1P = Press[10];
        Sol1P = Press[11];
    }

    //Som das Notas
    public void C_Note_Play()
    {
       
            C_Note.Play();
                     
    }
    public void D_Note_Play()
    {
       
            D_Note.Play();
        
    }
    public void E_Note_Play()
    {
      E_Note.Play();
        
          
    }
    public void F_Note_Play()
    {
          F_Note.Play();
               
    }
    public void G_Note_Play()
    {
        G_Note.Play();
              
    }
    public void A_Note_Play()
    {
        A_Note.Play();
            
    }
    public void B_Note_Play()
    {
       
            B_Note.Play();
            
    }
    public void C1_Note_Play()
    {
        C1_Note.Play();
        
    }
    public void D1_Note_Play()
    {
       
            D1_Note.Play();
      
    }
    public void E1_Note_Play()
    {
        E1_Note.Play();
             
    }
    public void F1_Note_Play()
    {
       F1_Note.Play();
        
    }
    public void G1_Note_Play()
    {
      G1_Note.Play();
        
    }
    //public void CS_Note_Play()
    //{
    //    CS_Note.Play();
    //}
    //public void DS_Note_Play()
    //{
    //    DS_Note.Play();
    //}
    //public void FS_Note_Play()
    //{
    //    FS_Note.Play();
    //}
    //public void GS_Note_Play()
    //{
    //    GS_Note.Play();
    //}
    //public void Bb_Note_Play()
    //{
    //    Bb_Note.Play();
    //}
    //public void CS1_Note_Play()
    //{
    //    CS1_Note.Play();
    //}
    //public void DS1_Note_Play()
    //{
    //    DS1_Note.Play();
    //}
    //public void FS1_Note_Play()
    //{
    //    FS1_Note.Play();
    //}

    //Canvas

    //Acerto
    public void V_Do_A() 
    {
        if(CondDoA == false)
        {
            DoA.SetActive(true);
            CondDoA = true;
            StartCoroutine(AttNotaNormalA());
        }
        StartCoroutine(AttNotaNormalA());
        //else if (CondDoA == true)
        //{
        //    DoA.SetActive(false);
        //    CondDoA = false;
        //}
    }
    public void V_Re_A()
    {
        if (CondReA == false)
        {
            ReA.SetActive(true);
            CondReA = true;
            StartCoroutine(AttNotaNormalA());
        }
        StartCoroutine(AttNotaNormalA());
        //else if (CondReA == true)
        //{
        //    ReA.SetActive(false);
        //    CondReA = false;
        //}
    }
    public void V_Mi_A()
    {
        if (CondMiA == false)
        {
            MiA.SetActive(true);
            CondMiA = true;
            StartCoroutine(AttNotaNormalA());
        }
        StartCoroutine(AttNotaNormalA());
        //else if (CondMiA == true)
        //{
        //    MiA.SetActive(false);
        //    CondMiA = false;
        //}
    }
    public void V_Fa_A()
    {
        if (CondFaA == false)
        {
            FaA.SetActive(true);
            CondFaA = true;
            StartCoroutine(AttNotaNormalA());
        }
        StartCoroutine(AttNotaNormalA());
        //else if (CondFaA == true)
        //{
        //    FaA.SetActive(false);
        //    CondFaA = false;
        //}
    }
    public void V_Sol_A()
    {
        if (CondSolA == false)
        {
            SolA.SetActive(true);
            CondSolA = true;
            StartCoroutine(AttNotaNormalA());
        }
        StartCoroutine(AttNotaNormalA());
        //else if (CondSolA == true)
        //{
        //    SolA.SetActive(false);
        //    CondSolA = false;
        //}
    }
    public void V_La_A()
    {
        if (CondLaA == false)
        {
            LaA.SetActive(true);
            CondLaA = true;
            StartCoroutine(AttNotaNormalA());
        }
        StartCoroutine(AttNotaNormalA());
        //else if (CondLaA == true)
        //{
        //    LaA.SetActive(false);
        //    CondLaA = false;
        //}
    }
    public void V_Si_A()
    {
        if (CondSiA == false)
        {
            SiA.SetActive(true);
            CondSiA = true;
            StartCoroutine(AttNotaNormalA());
        }
        StartCoroutine(AttNotaNormalA());
        //else if (CondSiA == true)
        //{
        //    SiA.SetActive(false);
        //    CondSiA = false;
        //}
    }
    public void V_Do1_A()
    {
        if (CondDo1A == false)
        {
            Do1A.SetActive(true);
            CondDo1A = true;
            StartCoroutine(AttNotaNormalA());
        }
        StartCoroutine(AttNotaNormalA());
        //else if (CondDo1A == true)
        //{
        //    Do1A.SetActive(false);
        //    CondDo1A = false;
        //}
    }
    public void V_Re1_A()
    {
        if (CondRe1A == false)
        {
            Re1A.SetActive(true);
            CondRe1A = true;
            StartCoroutine(AttNotaNormalA());
        }
        StartCoroutine(AttNotaNormalA());
        //else if (CondRe1A == true)
        //{
        //    Re1A.SetActive(false);
        //    CondRe1A = false;
        //}
    }
    public void V_Mi1_A()
    {
        if (CondMi1A == false)
        {
            Mi1A.SetActive(true);
            CondMi1A = true;
            StartCoroutine(AttNotaNormalA());
        }
        StartCoroutine(AttNotaNormalA());
        //else if (CondMi1A == true)
        //{
        //    Mi1A.SetActive(false);
        //    CondMi1A = false;
        //}
    }
    public void V_Fa1_A()
    {
        if (CondFa1A == false)
        {
            Fa1A.SetActive(true);
            CondFa1A = true;
            StartCoroutine(AttNotaNormalA());
        }
        StartCoroutine(AttNotaNormalA());
        //else if (CondFa1A == true)
        //{
        //    Fa1A.SetActive(false);
        //    CondFa1A = false;
        //}
    }
    public void V_Sol1_A()
    {
        if (CondSol1A == false)
        {
            Sol1A.SetActive(true);
            CondSol1A = true;
            StartCoroutine(AttNotaNormalA());
        }
        StartCoroutine(AttNotaNormalA());
        //else if (CondSol1A == true)
        //{
        //    Sol1A.SetActive(false);
        //    CondSol1A = false;
        //}
    }

    //Erro
    public void V_Do_E()
    {
        if (CondDoE == false)
        {
            DoE.SetActive(true);
            CondDoE = true;
            StartCoroutine(AttNotaNormalE());
        }
        StartCoroutine(AttNotaNormalE());
        //else if (CondDoE == true)
        //{
        //    DoE.SetActive(false);
        //    CondDoE = false;
        //}
    }
    public void V_Re_E()
    {
        if (CondReE == false)
        {
            ReE.SetActive(true);
            CondReE = true;
            StartCoroutine(AttNotaNormalE());
        }
        StartCoroutine(AttNotaNormalE());
        //else if (CondReE == true)
        //{
        //    ReE.SetActive(false);
        //    CondReE = false;
        //}
    }
    public void V_Mi_E()
    {
        if (CondMiE == false)
        {
            MiE.SetActive(true);
            CondMiE = true;
            StartCoroutine(AttNotaNormalE());
        }
        StartCoroutine(AttNotaNormalE());
        //else if (CondMiE == true)
        //{
        //    MiE.SetActive(false);
        //    CondMiE = false;
        //}
    }
    public void V_Fa_E()
    {
        if (CondFaE == false)
        {
            FaE.SetActive(true);
            CondFaE = true;
            StartCoroutine(AttNotaNormalE());
        }
        StartCoroutine(AttNotaNormalE());
        //else if (CondFaE == true)
        //{
        //    FaE.SetActive(false);
        //    CondFaE = false;
        //}
    }
    public void V_Sol_E()
    {
        if (CondSolE == false)
        {
            SolE.SetActive(true);
            CondSolE = true;
            StartCoroutine(AttNotaNormalE());
        }
        StartCoroutine(AttNotaNormalE());
        //else if (CondSolE == true)
        //{
        //    SolE.SetActive(false);
        //    CondSolE = false;
        //}
    }
    public void V_La_E()
    {
        if (CondLaE == false)
        {
            LaE.SetActive(true);
            CondLaE = true;
            StartCoroutine(AttNotaNormalE());
        }
        StartCoroutine(AttNotaNormalE());
        //else if (CondLaE == true)
        //{
        //    LaE.SetActive(false);
        //    CondLaE = false;
        //}
    }
    public void V_Si_E()
    {
        if (CondSiE == false)
        {
            SiE.SetActive(true);
            CondSiE = true;
            StartCoroutine(AttNotaNormalE());
        }
        StartCoroutine(AttNotaNormalE());
        //else if (CondSiE == true)
        //{
        //    SiE.SetActive(false);
        //    CondSiE = false;
        //}
    }
    public void V_Do1_E()
    {
        if (CondDo1E == false)
        {
            Do1E.SetActive(true);
            CondDo1E = true;
            StartCoroutine(AttNotaNormalE());
        }
        StartCoroutine(AttNotaNormalE());
        //else if (CondDo1E == true)
        //{
        //    Do1E.SetActive(false);
        //    CondDo1E = false;
        //}
    }
    public void V_Re1_E()
    {
        if (CondRe1E == false)
        {
            Re1E.SetActive(true);
            CondRe1E = true;
            StartCoroutine(AttNotaNormalE());
        }
        StartCoroutine(AttNotaNormalE());
        //else if (CondRe1E == true)
        //{
        //    Re1E.SetActive(false);
        //    CondRe1E = false;
        //}
    }
    public void V_Mi1_E()
    {
        if (CondMi1E == false)
        {
            Mi1E.SetActive(true);
            CondMi1E = true;
            StartCoroutine(AttNotaNormalE());
        }
        StartCoroutine(AttNotaNormalE());
        //else if (CondMi1E == true)
        //{
        //    Mi1E.SetActive(false);
        //    CondMi1E = false;
        //}
    }
    public void V_Fa1_E()
    {
        if (CondFa1E == false)
        {
            Fa1E.SetActive(true);
            CondFa1E = true;
            StartCoroutine(AttNotaNormalE());
        }
        StartCoroutine(AttNotaNormalE());
        //else if (CondFa1E == true)
        //{
        //    Fa1E.SetActive(false);
        //    CondFa1E = false;
        //    StartCoroutine(AttNotaNormal());
        //}
    }
    public void V_Sol1_E()
    {
        if (CondSol1E == false)
        {
            Sol1E.SetActive(true);
            CondSol1E = true;
            StartCoroutine(AttNotaNormalE());
        }
        StartCoroutine(AttNotaNormalE());
        //else if (CondSol1E == true)
        //{
        //    Sol1E.SetActive(false);
        //    CondSol1E = false;
        //}
    }

    //Pressionar
    public void V_Do_P()
    {
        if (CondDoP == false)
        {
            DoP.SetActive(true);
            CondDoP = true;
        }
        else if (CondDoP == true)
        {
            DoP.SetActive(false);
            CondDoP = false;
        }
    }
    public void V_Re_P()
    {
        if (CondReP == false)
        {
            ReP.SetActive(true);
            CondReP = true;
        }
        else if (CondReP == true)
        {
            ReP.SetActive(false);
            CondReP = false;
        }
    }
    public void V_Mi_P()
    {
        if (CondMiP == false)
        {
            MiP.SetActive(true);
            CondMiP = true;
        }
        else if (CondMiP == true)
        {
            MiP.SetActive(false);
            CondMiP = false;
        }
    }
    public void V_Fa_P()
    {
        if (CondFaP == false)
        {
            FaP.SetActive(true);
            CondFaP = true;
        }
        else if (CondFaP == true)
        {
            FaP.SetActive(false);
            CondFaP = false;
        }
    }
    public void V_Sol_P()
    {
        if (CondSolP == false)
        {
            SolP.SetActive(true);
            CondSolP = true;
        }
        else if (CondSolP == true)
        {
            SolP.SetActive(false);
            CondSolP = false;
        }
    }
    public void V_La_P()
    {
        if (CondLaP == false)
        {
            LaP.SetActive(true);
            CondLaP = true;
        }
        else if (CondLaP == true)
        {
            LaP.SetActive(false);
            CondLaP = false;
        }
    }
    public void V_Si_P()
    {
        if (CondSiP == false)
        {
            SiP.SetActive(true);
            CondSiP = true;
        }
        else if (CondSiP == true)
        {
            SiP.SetActive(false);
            CondSiP = false;
        }
    }
    public void V_Do1_P()
    {
        if (CondDo1P == false)
        {
            Do1P.SetActive(true);
            CondDo1P = true;
        }
        else if (CondDo1P == true)
        {
            Do1P.SetActive(false);
            CondDo1P = false;
        }
    }
    public void V_Re1_P()
    {
        if (CondRe1P == false)
        {
            Re1P.SetActive(true);
            CondRe1P = true;
        }
        else if (CondRe1P == true)
        {
            Re1P.SetActive(false);
            CondRe1P = false;
        }
    }
    public void V_Mi1_P()
    {
        if (CondMi1P == false)
        {
            Mi1P.SetActive(true);
            CondMi1P = true;
        }
        else if (CondMi1P == true)
        {
            Mi1P.SetActive(false);
            CondMi1P = false;
        }
    }
    public void V_Fa1_P()
    {
        if (CondFa1P == false)
        {
            Fa1P.SetActive(true);
            CondFa1P = true;
        }
        else if (CondFa1P == true)
        {
            Fa1P.SetActive(false);
            CondFa1P = false;
        }
    }
    public void V_Sol1_P()
    {
        if (CondSol1P == false)
        {
            Sol1P.SetActive(true);
            CondSol1P = true;
        }
        else if (CondSol1P == true)
        {
            Sol1P.SetActive(false);
            CondSol1P = false;
        }
    }
}
