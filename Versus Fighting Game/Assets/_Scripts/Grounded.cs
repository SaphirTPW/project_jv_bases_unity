using UnityEngine;
using System.Collections;

public class Grounded : MonoBehaviour {

    private bool grounded = false;
    public P1CharacterMove p1;
    
    void Start()
    {
        p1 = GetComponent<P1CharacterMove>();
    }
    
   void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Ground")
        {
            Debug.Log("You are grounded");
            grounded = true;
            
        }
        else
        {
            grounded = false;
        }
    }
}
