using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float spaceCooldown = 0;
    private float spaceTimer = 0.4f;

    // Update is called once per frame
    void Update()
    {
        spaceCooldown -= Time.deltaTime;
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (spaceCooldown <= 0) {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                spaceCooldown = spaceTimer;
            }
        }
    }
}
