using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDController : MonoBehaviour
{
    public GameObject company;
    public GameObject Nametext;
    public GameObject BankText;
    public GameObject contracts;
    public GameObject employees;
    public GameObject market;
    public GameObject analise;
    
    public static bool IsContract = false;
    public static bool IsEmployees = false;
    public static bool IsMarket = false;

    // Mercado e Contratar
    public GameObject workOne;
    public static bool IsWorkOne = false;


    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        Nametext.GetComponent<Text>().text = Company.nameCompanystr;
        BankText.GetComponent<Text>().text = Company.capitalstr.ToString();

    }

    public void TextChange ()
    {
        
    }

    public void ContractBTN()
    {
        if (IsContract)
        {
            contracts.SetActive(false);
            IsContract = false;
        }
        else
        {
            IsContract = true;
            contracts.SetActive(true);
        }
        

    }
    public void EmployeesBTN()
    {
        if (IsEmployees)
        {
            employees.SetActive(false);
            IsEmployees = false;
        }
        else
        {
            IsEmployees = true;
            employees.SetActive(true);
        }
        
    }
    public void MarketBTN()
    {
        if (IsMarket)
        {
            market.SetActive(false);
            IsMarket = false;
        }
        else
        {
            IsMarket = true;
            market.SetActive(true);
        }
    }

    /*public void BuyWorkPlace()
    {
        workOne.SetActive(true);
        IsWorkOne = true;
    }*/

    public void AnaliseBTN()
    {
        analise.SetActive(true);

    }

    public void CloseAnali()
    {
        analise.SetActive(false);
    }
}
