using System.Collections;
using UnityEngine;
using DG.Tweening;

public class WaterCan : MonoBehaviour
{
    private Camera cam;
    private float distanceToCamera;
    private Vector3 offset;
    private Vector3 initialPosition;
    private Vector3 initialRotation;

    public Vector3 targetPosition;
    public Vector3 targetRotation;

    public bool isDragging = false;
    public bool isInPosition = false;

    public Plant plant;
    public GameObject waterEffect;

    private bool hasWatered = false;
    private ParticleSystem waterParticle;

    private void Start()
    {
        cam = Camera.main;
        initialPosition = transform.localPosition;
        initialRotation = transform.localEulerAngles;

        if (waterEffect != null)
        {
            waterEffect.SetActive(false);
            waterParticle = waterEffect.GetComponent<ParticleSystem>();
            if (waterParticle != null)
                waterParticle.Stop();
        }
    }

    private void OnMouseDown()
    {
        isDragging = true;
        distanceToCamera = Vector3.Distance(cam.transform.position, transform.position);

        Vector3 mousePos = Input.mousePosition;
        mousePos.z = distanceToCamera;

        offset = transform.position - cam.ScreenToWorldPoint(mousePos);
    }

    private void OnMouseDrag()
    {
        if (isDragging)
        {
            Vector3 mousePos = Input.mousePosition;
            mousePos.z = distanceToCamera;

            Vector3 worldMousePos = cam.ScreenToWorldPoint(mousePos);
            Vector3 targetPos = worldMousePos + offset;

            // Prevent sinking below ground
            targetPos.y = Mathf.Max(targetPos.y, 0.2f);

            transform.position = targetPos;
        }
    }

    private void OnMouseUp()
    {
        isDragging = false;

        if (isInPosition && !hasWatered)
        {
            hasWatered = true;

            // Snap to final position and rotation
            transform.DOLocalMove(targetPosition, 0.5f);
            transform.DOLocalRotate(targetRotation, 0.5f).OnComplete(() =>
            {
                float zAngle = NormalizeAngle(transform.localEulerAngles.z);

                if (zAngle >= 65f)
                {
                    StartPouring();
                }
            });

            StartCoroutine(TriggerGrowth());
        }
        else
        {
            ResetPositionAnimation();
        }
    }

    private float NormalizeAngle(float angle)
    {
        return (angle > 180) ? 360 - angle : angle;
    }

    private void StartPouring()
    {
        if (waterEffect != null)
        {
            waterEffect.SetActive(true);
            if (waterParticle != null)
                waterParticle.Play();
        }
    }

    private void StopPouring()
    {
        if (waterEffect != null)
        {
            if (waterParticle != null)
                waterParticle.Stop();
            waterEffect.SetActive(false);
        }
    }

    private void ResetPositionAnimation()
    {
        transform.DOLocalMove(initialPosition, 0.5f);
        transform.DOLocalRotate(initialRotation, 0.5f);
        StopPouring();

        hasWatered = false;
        isInPosition = false;
    }

    private IEnumerator TriggerGrowth()
    {
        yield return new WaitForSeconds(2f);

        if (plant != null)
            plant.StartGrowth();

        yield return new WaitForSeconds(1.5f);
        StopPouring();
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Triggered with: " + other.name);

        if (other.CompareTag("PlantStage"))
        {
            isInPosition = true;
            Debug.Log("WaterCan is in position.");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("PlantStage"))
        {
            isInPosition = false;
        }
    }
}
