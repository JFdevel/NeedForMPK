using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changelvl : MonoBehaviour
{
    public GameObject temp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	private void Awake()
	{
        temp.gameObject.SetActive(false);
	}
}
