using UnityEngine;

namespace YW.Scripts
{
    public class CarMovement : MonoBehaviour
    {
        public float moveSpeed = 5f;  // 이동 속도 조정 변수

        void Update()
        {
            // 입력 처리
            float verticalInput = Input.GetAxis("Vertical");

            // 이동 벡터 계산
            Vector3 moveDirection = new Vector3(0, 0, verticalInput).normalized;

            // 이동 적용
            transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
        }
    }
}
