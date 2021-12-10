using UnityEngine;
using UnityEngine.Events;

public class PlayerCollision : MonoBehaviour
{
    public UnityEvent PlayerDied;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Obstacle"))
        {
            PlayerDied?.Invoke();
        }
    }

}
