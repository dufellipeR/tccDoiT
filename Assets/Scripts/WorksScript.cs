using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorksScript : MonoBehaviour
{
    public MarketController marketController;
    public EmployeeController employeeController;
    public Company company;
    public GameObject workanim1;
    public GameObject workanim2;
    public GameObject workanim3;
    public bool trabalhando = false;
    public GameObject MAINmov;
    public GameObject ContractHUD;
    public bool i;
    public bool j;
    public float k;

    void Start() 
    {
        workanim1.SetActive(false);
        workanim2.SetActive(false);
        workanim3.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(employeeController.IsEmployeeOne);
        //Verificando quais funcionários estão disponiveis
        i = employeeController.IsEmployeeOne && marketController.IsWorkPlaceOne;
        j = employeeController.IsEmployeeTwo && marketController.IsWorkPlaceTwo;
        
    }


    public void WebSite()
    {
        k = 60f;
        // Recalculando o tempo  por funcionário ativo
        if (i && j)
        {
            workanim1.SetActive(true);
            workanim2.SetActive(true);
            workanim3.SetActive(true);
            k -= (k * 0.15f) * 0.25f;
            Debug.Log(k -= (k * 0.15f) * 0.25f);
        }
        else if (i)
        {
            workanim1.SetActive(true);
            workanim2.SetActive(true);
            k -= k * 0.15f;
        } else if (j)
        {
            workanim1.SetActive(true);
            workanim3.SetActive(true);
            k -= k * 0.25f;
        } else
        {
            workanim1.SetActive(true);
           
        }
        
        Invoke("AddMoneyWeb", k);
        ContractHUD.SetActive(false); 


    }
    public void WebSite2()
    {
        k = 120f;

        if (i && j)
        {
            workanim1.SetActive(true);
            workanim2.SetActive(true);
            workanim3.SetActive(true);
            k -= (k * 0.15f) * 0.25f;
            Debug.Log(k -= (k * 0.15f) * 0.25f);
        }
        else if (i)
        {
            workanim1.SetActive(true);
            workanim2.SetActive(true);
            k -= k * 0.15f;
        }
        else if (j)
        {
            workanim1.SetActive(true);
            workanim3.SetActive(true);
            k -= k * 0.25f;
        }
        else
        {
            workanim1.SetActive(true);

        }

        Invoke("AddMoneyWeb2", k);
        ContractHUD.SetActive(false);
        
    }
    public void SisteEmbarca()
    {
        k = 90f;

        if (i && j)
        {
            workanim1.SetActive(true);
            workanim2.SetActive(true);
            workanim3.SetActive(true);
            k -= (k * 0.15f) * 0.25f;
            Debug.Log(k -= (k * 0.15f) * 0.25f);
        }
        else if (i)
        {
            workanim1.SetActive(true);
            workanim2.SetActive(true);
            k -= k * 0.15f;
        }
        else if (j)
        {
            workanim1.SetActive(true);
            workanim3.SetActive(true);
            k -= k * 0.25f;
        }
        else
        {
            workanim1.SetActive(true);

        }

        Invoke("AddMoneySisteEmb", k);
        ContractHUD.SetActive(false);
    }
    public void AplicaLogisti()
    {
        k = 72f;

        if (i && j)
        {
            workanim1.SetActive(true);
            workanim2.SetActive(true);
            workanim3.SetActive(true);
            k -= (k * 0.15f) * 0.25f;
            Debug.Log(k -= (k * 0.15f) * 0.25f);
        }
        else if (i)
        {
            workanim1.SetActive(true);
            workanim2.SetActive(true);
            k -= k * 0.15f;
        }
        else if (j)
        {
            workanim1.SetActive(true);
            workanim3.SetActive(true);
            k -= k * 0.25f;
        }
        else
        {
            workanim1.SetActive(true);

        }

        Invoke("AddMoneyApliLogis", k);
        ContractHUD.SetActive(false);
    }

    public void AddMoneyWeb()
    {
        company.contracts += 5432f;
        StopWorkinganim();
    }
    public void AddMoneyWeb2()
    {
        company.contracts += 10864f;
        StopWorkinganim();
    }
    public void AddMoneySisteEmb()
    {
        company.contracts += 8148f;
        StopWorkinganim();
    }
    public void AddMoneyApliLogis()
    {
        company.contracts += 6518f;
        StopWorkinganim();
    }

    public void StopWorkinganim()
    {
        workanim1.SetActive(false);
        workanim2.SetActive(false);
        workanim3.SetActive(false);
        
    }
}
