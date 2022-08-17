using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    #region Fields

    [SerializeField]
    Text scoreText;
    float elapsedSeconds = 0;
    bool timerRunning = true;

    #endregion

    #region Methods

    // Start is called before the first frame update
    void Start()
    {
        // set score text
        scoreText.text = "Score: " + "0";
    }

    // Update is called once per frame
    void Update()
    {
        // scoring support (at every second we get 1 score)
        if (timerRunning)
        {
            elapsedSeconds += Time.deltaTime;
            scoreText.text = "Score: " + ((int)elapsedSeconds).ToString();
        }       
    }

    /// <summary>
    /// stop a timer and scoring
    /// </summary>
    public void StopGameTimer()
    {
        timerRunning = false;
    }

    #endregion
}
