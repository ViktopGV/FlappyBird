using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class FlyBird : MonoBehaviour
{
    [SerializeField] private float _flyForce;
    [SerializeField] private float _rotationSpeed;
    [SerializeField] private float _rotationDegree;
    private Rigidbody2D _rb;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        Quaternion rotation = Quaternion.Lerp(Quaternion.Euler(0,0, _rb.rotation), Quaternion.Euler(0,0, -_rotationDegree), _rotationSpeed * Time.fixedDeltaTime);
        _rb.MoveRotation(rotation);
    }

    public void Fly()
    {
        _rb.velocity = Vector2.up * _flyForce;
        _rb.SetRotation(_rotationDegree);
    }
}
