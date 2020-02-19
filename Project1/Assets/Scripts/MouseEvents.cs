using UnityEngine;
using UnityEngine.Events;

public class MouseEvents : MonoBehaviour
{
    public UnityEvent mouseDownEvent, mouseEnterEvent;
    private void OnMouseDown()
    {
        mouseDownEvent.Invoke();
    }
    private void OnMouseEnter()
    {
        mouseEnterEvent.Invoke();
    }
    
    
}