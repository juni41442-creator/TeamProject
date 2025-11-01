using Unity.Cinemachine;
using UnityEngine;
public class MapPortal : MonoBehaviour
{
    //Cinnemachine Confiner2D�� BoundingShape A�ȿ� BoxCollider2D�� B�� BoxCollider2D�� �ٲپ�� �Ѵ�.
    //�÷��̾��� ĳ���͸� ���ϴ� �������� �̵� �ؾ� �Ѵ�.

    // Entry�� �浹 ������ �������
    public Transform movePosition;
    public Collider2D mapBoundry;           //MapPortal �÷��̾ ������� �̵��ؾ� �� ī�޶��� ��踦 �־� �ּ���.
    public CinemachineConfiner2D Confiner; //CinemachineConfiner2D �����͸� ���� �� �� �ִ� ����.
    public Animator SceneTransitonAnimator; //��� ������� �� ��ȯ �ִϸ����͸� ���⿡ �����ϼ���.

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))  //�ױװ� Player�� �༮�� ���� ������ �ض�.NPC�� ���� �ȵǴϱ�.(��� ���� ���� �̿� ���� �ڵ带 ���� ����� ��.
        {
            Confiner.BoundingShape2D = mapBoundry;
            //Collision.transform.position = �̵��ϰ� ���� ��ġ�� �̵��϶�.
            collision.transform.position = movePosition.position;

            SceneTransitonAnimator.SetTrigger("Show");
        }
    }

}
