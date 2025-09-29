using UnityEngine;
using UnityEngine.SceneManagement;

namespace WildBall.Inputs.Scenes_objecs.Triggers
{
    public class TriggerDeath : MonoBehaviour

    {
        private void OnTriggerEnter(Collider restartLvl)
        {
            if (restartLvl.CompareTag("Player"))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }
}