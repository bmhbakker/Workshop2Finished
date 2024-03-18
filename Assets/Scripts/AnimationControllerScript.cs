using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AnimationControllerScript : MonoBehaviour
{
    // Public fields
    [SerializeField] private float acceleration = 0.5f, deceleration = 0.5f, maximumInjuredLayerWeight = 0.5f;
    [SerializeField] private TextMeshProUGUI healthText;
    [SerializeField] private GameObject cubeObject;
    
    // Animator component
    private Animator _animator;

    // Player health
    private const float MaximumHealth = 100;
    private float _currentHealth;

    // Movement parameters
    private float _velocity;
    private int _velocityHash;
    private bool _isWalking;

    // Layer indexes
    private int _injuredLayerIndex;
    private int _aimingLayerIndex;
    private int _lookingLayerIndex;
    private float _layerWeightVelocity;
    
    // Start is called before the first frame update
    private void Start()
    {
        _currentHealth = MaximumHealth;
        
        _animator = GetComponent<Animator>();
        
        _velocityHash = Animator.StringToHash("Velocity");
        
        _injuredLayerIndex = _animator.GetLayerIndex("Injured");
        _aimingLayerIndex = _animator.GetLayerIndex("Aiming");
        _lookingLayerIndex = _animator.GetLayerIndex("Aiming");
        
        ResetAimingLayer();
    }

    // Update is called once per frame
    private void Update()
    {
        ExecuteBlendTree();
        ChangeLayers();
        ExecuteAim();
    }

    private void OnAnimatorIK(int layerIndex)
    {
        var lookAtPressed = Input.GetKey(KeyCode.Q);

        if (!lookAtPressed) return;
        _animator.SetLayerWeight(_lookingLayerIndex, 0);
        _animator.SetLookAtPosition(cubeObject.transform.position);
        _animator.SetLookAtWeight(1.0f,0.4f,1f);
    }

    private void ExecuteAim()
    {
        var aimingPressed = Input.GetKeyDown(KeyCode.A);
        _animator.SetBool("IsAiming", aimingPressed);
        if (!aimingPressed) return;
        
        _animator.SetLayerWeight(_aimingLayerIndex, 1);
        _animator.SetLayerWeight(_lookingLayerIndex, 1);
    }

    private void ResetAimingLayer()
    {
        _animator.SetLayerWeight(_aimingLayerIndex, 0f);
        _animator.SetLayerWeight(_lookingLayerIndex, 0f);
    }
    
    private void ChangeLayers()
    {
        var hitPressed = Input.GetKeyDown(KeyCode.Space);

        if (hitPressed)
        {
            _currentHealth -= MaximumHealth / 10;

            if (_currentHealth < 0)
            {
                _currentHealth = MaximumHealth;
            }
        }

        var healthPercentage = _currentHealth / MaximumHealth;
        healthText.text = $"Health: {healthPercentage * 100}%";

        var currentInjuredLayerWeight = _animator.GetLayerWeight(_injuredLayerIndex);
        var targetInjuredLayerWeight = (1 - healthPercentage) * maximumInjuredLayerWeight;
        
        _animator.SetLayerWeight(_injuredLayerIndex,
            Mathf.SmoothDamp(currentInjuredLayerWeight,
                targetInjuredLayerWeight,
                ref _layerWeightVelocity, 
                0.2f));
    }

    private void ExecuteBlendTree()
    {
        var forwardPressed = Input.GetKey(KeyCode.W);
        
        switch (forwardPressed)
        {
            case true when _velocity < 1:
                _animator.SetBool("IsWalking", true);
                _velocity += Time.deltaTime * acceleration;
                break;
            case false when _velocity > 0:
                _animator.SetBool("IsWalking", false);
                _velocity -= Time.deltaTime * deceleration;
                break;
        }
        
        if (!forwardPressed && _velocity < 0.0f)
        {
            _velocity = 0.0f;
        }
        
        _animator.SetFloat(_velocityHash, _velocity);
    }
}
