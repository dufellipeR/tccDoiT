using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialController : MonoBehaviour
{
    public Company company;
    public GameObject TextNamePlayer;
    public GameObject tutopanel;
    public GameObject moment1;
    public GameObject moment2;
    public GameObject moment3;
    public GameObject moment4;
    public GameObject moment5;
    public GameObject moment6;
    public GameObject moment7;
    public GameObject moment12;
    public GameObject meta60;

    private void Start()
    {
        moment6.SetActive(false);
    }

    private void Update()
    {
        TextNamePlayer.GetComponent<Text>().text = company.namePlayer;
    }

    public void StartTuto()
    {
        tutopanel.SetActive(true);
        callMo1();
    }

    public void callMo1()
    {
        moment1.SetActive(true);
       // moment1.SetActive(true);
    }
    public void callMo12()
    {
        moment1.SetActive(false);
        moment12.SetActive(true);
    }
    public void callMo2()
    {
        moment12.SetActive(false);
        moment2.SetActive(true);

    }
    public void callMo3()
    {
        moment2.SetActive(false);
        moment3.SetActive(true);
    }
    public void callMo4()
    {
        moment3.SetActive(false);
        moment4.SetActive(true);
    }
    public void callMo5()
    {
        moment4.SetActive(false);
        moment5.SetActive(true);
    }
    public void callMo6()
    {
        moment5.SetActive(false);
        moment6.SetActive(true);
        
    }
    public void callMo7()
    {
        moment6.SetActive(false);
        moment7.SetActive(true);
    }
    public void endtuto()
    {
        moment7.SetActive(false);
        tutopanel.SetActive(false);
        meta60.SetActive(true);
    }


}
