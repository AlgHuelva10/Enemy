using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    /* Creamos variables:
     * Velocidad
     * Posición del enemigo
     * Daño hacia el jugador */
    public float speed;
    public Transform target;
    public int playerDamage = 2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Mover al enemigo hacia delante cada frame
            transform.position =
        Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

        // Hacer que el enemigo mire siempre al jugador
        transform.LookAt(target.position);
    }
    private void OnTriggerEnter(Collider other)
    {
        // El jugador recibe daño
        Player player = other.GetComponent<Player>();

        player.TakeDamage(playerDamage);
        
    }
}
