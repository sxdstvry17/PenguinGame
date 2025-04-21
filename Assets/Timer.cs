using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timerText;  // Reference to the TextMeshPro UI component
    private float timeElapsed = 0f;    // Time elapsed in seconds
    private bool isTimerRunning = true; // Flag to check if the timer is running

    void Update()
    {
        // Only update the time if the timer is running
        if (isTimerRunning)
        {
            // Update the elapsed time by the time passed since last frame
            timeElapsed += Time.deltaTime;

            // Calculate minutes and seconds from the elapsed time
            int minutes = Mathf.FloorToInt(timeElapsed / 60f);
            int seconds = Mathf.FloorToInt(timeElapsed % 60f);

            // Format the time as MM:SS
            string timeFormatted = string.Format("{0:D2}:{1:D2}", minutes, seconds);

            // Update the UI TextMeshPro component
            if (timerText != null)
            {
                timerText.text = timeFormatted;
            }
        }
    }

    // Function to pause the timer
    public void PauseTimer()
    {
        isTimerRunning = false;
    }

    // Function to resume the timer
    public void ResumeTimer()
    {
        isTimerRunning = true;
    }
}
