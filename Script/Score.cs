using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public string Name;
    public string Frase;

    void Update()
    {
        GetComponent<Text>().text = Frase + " " + PlayerPrefs.GetInt(name) + "";
    }
}
