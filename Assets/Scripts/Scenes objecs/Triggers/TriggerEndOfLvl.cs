using UnityEngine;

namespace WildBall.Inputs.Scenes_objecs.Triggers
{
    public class TriggerEndOfLvl : MonoBehaviour
    {
        public void OnTriggerEnter(Collider endOfLvl)
        {
            if (endOfLvl.CompareTag("Player"))
            {
                WinWindow.WinM.SetActive(true);
                PlayerMovement.PlayerRigidbody.constraints = RigidbodyConstraints.FreezePosition;
            }
        }
    }
}