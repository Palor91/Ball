using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicScript : MonoBehaviour
{
    public AudioSource mainmenu;

    private void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            mainmenu.Play();
        }
    }
}
