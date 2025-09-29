using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using WildBall.Inputs;
using WildBall.Inputs.Scenes_objecs.Triggers;

public class SpeedTriggers : MonoBehaviour
{
    private bool _faster;
    private bool _slower;
    private float _timeCd;

    public GameObject timeBuff;
    public Text timeScore;

    [SerializeField] private List<Collider> speeder, slowerer;

    private void Update()
    {
        BuffTimers();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (speeder.Contains(other))
        {
            DropSpeedAndRefreshTimer();
            _faster = true;
        }
        if (slowerer.Contains(other))
        {
            DropSpeedAndRefreshTimer();
            _slower = true;
        }
    }

    private void DropSpeedAndRefreshTimer()
    {
        _timeCd = 5.0f;
        _slower = false;
        _faster = false;
    }

    private void TimerCd()
    {
        _timeCd -= Time.deltaTime;
    }

    private void BuffTimers()
    {
        if (_faster == true)
        {
            PlayerMovement.PlayerRigidbody.mass = 0.8f;
            timeBuff.SetActive(true);
            TimerCd();
            timeScore.text = _timeCd.ToString("Speed: " + "0.0");
            if (_timeCd <= 0)
            {
                timeBuff.SetActive(false);
                _faster = false;
                PlayerMovement.PlayerRigidbody.mass = 1f;
            }
        }

        if (_slower == true)
        {
            PlayerMovement.PlayerRigidbody.mass = 10f;
            timeBuff.SetActive(true);
            TimerCd();
            timeScore.text = _timeCd.ToString("Slow: " + "0.0");
            if (_timeCd <= 0)
            {
                timeBuff.SetActive(false);
                _slower = false;
                PlayerMovement.PlayerRigidbody.mass = 1f;
            }
        }

        if (WinWindow.WinM.activeSelf)
        {
            timeBuff.SetActive(false);
        }
    }
}
