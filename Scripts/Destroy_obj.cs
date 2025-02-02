using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_obj : MonoBehaviour
{

    void Update()
    {
        if(transform.position.x < -10)
		{
			Destroy( this.gameObject );
		}
    }
}
