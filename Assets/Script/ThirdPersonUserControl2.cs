using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets.Characters.ThirdPerson
{
   
    public class ThirdPersonUserControl2 : MonoBehaviour
    {
        private ThirdPersonCharacter m_Character; // A reference to the ThirdPersonCharacter on the object
        private Transform m_Cam;                  // A reference to the main camera in the scenes transform
        private Vector3 m_CamForward;             // The current forward direction of the camera
		public Vector3 m_Move;
        private bool m_Jump;                      // the world-relative desired move direction, calculated from the camForward and user input.

        private void Start()
        {
			
            // get the transform of the main camera
            if (Camera.main != null)
            {
                //m_Cam = Camera.main.transform;
            }
            else
            {
                Debug.LogWarning(
                    "Warning: no main camera found. Third person character needs a Camera tagged \"MainCamera\", for camera-relative controls.", gameObject);
                // we use self-relative controls in this case, which probably isn't what the user wants, but hey, we warned them!
            }

            // get the third person character ( this should never be null due to require component )
          
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
            float h = CrossPlatformInputManager.GetAxis("Horizontal2");
            float v = CrossPlatformInputManager.GetAxis("Vertical2");
            bool crouch = Input.GetKey(KeyCode.C);

		
            m_Move = v*Vector3.forward*100 + h*Vector3.right*100;
			//this.GetComponent<Rigidbody> ().AddForce (m_Move);
			//if (del_speed != 0)
				//this.transform.position = m_lastTrans.position;
            // pass all parameters to the character control script
			this.transform.Translate(m_Move,Space.World);
            m_Jump = false;

        }
    }
}
