using UnityEngine;
using UnityEngine.UI;
using Ui;

namespace WildBall.Inputs.Scenes_objecs.Triggers
{
    public class TriggerDef : MonoBehaviour
    {
        public Text timeScore;
        internal static float TimeLeft;
        internal static float CurrentTime;

        internal void StopTimer()
        {
            CurrentTime = 0.0f;
        }

        private void StartTimer()
        {
            CurrentTime +=  Time.deltaTime;
        }

        internal void TimerShow()
        {
            StartTimer();
            UiTimer.TimerM.SetActive(true);
            timeScore.text = TimeLeft.ToString("Time Left: " + "0.0");
        }
    }
}