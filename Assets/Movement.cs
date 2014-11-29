/*
 * Copyright 2014
 * autor: Daybson B.S. Paisante
 * email: daybsonbsp@gmail.com
 * encontrado em: http://daybsonpaisante.wordpress.com/ 
 */

using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour
{
    //fator de movimentação
    public float speed;

    private void Update()
    {
        //rotaciona e translada de acordo com o input do usuário
        transform.Rotate(0, Input.GetAxis("Horizontal") * speed, 0);
        transform.Translate(0, 0, Input.GetAxis("Vertical") * speed * Time.deltaTime);
    }
}
