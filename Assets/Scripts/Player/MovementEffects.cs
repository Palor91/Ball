using UnityEngine;
using WildBall.Inputs;

public class MovementEffects : MonoBehaviour
{
    [SerializeField]
    internal ParticleSystem sparks;

    private void Update()
    {
        sparks.transform.position = PlayerMovement.PlayerRigidbody.position;
    }
}
