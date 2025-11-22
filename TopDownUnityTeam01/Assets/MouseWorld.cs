// using - : 네임 스페이스 : 부산 - 김민수 서울 - 김민수 MonoBehaviour 설명
// public class 이름  : 클레스
// void Start(){} : 함수, 메소드
// 명령문 statment : 코드 ; 이루어져있는 구성요소


using UnityEngine;  //namespace를 설정 하지 않고 사용하면 다른 네임 스페이스에 만들어진 똑같은 이름의 클래스가 있다면 컴퓨터가 구멸을 할 수가 없다.

// ctrl + k ctrl + s : 코드 감싸기


namespace UnityEngine
{
    public class MouseWorld : MonoBehaviour
    {
        private void Update()   //프레임 마다 실행이 된다. 이미지가 그려지는 시간을 프레임. 계속해서 실행한다.
        {
            //마우스의 위치를 World 세상으로 바꾸고 싶습니다.
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);    // 컴퓨터에게 명령문            
            //Physics.Raycast(ray, out RaycastHit hit);                       //명령문2 : 광선으로 부터 충돌한 지점을 가져온다. hit                                                                            
            Physics.Raycast(ray, out RaycastHit hit);                       //명령문2 : 광선으로 부터 충돌한 지점을 가져온다. hit  
            Debug.Log(hit.point);                                           //명령문3 : hit의 충돌 값을 vector값으로 출력한다.

            transform.position = hit.point;                                     //명령문4 : 마우스의 위치에 오브젝트를 이동 시킨다.
        }
    } 
}

//클래스 밖에 코드를 작성하면 이 코드는 MouseWorld 의 코드가 아니다.
