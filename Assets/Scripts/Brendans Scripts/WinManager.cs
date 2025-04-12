using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class WinManager : MonoBehaviour
{
    public TMP_Text winDisplay;
    public GameManager gameManager;
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

        if (hasWon && Input.GetKeyDown(KeyCode.R))
        {
            Scene current = SceneManager.GetActiveScene();
            SceneManager.LoadScene(current.name);
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
