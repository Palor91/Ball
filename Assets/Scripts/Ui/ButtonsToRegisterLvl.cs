using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Ui
{
    [RequireComponent(typeof(Button))]
    public class ButtonsToRegisterLvl : MonoBehaviour
    {
        public static Button ButtonToRegister;
        [SerializeField] private Button button;

        public void Start()
        {
            button = GetComponent<Button>();
            ButtonToRegister = button;
        }
    }
}