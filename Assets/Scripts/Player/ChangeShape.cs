using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeShape : MonoBehaviour
{
    [SerializeField] public GameObject Triangle;
    [SerializeField] public GameObject Parallelepiped;
    [SerializeField] public GameObject Sphere;

    [SerializeField] public Mover mover;

    private void Start()
    {
        Triangle.SetActive(false);
        Parallelepiped.SetActive(false);
        Sphere.SetActive(true);
        ChangeCharacteristics(Sphere.GetComponent<Object>());
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Triangle.SetActive(false);
            Parallelepiped.SetActive(false);

            Sphere.SetActive(true);
            ChangeCharacteristics(Sphere.GetComponent<Object>());
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Triangle.SetActive(false);
            Sphere.SetActive(false);

            Parallelepiped.SetActive(true);
            ChangeCharacteristics(Parallelepiped.GetComponent<Object>());
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Sphere.SetActive(false);
            Parallelepiped.SetActive(false);

            Triangle.SetActive(true);
            ChangeCharacteristics(Triangle.GetComponent<Object>());
        }
    }

    public void ChangeCharacteristics(Object objectCharacterisics)
    {
        mover.speed = objectCharacterisics.speed;
        mover.jumpForce = objectCharacterisics.jumpForce;
    }
}
