using UnityEngine;

public class DragDrop : MonoBehaviour
{
    private bool onCollider = false, onDrag = false;
    [SerializeField] private Rigidbody2D rigidbody2D = default;
    [SerializeField] private Camera mainCamera = default;

    private void OnMouseOver()
    {
        onCollider = true;
    }
    private void OnMouseExit()
    {
        onCollider = false;
    }
    void Update()
    {
        if(onCollider & Input.GetKeyDown(KeyCode.Mouse0))

        {
            onDrag = true;
        }

        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            onDrag = false;
        }
    }
    private void FixedUpdate()
    {
        if (onDrag)
        {
            rigidbody2D.MovePosition(mainCamera.ScreenToWorldPoint(Input.mousePosition));
        }
    }
}
