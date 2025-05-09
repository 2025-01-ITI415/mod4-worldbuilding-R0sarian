using UnityEngine;
using TMPro;
using System.Collections;
using UnityEngine.SceneManagement;

public class DisplayTimer : MonoBehaviour
{
    public TextMeshProUGUI countdownText;
    private int timeLeft = 90;
    private bool timerRunning = true;

    void Start()
    {
        StartCoroutine(Countdown());
    }

    IEnumerator Countdown()
    {
        while (timeLeft >= 0 && timerRunning)
        {
            countdownText.text = timeLeft.ToString();
            yield return new WaitForSeconds(1f);
            timeLeft--;
        }

        if (timeLeft < 0)
        {
            SceneManager.LoadScene("Restart Menu");
        }
    }

    public void StopTimer()
    {
        timerRunning = false;
        countdownText.text = "This song is a vibe, but otherwise, go try out some other games :)";
    }
}
