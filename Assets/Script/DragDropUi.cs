using UnityEngine;
using UnityEngine.EventSystems;

public class DragDropUi : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private Canvas canvas = default;
    [SerializeField] private Camera mainCamera = default;
    private bool onCollider = false, onDrag = false;

    void Update()
    {
        if (onCollider & Input.GetKeyDown(KeyCode.Mouse0))

        {
            onDrag = true;
        }

        if (onDrag)
        {
            transform.position = mainCamera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, canvas.planeDistance));
        }

        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            onDrag = false;
        }
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        onCollider = true;
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        onCollider = false;
    }
}
