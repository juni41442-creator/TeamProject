// using - : ���� �����̽� : �λ� - ��μ� ���� - ��μ� MonoBehaviour ����
// public class �̸�  : Ŭ����
// void Start(){} : �Լ�, �޼ҵ�
// ��ɹ� statment : �ڵ� ; �̷�����ִ� �������


using UnityEngine;  //namespace�� ���� ���� �ʰ� ����ϸ� �ٸ� ���� �����̽��� ������� �Ȱ��� �̸��� Ŭ������ �ִٸ� ��ǻ�Ͱ� ������ �� ���� ����.

// ctrl + k ctrl + s : �ڵ� ���α�


namespace UnityEngine
{
    public class MouseWorld : MonoBehaviour
    {
        private void Update()   //������ ���� ������ �ȴ�. �̹����� �׷����� �ð��� ������. ����ؼ� �����Ѵ�.
        {
            //���콺�� ��ġ�� World �������� �ٲٰ� �ͽ��ϴ�.
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);    // ��ǻ�Ϳ��� ��ɹ�            
            //Physics.Raycast(ray, out RaycastHit hit);                       //��ɹ�2 : �������� ���� �浹�� ������ �����´�. hit                                                                            
            Physics.Raycast(ray, out RaycastHit hit);                       //��ɹ�2 : �������� ���� �浹�� ������ �����´�. hit  
            Debug.Log(hit.point);                                           //��ɹ�3 : hit�� �浹 ���� vector������ ����Ѵ�.

            transform.position = hit.point;                                     //��ɹ�4 : ���콺�� ��ġ�� ������Ʈ�� �̵� ��Ų��.
        }
    } 
}

//Ŭ���� �ۿ� �ڵ带 �ۼ��ϸ� �� �ڵ�� MouseWorld �� �ڵ尡 �ƴϴ�.
