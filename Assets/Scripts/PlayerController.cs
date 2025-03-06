using Unity.Mathematics;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;
    public float speed = 10.0f;
    public float xRange = 15.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput *Time.deltaTime * speed);

        // Keep player in bounds
        if(math.abs(transform.position.x) > xRange) {
            // the tutorial is bad and inefficient so i took it into my own hands
            transform.position = new Vector3(xRange * math.sign(transform.position.x), transform.position.y, transform.position.z);
        }
    }
}
