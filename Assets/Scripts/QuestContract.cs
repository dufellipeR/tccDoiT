using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestContract : MonoBehaviour
{
    public Company company;
    public GameObject HUD_WorkPlaceContract;
    
    public GameObject contractsView;
    private bool IsonWorkPlace = false;
    private bool F_alreadypressed = false;
    public GameObject MAINmov;
    public Text timeText;

    void Start()
    {
        HUD_WorkPlaceContract.SetActive(false);
        contractsView.SetActive(false);
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (IsonWorkPlace)
            {
                Debug.Log("Is WORKING!!!!!");
                contractsView.SetActive(true);
                MAINmov.GetComponent<PlayerController>().enabled = false;
                HUD_WorkPlaceContract.SetActive(false);
                F_alreadypressed = true;
                IsonWorkPlace = false;


            }
            else
            {
                Debug.Log("Is WORKING!!!!!");
                contractsView.SetActive(false);
                MAINmov.GetComponent<PlayerController>().enabled = true;
                HUD_WorkPlaceContract.SetActive(false);
                IsonWorkPlace = true;
            }
            
        }

        
    }

    private void OnTriggerEnter2D(Collider2D hit)
    {
        if (hit.gameObject.tag == "Main")
        {
           // HUD_WorkPlaceContract.SetActive(true);
            IsonWorkPlace = true;


        }

        Debug.Log("Entrou na área de trabalho");
        
    }

    private void OnTriggerExit2D(Collider2D hit)
    {
        if (hit.gameObject.tag == "Main")
        {
            HUD_WorkPlaceContract.SetActive(false);
            IsonWorkPlace = false;
            contractsView.SetActive(false);
        }

    }

}
