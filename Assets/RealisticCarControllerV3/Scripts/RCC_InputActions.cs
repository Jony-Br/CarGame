// GENERATED AUTOMATICALLY FROM 'Assets/RealisticCarControllerV3/Resources/RCC_InputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @RCC_InputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @RCC_InputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""RCC_InputActions"",
    ""maps"": [
        {
            ""name"": ""Vehicle"",
            ""id"": ""dab82b1c-787e-4a36-b968-b40e68121a11"",
            ""actions"": [
                {
                    ""name"": ""Throttle"",
                    ""type"": ""Value"",
                    ""id"": ""90dd0b16-b17c-4e2f-816d-3f6f472fbe4d"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Brake"",
                    ""type"": ""Value"",
                    ""id"": ""fd45c78a-8d28-433b-938d-216a05e39978"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Steering"",
                    ""type"": ""Value"",
                    ""id"": ""07554ee5-17d2-4f02-a18b-c167de4685b5"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Handbrake"",
                    ""type"": ""Button"",
                    ""id"": ""862a1da3-327a-425f-bc3a-c144667b0f07"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Start/Stop Engine"",
                    ""type"": ""Button"",
                    ""id"": ""665ce79b-380f-460c-954c-a66e8d7f6868"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Low Beam Lights"",
                    ""type"": ""Button"",
                    ""id"": ""372f474d-e084-434c-8671-5dde678119fc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""High Beam Lights"",
                    ""type"": ""Button"",
                    ""id"": ""ce045397-f3db-4d56-a9ab-f15b8d6284f3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Indicator Right"",
                    ""type"": ""Button"",
                    ""id"": ""a5494e84-44f4-4747-a2bc-8c888e6c6981"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Indicator Left"",
                    ""type"": ""Button"",
                    ""id"": ""8c0cd9f5-2c12-4dda-867e-68ac4f8d12a7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Indicator Hazard"",
                    ""type"": ""Button"",
                    ""id"": ""2cf3bd64-7349-45c4-bd17-ac5c026c14f3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Gear Shift Up"",
                    ""type"": ""Button"",
                    ""id"": ""bfed3200-a183-457f-89e2-4728ba190654"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Gear Shift Down"",
                    ""type"": ""Button"",
                    ""id"": ""60814594-0217-41d9-be0b-f732e6e15ec1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""NOS"",
                    ""type"": ""Value"",
                    ""id"": ""724bd134-194c-493a-8539-b6045edcdcd5"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Trailer Detach"",
                    ""type"": ""Button"",
                    ""id"": ""436e8ef9-e6d5-4264-92e2-aa09d5704ea7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""N Gear"",
                    ""type"": ""Button"",
                    ""id"": ""c730406c-3f6f-4378-9425-575126e2ffe9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""1stGear"",
                    ""type"": ""Button"",
                    ""id"": ""faa60fae-83d3-468d-9047-242f9aed211f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""2ndGear"",
                    ""type"": ""Button"",
                    ""id"": ""065a4580-591d-4266-acf7-9d98d3363a8b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""3rdGear"",
                    ""type"": ""Button"",
                    ""id"": ""2406bc0d-f79a-40c9-a124-3bb7e223376d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""4thGear"",
                    ""type"": ""Button"",
                    ""id"": ""47dc584e-88a1-4fb1-b3a1-a618860c4981"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""5thGear"",
                    ""type"": ""Button"",
                    ""id"": ""292f9c56-7502-4eb7-8ea9-807f40b45681"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""6thGear"",
                    ""type"": ""Button"",
                    ""id"": ""72cd6b51-4b79-4956-979a-fead73af3865"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""RGear"",
                    ""type"": ""Button"",
                    ""id"": ""9586b554-9d81-4d23-9217-bb33ac196bce"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Clutch"",
                    ""type"": ""Value"",
                    ""id"": ""74b6b726-c60c-461c-b6c3-28e27b55d665"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""arrows"",
                    ""id"": ""f11f01e4-cf2c-47ed-ab18-9f957fe8913a"",
                    ""path"": ""1DAxis(minValue=0)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Throttle"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""e0cd1536-dbc9-4a1c-85e1-a1a092c6d2dc"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard Mouse"",
                    ""action"": ""Throttle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""a1ba4f3e-7db4-494b-94a9-609e76725d20"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard Mouse"",
                    ""action"": ""Throttle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""wasd"",
                    ""id"": ""3fdb6416-2def-4c85-8aaa-8bc786eee672"",
                    ""path"": ""1DAxis(minValue=0)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard Mouse"",
                    ""action"": ""Throttle"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""20f6ae90-cf5c-4fdf-a3b2-156ecb775171"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard Mouse"",
                    ""action"": ""Throttle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""1f637e88-9cd0-42a6-93cf-ce55b89ff212"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard Mouse"",
                    ""action"": ""Throttle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""gamepads"",
                    ""id"": ""34d118d2-ab65-4ccd-bb89-78a9a042d4de"",
                    ""path"": ""1DAxis(minValue=0)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Throttle"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""af0c3935-4ef0-4f3b-8a8d-13853137f6db"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Throttle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""e323a5f2-36c3-459c-813e-d6bbb9e3bac7"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Throttle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""G29/920"",
                    ""id"": ""917fc2f9-b027-48ea-a670-9f4f3cb137af"",
                    ""path"": ""1DAxis(minValue=0,maxValue=55)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Throttle"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""be73745b-397e-4185-9283-ea2f38bf4f84"",
                    ""path"": ""<HID::Logitech G920 Driving Force Racing Wheel for Xbox One>/stick/down"",
                    ""interactions"": """",
                    ""processors"": ""Normalize(min=1,zero=1)"",
                    ""groups"": ""G920"",
                    ""action"": ""Throttle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""9f6b1783-7b9a-44f2-ade9-211f48c51442"",
                    ""path"": ""<HID::Logitech G920 Driving Force Racing Wheel for Xbox One>/stick/up"",
                    ""interactions"": """",
                    ""processors"": ""Normalize(max=1)"",
                    ""groups"": ""G920"",
                    ""action"": ""Throttle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""b7f469da-1f0b-4649-a1d2-d5c6795d48b5"",
                    ""path"": ""<OculusTouchController>{RightHand}/trigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Oculus Quest"",
                    ""action"": ""Throttle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""keyboard"",
                    ""id"": ""719ca6b9-d323-4341-8e55-caa156a602e8"",
                    ""path"": ""1DAxis(minValue=0)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Handbrake"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""4d2b585c-6f0c-4907-8009-b23e2a8bfce1"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard Mouse"",
                    ""action"": ""Handbrake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""ebd5b62c-f128-414b-8280-7decced19010"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard Mouse"",
                    ""action"": ""Handbrake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""gamepads"",
                    ""id"": ""3d7e56ad-b8c0-434a-8415-72fa857776ac"",
                    ""path"": ""1DAxis(minValue=0)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Handbrake"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""bab83804-84b2-4e39-9fc1-9bb9787d2a60"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Handbrake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""3db07aa2-78b1-4e62-869e-5540b1d2ea11"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Handbrake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""5aaefde0-b9f2-4263-ada8-08c4754560fc"",
                    ""path"": ""<HID::Logitech G920 Driving Force Racing Wheel for Xbox One>/button2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""G920"",
                    ""action"": ""Handbrake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3cbd8e1e-8b86-4741-8cb2-876fb108b2a3"",
                    ""path"": ""<OculusTouchController>{RightHand}/primaryButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Oculus Quest"",
                    ""action"": ""Handbrake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""wasd"",
                    ""id"": ""a135f3bc-f45c-479f-ad28-b4581890cd28"",
                    ""path"": ""1DAxis(minValue=0)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Brake"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""b1647269-c5f0-41dc-b651-b4e2f87d8fdb"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard Mouse"",
                    ""action"": ""Brake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""f7d779b9-21fe-4e3d-9744-a94e504b04fc"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard Mouse"",
                    ""action"": ""Brake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""arrows"",
                    ""id"": ""c8307ec0-22ef-43bb-8351-b6aef882fa5f"",
                    ""path"": ""1DAxis(minValue=0)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Brake"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""b17286eb-c31a-424d-97bc-ffc8ee35b47a"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard Mouse"",
                    ""action"": ""Brake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""9ee6ed4f-8f71-47d6-af83-3d0b1e20860c"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard Mouse"",
                    ""action"": ""Brake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""gamepads"",
                    ""id"": ""885ad1e3-b856-4be1-a7cb-32bb8bfb2b88"",
                    ""path"": ""1DAxis(minValue=0)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Brake"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""6a9790aa-c6f0-48b7-b93c-c2d033442261"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Brake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""69462041-e882-40fd-bed8-deff21837f89"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Brake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""3d3279f2-f677-4514-898f-2f379e478f35"",
                    ""path"": ""<HID::Logitech G920 Driving Force Racing Wheel for Xbox One>/z"",
                    ""interactions"": """",
                    ""processors"": ""Normalize(min=1,zero=1)"",
                    ""groups"": ""G920"",
                    ""action"": ""Brake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""aaf2efcb-4c14-4b5f-8669-de517f4ad583"",
                    ""path"": ""<OculusTouchController>{LeftHand}/trigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Oculus Quest"",
                    ""action"": ""Brake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""wasd"",
                    ""id"": ""b84118c6-f280-4827-aec2-23b358ff2839"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steering"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Negative"",
                    ""id"": ""e39a68f9-d10f-4dfb-9c23-4911299ada81"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard Mouse"",
                    ""action"": ""Steering"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Positive"",
                    ""id"": ""95b1dcb4-e179-495b-9829-2441e822fa9c"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard Mouse"",
                    ""action"": ""Steering"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""arrows"",
                    ""id"": ""c9265635-9301-4f28-857f-f8c35c3aeaa3"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steering"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""0efc1b5a-a2af-4412-9c79-657c31d182ad"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard Mouse"",
                    ""action"": ""Steering"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Positive"",
                    ""id"": ""f8373c7a-eb6c-4d91-afe6-1f8f9db75611"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard Mouse"",
                    ""action"": ""Steering"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""gamepads"",
                    ""id"": ""c33597ed-2d60-4495-acd6-1898c0c03435"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steering"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Negative"",
                    ""id"": ""2605240c-dc7a-4c85-a40f-3976962910e4"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Steering"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Positive"",
                    ""id"": ""dfa77fc0-a4e7-4963-ba95-c84d55d9166b"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Steering"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""a72b71b3-a5a9-476e-ba2f-303039d7d7f9"",
                    ""path"": ""<HID::Logitech G920 Driving Force Racing Wheel for Xbox One>/stick/x"",
                    ""interactions"": """",
                    ""processors"": ""Scale(factor=4)"",
                    ""groups"": ""G920"",
                    ""action"": ""Steering"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4f884a2c-fc71-409f-85a6-58868973caca"",
                    ""path"": ""<OculusTouchController>{LeftHand}/thumbstick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Oculus Quest"",
                    ""action"": ""Steering"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2252f11a-7704-4821-84b9-3abbcc3b2527"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard Mouse"",
                    ""action"": ""Start/Stop Engine"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e47a5c95-3e0c-4635-a53e-fd10b8d4047f"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Start/Stop Engine"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""29b37afd-bc61-4290-9fdc-dd474f1cb45d"",
                    ""path"": ""<HID::Logitech G920 Driving Force Racing Wheel for Xbox One>/button7"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""G920"",
                    ""action"": ""Start/Stop Engine"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5684f55e-081f-4c1b-907a-f29c3e57b7ae"",
                    ""path"": ""<Keyboard>/l"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard Mouse"",
                    ""action"": ""Low Beam Lights"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2dd929da-4b2b-4b95-afc6-dc90a1a9a8d9"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Low Beam Lights"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""68049a6d-7f4b-4ac6-ae57-134a916a4a11"",
                    ""path"": ""<HID::Logitech G920 Driving Force Racing Wheel for Xbox One>/button10"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""G920"",
                    ""action"": ""Low Beam Lights"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cb6ea6f1-37fa-4b63-8727-dbb03c52bc9e"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard Mouse"",
                    ""action"": ""High Beam Lights"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6f713ae7-4827-41a6-91e8-770b31c3deb9"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""High Beam Lights"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""da808eef-18ce-4dbc-9cf1-043577d98c91"",
                    ""path"": ""<HID::Logitech G920 Driving Force Racing Wheel for Xbox One>/button9"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""G920"",
                    ""action"": ""High Beam Lights"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0367e370-02e2-4afe-aa28-6329c07f3a80"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard Mouse"",
                    ""action"": ""Indicator Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e7494dde-bbd8-4530-81b9-b0202b184c0c"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Indicator Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e2c9283d-228b-4eed-bb92-7754056bc3cc"",
                    ""path"": ""<HID::Logitech G920 Driving Force Racing Wheel for Xbox One>/hat/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""G920"",
                    ""action"": ""Indicator Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2694c28d-039d-4942-b81b-e63b965420f4"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard Mouse"",
                    ""action"": ""Indicator Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cf7abf08-b917-487c-ab52-fd1026fc7331"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Indicator Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4dab2970-04c0-4e49-94f3-7f1d66dbda9b"",
                    ""path"": ""<HID::Logitech G920 Driving Force Racing Wheel for Xbox One>/hat/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""G920"",
                    ""action"": ""Indicator Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""45686879-95ca-4111-a1a0-8a51bd6face3"",
                    ""path"": ""<Keyboard>/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard Mouse"",
                    ""action"": ""Indicator Hazard"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9adff5e7-b73f-40d7-b21f-0b3befd55d7a"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Indicator Hazard"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5ade0cb3-2beb-4419-816f-f881768375b9"",
                    ""path"": ""<HID::Logitech G920 Driving Force Racing Wheel for Xbox One>/hat/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""G920"",
                    ""action"": ""Indicator Hazard"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4ce9aa29-2ded-426a-9ad1-66520c441d57"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard Mouse"",
                    ""action"": ""Gear Shift Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""88696b5a-7de1-487d-9432-72ff1f524543"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Gear Shift Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a515f912-72c4-445d-aa6d-ba6be1069897"",
                    ""path"": ""<HID::Logitech G920 Driving Force Racing Wheel for Xbox One>/button5"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""G920"",
                    ""action"": ""Gear Shift Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5d68445d-55a1-40dc-a621-761b6465aaf6"",
                    ""path"": ""<OculusTouchController>{RightHand}/gripPressed"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Oculus Quest"",
                    ""action"": ""Gear Shift Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a3802bd2-36a4-413e-8167-4a340771200f"",
                    ""path"": ""<Keyboard>/ctrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard Mouse"",
                    ""action"": ""Gear Shift Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a79f57a5-8548-4707-a04f-c90d4145e24e"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Gear Shift Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5763683e-0147-4154-9e8a-5fc71fd7161c"",
                    ""path"": ""<HID::Logitech G920 Driving Force Racing Wheel for Xbox One>/button6"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""G920"",
                    ""action"": ""Gear Shift Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""62961681-402e-4996-8576-ff512ede7953"",
                    ""path"": ""<OculusTouchController>{LeftHand}/gripPressed"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Oculus Quest"",
                    ""action"": ""Gear Shift Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""43b23f3e-b99b-410c-ab1a-494f337ce92d"",
                    ""path"": ""<Keyboard>/t"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard Mouse"",
                    ""action"": ""Trailer Detach"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""512cda51-6521-4aa0-aeb0-7e4e804ca2ac"",
                    ""path"": ""<Gamepad>/rightStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Trailer Detach"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""keyboard"",
                    ""id"": ""102ac6d8-122a-4b65-be31-7707770e70ec"",
                    ""path"": ""1DAxis(minValue=0)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""NOS"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""2e2a73c9-1895-4a1c-b03f-68828175ccab"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard Mouse"",
                    ""action"": ""NOS"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""e79973b3-7960-4f29-abd3-aa45793d6dc2"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard Mouse"",
                    ""action"": ""NOS"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""gamepads"",
                    ""id"": ""e65d7948-806f-4365-abed-6afce7426719"",
                    ""path"": ""1DAxis(minValue=0)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""NOS"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""09faeb51-116d-4cce-a128-5c75e6e0c09d"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""NOS"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""09cafb73-a3fe-4b17-8eae-2af054391159"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""NOS"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""8395bdc6-38e3-4d8c-8910-04c1598e3626"",
                    ""path"": ""1DAxis(minValue=0)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""NOS"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""def3df07-c7c5-49e2-8ead-a9d15d455d3f"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""G920"",
                    ""action"": ""NOS"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""895259a8-90c8-49b2-a3bd-ec8b286ddf79"",
                    ""path"": ""<HID::Logitech G920 Driving Force Racing Wheel for Xbox One>/trigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""G920"",
                    ""action"": ""NOS"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""c7221e56-c7e1-42d9-8763-520459e0e6ca"",
                    ""path"": ""<OculusTouchController>{RightHand}/secondaryButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Oculus Quest"",
                    ""action"": ""NOS"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5e4d36f2-15d1-4f09-984f-f79157b2dbf6"",
                    ""path"": ""<Keyboard>/n"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard Mouse"",
                    ""action"": ""N Gear"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f28cedbd-5d4e-4109-a83f-6034beeb1786"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""G920"",
                    ""action"": ""N Gear"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c67d3a53-1242-4c81-ade5-2b57f7d4bd18"",
                    ""path"": ""<HID::Logitech G920 Driving Force Racing Wheel for Xbox One>/button13"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""G920"",
                    ""action"": ""1stGear"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d1f89ffa-9f6c-4a79-9531-92fa5caf8ac3"",
                    ""path"": ""<HID::Logitech G920 Driving Force Racing Wheel for Xbox One>/button14"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""G920"",
                    ""action"": ""2ndGear"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d1efd96e-fba6-43d8-9653-e454c6d1a279"",
                    ""path"": ""<HID::Logitech G920 Driving Force Racing Wheel for Xbox One>/button15"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""G920"",
                    ""action"": ""3rdGear"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""94746981-391a-411d-ba01-7d9cee57ef19"",
                    ""path"": ""<HID::Logitech G920 Driving Force Racing Wheel for Xbox One>/button16"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""G920"",
                    ""action"": ""4thGear"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""18c7fc4b-5172-4255-90af-1779c92d64fd"",
                    ""path"": ""<HID::Logitech G920 Driving Force Racing Wheel for Xbox One>/button17"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""G920"",
                    ""action"": ""5thGear"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5bb54458-b514-4be4-a828-d0e3c305c891"",
                    ""path"": ""<HID::Logitech G920 Driving Force Racing Wheel for Xbox One>/button18"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""G920"",
                    ""action"": ""6thGear"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""56a18610-79a9-4ed7-8576-92a99b424107"",
                    ""path"": ""<HID::Logitech G920 Driving Force Racing Wheel for Xbox One>/button12"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""G920"",
                    ""action"": ""RGear"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e086e6ca-c703-4901-878c-46e7567d1730"",
                    ""path"": ""<HID::Logitech G920 Driving Force Racing Wheel for Xbox One>/rz"",
                    ""interactions"": """",
                    ""processors"": ""Normalize(min=1,max=-1,zero=1)"",
                    ""groups"": ""G920"",
                    ""action"": ""Clutch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Camera"",
            ""id"": ""9833443b-7a36-43d9-b723-68beac1a943a"",
            ""actions"": [
                {
                    ""name"": ""Orbit"",
                    ""type"": ""Value"",
                    ""id"": ""36c3b66b-e716-43bf-8b0f-d41f0459994b"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Change Camera"",
                    ""type"": ""Button"",
                    ""id"": ""bd133a91-3836-4263-8f7d-7ebb0cd992a6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Look Back"",
                    ""type"": ""Button"",
                    ""id"": ""54cd471e-6c0b-42c9-b81c-87833fc3331a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Zoom"",
                    ""type"": ""Value"",
                    ""id"": ""f533f3d2-f07d-4dc7-b0cb-c4446055fdbf"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": ""ScaleVector2(x=0.001,y=0.001),InvertVector2"",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""27ceac0e-cf18-40fc-9dd9-954bef4acec7"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard Mouse"",
                    ""action"": ""Change Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""928221b7-589f-47d1-9ebe-5561a8043444"",
                    ""path"": ""<Gamepad>/leftStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Change Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""72d2d1f3-315b-43a7-8f6c-3925bc71f2c1"",
                    ""path"": ""<HID::Logitech G920 Driving Force Racing Wheel for Xbox One>/button8"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""G920"",
                    ""action"": ""Change Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""75dc1a32-b749-400b-b89e-900e218595d9"",
                    ""path"": ""<OculusTouchController>{LeftHand}/primaryButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Oculus Quest"",
                    ""action"": ""Change Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f50bba44-f018-4f50-bae4-0fb6b314f581"",
                    ""path"": ""<Keyboard>/b"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard Mouse"",
                    ""action"": ""Look Back"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""410cb6fc-fa7e-40ab-9c8d-afebd630b972"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Look Back"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cc718a8a-3bab-4b1f-b0e7-47f9a771f183"",
                    ""path"": ""<HID::Logitech G920 Driving Force Racing Wheel for Xbox One>/hat/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""G920"",
                    ""action"": ""Look Back"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0e6e3cd4-1cef-4169-845f-c4ce50524512"",
                    ""path"": ""<OculusTouchController>{RightHand}/thumbstickClicked"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Oculus Quest"",
                    ""action"": ""Look Back"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""10705ed5-34a8-40b6-afab-e3723c412fd4"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": ""ScaleVector2(x=0.25,y=0.25)"",
                    ""groups"": ""Keyboard Mouse"",
                    ""action"": ""Orbit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""gamepads"",
                    ""id"": ""adf39205-15ba-43f3-9a61-30694bdff208"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": ""StickDeadzone"",
                    ""groups"": """",
                    ""action"": ""Orbit"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""e88670fd-67e0-46a4-93ff-edfecf9d387a"",
                    ""path"": ""<Gamepad>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Orbit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""bed807c8-3819-4858-bbef-fc3a524d09fe"",
                    ""path"": ""<Gamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Orbit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""6ca2a81c-e237-4897-90c2-2430527a1da7"",
                    ""path"": ""<Gamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Orbit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""858ac0f9-c985-4d92-a793-44c779f559ab"",
                    ""path"": ""<Gamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Orbit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""a8ebc1cc-3aa1-4d4b-88d3-f03fd85805ef"",
                    ""path"": ""<OculusTouchController>{RightHand}/thumbstick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Oculus Quest"",
                    ""action"": ""Orbit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8e98b069-ee32-4fdd-a016-be730c22a2ee"",
                    ""path"": ""<Mouse>/scroll"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard Mouse"",
                    ""action"": ""Zoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Optional"",
            ""id"": ""16242ab5-e647-477b-9a17-348443e08aaf"",
            ""actions"": [
                {
                    ""name"": ""Slow Motion"",
                    ""type"": ""Button"",
                    ""id"": ""1b85fbea-08df-4020-9c1d-1dccac44b6e6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Record"",
                    ""type"": ""Button"",
                    ""id"": ""97e1cd85-e655-4c88-99b5-41db78efd038"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Replay"",
                    ""type"": ""Button"",
                    ""id"": ""32a18283-3e10-4e5a-9367-d8d9eade3e78"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""7e7f1b75-4234-4221-9430-5009b0189f41"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard Mouse"",
                    ""action"": ""Record"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""470d0d53-dcb2-4cb0-a5a0-add83c1f0eec"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard Mouse"",
                    ""action"": ""Replay"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7babc1f5-e42a-4a07-b608-403cd4d3e66e"",
                    ""path"": ""<Keyboard>/g"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard Mouse"",
                    ""action"": ""Slow Motion"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard Mouse"",
            ""bindingGroup"": ""Keyboard Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": []
        },
        {
            ""name"": ""G920"",
            ""bindingGroup"": ""G920"",
            ""devices"": []
        },
        {
            ""name"": ""Oculus Quest"",
            ""bindingGroup"": ""Oculus Quest"",
            ""devices"": []
        }
    ]
}");
        // Vehicle
        m_Vehicle = asset.FindActionMap("Vehicle", throwIfNotFound: true);
        m_Vehicle_Throttle = m_Vehicle.FindAction("Throttle", throwIfNotFound: true);
        m_Vehicle_Brake = m_Vehicle.FindAction("Brake", throwIfNotFound: true);
        m_Vehicle_Steering = m_Vehicle.FindAction("Steering", throwIfNotFound: true);
        m_Vehicle_Handbrake = m_Vehicle.FindAction("Handbrake", throwIfNotFound: true);
        m_Vehicle_StartStopEngine = m_Vehicle.FindAction("Start/Stop Engine", throwIfNotFound: true);
        m_Vehicle_LowBeamLights = m_Vehicle.FindAction("Low Beam Lights", throwIfNotFound: true);
        m_Vehicle_HighBeamLights = m_Vehicle.FindAction("High Beam Lights", throwIfNotFound: true);
        m_Vehicle_IndicatorRight = m_Vehicle.FindAction("Indicator Right", throwIfNotFound: true);
        m_Vehicle_IndicatorLeft = m_Vehicle.FindAction("Indicator Left", throwIfNotFound: true);
        m_Vehicle_IndicatorHazard = m_Vehicle.FindAction("Indicator Hazard", throwIfNotFound: true);
        m_Vehicle_GearShiftUp = m_Vehicle.FindAction("Gear Shift Up", throwIfNotFound: true);
        m_Vehicle_GearShiftDown = m_Vehicle.FindAction("Gear Shift Down", throwIfNotFound: true);
        m_Vehicle_NOS = m_Vehicle.FindAction("NOS", throwIfNotFound: true);
        m_Vehicle_TrailerDetach = m_Vehicle.FindAction("Trailer Detach", throwIfNotFound: true);
        m_Vehicle_NGear = m_Vehicle.FindAction("N Gear", throwIfNotFound: true);
        m_Vehicle__1stGear = m_Vehicle.FindAction("1stGear", throwIfNotFound: true);
        m_Vehicle__2ndGear = m_Vehicle.FindAction("2ndGear", throwIfNotFound: true);
        m_Vehicle__3rdGear = m_Vehicle.FindAction("3rdGear", throwIfNotFound: true);
        m_Vehicle__4thGear = m_Vehicle.FindAction("4thGear", throwIfNotFound: true);
        m_Vehicle__5thGear = m_Vehicle.FindAction("5thGear", throwIfNotFound: true);
        m_Vehicle__6thGear = m_Vehicle.FindAction("6thGear", throwIfNotFound: true);
        m_Vehicle_RGear = m_Vehicle.FindAction("RGear", throwIfNotFound: true);
        m_Vehicle_Clutch = m_Vehicle.FindAction("Clutch", throwIfNotFound: true);
        // Camera
        m_Camera = asset.FindActionMap("Camera", throwIfNotFound: true);
        m_Camera_Orbit = m_Camera.FindAction("Orbit", throwIfNotFound: true);
        m_Camera_ChangeCamera = m_Camera.FindAction("Change Camera", throwIfNotFound: true);
        m_Camera_LookBack = m_Camera.FindAction("Look Back", throwIfNotFound: true);
        m_Camera_Zoom = m_Camera.FindAction("Zoom", throwIfNotFound: true);
        // Optional
        m_Optional = asset.FindActionMap("Optional", throwIfNotFound: true);
        m_Optional_SlowMotion = m_Optional.FindAction("Slow Motion", throwIfNotFound: true);
        m_Optional_Record = m_Optional.FindAction("Record", throwIfNotFound: true);
        m_Optional_Replay = m_Optional.FindAction("Replay", throwIfNotFound: true);
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

    // Vehicle
    private readonly InputActionMap m_Vehicle;
    private IVehicleActions m_VehicleActionsCallbackInterface;
    private readonly InputAction m_Vehicle_Throttle;
    private readonly InputAction m_Vehicle_Brake;
    private readonly InputAction m_Vehicle_Steering;
    private readonly InputAction m_Vehicle_Handbrake;
    private readonly InputAction m_Vehicle_StartStopEngine;
    private readonly InputAction m_Vehicle_LowBeamLights;
    private readonly InputAction m_Vehicle_HighBeamLights;
    private readonly InputAction m_Vehicle_IndicatorRight;
    private readonly InputAction m_Vehicle_IndicatorLeft;
    private readonly InputAction m_Vehicle_IndicatorHazard;
    private readonly InputAction m_Vehicle_GearShiftUp;
    private readonly InputAction m_Vehicle_GearShiftDown;
    private readonly InputAction m_Vehicle_NOS;
    private readonly InputAction m_Vehicle_TrailerDetach;
    private readonly InputAction m_Vehicle_NGear;
    private readonly InputAction m_Vehicle__1stGear;
    private readonly InputAction m_Vehicle__2ndGear;
    private readonly InputAction m_Vehicle__3rdGear;
    private readonly InputAction m_Vehicle__4thGear;
    private readonly InputAction m_Vehicle__5thGear;
    private readonly InputAction m_Vehicle__6thGear;
    private readonly InputAction m_Vehicle_RGear;
    private readonly InputAction m_Vehicle_Clutch;
    public struct VehicleActions
    {
        private @RCC_InputActions m_Wrapper;
        public VehicleActions(@RCC_InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Throttle => m_Wrapper.m_Vehicle_Throttle;
        public InputAction @Brake => m_Wrapper.m_Vehicle_Brake;
        public InputAction @Steering => m_Wrapper.m_Vehicle_Steering;
        public InputAction @Handbrake => m_Wrapper.m_Vehicle_Handbrake;
        public InputAction @StartStopEngine => m_Wrapper.m_Vehicle_StartStopEngine;
        public InputAction @LowBeamLights => m_Wrapper.m_Vehicle_LowBeamLights;
        public InputAction @HighBeamLights => m_Wrapper.m_Vehicle_HighBeamLights;
        public InputAction @IndicatorRight => m_Wrapper.m_Vehicle_IndicatorRight;
        public InputAction @IndicatorLeft => m_Wrapper.m_Vehicle_IndicatorLeft;
        public InputAction @IndicatorHazard => m_Wrapper.m_Vehicle_IndicatorHazard;
        public InputAction @GearShiftUp => m_Wrapper.m_Vehicle_GearShiftUp;
        public InputAction @GearShiftDown => m_Wrapper.m_Vehicle_GearShiftDown;
        public InputAction @NOS => m_Wrapper.m_Vehicle_NOS;
        public InputAction @TrailerDetach => m_Wrapper.m_Vehicle_TrailerDetach;
        public InputAction @NGear => m_Wrapper.m_Vehicle_NGear;
        public InputAction @_1stGear => m_Wrapper.m_Vehicle__1stGear;
        public InputAction @_2ndGear => m_Wrapper.m_Vehicle__2ndGear;
        public InputAction @_3rdGear => m_Wrapper.m_Vehicle__3rdGear;
        public InputAction @_4thGear => m_Wrapper.m_Vehicle__4thGear;
        public InputAction @_5thGear => m_Wrapper.m_Vehicle__5thGear;
        public InputAction @_6thGear => m_Wrapper.m_Vehicle__6thGear;
        public InputAction @RGear => m_Wrapper.m_Vehicle_RGear;
        public InputAction @Clutch => m_Wrapper.m_Vehicle_Clutch;
        public InputActionMap Get() { return m_Wrapper.m_Vehicle; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(VehicleActions set) { return set.Get(); }
        public void SetCallbacks(IVehicleActions instance)
        {
            if (m_Wrapper.m_VehicleActionsCallbackInterface != null)
            {
                @Throttle.started -= m_Wrapper.m_VehicleActionsCallbackInterface.OnThrottle;
                @Throttle.performed -= m_Wrapper.m_VehicleActionsCallbackInterface.OnThrottle;
                @Throttle.canceled -= m_Wrapper.m_VehicleActionsCallbackInterface.OnThrottle;
                @Brake.started -= m_Wrapper.m_VehicleActionsCallbackInterface.OnBrake;
                @Brake.performed -= m_Wrapper.m_VehicleActionsCallbackInterface.OnBrake;
                @Brake.canceled -= m_Wrapper.m_VehicleActionsCallbackInterface.OnBrake;
                @Steering.started -= m_Wrapper.m_VehicleActionsCallbackInterface.OnSteering;
                @Steering.performed -= m_Wrapper.m_VehicleActionsCallbackInterface.OnSteering;
                @Steering.canceled -= m_Wrapper.m_VehicleActionsCallbackInterface.OnSteering;
                @Handbrake.started -= m_Wrapper.m_VehicleActionsCallbackInterface.OnHandbrake;
                @Handbrake.performed -= m_Wrapper.m_VehicleActionsCallbackInterface.OnHandbrake;
                @Handbrake.canceled -= m_Wrapper.m_VehicleActionsCallbackInterface.OnHandbrake;
                @StartStopEngine.started -= m_Wrapper.m_VehicleActionsCallbackInterface.OnStartStopEngine;
                @StartStopEngine.performed -= m_Wrapper.m_VehicleActionsCallbackInterface.OnStartStopEngine;
                @StartStopEngine.canceled -= m_Wrapper.m_VehicleActionsCallbackInterface.OnStartStopEngine;
                @LowBeamLights.started -= m_Wrapper.m_VehicleActionsCallbackInterface.OnLowBeamLights;
                @LowBeamLights.performed -= m_Wrapper.m_VehicleActionsCallbackInterface.OnLowBeamLights;
                @LowBeamLights.canceled -= m_Wrapper.m_VehicleActionsCallbackInterface.OnLowBeamLights;
                @HighBeamLights.started -= m_Wrapper.m_VehicleActionsCallbackInterface.OnHighBeamLights;
                @HighBeamLights.performed -= m_Wrapper.m_VehicleActionsCallbackInterface.OnHighBeamLights;
                @HighBeamLights.canceled -= m_Wrapper.m_VehicleActionsCallbackInterface.OnHighBeamLights;
                @IndicatorRight.started -= m_Wrapper.m_VehicleActionsCallbackInterface.OnIndicatorRight;
                @IndicatorRight.performed -= m_Wrapper.m_VehicleActionsCallbackInterface.OnIndicatorRight;
                @IndicatorRight.canceled -= m_Wrapper.m_VehicleActionsCallbackInterface.OnIndicatorRight;
                @IndicatorLeft.started -= m_Wrapper.m_VehicleActionsCallbackInterface.OnIndicatorLeft;
                @IndicatorLeft.performed -= m_Wrapper.m_VehicleActionsCallbackInterface.OnIndicatorLeft;
                @IndicatorLeft.canceled -= m_Wrapper.m_VehicleActionsCallbackInterface.OnIndicatorLeft;
                @IndicatorHazard.started -= m_Wrapper.m_VehicleActionsCallbackInterface.OnIndicatorHazard;
                @IndicatorHazard.performed -= m_Wrapper.m_VehicleActionsCallbackInterface.OnIndicatorHazard;
                @IndicatorHazard.canceled -= m_Wrapper.m_VehicleActionsCallbackInterface.OnIndicatorHazard;
                @GearShiftUp.started -= m_Wrapper.m_VehicleActionsCallbackInterface.OnGearShiftUp;
                @GearShiftUp.performed -= m_Wrapper.m_VehicleActionsCallbackInterface.OnGearShiftUp;
                @GearShiftUp.canceled -= m_Wrapper.m_VehicleActionsCallbackInterface.OnGearShiftUp;
                @GearShiftDown.started -= m_Wrapper.m_VehicleActionsCallbackInterface.OnGearShiftDown;
                @GearShiftDown.performed -= m_Wrapper.m_VehicleActionsCallbackInterface.OnGearShiftDown;
                @GearShiftDown.canceled -= m_Wrapper.m_VehicleActionsCallbackInterface.OnGearShiftDown;
                @NOS.started -= m_Wrapper.m_VehicleActionsCallbackInterface.OnNOS;
                @NOS.performed -= m_Wrapper.m_VehicleActionsCallbackInterface.OnNOS;
                @NOS.canceled -= m_Wrapper.m_VehicleActionsCallbackInterface.OnNOS;
                @TrailerDetach.started -= m_Wrapper.m_VehicleActionsCallbackInterface.OnTrailerDetach;
                @TrailerDetach.performed -= m_Wrapper.m_VehicleActionsCallbackInterface.OnTrailerDetach;
                @TrailerDetach.canceled -= m_Wrapper.m_VehicleActionsCallbackInterface.OnTrailerDetach;
                @NGear.started -= m_Wrapper.m_VehicleActionsCallbackInterface.OnNGear;
                @NGear.performed -= m_Wrapper.m_VehicleActionsCallbackInterface.OnNGear;
                @NGear.canceled -= m_Wrapper.m_VehicleActionsCallbackInterface.OnNGear;
                @_1stGear.started -= m_Wrapper.m_VehicleActionsCallbackInterface.On_1stGear;
                @_1stGear.performed -= m_Wrapper.m_VehicleActionsCallbackInterface.On_1stGear;
                @_1stGear.canceled -= m_Wrapper.m_VehicleActionsCallbackInterface.On_1stGear;
                @_2ndGear.started -= m_Wrapper.m_VehicleActionsCallbackInterface.On_2ndGear;
                @_2ndGear.performed -= m_Wrapper.m_VehicleActionsCallbackInterface.On_2ndGear;
                @_2ndGear.canceled -= m_Wrapper.m_VehicleActionsCallbackInterface.On_2ndGear;
                @_3rdGear.started -= m_Wrapper.m_VehicleActionsCallbackInterface.On_3rdGear;
                @_3rdGear.performed -= m_Wrapper.m_VehicleActionsCallbackInterface.On_3rdGear;
                @_3rdGear.canceled -= m_Wrapper.m_VehicleActionsCallbackInterface.On_3rdGear;
                @_4thGear.started -= m_Wrapper.m_VehicleActionsCallbackInterface.On_4thGear;
                @_4thGear.performed -= m_Wrapper.m_VehicleActionsCallbackInterface.On_4thGear;
                @_4thGear.canceled -= m_Wrapper.m_VehicleActionsCallbackInterface.On_4thGear;
                @_5thGear.started -= m_Wrapper.m_VehicleActionsCallbackInterface.On_5thGear;
                @_5thGear.performed -= m_Wrapper.m_VehicleActionsCallbackInterface.On_5thGear;
                @_5thGear.canceled -= m_Wrapper.m_VehicleActionsCallbackInterface.On_5thGear;
                @_6thGear.started -= m_Wrapper.m_VehicleActionsCallbackInterface.On_6thGear;
                @_6thGear.performed -= m_Wrapper.m_VehicleActionsCallbackInterface.On_6thGear;
                @_6thGear.canceled -= m_Wrapper.m_VehicleActionsCallbackInterface.On_6thGear;
                @RGear.started -= m_Wrapper.m_VehicleActionsCallbackInterface.OnRGear;
                @RGear.performed -= m_Wrapper.m_VehicleActionsCallbackInterface.OnRGear;
                @RGear.canceled -= m_Wrapper.m_VehicleActionsCallbackInterface.OnRGear;
                @Clutch.started -= m_Wrapper.m_VehicleActionsCallbackInterface.OnClutch;
                @Clutch.performed -= m_Wrapper.m_VehicleActionsCallbackInterface.OnClutch;
                @Clutch.canceled -= m_Wrapper.m_VehicleActionsCallbackInterface.OnClutch;
            }
            m_Wrapper.m_VehicleActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Throttle.started += instance.OnThrottle;
                @Throttle.performed += instance.OnThrottle;
                @Throttle.canceled += instance.OnThrottle;
                @Brake.started += instance.OnBrake;
                @Brake.performed += instance.OnBrake;
                @Brake.canceled += instance.OnBrake;
                @Steering.started += instance.OnSteering;
                @Steering.performed += instance.OnSteering;
                @Steering.canceled += instance.OnSteering;
                @Handbrake.started += instance.OnHandbrake;
                @Handbrake.performed += instance.OnHandbrake;
                @Handbrake.canceled += instance.OnHandbrake;
                @StartStopEngine.started += instance.OnStartStopEngine;
                @StartStopEngine.performed += instance.OnStartStopEngine;
                @StartStopEngine.canceled += instance.OnStartStopEngine;
                @LowBeamLights.started += instance.OnLowBeamLights;
                @LowBeamLights.performed += instance.OnLowBeamLights;
                @LowBeamLights.canceled += instance.OnLowBeamLights;
                @HighBeamLights.started += instance.OnHighBeamLights;
                @HighBeamLights.performed += instance.OnHighBeamLights;
                @HighBeamLights.canceled += instance.OnHighBeamLights;
                @IndicatorRight.started += instance.OnIndicatorRight;
                @IndicatorRight.performed += instance.OnIndicatorRight;
                @IndicatorRight.canceled += instance.OnIndicatorRight;
                @IndicatorLeft.started += instance.OnIndicatorLeft;
                @IndicatorLeft.performed += instance.OnIndicatorLeft;
                @IndicatorLeft.canceled += instance.OnIndicatorLeft;
                @IndicatorHazard.started += instance.OnIndicatorHazard;
                @IndicatorHazard.performed += instance.OnIndicatorHazard;
                @IndicatorHazard.canceled += instance.OnIndicatorHazard;
                @GearShiftUp.started += instance.OnGearShiftUp;
                @GearShiftUp.performed += instance.OnGearShiftUp;
                @GearShiftUp.canceled += instance.OnGearShiftUp;
                @GearShiftDown.started += instance.OnGearShiftDown;
                @GearShiftDown.performed += instance.OnGearShiftDown;
                @GearShiftDown.canceled += instance.OnGearShiftDown;
                @NOS.started += instance.OnNOS;
                @NOS.performed += instance.OnNOS;
                @NOS.canceled += instance.OnNOS;
                @TrailerDetach.started += instance.OnTrailerDetach;
                @TrailerDetach.performed += instance.OnTrailerDetach;
                @TrailerDetach.canceled += instance.OnTrailerDetach;
                @NGear.started += instance.OnNGear;
                @NGear.performed += instance.OnNGear;
                @NGear.canceled += instance.OnNGear;
                @_1stGear.started += instance.On_1stGear;
                @_1stGear.performed += instance.On_1stGear;
                @_1stGear.canceled += instance.On_1stGear;
                @_2ndGear.started += instance.On_2ndGear;
                @_2ndGear.performed += instance.On_2ndGear;
                @_2ndGear.canceled += instance.On_2ndGear;
                @_3rdGear.started += instance.On_3rdGear;
                @_3rdGear.performed += instance.On_3rdGear;
                @_3rdGear.canceled += instance.On_3rdGear;
                @_4thGear.started += instance.On_4thGear;
                @_4thGear.performed += instance.On_4thGear;
                @_4thGear.canceled += instance.On_4thGear;
                @_5thGear.started += instance.On_5thGear;
                @_5thGear.performed += instance.On_5thGear;
                @_5thGear.canceled += instance.On_5thGear;
                @_6thGear.started += instance.On_6thGear;
                @_6thGear.performed += instance.On_6thGear;
                @_6thGear.canceled += instance.On_6thGear;
                @RGear.started += instance.OnRGear;
                @RGear.performed += instance.OnRGear;
                @RGear.canceled += instance.OnRGear;
                @Clutch.started += instance.OnClutch;
                @Clutch.performed += instance.OnClutch;
                @Clutch.canceled += instance.OnClutch;
            }
        }
    }
    public VehicleActions @Vehicle => new VehicleActions(this);

    // Camera
    private readonly InputActionMap m_Camera;
    private ICameraActions m_CameraActionsCallbackInterface;
    private readonly InputAction m_Camera_Orbit;
    private readonly InputAction m_Camera_ChangeCamera;
    private readonly InputAction m_Camera_LookBack;
    private readonly InputAction m_Camera_Zoom;
    public struct CameraActions
    {
        private @RCC_InputActions m_Wrapper;
        public CameraActions(@RCC_InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Orbit => m_Wrapper.m_Camera_Orbit;
        public InputAction @ChangeCamera => m_Wrapper.m_Camera_ChangeCamera;
        public InputAction @LookBack => m_Wrapper.m_Camera_LookBack;
        public InputAction @Zoom => m_Wrapper.m_Camera_Zoom;
        public InputActionMap Get() { return m_Wrapper.m_Camera; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CameraActions set) { return set.Get(); }
        public void SetCallbacks(ICameraActions instance)
        {
            if (m_Wrapper.m_CameraActionsCallbackInterface != null)
            {
                @Orbit.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnOrbit;
                @Orbit.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnOrbit;
                @Orbit.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnOrbit;
                @ChangeCamera.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnChangeCamera;
                @ChangeCamera.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnChangeCamera;
                @ChangeCamera.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnChangeCamera;
                @LookBack.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnLookBack;
                @LookBack.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnLookBack;
                @LookBack.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnLookBack;
                @Zoom.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnZoom;
                @Zoom.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnZoom;
                @Zoom.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnZoom;
            }
            m_Wrapper.m_CameraActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Orbit.started += instance.OnOrbit;
                @Orbit.performed += instance.OnOrbit;
                @Orbit.canceled += instance.OnOrbit;
                @ChangeCamera.started += instance.OnChangeCamera;
                @ChangeCamera.performed += instance.OnChangeCamera;
                @ChangeCamera.canceled += instance.OnChangeCamera;
                @LookBack.started += instance.OnLookBack;
                @LookBack.performed += instance.OnLookBack;
                @LookBack.canceled += instance.OnLookBack;
                @Zoom.started += instance.OnZoom;
                @Zoom.performed += instance.OnZoom;
                @Zoom.canceled += instance.OnZoom;
            }
        }
    }
    public CameraActions @Camera => new CameraActions(this);

    // Optional
    private readonly InputActionMap m_Optional;
    private IOptionalActions m_OptionalActionsCallbackInterface;
    private readonly InputAction m_Optional_SlowMotion;
    private readonly InputAction m_Optional_Record;
    private readonly InputAction m_Optional_Replay;
    public struct OptionalActions
    {
        private @RCC_InputActions m_Wrapper;
        public OptionalActions(@RCC_InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @SlowMotion => m_Wrapper.m_Optional_SlowMotion;
        public InputAction @Record => m_Wrapper.m_Optional_Record;
        public InputAction @Replay => m_Wrapper.m_Optional_Replay;
        public InputActionMap Get() { return m_Wrapper.m_Optional; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(OptionalActions set) { return set.Get(); }
        public void SetCallbacks(IOptionalActions instance)
        {
            if (m_Wrapper.m_OptionalActionsCallbackInterface != null)
            {
                @SlowMotion.started -= m_Wrapper.m_OptionalActionsCallbackInterface.OnSlowMotion;
                @SlowMotion.performed -= m_Wrapper.m_OptionalActionsCallbackInterface.OnSlowMotion;
                @SlowMotion.canceled -= m_Wrapper.m_OptionalActionsCallbackInterface.OnSlowMotion;
                @Record.started -= m_Wrapper.m_OptionalActionsCallbackInterface.OnRecord;
                @Record.performed -= m_Wrapper.m_OptionalActionsCallbackInterface.OnRecord;
                @Record.canceled -= m_Wrapper.m_OptionalActionsCallbackInterface.OnRecord;
                @Replay.started -= m_Wrapper.m_OptionalActionsCallbackInterface.OnReplay;
                @Replay.performed -= m_Wrapper.m_OptionalActionsCallbackInterface.OnReplay;
                @Replay.canceled -= m_Wrapper.m_OptionalActionsCallbackInterface.OnReplay;
            }
            m_Wrapper.m_OptionalActionsCallbackInterface = instance;
            if (instance != null)
            {
                @SlowMotion.started += instance.OnSlowMotion;
                @SlowMotion.performed += instance.OnSlowMotion;
                @SlowMotion.canceled += instance.OnSlowMotion;
                @Record.started += instance.OnRecord;
                @Record.performed += instance.OnRecord;
                @Record.canceled += instance.OnRecord;
                @Replay.started += instance.OnReplay;
                @Replay.performed += instance.OnReplay;
                @Replay.canceled += instance.OnReplay;
            }
        }
    }
    public OptionalActions @Optional => new OptionalActions(this);
    private int m_KeyboardMouseSchemeIndex = -1;
    public InputControlScheme KeyboardMouseScheme
    {
        get
        {
            if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard Mouse");
            return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    private int m_G920SchemeIndex = -1;
    public InputControlScheme G920Scheme
    {
        get
        {
            if (m_G920SchemeIndex == -1) m_G920SchemeIndex = asset.FindControlSchemeIndex("G920");
            return asset.controlSchemes[m_G920SchemeIndex];
        }
    }
    private int m_OculusQuestSchemeIndex = -1;
    public InputControlScheme OculusQuestScheme
    {
        get
        {
            if (m_OculusQuestSchemeIndex == -1) m_OculusQuestSchemeIndex = asset.FindControlSchemeIndex("Oculus Quest");
            return asset.controlSchemes[m_OculusQuestSchemeIndex];
        }
    }
    public interface IVehicleActions
    {
        void OnThrottle(InputAction.CallbackContext context);
        void OnBrake(InputAction.CallbackContext context);
        void OnSteering(InputAction.CallbackContext context);
        void OnHandbrake(InputAction.CallbackContext context);
        void OnStartStopEngine(InputAction.CallbackContext context);
        void OnLowBeamLights(InputAction.CallbackContext context);
        void OnHighBeamLights(InputAction.CallbackContext context);
        void OnIndicatorRight(InputAction.CallbackContext context);
        void OnIndicatorLeft(InputAction.CallbackContext context);
        void OnIndicatorHazard(InputAction.CallbackContext context);
        void OnGearShiftUp(InputAction.CallbackContext context);
        void OnGearShiftDown(InputAction.CallbackContext context);
        void OnNOS(InputAction.CallbackContext context);
        void OnTrailerDetach(InputAction.CallbackContext context);
        void OnNGear(InputAction.CallbackContext context);
        void On_1stGear(InputAction.CallbackContext context);
        void On_2ndGear(InputAction.CallbackContext context);
        void On_3rdGear(InputAction.CallbackContext context);
        void On_4thGear(InputAction.CallbackContext context);
        void On_5thGear(InputAction.CallbackContext context);
        void On_6thGear(InputAction.CallbackContext context);
        void OnRGear(InputAction.CallbackContext context);
        void OnClutch(InputAction.CallbackContext context);
    }
    public interface ICameraActions
    {
        void OnOrbit(InputAction.CallbackContext context);
        void OnChangeCamera(InputAction.CallbackContext context);
        void OnLookBack(InputAction.CallbackContext context);
        void OnZoom(InputAction.CallbackContext context);
    }
    public interface IOptionalActions
    {
        void OnSlowMotion(InputAction.CallbackContext context);
        void OnRecord(InputAction.CallbackContext context);
        void OnReplay(InputAction.CallbackContext context);
    }
}
