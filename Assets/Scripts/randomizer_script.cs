using UnityEngine;
using UnityEngine.UI;
using TMPro;
// Developed by: Eliot Pearson Jr
// February 11, 2025

public class randomizer_script : MonoBehaviour
{
    [System.Serializable]
    // each food item will have an icon and a name
    public struct FoodItem
    {
        public Sprite image;                // food icon
        public string name;                 // food name (ex: pizza)
    }

    // public instance variables
    public FoodItem[] foodItems;            // array to store the food icons and corresponding names
    public Image displayImage;              // Reference to the UI Image
    public TMP_Text name;                   // Reference to the text component for the name
    public ParticleSystem starBurstEffect;  // will show stars when button is pressed
    
    // private instance variables
    private int lastIndex = -1;             // store the last chosen index

    void Start()
    {
        if (foodItems.Length == 0 || displayImage == null || name == null) {
            Debug.LogError("Please assign food items, the display image, and the name text in the Inspector.");

        }
    }

    public void ShowRandomFood()
    {
        // ensure there is more than one option
        if (foodItems.Length > 1) {
            int randomIndex;                // index of the randomly selected food

            do {
                randomIndex = Random.Range(0, foodItems.Length);

            // keep generating until a different index is found
            } while (randomIndex == lastIndex);

            // store the new index
            lastIndex = randomIndex;
            
            // display image
            displayImage.sprite = foodItems[randomIndex].image;
            name.text = foodItems[randomIndex].name;

            // display particle system
            starBurstEffect.Play();

        } else {
            Debug.LogWarning("Not enough food items to ensure a different selection each time.");

        }
    }
    
}
