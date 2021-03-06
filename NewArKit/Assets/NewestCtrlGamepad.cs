// GENERATED AUTOMATICALLY FROM 'Assets/New Controls.inputactions'

using System;
using UnityEngine;
using UnityEngine.Experimental.Input;


[Serializable]
public class NewControls : InputActionAssetReference
{
    public NewControls()
    {

    }


    public NewControls(InputActionAsset asset)
        : base(asset)
    {
    }
    private bool m_Initialized;
    private void Initialize()
    {
        // Gameplay
        m_Gameplay = asset.GetActionMap("Gameplay");
        m_Gameplay_Forward = m_Gameplay.GetAction("Forward");
        m_Gameplay_Move = m_Gameplay.GetAction("Move");
        m_Gameplay_Rotate = m_Gameplay.GetAction("Rotate");
        m_Initialized = true;
    }
    private void Uninitialize()
    {
        m_Gameplay = null;
        m_Gameplay_Forward = null;
        m_Gameplay_Move = null;
        m_Gameplay_Rotate = null;
        m_Initialized = false;
    }
    public void SetAsset(InputActionAsset newAsset)
    {
        if (newAsset == asset) return;
        if (m_Initialized) Uninitialize();
        asset = newAsset;
    }
    public override void MakePrivateCopyOfActions()
    {
        SetAsset(ScriptableObject.Instantiate(asset));
    }
    // Gameplay
    private InputActionMap m_Gameplay;
    private InputAction m_Gameplay_Forward;
    private InputAction m_Gameplay_Move;
    private InputAction m_Gameplay_Rotate;
    public struct GameplayActions
    {
        private NewControls m_Wrapper;
        public GameplayActions(NewControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Forward { get { return m_Wrapper.m_Gameplay_Forward; } }
        public InputAction @Move { get { return m_Wrapper.m_Gameplay_Move; } }
        public InputAction @Rotate { get { return m_Wrapper.m_Gameplay_Rotate; } }
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled { get { return Get().enabled; } }
        public InputActionMap Clone() { return Get().Clone(); }
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
    }
    public GameplayActions @Gameplay
    {
        get
        {
            if (!m_Initialized) Initialize();
            return new GameplayActions(this);
        }
    }
}
