using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPlayer : MonoBehaviour
{
    public static string Namestr;
    public float Design;
    public float Code;
    public float Art;
    private string NamePlayer;


    // Start is called before the first frame update
    private void Awake()
    {
        Design = Random.Range(0.8f, 1.0f);
        Code = Random.Range(0.8f, 1.0f);
        Art = Random.Range(0.8f, 1.0f);
    }
    void Start()
    {
        NamePlayer = Namestr;
        Debug.Log(NamePlayer);
    }

    // Update is called once per frame
    void Update()
    {
       // Debug.Log(NamePlayer);
       // Debug.Log(Design);
    }
}
