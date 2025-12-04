using UnityEngine;
using System.Collections.Generic;

public class Plant : MonoBehaviour
{
    public WaterCan waterCan;
    public Seed seed;
    public List<GameObject> stages; // 0: seed, 1: small, 2: medium, 3: large

    private int currentStage = 0;

    private void Awake()
    {
        // Ensure all stages are hidden before Start runs
        foreach (GameObject stage in stages)
        {
            if (stage != null)
                stage.SetActive(false);
        }
    }

    private void Start()
    {
        // Activate only stage 0 (seed or placeholder)
        if (stages.Count > 0 && stages[0] != null)
            stages[0].SetActive(true);
    }

    public void Grow()
    {
        if (currentStage < stages.Count - 1)
        {
            stages[currentStage].SetActive(false);
            currentStage++;
            stages[currentStage].SetActive(true);

            // Disable seed object when it grows past the seed stage
            if (currentStage > 0 && seed != null)
                seed.gameObject.SetActive(false);
        }

        // If it's the last stage, stop further interaction
        if (currentStage == stages.Count - 1)
        {
            if (waterCan != null)
                waterCan.enabled = false;

            this.enabled = false;
        }
    }

    public void StartGrowth()
    {
        Grow(); // Only grow one stage per watering
    }
}