using UnityEngine;
using TMPro;

public class Count_Pick : MonoBehaviour
{
    public static Count_Pick Instance;

    public TextMeshProUGUI counterText;
    public int maxCount = 5; // Set this in the Inspector
    private int count = 0;

    private DisplayTimer timerScript;

    void Awake()
    {
        timerScript = FindObjectOfType<DisplayTimer>();

        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        timerScript = FindObjectOfType<DisplayTimer>();

        counterText.text = "Collected: " + count + "/" + maxCount;
    }

    public void IncreaseCount()
    {
        count++;
        counterText.text = "Collected: " + count + "/" + maxCount;

        if (count >= maxCount && timerScript != null)
        {
            timerScript.StopTimer();

        }
    }
}
