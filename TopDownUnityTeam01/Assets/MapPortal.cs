using Unity.Cinemachine;
using UnityEngine;
public class MapPortal : MonoBehaviour
{
    //Cinnemachine Confiner2D의 BoundingShape A안에 BoxCollider2D를 B의 BoxCollider2D로 바꾸어야 한다.
    //플레이어의 캐릭터를 원하는 지점으로 이동 해야 한다.

    // Entry의 충돌 지점을 닿았을때
    public Transform movePosition;
    public Collider2D mapBoundry;           //MapPortal 플레이어가 닿았을때 이동해야 할 카메라의 경계를 넣어 주세요.
    public CinemachineConfiner2D Confiner; //CinemachineConfiner2D 데이터를 저장 할 수 있는 상자.
    public Animator SceneTransitonAnimator; //방금 만들었던 씬 전환 애니메이터를 여기에 저장하세요.

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))  //테그가 Player인 녀석일 때만 실행을 해라.NPC가 들어가면 안되니까.(들어 가는 경우는 이와 같은 코드를 따로 만들어 줌.
        {
            Confiner.BoundingShape2D = mapBoundry;
            //Collision.transform.position = 이동하고 싶은 위치로 이동하라.
            collision.transform.position = movePosition.position;

            SceneTransitonAnimator.SetTrigger("Show");
        }
    }

}
