using UnityEngine;

public class PipeMove : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 1;

    private Transform _transform;

    private void Awake()
    {
        _transform = transform;
    }

    private void Update()
    {
        _transform.Translate(Vector3.left * _moveSpeed * Time.deltaTime);
    }
}
