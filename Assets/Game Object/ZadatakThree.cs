using UnityEngine;
using UnityEngine.InputSystem;

public class ZadatakThree : MonoBehaviour
{
        
        public Key right = Key.D;
        public Key left = Key.A;
        public Key forward = Key.W;
        public Key backward = Key.S;

        public float moveSpeed = 1f;
        public float runSpeed;
        public Key sprint = Key.LeftShift;
        
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Keyboard.current[left].isPressed) 
                gameObject.transform.position += new Vector3(-moveSpeed, 0, 0);

        if(Keyboard.current[forward].isPressed) 
                gameObject.transform.position += new Vector3(0, 0, moveSpeed * runSpeed);
       
        if(Keyboard.current[forward].isPressed) 
                gameObject.transform.position += new Vector3(0, 0, moveSpeed);
        
             
        if(Keyboard.current[backward].isPressed)
                gameObject.transform.position += new Vector3(0, 0, -moveSpeed);
        
        if(Keyboard.current[right].isPressed)
                gameObject.transform.position += new Vector3(moveSpeed, 0, 0);

        if (Keyboard.current[sprint].isPressed)
                runSpeed = 2f;
        if (Keyboard.current[sprint].wasReleasedThisFrame)
                runSpeed = 1f;
        /*
        if(Keyboard.current[left].isPressed && Keyboard.current[forward].isPressed)
                gameObject.transform.position += new Vector3(-0.1f, 0, 0.1f);

        if(Keyboard.current[right].isPressed && Keyboard.current[forward].isPressed)
                gameObject.transform.position += new Vector3(0.1f, 0, 0.1f);

        if(Keyboard.current[left].isPressed && Keyboard.current[backward].isPressed)
                gameObject.transform.position += new Vector3(-0.1f, 0, -0.1f);

        if(Keyboard.current[right].isPressed && Keyboard.current[backward].isPressed)
                gameObject.transform.position += new Vector3(0.1f, 0, -0.1f);
         */
    }
}
