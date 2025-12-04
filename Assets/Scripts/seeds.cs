using System.Collections;
using UnityEngine;
using DG.Tweening;

public class Seed : MonoBehaviour
{
    private Camera cam;
    private float distanceToCamera;
    private Vector3 offset;
    private Vector3 initialPosition;

    public bool isDragging = false;
    public bool isPlaced;

    void Start()
    {
        initialPosition = transform.localPosition;
        cam = Camera.main;
    }

    void OnMouseDown()
    {
        isDragging = true;

        // Calculate distance from camera to object
        distanceToCamera = Vector3.Distance(cam.transform.position, transform.position);

        // Get mouse position and calculate offset
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = distanceToCamera;
        Vector3 worldMousePos = cam.ScreenToWorldPoint(mousePos);
        offset = transform.position - worldMousePos;
    }

    void OnMouseDrag()
    {
        if (isDragging)
        {
            Vector3 mousePos = Input.mousePosition;
            mousePos.z = distanceToCamera;
            Vector3 worldMousePos = cam.ScreenToWorldPoint(mousePos);
            transform.position = worldMousePos + offset;
        }
    }

    void OnMouseUp()
    {
        Debug.Log("Mouse Up on Seed");
        isDragging = false;
        StartCoroutine(ResetPosition());
    }

    IEnumerator ResetPosition()
    {
        yield return new WaitForSeconds(0.1f);
        if (!isPlaced)
        {
            transform.DOLocalMove(initialPosition, 0.5f);
        }
        

    }
}