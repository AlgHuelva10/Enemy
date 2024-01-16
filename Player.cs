using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    /*Creamos variables:
     * Vida */
    public int health = 10;
    public GameObject fireballPrefab;
    public Transform attackPoint;

    // Función para recibir daño, a la vida le restas el daño para imprimir tu siguiente vida
    public void TakeDamage(int damage)
    {
        health -= damage;
        print("Tu vida actual es: " + health);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Instantiate(fireballPrefab, attackPoint.position, attackPoint.rotation);
        }
    }

}
