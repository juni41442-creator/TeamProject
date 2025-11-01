using Unity.Cinemachine;
using UnityEngine;
public class MapPortal : MonoBehaviour
{
    //플레이어의 캐릭터를 원하는 지점으로 이동 해야 한다.

    // Entry의 충돌 지점을 닿았을때
    public Transform movePosition;
    public Collider2D mapBoundry;
    public CinemachineConfiner2D Confiner; //inemachineConfiner2D 데이터를 저장 할 수 있는 상자.
    public Animator SceneTransitonAnimator; //방금 만들었던 씬 전환 애니메이터를 여기에 저장하세요.

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            Confiner.BoundingShape2D = mapBoundry;
            //Collision.transform.position = 이동하고 싶은 위치로 이동하라.
            collision.transform.position = movePosition.position;

            SceneTransitonAnimator.SetTrigger("Show");
        }
    }

}
