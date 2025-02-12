using UnityEngine;
using UnityEngine.UI;
// Developed by: Eliot Pearson Jr
// February 11, 2025

public class randomizer_script : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public Sprite[] images;         // Array to store the food icons
    public Image displayImage;      // The base image displayed before randomization

    void Start()
    {
        // no images present in inspector
        if (images.Length == 0 || displayImage == null)
        {
            Debug.LogError("Please assign images and the display image in the Inspector.");
        }
    }

    // will randomly select from the array of image icons upon each button press
    public void ShowRandomImage()
    {
        if (images.Length > 0)
        {
            int randomIndex = Random.Range(0, images.Length);
            displayImage.sprite = images[randomIndex];
        }
    }
}
