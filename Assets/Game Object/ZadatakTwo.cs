using UnityEngine;
using UnityEngine.InputSystem;

public class ZadatakTwo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current[Key.Space].isPressed)
            gameObject.transform.position += new Vector3(0.5f, 0, 0);
    }
}
