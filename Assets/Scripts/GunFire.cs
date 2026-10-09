using System;
using StarterAssets;
using Unity.Cinemachine;
using UnityEngine;
using UnityEngine.InputSystem;

public class GunFire : MonoBehaviour
{

    [SerializeField] AudioSource gunFire;
    [SerializeField] Transform rifleTransform;

#if ENABLE_INPUT_SYSTEM
        private PlayerInput _playerInput;
#endif
    private StarterAssetsInputs _input;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _input = GetComponent<StarterAssetsInputs>();
        _playerInput = GetComponent<PlayerInput>();
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(_input.isFiring);

        Vector3 viewPointCenter = new Vector3(0.5f, 0.5f, 10f);
        Vector3 worldPointCenter = Camera.main.ViewportToWorldPoint(viewPointCenter);
        rifleTransform.LookAt(worldPointCenter);

        if (_input.isFiring)
        {
            if (!gunFire.isPlaying)
            {
                gunFire.Play();
            }
        }     
    }
}
