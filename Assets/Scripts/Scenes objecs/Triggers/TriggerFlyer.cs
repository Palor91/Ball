using UnityEngine;
using WildBall.Inputs;
using Player;
using Ui;
using WildBall.Inputs.Scenes_objecs.Triggers;

public class TriggerFlyer : TriggerDef
{
    [SerializeField]
    private float maxFlyTime;
    
    private bool _playerCanFly;
    private bool _playerIsFling;

    private void Update()
    {
        TimeLeft = maxFlyTime - CurrentTime;

        if (Input.GetKeyDown(KeyCode.E) && _playerCanFly)
        {
            PlayerMovement.PlayerRigidbody.useGravity = false;
            PlayerMovement.PlayerRenderer.material = PlayerMaterials.MaterialPool[2];
            _playerIsFling = true;
        }

        if (_playerIsFling)
        {
            TimerShow();
        }

        if (CurrentTime >= maxFlyTime && _playerIsFling)
        {
            _playerIsFling = false;
            StopTimer();
            UiTimer.TimerM.SetActive(false);
            PlayerMovement.PlayerRenderer.material = PlayerMaterials.MaterialPool[0];
            PlayerMovement.PlayerRigidbody.useGravity = true;
        }
        else
        {
             return;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other == PlayerMovement.PlayerCollider)
        {
            _playerCanFly = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other == PlayerMovement.PlayerCollider)
        {
            _playerCanFly = false;
        }
    }
}
