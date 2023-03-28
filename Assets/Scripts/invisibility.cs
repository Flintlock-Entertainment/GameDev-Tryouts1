using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class invisibility : MonoBehaviour
{
    [SerializeField][Tooltip("Toggle 'invisibility' on or off")]
    InputAction objectClicked = new InputAction(type: InputActionType.Button); 
    bool toggleInvisiability;
    SpriteRenderer objectSprite ;
    Color originalColor;

    void Start()
    {
        objectSprite = GetComponent<SpriteRenderer>();
        originalColor = objectSprite.color;
    }
    void OnEnable()  {
        objectClicked.Enable();
    }

    void OnDisable()  {
        objectClicked.Disable();
    }

    void Update() {
        if (objectClicked.WasPressedThisFrame()) {
            toggleInvisiability = !toggleInvisiability;
            if (toggleInvisiability)
            {
                objectSprite.color = Color.clear;
            }
            else
            {
                objectSprite.color = originalColor; 
            }
           
        }
    }
}