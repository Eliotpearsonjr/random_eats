using UnityEngine;
using UnityEngine.SceneManagement;
// Developed by: Eliot Pearson Jr
// February 10, 2025

public class start_button : MonoBehaviour
{
    // this function will open the game
    public void open_game() {
        SceneManager.LoadScene(1);
    }
}
