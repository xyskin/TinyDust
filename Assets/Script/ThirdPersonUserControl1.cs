using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets.Characters.ThirdPerson
{
   
    public class ThirdPersonUserControl1 : MonoBehaviour
    {
        private ThirdPersonCharacter m_Character; // A reference to the ThirdPersonCharacter on the object
        private Transform m_Cam;                  // A reference to the main camera in the scenes transform
        private Vector3 m_CamForward;             // The current forward direction of the camera
        private Vector3 m_Move;
        private bool m_Jump;                      // the world-relative desired move direction, calculated from the camForward and user input.
		public float speed;
        
        private void Start()
        {
         
         
        }


        private void Update()
        {
            if (!m_Jump)
            {
                m_Jump = CrossPlatformInputManager.GetButtonDown("Jump");
            }
        }


        // Fixed update is called in sync with physics
        private void FixedUpdate()
        {
            // read inputs
            float h = CrossPlatformInputManager.GetAxis("Horizontal1");
            float v = CrossPlatformInputManager.GetAxis("Vertical1");
            bool crouch = Input.GetKey(KeyCode.C);

        
			m_Move = v*Vector3.forward*speed + h*Vector3.right*speed;


            // pass all parameters to the character control script
			this.transform.Translate(m_Move,Space.World);
            m_Jump = false;
        }
    }
}
