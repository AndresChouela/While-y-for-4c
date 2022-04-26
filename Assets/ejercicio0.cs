using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio0 : MonoBehaviour {
    public int num1;
    public int num2;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void validarcontrasenia()
    {
        int contador = 1;
        //for(int i = 0, i > 3, i ++){

        if (num2 < num1)
        {
            while (num1 >= num2)
            {
                Debug.Log(num1);
                num1--;
            }
        }
        else if (num1 == num2)
        {
            Debug.Log("los numeros son iguales");
        }
        else if (num1 < num2)
        {
            Debug.Log("el segundo numero es mayor que el primero");
        }
    }
}
