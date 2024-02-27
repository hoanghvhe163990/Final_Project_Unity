//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//    public class FollowCam : MonoBehaviour
//    {
//        public DirectionCam camDirection;
//        private Camera m_cam;
//        private Vector3 m_startingPos;
//        private Vector2 m_camSize;

//        private void Awake()
//        {
//            m_cam = Camera.main;
//            m_startingPos = transform.position;
//            m_camSize = Helper.Get2DCamSize();
//        }

//        private void Update()
//        {
//            switch (camDirection)
//            {
//                case DirectionCam.Up:
//                    if (m_cam.transform.position.y < m_startingPos.y)
//                    {
//                        transform.position = new Vector3(
//                m_cam.transform.position.x,
//                m_startingPos.y,
//                transform.position.z);
//                    }
//                    else
//                    {
//                        transform.position = new Vector3(
//                            m_cam.transform.position.x,
//                            m_cam.transform.position.y, 0f
//                            );
//                    }
//                    break;
//                case DirectionCam.Down:
//                    if (m_cam.transform.position.y > m_startingPos.y)
//                    {
//                        transform.position = new Vector3(
//                m_cam.transform.position.x,
//                m_startingPos.y,
//                transform.position.z);
//                    }
//                    else
//                    {
//                        transform.position = new Vector3(
//                            m_cam.transform.position.x,
//                            m_cam.transform.position.y, 0f
//                            );
//                    }
//                    break;
//                default:
//                    transform.position = new Vector3(
//                            m_cam.transform.position.x,
//                            m_cam.transform.position.y, 0f
//                            );
//                    break;
//            }
//        }
//    }

