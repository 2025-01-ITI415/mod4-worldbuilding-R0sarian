using UnityEngine;
using UnityEngine.SceneManagement;

public class Kill_Player : MonoBehaviour
{


    private void OnTriggerEnter(Collider other)
    {
        // Check if the object that entered the trigger is the FPSController (tagged as "Player")
        if (other.CompareTag("Player"))
        {

            // Load the Restart Menu scene
            SceneManager.LoadScene("Restart_menu");

        }
    }
}
