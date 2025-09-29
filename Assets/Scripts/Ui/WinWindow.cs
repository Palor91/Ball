using UnityEngine;
using UnityEngine.SceneManagement;

namespace WildBall.Inputs.Scenes_objecs.Triggers
{
    public class WinWindow : MonoBehaviour
    {
        public static GameObject WinM;
        [SerializeField] private GameObject winMenu;
        [SerializeField] private GameObject menuButtom;

        public void Start()
        {
            WinM = winMenu;
        }

        public void Update()
        {
            if (WinM.activeSelf)
            {
                menuButtom.SetActive(false);
            }
        }
    }
}