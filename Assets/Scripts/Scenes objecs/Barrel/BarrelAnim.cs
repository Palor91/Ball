using UnityEngine;

public class BarrelAnim : MonoBehaviour
{
    private Animator _destroyBarrel;
    private AudioSource _barrelBrake;

    private void Awake()
    {
        _destroyBarrel = GetComponent<Animator>();
        _barrelBrake = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        _barrelBrake.Play();
        _destroyBarrel.SetBool("IsIdle", false);
        _destroyBarrel.SetTrigger("BarrelEntered");
    }
}
