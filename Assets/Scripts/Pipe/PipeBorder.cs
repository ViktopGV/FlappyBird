using UnityEngine;

public class PipeBorder : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Pipe collider has a parent transform
        if (collision.transform.parent != null)
        {
            //in current logic is not neccessary, but any way
            if (collision.transform.parent.TryGetComponent(out PipeMove pipe))
            {
                collision.transform.parent.gameObject.SetActive(false);
            }
        }
    }
}
