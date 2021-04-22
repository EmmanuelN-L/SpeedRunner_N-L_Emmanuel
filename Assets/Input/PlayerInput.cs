// GENERATED AUTOMATICALLY FROM 'Assets/Input/PlayerInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""DefaultInput"",
            ""id"": ""c86c4d43-218d-45c2-85c9-cb5d585fc38b"",
            ""actions"": [
                {
                    ""name"": ""MoveLeft"",
                    ""type"": ""Button"",
                    ""id"": ""b214592a-6229-4614-b2c3-1033b49beaff"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""MoveRight"",
                    ""type"": ""Button"",
                    ""id"": ""902e269e-d19c-4b3d-9a43-32e0cc2098ac"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""3e3e9569-e265-4cc8-85b0-ee536d025f3d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""13662081-beab-45ec-aa00-bf347573d9ed"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""036f6c09-62a6-4132-b38a-c6546cdd6704"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""713cbd5c-74fd-4a46-9767-b4388d9ca0d7"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""76ff14ca-a831-46fa-b9a3-f75eaea4909e"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1937283e-f7f1-4123-903c-bb5e406f3162"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""83970fc5-dfbc-44c8-8248-b36ba6e67bef"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b5af48de-3d16-4960-8f40-90b22b90adf6"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ff6108aa-7a94-4183-893f-d531fe6f5a33"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // DefaultInput
        m_DefaultInput = asset.FindActionMap("DefaultInput", throwIfNotFound: true);
        m_DefaultInput_MoveLeft = m_DefaultInput.FindAction("MoveLeft", throwIfNotFound: true);
        m_DefaultInput_MoveRight = m_DefaultInput.FindAction("MoveRight", throwIfNotFound: true);
        m_DefaultInput_Jump = m_DefaultInput.FindAction("Jump", throwIfNotFound: true);
        m_DefaultInput_Pause = m_DefaultInput.FindAction("Pause", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // DefaultInput
    private readonly InputActionMap m_DefaultInput;
    private IDefaultInputActions m_DefaultInputActionsCallbackInterface;
    private readonly InputAction m_DefaultInput_MoveLeft;
    private readonly InputAction m_DefaultInput_MoveRight;
    private readonly InputAction m_DefaultInput_Jump;
    private readonly InputAction m_DefaultInput_Pause;
    public struct DefaultInputActions
    {
        private @PlayerInput m_Wrapper;
        public DefaultInputActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @MoveLeft => m_Wrapper.m_DefaultInput_MoveLeft;
        public InputAction @MoveRight => m_Wrapper.m_DefaultInput_MoveRight;
        public InputAction @Jump => m_Wrapper.m_DefaultInput_Jump;
        public InputAction @Pause => m_Wrapper.m_DefaultInput_Pause;
        public InputActionMap Get() { return m_Wrapper.m_DefaultInput; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DefaultInputActions set) { return set.Get(); }
        public void SetCallbacks(IDefaultInputActions instance)
        {
            if (m_Wrapper.m_DefaultInputActionsCallbackInterface != null)
            {
                @MoveLeft.started -= m_Wrapper.m_DefaultInputActionsCallbackInterface.OnMoveLeft;
                @MoveLeft.performed -= m_Wrapper.m_DefaultInputActionsCallbackInterface.OnMoveLeft;
                @MoveLeft.canceled -= m_Wrapper.m_DefaultInputActionsCallbackInterface.OnMoveLeft;
                @MoveRight.started -= m_Wrapper.m_DefaultInputActionsCallbackInterface.OnMoveRight;
                @MoveRight.performed -= m_Wrapper.m_DefaultInputActionsCallbackInterface.OnMoveRight;
                @MoveRight.canceled -= m_Wrapper.m_DefaultInputActionsCallbackInterface.OnMoveRight;
                @Jump.started -= m_Wrapper.m_DefaultInputActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_DefaultInputActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_DefaultInputActionsCallbackInterface.OnJump;
                @Pause.started -= m_Wrapper.m_DefaultInputActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_DefaultInputActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_DefaultInputActionsCallbackInterface.OnPause;
            }
            m_Wrapper.m_DefaultInputActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MoveLeft.started += instance.OnMoveLeft;
                @MoveLeft.performed += instance.OnMoveLeft;
                @MoveLeft.canceled += instance.OnMoveLeft;
                @MoveRight.started += instance.OnMoveRight;
                @MoveRight.performed += instance.OnMoveRight;
                @MoveRight.canceled += instance.OnMoveRight;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
            }
        }
    }
    public DefaultInputActions @DefaultInput => new DefaultInputActions(this);
    public interface IDefaultInputActions
    {
        void OnMoveLeft(InputAction.CallbackContext context);
        void OnMoveRight(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
    }
}
