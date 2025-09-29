using UnityEngine;

namespace WildBall.Inputs
{
    [RequireComponent(typeof(PlayerMovement))]
    public class PlayerInput : MonoBehaviour
    {
        private Vector3 _movement, _jumping;
        private PlayerMovement _playerMovement;

        private float _jump, _horisontal, _vertical;

        private void Awake()
        {
            _playerMovement = GetComponent<PlayerMovement>();
        }

        private void Update()
        {
            _jump = Input.GetAxis(GlobalStringVars.JUMP_BUTTON);
            _horisontal = Input.GetAxis(GlobalStringVars.HORIZANTAL_AXIS);
            _vertical = Input.GetAxis(GlobalStringVars.VERTICAL_AXIS);

            _movement = new Vector3(-_horisontal, 0, -_vertical);
            _jumping = new Vector2(0, _jump);

            _playerMovement.Jumping(_jumping);
        }

        private void FixedUpdate()
        {
            _playerMovement.MoveCaracter(_movement);
        }
    }
}