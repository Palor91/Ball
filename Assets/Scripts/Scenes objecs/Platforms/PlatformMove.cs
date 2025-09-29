using UnityEngine;

public class PlatformMove : MonoBehaviour
{
    [SerializeField] private Transform point1;
    [SerializeField] private Transform point2;
    
    [SerializeField] private float speed;
    [SerializeField] internal bool isStarted;

    private float _timeCurrent;
    private float _timeToStartPlatform = 1;

    private GameObject _child;
    private Transform _parent;

    private Vector3 _target;

    private void Start()
    {
        _target = point1.position;
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void OnTriggerEnter(Collider platform)
    {
        platform.gameObject.transform.SetParent(gameObject.transform);
    }

    private void OnTriggerExit(Collider platform)
    {
        platform.gameObject.transform.SetParent(null);
    }

    private void StopTimer()
    {
        _timeCurrent = 0;
    }

    private void StartTimer()
    {
        _timeCurrent += Time.deltaTime;
    }

    private void Move()
    {
        if (isStarted)
        {
            transform.position = Vector3.MoveTowards
                (transform.position, _target, Time.deltaTime * speed);
        }

        if (transform.position == _target)
        {
            StartTimer();
            if (_target == point1.position && _timeCurrent >= _timeToStartPlatform)
            {
                StopTimer();
                _target = point2.position;
            }

            else if (_target == point2.position && _timeCurrent >= _timeToStartPlatform)
            {
                StopTimer();
                _target = point1.position;
            }
        }
    }
}
