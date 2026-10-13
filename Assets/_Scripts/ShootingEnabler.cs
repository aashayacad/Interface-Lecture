using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ShootingEnabler : MonoBehaviour
{
    public List<Transform> shootables = new List<Transform>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            foreach (Transform shootableTransform in shootables)
            {
                IShootable shootable = shootableTransform.GetComponent<IShootable>();
                if (shootable != null)
                {
                    shootable.Shoot();
                }
            }
        }
    }
}
