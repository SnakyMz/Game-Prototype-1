using UnityEngine;
using UnityEngine.SceneManagement;

public class RideUIHandler : MonoBehaviour
{
    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
