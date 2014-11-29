/*
 * Copyright 2014
 * autor: Daybson B.S. Paisante
 * email: daybsonbsp@gmail.com
 * encontrado em: http://daybsonpaisante.wordpress.com/ 
 */

using UnityEngine;
using System.Collections;

public class Gun : MonoBehaviour
{
		private LineRenderer lineRenderer;

		void Start ()
		{   
				var MyNewVar = this.transform.GetComponent<Rigidbody> ();
				//salva referência ao LineRenderer
				lineRenderer = this.GetComponent<LineRenderer> ();
		}

		void Update ()
		{
				//objeto do contato do raio lançado
				RaycastHit hit;

				//origem da linha
				lineRenderer.SetPosition (0, this.transform.position);

				//se raio tocar em algo, hit é preenchido com informações do contato
				if (Physics.Raycast (this.transform.position, this.transform.forward, out hit))
            
            //seta final da linha no ponto de contato
						lineRenderer.SetPosition (1, hit.point);
				else
            //seta final da linha rumo ao infinito na direção frontal do player.
						lineRenderer.SetPosition (1, transform.forward * 99999999);
		}
}