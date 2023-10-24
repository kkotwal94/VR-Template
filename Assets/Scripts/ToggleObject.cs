using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ToggleObject : MonoBehaviour
{
    public InputActionReference toggleReference = null;

    void Awake() {
        toggleReference.action.started += Toggle;
    }

    void OnDestroy() {
        toggleReference.action.started -= Toggle;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Toggle(InputAction.CallbackContext context) {
        bool isActive = !gameObject.activeSelf;
        gameObject.SetActive(isActive);
    }
}
