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
         	 

            m_Move = v*Vector3.forward*100 + h*Vector3.right*100;

			this.transform.Translate(m_Move,Space.World);
            //m_Jump = false;

        }
		//void OnTriggerEnter(Collider obj){
		//	if (obj.GetComponent<Rigidbody>()!=null) {
		//		obj.GetComponent<Rigidbody> ().isKinematic = false;
		//	}
		//		this.GetComponent<Rigidbody> ().isKinematic = false;
		//	
		//}

		//void OnTriggerExit(Collider obj){
		//	if (obj.GetComponent<Rigidbody> () != null&&obj.name!="Sphere") {
		//		obj.GetComponent<Rigidbody> ().isKinematic = true;
		//	}
		//		this.GetComponent<Rigidbody> ().isKinematic = true;
			
		//}
    }
}
