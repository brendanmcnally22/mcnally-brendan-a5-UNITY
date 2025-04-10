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
    
    }

    private void Update()
    {

    }

    // Cycle to the next color.
    private void ChangeColor()
    {
       
    }
}

