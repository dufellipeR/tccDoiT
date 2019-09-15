using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectLevel : MonoBehaviour
{
    public void PlayBrasil()
    {
        SceneManager.LoadScene("GameDoIt");
    }
    public void PlaYChina()
    {
        SceneManager.LoadScene("ChinaScene");
    }
    public void PlayEUA()
    {
        SceneManager.LoadScene("EUAScene");
    }
}
