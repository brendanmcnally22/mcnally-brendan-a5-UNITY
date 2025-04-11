using UnityEngine;

public class ShipColorChangerKeyboard : MonoBehaviour
{
    // Array of colors to cycle through WOO
    public Color[] colors = new Color[] { Color.white, Color.red, Color.green, Color.blue, Color.yellow };

    // Index to track the current color
    private int currentColorIndex = 0;


    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        // get the SpriteRenderer on this GameObject
        spriteRenderer = GetComponent<SpriteRenderer>();
       
        // Initialize with the first color.
        spriteRenderer.color = colors[currentColorIndex];
    }

    private void Update()
    {
        // Either shift can change our color :D
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            ChangeColor();
        }
    }

    // Cycle to the next color.
    private void ChangeColor()
    {
        currentColorIndex = (currentColorIndex + 1) % colors.Length;
        spriteRenderer.color = colors[currentColorIndex];
    }
}

