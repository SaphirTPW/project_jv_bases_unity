using UnityEngine;
using System.Collections;

public class SpawnItem : MonoBehaviour {

    public GameObject itemPrebab;
    private float Timer;

    void Awake()
    {
        Timer = Time.time + 20;
    }
    
    // Use this for initialization
	
	
	// Update is called once per frame
	void Update ()
    {
	    if(Timer < Time.time)
        {
            Instantiate(itemPrebab, transform.position, transform.rotation);
            Timer = Time.time + 20; 
        }
	}
}
