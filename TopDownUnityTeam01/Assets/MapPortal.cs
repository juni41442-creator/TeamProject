using Unity.Cinemachine;
using UnityEngine;
public class MapPortal : MonoBehaviour
{
    //�÷��̾��� ĳ���͸� ���ϴ� �������� �̵� �ؾ� �Ѵ�.

    // Entry�� �浹 ������ �������
    public Transform movePosition;
    public Collider2D mapBoundry;
    public CinemachineConfiner2D Confiner; //inemachineConfiner2D �����͸� ���� �� �� �ִ� ����.
    public Animator SceneTransitonAnimator; //��� ������� �� ��ȯ �ִϸ����͸� ���⿡ �����ϼ���.

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            Confiner.BoundingShape2D = mapBoundry;
            //Collision.transform.position = �̵��ϰ� ���� ��ġ�� �̵��϶�.
            collision.transform.position = movePosition.position;

            SceneTransitonAnimator.SetTrigger("Show");
        }
    }

}
