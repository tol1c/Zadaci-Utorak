using UnityEngine;
using UnityEngine.InputSystem;

public class ZadatakFour : MonoBehaviour
{
    private GameObject primitiveCube;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject.CreatePrimitive(PrimitiveType.Cube);
        primitiveCube.AddComponent<ZadatakThree>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
