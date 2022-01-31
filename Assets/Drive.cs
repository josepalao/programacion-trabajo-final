using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drive : MonoBehaviour
{
    public float speed = 10.0f;
    //Referencia a la bala que dispara la nave
    public GameObject bullet;

    void Update()
    {
        //Ls nave se mueve
        float translation = Input.GetAxis("Horizontal") * speed;
        translation *= Time.deltaTime;
        transform.Translate(translation, 0, 0);

        //Al pulsar espacio la nave disparara
        if (Input.GetKeyDown("space"))
        {
            //Hacemos aparecer una bala
            //Instantiate(bullet, this.transform.position, Quaternion.identity);

            //Creamos una referencia al objeto de la lista de objetos creados mediante el Pool
            GameObject b = Pool.singleton.Get("Bullet");
            //Si el objeto que he recibido no está vacío(osea que se puede usar)
            if (b != null)
            {
                //Igualamos la posición de esa bala con la de la nave
                b.transform.position = this.transform.position + Vector3.up * 1;
                //Y activamos la bala
                b.SetActive(true);
            }
        }
    }
}