using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsScript : MonoBehaviour
{
    public AudioSource buttonClick;
    
    [SerializeField] private GameObject menu, backToMenu;

    public ButtonsScript(GameObject menu)
    {
        this.menu = menu;
    }

    private void Update()
    {
        if (menu.activeSelf)
        {
            Time.timeScale = 0;
        }
        if (!menu.activeSelf)
        {
            Time.timeScale = 1;
        }
        
        OnEscPressed();
    }

    public void OnButtonPressed()
    {
        buttonClick.Play();
    }

    private void OnEscPressed()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !menu.activeSelf)
        {
            menu.SetActive(true);
            backToMenu.SetActive(false);
        }
        
        else if (Input.GetKeyDown(KeyCode.Escape) &&  menu.activeSelf)
        {
            menu.SetActive(false);
            backToMenu.SetActive(true);
        }
    }
    public void ToNextLvL()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
        
    public void ToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
