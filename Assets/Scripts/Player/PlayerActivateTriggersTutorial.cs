using System.Collections.Generic;
using UnityEngine;

public class PlayerActivateTriggersTutorial : MonoBehaviour
{
    public List<Collider> triggerColl;
    public List<GameObject> image;

    private void OnTriggerEnter(Collider other)
    {
        if (triggerColl.Contains(other))
        {
            image[triggerColl.IndexOf(other)].SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (triggerColl.Contains(other))
        {
            image[triggerColl.IndexOf(other)].SetActive(false);
        }
    }
}
