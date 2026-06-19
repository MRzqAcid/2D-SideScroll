using UnityEngine;



    public class VerticalMovement : MonoBehaviour
    {

        static float t = 0.0f;

        public float distance, speed;   

        private float originalPos;

         //bool isRotate = false;

        void Start()
        {
            originalPos = transform.position.x;
        }

    

        void Update()
        {
            transform.position = new Vector3( originalPos + Mathf.Sin(t) * distance, transform.position.x, transform.position.z);
            t += speed * Time.deltaTime;
        }
    }
