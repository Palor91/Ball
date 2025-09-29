using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonsToChangeLvLScript : MonoBehaviour
{
    public List<Button> buttons = new List<Button>();
    
    public void OnpushToLvl(Button button)
    {
        if (buttons.Contains(button))
        {
            SceneManager.LoadScene(buttons.IndexOf(button) + 1);
        }
    }

    public void OnPushToStart()
    {
        SceneManager.LoadScene(1);
    }
    
    public void OnPushToMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void OnPushToRestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
    public void OnPushToQuit()
    {
        Application.Quit();
    }
}
