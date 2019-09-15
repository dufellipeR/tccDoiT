using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EmployeeController : MonoBehaviour
{
    public Company company;
    public GameObject employeeone;
    public bool IsEmployeeOne = false;
    public GameObject employeetwo;
    public bool IsEmployeeTwo = false;
    public GameObject soldone;
    public GameObject soldedtwo;
    public GameObject employeeshud;
    public GameObject shopemployees;
    public GameObject btnemployeeonehud;
    public GameObject btnemployeetwohud;
    void Start()
    {
       
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BuyEmpOne()
    {
        soldone.SetActive(true);       
        company.wage += 1467f;
        //company.capital -= 1467f;
        employeeone.SetActive(true);
        IsEmployeeOne = true;
        btnemployeeonehud.SetActive(true);
       
    }

    public void BuyEmpTwo()
    {
        soldedtwo.SetActive(true);
        company.wage += 2458f;
        // company.capital -= 2458f;
        employeetwo.SetActive(true);
        IsEmployeeTwo = true;
        btnemployeetwohud.SetActive(true);
        

    }

    public void CallShopEmployees()
    {
        employeeshud.SetActive(false);
        shopemployees.SetActive(true);
    }

    public void demitirFuncOne()
    {
        soldone.SetActive(false);
        employeeone.SetActive(false);
        IsEmployeeOne = false;
        company.wage -= 1467f;
        btnemployeeonehud.SetActive(false);
    }
    public void demitirFuncTwo()
    {
        soldedtwo.SetActive(false);
        employeetwo.SetActive(false);
        IsEmployeeTwo = false;
        company.wage -= 2458f;
        btnemployeetwohud.SetActive(false);
    }


}
