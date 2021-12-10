using UnityEngine;

[RequireComponent(typeof(Animator))]
public class AnimationController : MonoBehaviour
{
    [SerializeField] private float _animationSpeed = 1;
    private Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    public void PlayAnimation()
    {
        _animator.speed = _animationSpeed;
    }

    public void StopAnimation()
    {
        _animator.speed = 0;
    }

    public void IncreaseAnimationSpeed(float increaseValue)
    {
        _animationSpeed += increaseValue;
        _animator.speed = _animationSpeed;
    }
}
