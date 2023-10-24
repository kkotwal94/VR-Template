using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ColorChange : MonoBehaviour
{
    public InputActionReference colorReference = null;
    private MeshRenderer meshRenderer = null;

    void Awake() {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float value = colorReference.action.ReadValue<float>();
        UpdateColor(value);
    }

    private void UpdateColor(float value) {
        meshRenderer.material.color = new Color(value, value, value);
    }
}
