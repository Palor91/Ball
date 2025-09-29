using System.Collections.Generic;
using Player;
using UnityEngine;
using WildBall.Inputs;

public class PlayerActivator : MonoBehaviour
{
    [SerializeField] internal List<Collider> activators;

    [SerializeField] private PlatformMove platformMove;

    private bool _rePaint;
    private bool _rePainted;
    private bool _activate;
    private bool _noMorePaint = false;

    private void Start()
    {
        PlayerMovement.PlayerRenderer = gameObject.GetComponent<Renderer>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && _rePaint && !_noMorePaint)
        {
            _rePainted = true;
            PlayerMovement.PlayerRenderer.material = PlayerMaterials.MaterialPool[1];
        }

        if (Input.GetKeyDown(KeyCode.E) && _activate && _rePainted)
        {
            _noMorePaint = true;
            platformMove.isStarted = true;
            _rePainted = false;
            PlayerMovement.PlayerRenderer.material = PlayerMaterials.MaterialPool[0];
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other == activators[0])
        {
            _rePaint = true;
        }

        if (other == activators[1])
        {
            _activate = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other == activators[0])
        {
            _rePaint = false;
        }

        if (other == activators[1])
        {
            _activate = false;
        }
    }
}
