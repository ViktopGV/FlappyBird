using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class InputSystem : MonoBehaviour
{
    public UnityEvent AnyKeyClicked;

    [DllImport("__Internal")]
    private static extern bool IsMobile();

    private EventSystem _eventSys;

    private void Awake()
    {
        _eventSys = EventSystem.current;
    }

    private void Update()
    {
        if (Input.anyKeyDown)
        {
            if(!IsCursorOverUI())
            {
                AnyKeyClicked?.Invoke();
            }
        }
    }

    public bool IsCursorOverUI()
    {
#if (UNITY_ANDROID || UNITY_IOS) && (!UNITY_EDITOR)
        int clickId = Input.GetTouch(0).fingerId;
        return _eventSys.IsPointerOverGameObject(clickId);
#elif UNITY_WEBGL && !UNITY_EDITOR
        if(IsMobile())
        {
            int clickId = Input.GetTouch(0).fingerId;
            return _eventSys.IsPointerOverGameObject(clickId);
        }
        else
            return _eventSys.IsPointerOverGameObject();
#else
        return _eventSys.IsPointerOverGameObject(); 
#endif
    }
}
