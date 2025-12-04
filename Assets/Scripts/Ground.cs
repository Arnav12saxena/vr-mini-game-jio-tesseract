using UnityEngine;
using DG.Tweening; // Required for DOLocalMove

public class Ground : MonoBehaviour
{
    public Vector3 targetPosition;   // Where the seed should snap
    public Seed seed;                // Reference to Seed script
    public WaterCan waterCan;        // Reference to WaterCan script
    public Plant plant;              // Reference to Plant script

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Collision detected with: " + other.gameObject.name);
        if (other.gameObject == seed.gameObject)
        {
            if (!seed.isDragging)
            {
                Debug.Log("Seed placed on ground " + seed.isDragging);
                seed.transform.DOLocalMove(targetPosition, 0.5f);
                seed.isPlaced = true;
                GetComponent<Collider>().enabled = false;
                seed.GetComponent<Collider>().enabled = false;
                waterCan.GetComponent<Collider>().enabled = true;
                plant.GetComponent<Collider>().enabled = true;
            }
        }
    }
}
