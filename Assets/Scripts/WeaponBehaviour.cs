using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponBehaviour : MonoBehaviour
{

    public Transform shootOrigin;
    public float shootForce = 1000f;

    private void Update()
    {
        Debug.DrawRay(shootOrigin.position, shootOrigin.forward * shootForce, Color.red);

        if (Input.GetMouseButtonDown(0))
        {
            bool didHit = Physics.Raycast(shootOrigin.position, shootOrigin.forward, out RaycastHit hit);

            if (didHit)
            {
                if (hit.collider.gameObject.layer == LayerMask.NameToLayer("Enemy"))
                {
                    Destroy(hit.collider.gameObject);
                }

                Debug.Log("Hit");
            }
            else
            {
                Debug.Log("Miss");
            }
        }
    }

}


// Magic numbers, parametrizacion, literal magico, nombre clase, nombres de variables, optimizacion(en un update se hace algo que no se haria), codigo duplicado