using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeScript : MonoBehaviour
{
    private const float Real_Seconds_Per_Game_In_Day = 60f;
    private float day;
    public Text timeText;
    public static string  hoursString;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake()
    {

    }

    // Update is called once per frame
    void Update()
    {
        day += Time.deltaTime / Real_Seconds_Per_Game_In_Day;

        float dayNormalized = day % 1f;
        float hoursPerDay = 24f;
        hoursString = Mathf.Floor(dayNormalized * hoursPerDay).ToString("00");
        float minutesPerHour = 60f;
        string minuteString = Mathf.Floor(((dayNormalized * hoursPerDay) % 1f) * minutesPerHour).ToString("00");
        timeText.text = hoursString + ":" + minuteString;
       
    }
}
