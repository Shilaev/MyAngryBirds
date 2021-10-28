// GENERATED AUTOMATICALLY FROM 'Assets/InputSystem/PlayerInputSystem.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInputSystem : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputSystem()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputSystem"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""adaa64ab-89f0-4ec2-8b4d-4d29ee9d72cf"",
            ""actions"": [
                {
                    ""name"": ""SelectAndMove"",
                    ""type"": ""Value"",
                    ""id"": ""4ea524db-2439-4b6c-8d1d-39b24dbdf87b"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b1d64fb2-3957-4776-96df-ee9ba9fd4eda"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SelectAndMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d1c6930c-4135-4883-b8bd-486c12ddd75c"",
                    ""path"": ""<Touchscreen>/primaryTouch/tap"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SelectAndMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1a0ea5d2-3710-43b6-ade1-a41a54cf3834"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SelectAndMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_SelectAndMove = m_Player.FindAction("SelectAndMove", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_SelectAndMove;
    public struct PlayerActions
    {
        private @PlayerInputSystem m_Wrapper;
        public PlayerActions(@PlayerInputSystem wrapper) { m_Wrapper = wrapper; }
        public InputAction @SelectAndMove => m_Wrapper.m_Player_SelectAndMove;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @SelectAndMove.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSelectAndMove;
                @SelectAndMove.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSelectAndMove;
                @SelectAndMove.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSelectAndMove;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @SelectAndMove.started += instance.OnSelectAndMove;
                @SelectAndMove.performed += instance.OnSelectAndMove;
                @SelectAndMove.canceled += instance.OnSelectAndMove;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    public interface IPlayerActions
    {
        void OnSelectAndMove(InputAction.CallbackContext context);
    }
}
