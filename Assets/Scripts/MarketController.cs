using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarketController : MonoBehaviour
{
    public GameObject ContractsHUD;
    public GameObject EmployeesHUD;
    public GameObject MarketHUD;
    public EmployeeController employeeController;
    //public GameObject contracttips;
    public Company company;
    public GameObject workplaceone;
    public GameObject workplacetwo;
    public GameObject workplaceassist;
    public GameObject btnWorkAssistant;
    public bool IsWorkAssistant = false;
    public bool IsWorkPlaceOne = false;
    public bool IsWorkPlaceTwo = false;
    public GameObject soldedOne;
    public GameObject soldedTwo;
    public GameObject moment6;
    public GameObject moment7;

    // Start is called before the first frame update
    void Start()
    {
        moment6.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
        
        
    }

    public void BuyWorkPlaceOne()
    {
        soldedOne.SetActive(true);
        workplaceone.SetActive(true);
        if (IsWorkPlaceOne)
        {
            soldedOne.SetActive(true);
        }
        else
        {
            company.despesas -= 2500f;
            company.energia += Random.Range(0.2f, 0.5f) * 1000;
            workplaceone.SetActive(true);
            IsWorkPlaceOne = true;
        }
       
        
        
    }

    public void BuyWorkPlaceAssistant()
    {
        btnWorkAssistant.SetActive(false);
        workplaceassist.SetActive(true);
        IsWorkAssistant = true;
        company.despesas -= 2500f;
        company.energia += Random.Range(0.2f, 0.5f) * 1000;
       // moment6.SetActive(false);
        moment7.SetActive(true);
        MarketHUD.SetActive(false);


    }

    public void BuyWorkPlaceTwo()
    {
        soldedTwo.SetActive(true);
        workplacetwo.SetActive(true);
        if (IsWorkPlaceTwo)
        {
            soldedTwo.SetActive(true);

        }
        else
        {
            company.despesas -= 2500f;
            company.energia += Random.Range(0.2f, 0.5f) * 1000;
            workplacetwo.SetActive(true);
            IsWorkPlaceTwo = true;
        }



    }

    public void CloseContractHUD()
    {
        ContractsHUD.SetActive(false);
    }
    public void CloseEmployeeHUD()
    {
        EmployeesHUD.SetActive(false);
    }
    public void CloseMarketHUD()
    {
        MarketHUD.SetActive(false);
    }


}
