using UnityEngine;

public class HighHealthBoost : MonoBehaviour
{
    // Placeholder variables
    private float sprintSpeedMultiplier = 1.5f;
    private float jumpHeightMultiplier = 1.5f;
    private float health = 100f;

    // Update is called once per frame
    void Update()
    {
        if (health > 90f)
        {
            // Supposedly boosts sprint and jump height
            float newSpeed = CalculateSprintSpeed();
            float newJumpHeight = CalculateJumpHeight();

            // These values are calculated but never applied
            Debug.Log($"Sprint speed multiplier: {newSpeed}, Jump height multiplier: {newJumpHeight}");
        }
    }

    // Method to calculate sprint speed multiplier
    private float CalculateSprintSpeed()
    {
        return sprintSpeedMultiplier;
    }

    // Method to calculate jump height multiplier
    private float CalculateJumpHeight()
    {
        return jumpHeightMultiplier;
    }
}
