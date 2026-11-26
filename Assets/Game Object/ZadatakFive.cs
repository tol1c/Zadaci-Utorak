using UnityEngine;

public class ZadatakFive : MonoBehaviour
{
    public GameObject ObjektOne;
    public GameObject ObjektTwo;
    public GameObject ObjektThree;
    public GameObject ObjektFour;
    public GameObject ObjektFive;

    public Vector3 x;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*
        ObjektOne = GameObject.CreatePrimitive(PrimitiveType.Cube);
        ObjektTwo = GameObject.CreatePrimitive(PrimitiveType.Cube);
        ObjektThree = GameObject.CreatePrimitive(PrimitiveType.Cube);
        ObjektFour = GameObject.CreatePrimitive(PrimitiveType.Cube);

        ObjektOne.transform.position = new Vector3(5, 0, 0);
        ObjektTwo.transform.position = new Vector3(10,0,0);
        ObjektThree.transform.position = new Vector3(15,0,0);
        ObjektFour.transform.position = new Vector3(20,0,0);
        ObjektFive.transform.position = new Vector3(25,0,0);
        */

        for (int i = 0; i <= 5; i++)
        {
            ObjektOne = GameObject.CreatePrimitive(PrimitiveType.Cube);
            ObjektOne.transform.position = Vector3.left * i * 2;
            ObjektOne.name = ($"Cube{i}"); 
            ObjektOne.AddComponent<ZadatakThree>();
            Debug.Log(ObjektOne);
            
        }
            
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
