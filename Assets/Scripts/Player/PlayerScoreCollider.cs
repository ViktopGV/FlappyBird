using UnityEngine;
using UnityEngine.Events;

public class PlayerScoreCollider : MonoBehaviour
{
    public UnityEvent ScoreCollider;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Score"))
        {
            ScoreCollider?.Invoke();
        }
    }
}
