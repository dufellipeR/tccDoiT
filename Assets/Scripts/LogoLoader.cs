using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LogoLoader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Countdown");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator Countdown()
    {
        yield return new WaitForSeconds(8);
        SceneManager.LoadScene(1);
    }
}
