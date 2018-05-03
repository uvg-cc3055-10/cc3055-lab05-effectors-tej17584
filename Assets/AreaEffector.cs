using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaEffector : MonoBehaviour {

    float time;//variable que llevara la cuenta del tiempo
    public GameObject area;
    // Use this for initialization
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        time = time + Time.deltaTime;//le sumamos a time el tiempo 
        if ((time > 4))//si el tiempo es mayor a 4
        {
            area.SetActive(false);//seteamos el objeto en falso
            if ((time>6.5))//si es mayor a 6.5
            {
                time = 0;//colocamos el tiempo en 0 de nuevo
            }
        }
        else if (time < 4)//si el tiempo es menor a cuatro
        {
            area.SetActive(true);//esta activado
        }
        
        Debug.Log("Tiempo :" + time);//imprimimos en consola para ver el tiempo
    }
}
