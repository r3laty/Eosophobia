//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Input/InputActions.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @InputActions: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputActions"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""2bdc1496-558f-4bbc-a5af-b5d94ba36a82"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""264e805d-6b3b-4f05-a39a-7574b4500edf"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""a2aa3c53-1209-4f7b-9b47-8997086efc3c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MouseLook"",
                    ""type"": ""Value"",
                    ""id"": ""2fa64bac-02a1-42c5-aace-f50dfa6490a0"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""e8cadb7b-5a72-49b5-a109-ef34ac10eb66"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""cd4f5f41-fc9d-4a33-8355-d149059055d5"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""836ce431-aff5-42c7-973d-8ade4d2160ba"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseLook"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""4a75ab92-2755-4ed6-9c0e-a8b074382756"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""7c28d0dd-a954-4d70-bc72-64ba605a111f"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""aa5b2367-4b07-4bb9-9e26-c972ab2dd2cc"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""bfdf41ea-9ae1-4112-a884-f35a9994a4f7"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""25d6e342-89e7-4652-bd2a-e1913577ca05"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""89f5f806-fb05-45d5-8130-35221a53a2b3"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""InGameUi"",
            ""id"": ""4c1a475a-3125-4517-a1f6-f89ed6d52046"",
            ""actions"": [
                {
                    ""name"": ""WeaponChangeKeyOne"",
                    ""type"": ""Button"",
                    ""id"": ""81fa2ef6-7c9c-4dd2-8e40-69f3d69ff968"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""WeaponChangeKeyTwo"",
                    ""type"": ""Button"",
                    ""id"": ""e4e36bfb-7f50-48d6-add2-cf659c1c4691"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""WeaponChangeKeyThree"",
                    ""type"": ""Button"",
                    ""id"": ""45f0e557-a559-4bf2-a516-8fbcf9ebbe7b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""ea127d2d-9932-4ecd-a924-7f5efe5bc60a"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WeaponChangeKeyOne"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0cd66ada-7dfe-43b0-994b-7ddc197f353f"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WeaponChangeKeyTwo"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""09f954d6-abed-4ff0-bb1d-6f48c59d6455"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WeaponChangeKeyThree"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Gameplay
        m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
        m_Gameplay_Movement = m_Gameplay.FindAction("Movement", throwIfNotFound: true);
        m_Gameplay_Jump = m_Gameplay.FindAction("Jump", throwIfNotFound: true);
        m_Gameplay_MouseLook = m_Gameplay.FindAction("MouseLook", throwIfNotFound: true);
        m_Gameplay_Attack = m_Gameplay.FindAction("Attack", throwIfNotFound: true);
        // InGameUi
        m_InGameUi = asset.FindActionMap("InGameUi", throwIfNotFound: true);
        m_InGameUi_WeaponChangeKeyOne = m_InGameUi.FindAction("WeaponChangeKeyOne", throwIfNotFound: true);
        m_InGameUi_WeaponChangeKeyTwo = m_InGameUi.FindAction("WeaponChangeKeyTwo", throwIfNotFound: true);
        m_InGameUi_WeaponChangeKeyThree = m_InGameUi.FindAction("WeaponChangeKeyThree", throwIfNotFound: true);
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

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Gameplay
    private readonly InputActionMap m_Gameplay;
    private List<IGameplayActions> m_GameplayActionsCallbackInterfaces = new List<IGameplayActions>();
    private readonly InputAction m_Gameplay_Movement;
    private readonly InputAction m_Gameplay_Jump;
    private readonly InputAction m_Gameplay_MouseLook;
    private readonly InputAction m_Gameplay_Attack;
    public struct GameplayActions
    {
        private @InputActions m_Wrapper;
        public GameplayActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Gameplay_Movement;
        public InputAction @Jump => m_Wrapper.m_Gameplay_Jump;
        public InputAction @MouseLook => m_Wrapper.m_Gameplay_MouseLook;
        public InputAction @Attack => m_Wrapper.m_Gameplay_Attack;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void AddCallbacks(IGameplayActions instance)
        {
            if (instance == null || m_Wrapper.m_GameplayActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_GameplayActionsCallbackInterfaces.Add(instance);
            @Movement.started += instance.OnMovement;
            @Movement.performed += instance.OnMovement;
            @Movement.canceled += instance.OnMovement;
            @Jump.started += instance.OnJump;
            @Jump.performed += instance.OnJump;
            @Jump.canceled += instance.OnJump;
            @MouseLook.started += instance.OnMouseLook;
            @MouseLook.performed += instance.OnMouseLook;
            @MouseLook.canceled += instance.OnMouseLook;
            @Attack.started += instance.OnAttack;
            @Attack.performed += instance.OnAttack;
            @Attack.canceled += instance.OnAttack;
        }

        private void UnregisterCallbacks(IGameplayActions instance)
        {
            @Movement.started -= instance.OnMovement;
            @Movement.performed -= instance.OnMovement;
            @Movement.canceled -= instance.OnMovement;
            @Jump.started -= instance.OnJump;
            @Jump.performed -= instance.OnJump;
            @Jump.canceled -= instance.OnJump;
            @MouseLook.started -= instance.OnMouseLook;
            @MouseLook.performed -= instance.OnMouseLook;
            @MouseLook.canceled -= instance.OnMouseLook;
            @Attack.started -= instance.OnAttack;
            @Attack.performed -= instance.OnAttack;
            @Attack.canceled -= instance.OnAttack;
        }

        public void RemoveCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IGameplayActions instance)
        {
            foreach (var item in m_Wrapper.m_GameplayActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_GameplayActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);

    // InGameUi
    private readonly InputActionMap m_InGameUi;
    private List<IInGameUiActions> m_InGameUiActionsCallbackInterfaces = new List<IInGameUiActions>();
    private readonly InputAction m_InGameUi_WeaponChangeKeyOne;
    private readonly InputAction m_InGameUi_WeaponChangeKeyTwo;
    private readonly InputAction m_InGameUi_WeaponChangeKeyThree;
    public struct InGameUiActions
    {
        private @InputActions m_Wrapper;
        public InGameUiActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @WeaponChangeKeyOne => m_Wrapper.m_InGameUi_WeaponChangeKeyOne;
        public InputAction @WeaponChangeKeyTwo => m_Wrapper.m_InGameUi_WeaponChangeKeyTwo;
        public InputAction @WeaponChangeKeyThree => m_Wrapper.m_InGameUi_WeaponChangeKeyThree;
        public InputActionMap Get() { return m_Wrapper.m_InGameUi; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(InGameUiActions set) { return set.Get(); }
        public void AddCallbacks(IInGameUiActions instance)
        {
            if (instance == null || m_Wrapper.m_InGameUiActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_InGameUiActionsCallbackInterfaces.Add(instance);
            @WeaponChangeKeyOne.started += instance.OnWeaponChangeKeyOne;
            @WeaponChangeKeyOne.performed += instance.OnWeaponChangeKeyOne;
            @WeaponChangeKeyOne.canceled += instance.OnWeaponChangeKeyOne;
            @WeaponChangeKeyTwo.started += instance.OnWeaponChangeKeyTwo;
            @WeaponChangeKeyTwo.performed += instance.OnWeaponChangeKeyTwo;
            @WeaponChangeKeyTwo.canceled += instance.OnWeaponChangeKeyTwo;
            @WeaponChangeKeyThree.started += instance.OnWeaponChangeKeyThree;
            @WeaponChangeKeyThree.performed += instance.OnWeaponChangeKeyThree;
            @WeaponChangeKeyThree.canceled += instance.OnWeaponChangeKeyThree;
        }

        private void UnregisterCallbacks(IInGameUiActions instance)
        {
            @WeaponChangeKeyOne.started -= instance.OnWeaponChangeKeyOne;
            @WeaponChangeKeyOne.performed -= instance.OnWeaponChangeKeyOne;
            @WeaponChangeKeyOne.canceled -= instance.OnWeaponChangeKeyOne;
            @WeaponChangeKeyTwo.started -= instance.OnWeaponChangeKeyTwo;
            @WeaponChangeKeyTwo.performed -= instance.OnWeaponChangeKeyTwo;
            @WeaponChangeKeyTwo.canceled -= instance.OnWeaponChangeKeyTwo;
            @WeaponChangeKeyThree.started -= instance.OnWeaponChangeKeyThree;
            @WeaponChangeKeyThree.performed -= instance.OnWeaponChangeKeyThree;
            @WeaponChangeKeyThree.canceled -= instance.OnWeaponChangeKeyThree;
        }

        public void RemoveCallbacks(IInGameUiActions instance)
        {
            if (m_Wrapper.m_InGameUiActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IInGameUiActions instance)
        {
            foreach (var item in m_Wrapper.m_InGameUiActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_InGameUiActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public InGameUiActions @InGameUi => new InGameUiActions(this);
    public interface IGameplayActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnMouseLook(InputAction.CallbackContext context);
        void OnAttack(InputAction.CallbackContext context);
    }
    public interface IInGameUiActions
    {
        void OnWeaponChangeKeyOne(InputAction.CallbackContext context);
        void OnWeaponChangeKeyTwo(InputAction.CallbackContext context);
        void OnWeaponChangeKeyThree(InputAction.CallbackContext context);
    }
}
