using UnityEngine;

namespace WildBall.Inputs
{
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField, Range(0, 10)] private float speed;
        [SerializeField, Range(0, 100)] private float jSpeed;

        internal static Rigidbody PlayerRigidbody;
        internal static Collider PlayerCollider;
        internal static Renderer PlayerRenderer;

        internal static bool IsJumping;

        [SerializeField]
        private float distance, radius, y;


        private void Awake()
        {
            PlayerRigidbody = GetComponent<Rigidbody>();
            PlayerCollider = GetComponent<Collider>();
            PlayerRenderer = gameObject.GetComponent<Renderer>();
        }

        public void Update()
        {
            Ray ray = new Ray(transform.position, -Vector3.up);
            Debug.DrawRay(ray.origin, ray.direction * distance, Color.yellow);
        
            if (Physics.Raycast(ray, distance) || PlayerRigidbody.useGravity == false)
                IsJumping = false;
            else
                IsJumping = true;
        }

        public void FixedUpdate()
        {
            PlayerRigidbody.AddForce(new Vector2(0, -1), ForceMode.Force);
        }

        public void MoveCaracter(Vector3 movement)
        {
            if (IsJumping == false)
                PlayerRigidbody.AddForce(movement * speed, ForceMode.Impulse);
        }
        
        public void Jumping(Vector2 jumping)
        {
            if (Input.GetKeyDown(KeyCode.Space) && IsJumping == false)
            {
                PlayerRigidbody.AddForce(new Vector2(0, jSpeed), ForceMode.VelocityChange);
                IsJumping = true;
            }
        }
    }
}