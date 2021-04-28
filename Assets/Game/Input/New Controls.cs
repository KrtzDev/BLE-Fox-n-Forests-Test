// GENERATED AUTOMATICALLY FROM 'Assets/Game/Input/New Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @NewControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @NewControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""New Controls"",
    ""maps"": [
        {
            ""name"": ""Fox"",
            ""id"": ""8885581b-9001-4a71-b099-48c2dd42152d"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""c696be15-8d5f-4c4c-9fae-1eb6c96b40e3"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""d119d145-959c-4f54-b442-d7e2d9bba626"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""e9ecfa95-0c27-4ef9-b8b2-6a3e77b3c84b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""f23f09f5-548d-4e14-a802-c5b339e515ae"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""55bad957-c2fc-4d10-a8b0-efa7b9dbaa3c"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""e2fdd7bd-dc4c-4b4d-bd9e-c91b52fac02d"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrows"",
                    ""id"": ""3727d78c-dea5-4051-8fa8-d1b2ad555354"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""8f548af2-804e-4232-b4bb-74602b4e9089"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""f84cfbbe-2f67-4c0d-98d4-98e649c8fb96"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Controller Stick"",
                    ""id"": ""5ca9f7c6-21d8-4850-89f0-255f8c29cc6e"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""5064d20f-004b-40be-b9e1-682d795e2397"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""ebfceec2-149f-4c7c-b1aa-0f61a604af3d"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Controller DPad"",
                    ""id"": ""c6ad535e-a9f4-4e6d-b0f5-c51530abe883"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""bb2e9d62-3093-4c58-936f-24688a60903f"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""2b7d094c-3dfa-48b4-af92-0f6ac1bfc04f"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""ebaf6e97-ff84-4598-b706-e1b191425942"",
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
                    ""id"": ""01d42d46-ce9f-4e46-bbfc-dd435297bf71"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""eb23907f-0df5-4382-99ce-4fdc31396cdf"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""27497ddb-3b63-412c-a2fa-727fb4eeecd7"",
                    ""path"": ""<Keyboard>/ctrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""50cda5e7-0514-43a2-aeac-d969b6213b72"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""210d14b1-2cff-48d9-84db-4a99bd6ac8d1"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""50a5f10a-7afd-498d-badc-b3fc6f5525b5"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""MenuControlls"",
            ""id"": ""8d32666e-e604-42d1-ad1b-73ec82759618"",
            ""actions"": [
                {
                    ""name"": ""Menu"",
                    ""type"": ""Button"",
                    ""id"": ""78e7a0bb-e3eb-4e17-b1f7-b2308a7e5b26"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a5a9d155-0d16-48b1-b16d-10635049edca"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1c0bef0d-078b-40b7-99d2-891a31b8041e"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Fox
        m_Fox = asset.FindActionMap("Fox", throwIfNotFound: true);
        m_Fox_Move = m_Fox.FindAction("Move", throwIfNotFound: true);
        m_Fox_Jump = m_Fox.FindAction("Jump", throwIfNotFound: true);
        m_Fox_Shoot = m_Fox.FindAction("Shoot", throwIfNotFound: true);
        // MenuControlls
        m_MenuControlls = asset.FindActionMap("MenuControlls", throwIfNotFound: true);
        m_MenuControlls_Menu = m_MenuControlls.FindAction("Menu", throwIfNotFound: true);
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

    // Fox
    private readonly InputActionMap m_Fox;
    private IFoxActions m_FoxActionsCallbackInterface;
    private readonly InputAction m_Fox_Move;
    private readonly InputAction m_Fox_Jump;
    private readonly InputAction m_Fox_Shoot;
    public struct FoxActions
    {
        private @NewControls m_Wrapper;
        public FoxActions(@NewControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Fox_Move;
        public InputAction @Jump => m_Wrapper.m_Fox_Jump;
        public InputAction @Shoot => m_Wrapper.m_Fox_Shoot;
        public InputActionMap Get() { return m_Wrapper.m_Fox; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(FoxActions set) { return set.Get(); }
        public void SetCallbacks(IFoxActions instance)
        {
            if (m_Wrapper.m_FoxActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_FoxActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_FoxActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_FoxActionsCallbackInterface.OnMove;
                @Jump.started -= m_Wrapper.m_FoxActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_FoxActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_FoxActionsCallbackInterface.OnJump;
                @Shoot.started -= m_Wrapper.m_FoxActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_FoxActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_FoxActionsCallbackInterface.OnShoot;
            }
            m_Wrapper.m_FoxActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
            }
        }
    }
    public FoxActions @Fox => new FoxActions(this);

    // MenuControlls
    private readonly InputActionMap m_MenuControlls;
    private IMenuControllsActions m_MenuControllsActionsCallbackInterface;
    private readonly InputAction m_MenuControlls_Menu;
    public struct MenuControllsActions
    {
        private @NewControls m_Wrapper;
        public MenuControllsActions(@NewControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Menu => m_Wrapper.m_MenuControlls_Menu;
        public InputActionMap Get() { return m_Wrapper.m_MenuControlls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenuControllsActions set) { return set.Get(); }
        public void SetCallbacks(IMenuControllsActions instance)
        {
            if (m_Wrapper.m_MenuControllsActionsCallbackInterface != null)
            {
                @Menu.started -= m_Wrapper.m_MenuControllsActionsCallbackInterface.OnMenu;
                @Menu.performed -= m_Wrapper.m_MenuControllsActionsCallbackInterface.OnMenu;
                @Menu.canceled -= m_Wrapper.m_MenuControllsActionsCallbackInterface.OnMenu;
            }
            m_Wrapper.m_MenuControllsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Menu.started += instance.OnMenu;
                @Menu.performed += instance.OnMenu;
                @Menu.canceled += instance.OnMenu;
            }
        }
    }
    public MenuControllsActions @MenuControlls => new MenuControllsActions(this);
    public interface IFoxActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
    }
    public interface IMenuControllsActions
    {
        void OnMenu(InputAction.CallbackContext context);
    }
}
