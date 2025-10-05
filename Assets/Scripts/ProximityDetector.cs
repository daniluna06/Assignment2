using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProximityDetector : MonoBehaviour { public GameObject popUpPanel; // Assign the UI Panel in the Inspector
private void Start()
{
    // Ensure the panel is hidden at the start
    if (popUpPanel != null)
    {
        popUpPanel.SetActive(false);
    }
}
private void OnTriggerEnter(Collider other)
{
    // Check if the player enters the trigger zone
    if (other.CompareTag("Player"))
    {
        if (popUpPanel != null)
        {
            popUpPanel.SetActive(true); // Show the panel
        }
    }
}
private void OnTriggerExit(Collider other)
{
    // Check if the player exits the trigger zone
    if (other.CompareTag("Player"))
    {
        if (popUpPanel != null)
        {
            popUpPanel.SetActive(false); // Hide the panel
        }
    }
}
}