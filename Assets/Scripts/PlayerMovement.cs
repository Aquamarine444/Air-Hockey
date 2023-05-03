
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Camera Cam;

    private float startXPos;
    private float startYPos;
    private float startZPos;

    private bool isDragging = false;

    [SerializeField]
    private Rigidbody attachedBody;


    void FixedUpdate()
    {
        //if isDragging is true then it will call the DragObject function
        if (isDragging)
        {
            DragObject();
        }
    }

    private void OnMouseDown()
    {
        //runs when the mouse is clicked
        Vector3 mousePos = Input.mousePosition;

        if (!Cam.orthographic)
        {
            mousePos.z = 10;
        }

        mousePos = Cam.ScreenToWorldPoint(mousePos);

        startXPos = mousePos.x - transform.localPosition.x;
        startYPos = mousePos.y - transform.localPosition.y;
        startZPos = mousePos.z - transform.localPosition.z;

        isDragging = true;
    }

    private void OnMouseUp()
    {
        //when the mouse is no longer being clicked 
        isDragging = false;
    }

    public void DragObject()
        //A function to allow the  mouse to drag the playerobject
    {
        Vector3 mousePos = Input.mousePosition;

        if (!Cam.orthographic)
        {
            mousePos.z = 10;
        }

        mousePos = Cam.ScreenToWorldPoint(mousePos);
        attachedBody.position = new Vector3(mousePos.x - startXPos, mousePos.y - startYPos, mousePos.z - startZPos);
    }

}
