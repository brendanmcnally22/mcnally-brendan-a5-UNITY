using UnityEngine;

public class SharpStop : MonoBehaviour
{
    private Rigidbody2D rb2d;

    void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightShift))
        {
            ApplyStop();
        }
    }

    void ApplyStop()
    {
        rb2d.linearVelocity = Vector2.zero;
        rb2d.angularVelocity = 0f;
    }
}
