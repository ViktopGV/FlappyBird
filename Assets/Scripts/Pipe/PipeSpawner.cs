using System.Collections;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] private PipeMove _pipeTemplate;// PipeMove for the specificity of the type
    [SerializeField] private int _pipesCount;
    [SerializeField] private float _minY = -4.5f;
    [SerializeField] private float _maxY = 4.5f;
    [SerializeField] private float _minDelay = .5f;
    [SerializeField] private float _maxDelay = 2f;

    private ObjectPool<PipeMove> _pipes;

    private void Awake()
    {
        _pipes = new ObjectPool<PipeMove>(_pipeTemplate, _pipesCount, transform);
    }

    private void Start()
    {
        SpawnPipe();
        StartCoroutine(SpawnPipeWithDelay());
    }

    public void SpawnPipe()
    {
        PipeMove pipe = _pipes.GetFreeElement();
        if (pipe)
        {
            float posY = Random.Range(_minY, _maxY);
            pipe.transform.localPosition = new Vector3(0, posY, 0);
            pipe.gameObject.SetActive(true);
        }
    }

    private IEnumerator SpawnPipeWithDelay()
    {
        float delay = Random.Range(_minDelay, _maxDelay);
        yield return new WaitForSeconds(delay);
        SpawnPipe();
        StartCoroutine(SpawnPipeWithDelay());
    }

    public void StopPipesMovement()
    {
        _pipes.GetAllElements().ForEach(pipe =>
        {
            pipe.GetComponent<PipeMove>().enabled = false;
        });
    }

    public void StopSpawnPipes()
    {
        StopCoroutine(SpawnPipeWithDelay());
    }
}
