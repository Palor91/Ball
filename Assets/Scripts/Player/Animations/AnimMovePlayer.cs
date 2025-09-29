using UnityEngine;
using WildBall.Inputs;

public class AnimMovePlayer : MonoBehaviour
{
    Animator _move;

    private void Start()
    {
        _move = GetComponent<Animator>();
    }

    private void Update()
    {
        if (PlayerMovement.PlayerRigidbody.useGravity == false && Input.GetKeyDown(KeyCode.Space))
        {
            _move.Play("Fly");
        }
    }
}
