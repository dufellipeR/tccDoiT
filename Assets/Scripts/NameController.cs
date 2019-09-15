using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NameController : MonoBehaviour
{
    public Company company;
    public InputField NameCompany;
    public InputField NamePlayer;
    public GameObject Nextbtn;
    public GameObject PopUp;

    // Start is called before the first frame update
    void Start()
    {
        
        Nextbtn.SetActive(false);
        //Debug.Log(NamePlayer.inputType);
    }

    // Update is called once per frame
    void Update()
    {
        ShowNextBtn();
       // Debug.Log(NameCompany);
    }

    public void ShowNextBtn()
    {
        string j = "";
        bool i = NamePlayer.text == j;
        bool h = NameCompany.text == j;
       // Debug.Log(i);

       if (i || h)
        {
            Nextbtn.SetActive(false);

        }
        else if (!i && !h)
        {
            Nextbtn.SetActive(true);
        }

    }

    public void Next()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Company.nameCompanystr = NameCompany.text;
        Company.namePlayerstr = NamePlayer.text;
        //Debug.Log(NameCompany.text);


    }
}
