using UnityEngine;

public class SpeedBoost : MonoBehaviour
{
    [SerializeField] private float boostForce = 10f;
    private Rigidbody2D rb2d;

    void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
        if (rb2d == null)
        {
            Debug.LogError("SpeedBoost: No Rigidbody2D found on " + gameObject.name);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightShift))
        {
            ApplyBoost();
        }
    }

    void ApplyBoost()
    {
        Vector2 boostDirection = new Vector2(transform.up.x, transform.up.y);
        rb2d.AddForce(boostDirection * boostForce, ForceMode2D.Impulse);
    }
}


