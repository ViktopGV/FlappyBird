using System.Collections.Generic;
using UnityEngine;

public class ObjectPool<T> where T : MonoBehaviour
{
    private T _objectPrefab;
    private Transform _objectContainer;
    private int _count;

    private List<T> _pool;

    public ObjectPool(T prefab, int count, Transform container)
    {
        _objectPrefab = prefab;
        _count = count;
        _objectContainer = container;

        CreateObjectPool();        
    }

    private void CreateObjectPool()
    {
        _pool = new List<T>();
        for(int i = 0; i < _count; ++i)
        {
            T InstanceObject = Object.Instantiate<T>(_objectPrefab, _objectContainer);
            InstanceObject.gameObject.SetActive(false);
            _pool.Add(InstanceObject);

        }
    }

    public bool HasFreeElement(out T element)
    {
        foreach(T item in _pool)
        {
            if(!item.gameObject.activeInHierarchy)
            {
                element = item;
                return true;
            }
        }

        element = null;
        return false;
    }

    public T GetFreeElement()
    {
        return HasFreeElement(out T item) ? item : null;
    }

    public List<T> GetAllElements()
    {
        return _pool;
    }
}
