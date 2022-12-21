using System.Collections;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float timer;
    float seconds;
    float minutes;
    float hours;
    
    public Text timeText;

    void Start(){
        timer = 0;

        
    }

    void Update()
    {
     StartTimer();
      
    }

    public void StartTimer() {

        timer += Time.deltaTime;
        seconds = (int)(timer % 60);
        minutes = (int)(timer / 60);
        hours = (int)(timer / 3600);

        timeText.text = hours.ToString("00") + ":" + minutes.ToString("00") + ":" + seconds.ToString("00");

    }

    }
