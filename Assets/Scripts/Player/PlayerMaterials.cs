using System.Collections.Generic;
using UnityEngine;
using WildBall.Inputs;

namespace Player
{
    [RequireComponent(typeof(GameObject))]
    public class PlayerMaterials : MonoBehaviour
    {
        public static List<Material> MaterialPool;
        [SerializeField] public Material activationMaterial, defMaterial,
            flyMaterial, heavyMaterial;

        private void Start()
        {
            MaterialPool = new List<Material>();
            
            MaterialPool.Add(defMaterial);
            MaterialPool.Add(activationMaterial);
            MaterialPool.Add(flyMaterial);
            MaterialPool.Add(heavyMaterial);
        }
        
        public void GetColor(int materialNum)
        {
            PlayerMovement.PlayerRenderer.material = PlayerMaterials.MaterialPool[materialNum];
        }
    }
}
