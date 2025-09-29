using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WildBall.Inputs;

public class CameraMovement : MonoBehaviour
{
    private Vector3 offset;

    private void Start()
    {
        offset = transform.position - PlayerMovement.PlayerRigidbody.position;
    }

    private void FixedUpdate()
    {
        transform.position = PlayerMovement.PlayerRigidbody.position + offset;
    }
}
