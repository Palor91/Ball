using Player;
using Ui;
using UnityEngine;
using WildBall.Inputs;
using WildBall.Inputs.Scenes_objecs.Triggers;

public class TriggerHeavy : TriggerDef
{
    [SerializeField]
    private float maxHeavyTime = 10f;

    private bool _playerCanBeHeavy;
    private bool _playerIsHeavy;

    private void Update()
    {
        TimeLeft = maxHeavyTime - CurrentTime;
        
        if (Input.GetKeyDown(KeyCode.E) && _playerCanBeHeavy)
        {
            PlayerMovement.PlayerRigidbody.mass = 10;
            PlayerMovement.PlayerRenderer.material = PlayerMaterials.MaterialPool[3];
            _playerIsHeavy = true;
        }

        if (_playerIsHeavy)
        {
            TimerShow();
        }
        
        if (CurrentTime >= maxHeavyTime && _playerIsHeavy)
        {
            _playerIsHeavy = false;
            StopTimer();
            UiTimer.TimerM.SetActive(false);
            PlayerMovement.PlayerRenderer.material = PlayerMaterials.MaterialPool[0];
            PlayerMovement.PlayerRigidbody.mass = 1;
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
            _playerCanBeHeavy = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other == PlayerMovement.PlayerCollider)
        {
            _playerCanBeHeavy = false;
        }
    }
}
