using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using WildBall.Inputs.Scenes_objecs.Triggers;

public class DeathTimer : MonoBehaviour
{
    [SerializeField]
    private float timeLeft = 60f;

    [SerializeField]
    private GameObject timerObject;
    [SerializeField]
    private Text timeScore;

    private bool _isOut;

    private void Update()
    {
        if (_isOut)
        {
            timerObject.SetActive(true);
            timeScore.text = timeLeft.ToString("Time left: " + "0.0");
            TimerCd();
        }
        if (timeLeft <= 0f)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        if (WinWindow.WinM.activeSelf)
        {
            timeLeft = 100;
            timerObject.SetActive(false);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        _isOut = true;
    }

    private void TimerCd()
    {
        timeLeft -= Time.deltaTime;
    }
}
