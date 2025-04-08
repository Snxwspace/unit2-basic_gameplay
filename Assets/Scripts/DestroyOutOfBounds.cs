using System.Globalization;
using Unity.VisualScripting;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30;
    private float bottomBound = -10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound) {
            Destroy(gameObject);
        } else if (transform.position.z < bottomBound) {
            if (gameObject) { // check if gameobject is of an animal (prefab comparison?) how do i do that though...
                Debug.Log("Game over");
            }
            Destroy(gameObject);
        }
    }
}
