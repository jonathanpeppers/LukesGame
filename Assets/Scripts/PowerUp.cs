using System.Collections;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class PowerUp : MonoBehaviour
{
    CarController carController;

    void Start()
    {
        carController = FindObjectOfType<CarController>();
    }

    void OnTriggerEnter(Collider other)
    {
        carController.PlayCoins();
        carController.MaxSpeed += 50;
        Destroy(transform.parent.gameObject);
    }
}
