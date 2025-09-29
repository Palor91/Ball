using UnityEngine;
using WildBall.Inputs;


public class Move_Player_Sound : MonoBehaviour
{
    public AudioSource roll;

        private void Update()
        {
            if (Input.GetButtonDown(GlobalStringVars.HORIZANTAL_AXIS)||
            Input.GetButtonDown(GlobalStringVars.VERTICAL_AXIS))
            {
            roll.Play();
            }
        }
    }

