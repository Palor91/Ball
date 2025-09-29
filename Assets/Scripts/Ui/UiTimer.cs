using UnityEngine;

namespace Ui
{
    public class UiTimer : MonoBehaviour
    {
        public static GameObject TimerM;
        public GameObject timer;

        public void Start()
        {
            TimerM = timer;
        }
    }
}