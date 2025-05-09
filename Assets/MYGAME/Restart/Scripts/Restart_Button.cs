using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart_Button : MonoBehaviour
{
    public void SceneLoader()
    {
        SceneManager.LoadScene("MainGame");
    }
}
