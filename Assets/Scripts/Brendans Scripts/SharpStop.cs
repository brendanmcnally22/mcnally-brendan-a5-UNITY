using UnityEngine;

public class SharpStop : MonoBehaviour
{
    private Rigidbody2D rb2d;

    void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
        if (rb2d == null)
        {
            Debug.LogError("SharpStop: No Rigidbody2D found on " + gameObject.name); // trying to debug rn
        }
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
        rb2d.velocity = Vector2.zero;
        rb2d.angularVelocity = 0f;
    }
}
