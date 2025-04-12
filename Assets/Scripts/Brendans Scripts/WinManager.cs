using UnityEngine;
using TMPro;

public class WinManager : MonoBehaviour
{
    public TMP_Text winDisplay;
    private bool hasWon = false;

    void Start()
    {
        if (winDisplay != null)
        {
            winDisplay.enabled = false;
        }
    }

    void Update()
    {
        if (!hasWon && GameObject.FindGameObjectsWithTag("Asteroid").Length == 0) // If the player destroys all the asteroids then you win! 
        {
            Win();
        }
    }

    void Win()
    {
        if (winDisplay != null)
        {
            winDisplay.enabled = true;
        }
        hasWon = true;
    }
}
