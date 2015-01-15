/*
 * Copyright 2014
 * author: Daybson B.S. Paisante
 * daybson.paisante@outlook.com
 * http://daybsonpaisante.wordpress.com/ 
 */

using UnityEngine;
using System.Collections;

public class Gun : MonoBehaviour
{
	private LineRenderer lineRenderer;
		void Start ()
	{   
		lineRenderer = this.GetComponent<LineRenderer> ();
	}
		void Update ()
	{
		RaycastHit hit;
		
		//line origin
		lineRenderer.SetPosition (0, this.transform.position);
		
		//if the ray hits something, fill hit with the contact point informations
		if (Physics.Raycast (this.transform.position, this.transform.forward, out hit))
                   	//line ending is set as the contact point
			lineRenderer.SetPosition (1, hit.point);
		else
           		//if hits anything, line goes to infinity foward the player
			lineRenderer.SetPosition (1, transform.forward * 99999999);
	}
}
