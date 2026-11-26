using UnityEngine;
using UnityEngine.InputSystem;

public class ZadatakOne : MonoBehaviour
{
    private bool isActive = true;
    public GameObject targetObject;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    { 
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current[Key.S].wasPressedThisFrame)
        {
            //targetObject.SetActive(isActive);
            isActive = !isActive;
            Destroy(targetObject);
        }
        
        
    }
    
}
