using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Company : MonoBehaviour
{
    // Fazendo referência aos objetos usados
    public static string nameCompanystr;
    public static float capitalstr;
    public static string namePlayerstr;
    public float capital = 5000f;
    public string nameCompany;
    public string namePlayer;
    public float despesas;
    public float energia;
    public float wage;
    public float aluguel;
    public float lucro;
    public float contracts;
    public float tot;
    public GameObject hudGameover;
    public GameObject FullGame;
    public GameObject MAINmov;
    public GameObject Nametext;
    public GameObject BankText;
    public GameObject MonthText;
    public gamecontroller controllergame;
    public GameObject textdesp;
    public GameObject textaluguel;
    public GameObject textenergia;
    public GameObject textwage;
    public GameObject textlucro;
    public GameObject textcontract;
    public GameObject texttot;

    private void Awake()
    {
        capitalstr = capital;
    }

    private void Start()
    {
        despesas = 0f;
        aluguel = Random.Range(0.8f, 1f) * 1000f;
        
    }

    private void Update()
    {
        nameCompany = nameCompanystr;
        capitalstr = capital;
        namePlayer = namePlayerstr;
        if (capital < -2340)
        {
            GameOver();
        }

        



    }

    // Função de Game Over
    public void GameOver()
    {
        hudGameover.SetActive(true);
        //FullGame.SetActive(false);
        MAINmov.GetComponent<PlayerController>().enabled = false;
        Nametext.GetComponent<Text>().text = nameCompanystr;
        BankText.GetComponent<Text>().text = capitalstr.ToString();
        MonthText.GetComponent<Text>().text = controllergame.j.ToString();
    }

    public void ShowFinancies()
    {
        //Adicionando salário e energia às despesas
        despesas = wage + energia + aluguel;

        //Adicionando contratos aos lucros
        lucro = contracts;

        // Soma de lucro e gasto
        tot = lucro - despesas;

        // Transforma em capital
        capital += tot; 


        //Mostrando as finanças
        textdesp.GetComponent<Text>().text = despesas.ToString();
        textaluguel.GetComponent<Text>().text = aluguel.ToString();
        textenergia.GetComponent<Text>().text = energia.ToString();
        textwage.GetComponent<Text>().text = wage.ToString();
        textlucro.GetComponent<Text>().text = lucro.ToString();
        textcontract.GetComponent<Text>().text = contracts.ToString();
        texttot.GetComponent<Text>().text = tot.ToString();

        
        contracts = 0f;
    }

}
