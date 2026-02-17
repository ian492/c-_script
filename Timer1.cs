using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class Timer : MonoBehaviour
{
    public int minutes;
    public float seconds;
    public TextMeshProUGUI timerText;
    private bool isRestarting = false;

    // Update is called once per frame
    void Update()
    {
        seconds -= Time.deltaTime;
        if (seconds <= 0 && !isRestarting)
        {
            if (minutes > 0)
            {
                seconds += 59;
                minutes--;

            }
            else
            {
                isRestarting = true;
                print("перезапуууууууск");
                int sceneIndex = SceneManager.GetActiveScene().buildIndex;
                SceneManager.LoadScene(sceneIndex); 
            }

        }
        //округляем значение секунд до целых для их вывода на экран
        int roundSeconds = Mathf.RoundToInt(seconds);
        timerText.text = minutes + ":" + roundSeconds;
    }
}
