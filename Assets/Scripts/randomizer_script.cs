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
        public Sprite image;
        public string name;
    }

    public FoodItem[] foodItems;    // Array to store the food icons and corresponding names
    public Image displayImage;      // Reference to the UI Image
    public TMP_Text name;           // Reference to the text component for the name

    void Start()
    {
        if (foodItems.Length == 0 || displayImage == null || name == null)
        {
            Debug.LogError("Please assign food items, the display image, and the name text in the Inspector.");
        }
    }

    public void ShowRandomFood()
    {
        if (foodItems.Length > 0)
        {
            int randomIndex = Random.Range(0, foodItems.Length);
            displayImage.sprite = foodItems[randomIndex].image;
            name.text = foodItems[randomIndex].name;
        }
    }
    
}
