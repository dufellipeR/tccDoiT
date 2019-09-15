using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gamecontroller : MonoBehaviour
{
    public TutorialController tutorialController;
    public float daycount;
    public GameObject contracttips;
    public GameObject expbtn;
    public GameObject congratpanel;
    public GameObject expansionPanel;
    public Text timeText;
    public Company company;
    private int i;
    public Text Daycounting;
    public Text Daycounting2;
    public int j = 1;
    public TimeScript timeScript;
    public bool passday;
    public float countdown;
    [SerializeField]
    private float timerspeed = 2f;

    void Start()
    {
        Debug.Log("começou");
        i = 0;
        Daycounting.GetComponent<Text>().text = j.ToString();
        tutorialController.StartTuto();




    }

    // Update is called once per frame
    void Update()
    {
        countdown += Time.deltaTime;
        if (countdown >= timerspeed)
        {
            countdown = 0f;
            j += 1;
            Daycounting.GetComponent<Text>().text = j.ToString();
            Daycounting2.GetComponent<Text>().text = j.ToString();
            //company.capital -= company.despesas;
            company.ShowFinancies();
        }

        if (j == 60)
        {
            contracttips.SetActive(false);
            expbtn.SetActive(true);
            congratpanel.SetActive(true);

        }

       // countdown -= Time.deltaTime;
       // if (countdown <= 0f)
       // {
       //     j += 1;
       // }

        /* while (passday)
         {
            Debug.Log(i += 1) ;
         }*/
        // while (TimeScript.hoursString == "01")
        // {
        //     i += 1;
        //    Debug.Log(i);
        // }






        /* if (timeText.text == "00:00")
         {
             i += 1;
             j = (int)daycount - 1;

             Debug.Log(i);
             daycount += 0.5f;
             company.capital -= 500f;
             Daycounting.GetComponent<Text>().text = j.ToString();
         }*/


    }
    /* private void FixedUpdate()
     {
         if (timeText.text == "00:00")
         {
             i += 1;
             j = (int)daycount - 1;

             Debug.Log(i);
             daycount += 0.5f;
             company.capital -= (company.despesas / 2) - 100;
             //company.capital -= 50f;
             Daycounting.GetComponent<Text>().text = j.ToString();
         }*/
//}

    public void howmanydays()
    {
        j += 1;
        Daycounting.GetComponent<Text>().text = j.ToString();
    }

    public void ExpasionBTN()
    {
        expansionPanel.SetActive(true);

    }


}
