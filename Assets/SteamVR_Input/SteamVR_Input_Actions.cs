//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Valve.VR
{
    using System;
    using UnityEngine;
    
    
    public partial class SteamVR_Actions
    {
        
        private static SteamVR_Action_Boolean p_landmarks_InteractUI;
        
        private static SteamVR_Action_Boolean p_landmarks_Teleport;
        
        private static SteamVR_Action_Boolean p_landmarks_GrabPinch;
        
        private static SteamVR_Action_Boolean p_landmarks_GrabGrip;
        
        private static SteamVR_Action_Pose p_landmarks_Pose;
        
        private static SteamVR_Action_Skeleton p_landmarks_SkeletonLeftHand;
        
        private static SteamVR_Action_Skeleton p_landmarks_SkeletonRightHand;
        
        private static SteamVR_Action_Single p_landmarks_Squeeze;
        
        private static SteamVR_Action_Vector2 p_landmarks_MoveAvatar;
        
        private static SteamVR_Action_Boolean p_landmarks_DebugButton;
        
        private static SteamVR_Action_Vibration p_landmarks_Haptic;
        
        private static SteamVR_Action_Vector2 p_platformer_Move;
        
        private static SteamVR_Action_Boolean p_platformer_Jump;
        
        private static SteamVR_Action_Vector2 p_buggy_Steering;
        
        private static SteamVR_Action_Single p_buggy_Throttle;
        
        private static SteamVR_Action_Boolean p_buggy_Brake;
        
        private static SteamVR_Action_Boolean p_buggy_Reset;
        
        public static SteamVR_Action_Boolean landmarks_InteractUI
        {
            get
            {
                return SteamVR_Actions.p_landmarks_InteractUI.GetCopy<SteamVR_Action_Boolean>();
            }
        }
        
        public static SteamVR_Action_Boolean landmarks_Teleport
        {
            get
            {
                return SteamVR_Actions.p_landmarks_Teleport.GetCopy<SteamVR_Action_Boolean>();
            }
        }
        
        public static SteamVR_Action_Boolean landmarks_GrabPinch
        {
            get
            {
                return SteamVR_Actions.p_landmarks_GrabPinch.GetCopy<SteamVR_Action_Boolean>();
            }
        }
        
        public static SteamVR_Action_Boolean landmarks_GrabGrip
        {
            get
            {
                return SteamVR_Actions.p_landmarks_GrabGrip.GetCopy<SteamVR_Action_Boolean>();
            }
        }
        
        public static SteamVR_Action_Pose landmarks_Pose
        {
            get
            {
                return SteamVR_Actions.p_landmarks_Pose.GetCopy<SteamVR_Action_Pose>();
            }
        }
        
        public static SteamVR_Action_Skeleton landmarks_SkeletonLeftHand
        {
            get
            {
                return SteamVR_Actions.p_landmarks_SkeletonLeftHand.GetCopy<SteamVR_Action_Skeleton>();
            }
        }
        
        public static SteamVR_Action_Skeleton landmarks_SkeletonRightHand
        {
            get
            {
                return SteamVR_Actions.p_landmarks_SkeletonRightHand.GetCopy<SteamVR_Action_Skeleton>();
            }
        }
        
        public static SteamVR_Action_Single landmarks_Squeeze
        {
            get
            {
                return SteamVR_Actions.p_landmarks_Squeeze.GetCopy<SteamVR_Action_Single>();
            }
        }
        
        public static SteamVR_Action_Vector2 landmarks_MoveAvatar
        {
            get
            {
                return SteamVR_Actions.p_landmarks_MoveAvatar.GetCopy<SteamVR_Action_Vector2>();
            }
        }
        
        public static SteamVR_Action_Boolean landmarks_DebugButton
        {
            get
            {
                return SteamVR_Actions.p_landmarks_DebugButton.GetCopy<SteamVR_Action_Boolean>();
            }
        }
        
        public static SteamVR_Action_Vibration landmarks_Haptic
        {
            get
            {
                return SteamVR_Actions.p_landmarks_Haptic.GetCopy<SteamVR_Action_Vibration>();
            }
        }
        
        public static SteamVR_Action_Vector2 platformer_Move
        {
            get
            {
                return SteamVR_Actions.p_platformer_Move.GetCopy<SteamVR_Action_Vector2>();
            }
        }
        
        public static SteamVR_Action_Boolean platformer_Jump
        {
            get
            {
                return SteamVR_Actions.p_platformer_Jump.GetCopy<SteamVR_Action_Boolean>();
            }
        }
        
        public static SteamVR_Action_Vector2 buggy_Steering
        {
            get
            {
                return SteamVR_Actions.p_buggy_Steering.GetCopy<SteamVR_Action_Vector2>();
            }
        }
        
        public static SteamVR_Action_Single buggy_Throttle
        {
            get
            {
                return SteamVR_Actions.p_buggy_Throttle.GetCopy<SteamVR_Action_Single>();
            }
        }
        
        public static SteamVR_Action_Boolean buggy_Brake
        {
            get
            {
                return SteamVR_Actions.p_buggy_Brake.GetCopy<SteamVR_Action_Boolean>();
            }
        }
        
        public static SteamVR_Action_Boolean buggy_Reset
        {
            get
            {
                return SteamVR_Actions.p_buggy_Reset.GetCopy<SteamVR_Action_Boolean>();
            }
        }
        
        private static void InitializeActionArrays()
        {
            Valve.VR.SteamVR_Input.actions = new Valve.VR.SteamVR_Action[] {
                    SteamVR_Actions.landmarks_InteractUI,
                    SteamVR_Actions.landmarks_Teleport,
                    SteamVR_Actions.landmarks_GrabPinch,
                    SteamVR_Actions.landmarks_GrabGrip,
                    SteamVR_Actions.landmarks_Pose,
                    SteamVR_Actions.landmarks_SkeletonLeftHand,
                    SteamVR_Actions.landmarks_SkeletonRightHand,
                    SteamVR_Actions.landmarks_Squeeze,
                    SteamVR_Actions.landmarks_MoveAvatar,
                    SteamVR_Actions.landmarks_DebugButton,
                    SteamVR_Actions.landmarks_Haptic,
                    SteamVR_Actions.platformer_Move,
                    SteamVR_Actions.platformer_Jump,
                    SteamVR_Actions.buggy_Steering,
                    SteamVR_Actions.buggy_Throttle,
                    SteamVR_Actions.buggy_Brake,
                    SteamVR_Actions.buggy_Reset};
            Valve.VR.SteamVR_Input.actionsIn = new Valve.VR.ISteamVR_Action_In[] {
                    SteamVR_Actions.landmarks_InteractUI,
                    SteamVR_Actions.landmarks_Teleport,
                    SteamVR_Actions.landmarks_GrabPinch,
                    SteamVR_Actions.landmarks_GrabGrip,
                    SteamVR_Actions.landmarks_Pose,
                    SteamVR_Actions.landmarks_SkeletonLeftHand,
                    SteamVR_Actions.landmarks_SkeletonRightHand,
                    SteamVR_Actions.landmarks_Squeeze,
                    SteamVR_Actions.landmarks_MoveAvatar,
                    SteamVR_Actions.landmarks_DebugButton,
                    SteamVR_Actions.platformer_Move,
                    SteamVR_Actions.platformer_Jump,
                    SteamVR_Actions.buggy_Steering,
                    SteamVR_Actions.buggy_Throttle,
                    SteamVR_Actions.buggy_Brake,
                    SteamVR_Actions.buggy_Reset};
            Valve.VR.SteamVR_Input.actionsOut = new Valve.VR.ISteamVR_Action_Out[] {
                    SteamVR_Actions.landmarks_Haptic};
            Valve.VR.SteamVR_Input.actionsVibration = new Valve.VR.SteamVR_Action_Vibration[] {
                    SteamVR_Actions.landmarks_Haptic};
            Valve.VR.SteamVR_Input.actionsPose = new Valve.VR.SteamVR_Action_Pose[] {
                    SteamVR_Actions.landmarks_Pose};
            Valve.VR.SteamVR_Input.actionsBoolean = new Valve.VR.SteamVR_Action_Boolean[] {
                    SteamVR_Actions.landmarks_InteractUI,
                    SteamVR_Actions.landmarks_Teleport,
                    SteamVR_Actions.landmarks_GrabPinch,
                    SteamVR_Actions.landmarks_GrabGrip,
                    SteamVR_Actions.landmarks_DebugButton,
                    SteamVR_Actions.platformer_Jump,
                    SteamVR_Actions.buggy_Brake,
                    SteamVR_Actions.buggy_Reset};
            Valve.VR.SteamVR_Input.actionsSingle = new Valve.VR.SteamVR_Action_Single[] {
                    SteamVR_Actions.landmarks_Squeeze,
                    SteamVR_Actions.buggy_Throttle};
            Valve.VR.SteamVR_Input.actionsVector2 = new Valve.VR.SteamVR_Action_Vector2[] {
                    SteamVR_Actions.landmarks_MoveAvatar,
                    SteamVR_Actions.platformer_Move,
                    SteamVR_Actions.buggy_Steering};
            Valve.VR.SteamVR_Input.actionsVector3 = new Valve.VR.SteamVR_Action_Vector3[0];
            Valve.VR.SteamVR_Input.actionsSkeleton = new Valve.VR.SteamVR_Action_Skeleton[] {
                    SteamVR_Actions.landmarks_SkeletonLeftHand,
                    SteamVR_Actions.landmarks_SkeletonRightHand};
            Valve.VR.SteamVR_Input.actionsNonPoseNonSkeletonIn = new Valve.VR.ISteamVR_Action_In[] {
                    SteamVR_Actions.landmarks_InteractUI,
                    SteamVR_Actions.landmarks_Teleport,
                    SteamVR_Actions.landmarks_GrabPinch,
                    SteamVR_Actions.landmarks_GrabGrip,
                    SteamVR_Actions.landmarks_Squeeze,
                    SteamVR_Actions.landmarks_MoveAvatar,
                    SteamVR_Actions.landmarks_DebugButton,
                    SteamVR_Actions.platformer_Move,
                    SteamVR_Actions.platformer_Jump,
                    SteamVR_Actions.buggy_Steering,
                    SteamVR_Actions.buggy_Throttle,
                    SteamVR_Actions.buggy_Brake,
                    SteamVR_Actions.buggy_Reset};
        }
        
        private static void PreInitActions()
        {
            SteamVR_Actions.p_landmarks_InteractUI = ((SteamVR_Action_Boolean)(SteamVR_Action.Create<SteamVR_Action_Boolean>("/actions/landmarks/in/InteractUI")));
            SteamVR_Actions.p_landmarks_Teleport = ((SteamVR_Action_Boolean)(SteamVR_Action.Create<SteamVR_Action_Boolean>("/actions/landmarks/in/Teleport")));
            SteamVR_Actions.p_landmarks_GrabPinch = ((SteamVR_Action_Boolean)(SteamVR_Action.Create<SteamVR_Action_Boolean>("/actions/landmarks/in/GrabPinch")));
            SteamVR_Actions.p_landmarks_GrabGrip = ((SteamVR_Action_Boolean)(SteamVR_Action.Create<SteamVR_Action_Boolean>("/actions/landmarks/in/GrabGrip")));
            SteamVR_Actions.p_landmarks_Pose = ((SteamVR_Action_Pose)(SteamVR_Action.Create<SteamVR_Action_Pose>("/actions/landmarks/in/Pose")));
            SteamVR_Actions.p_landmarks_SkeletonLeftHand = ((SteamVR_Action_Skeleton)(SteamVR_Action.Create<SteamVR_Action_Skeleton>("/actions/landmarks/in/SkeletonLeftHand")));
            SteamVR_Actions.p_landmarks_SkeletonRightHand = ((SteamVR_Action_Skeleton)(SteamVR_Action.Create<SteamVR_Action_Skeleton>("/actions/landmarks/in/SkeletonRightHand")));
            SteamVR_Actions.p_landmarks_Squeeze = ((SteamVR_Action_Single)(SteamVR_Action.Create<SteamVR_Action_Single>("/actions/landmarks/in/Squeeze")));
            SteamVR_Actions.p_landmarks_MoveAvatar = ((SteamVR_Action_Vector2)(SteamVR_Action.Create<SteamVR_Action_Vector2>("/actions/landmarks/in/MoveAvatar")));
            SteamVR_Actions.p_landmarks_DebugButton = ((SteamVR_Action_Boolean)(SteamVR_Action.Create<SteamVR_Action_Boolean>("/actions/landmarks/in/DebugButton")));
            SteamVR_Actions.p_landmarks_Haptic = ((SteamVR_Action_Vibration)(SteamVR_Action.Create<SteamVR_Action_Vibration>("/actions/landmarks/out/Haptic")));
            SteamVR_Actions.p_platformer_Move = ((SteamVR_Action_Vector2)(SteamVR_Action.Create<SteamVR_Action_Vector2>("/actions/platformer/in/Move")));
            SteamVR_Actions.p_platformer_Jump = ((SteamVR_Action_Boolean)(SteamVR_Action.Create<SteamVR_Action_Boolean>("/actions/platformer/in/Jump")));
            SteamVR_Actions.p_buggy_Steering = ((SteamVR_Action_Vector2)(SteamVR_Action.Create<SteamVR_Action_Vector2>("/actions/buggy/in/Steering")));
            SteamVR_Actions.p_buggy_Throttle = ((SteamVR_Action_Single)(SteamVR_Action.Create<SteamVR_Action_Single>("/actions/buggy/in/Throttle")));
            SteamVR_Actions.p_buggy_Brake = ((SteamVR_Action_Boolean)(SteamVR_Action.Create<SteamVR_Action_Boolean>("/actions/buggy/in/Brake")));
            SteamVR_Actions.p_buggy_Reset = ((SteamVR_Action_Boolean)(SteamVR_Action.Create<SteamVR_Action_Boolean>("/actions/buggy/in/Reset")));
        }
    }
}
