using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace X//����Ĵ��붼���� X ��������ռ䣬������java�İ�
{
    public class SummonGameObject : MonoBehaviour
    //���һ���ű���Ҫ���ص���Ϸ�����ϣ����ѡ�ļ�����������֤һ�¡�
    //�ű���Ҫ���ص������ϲ����Զ����У����԰�����ű����ص��������ʹ�����С�
    {
        public GameObject prefabrication;//���Ԥ����ı�����Ԥ����ʹ��GameObject�������档��Ϊ public ������unity���϶�Ԥ���嵽�����������
        void Update()//Update������������Ϸ��ÿһִ֡��һ��
        {
            if (Input.GetMouseButtonDown(0))//��� ��갴�£���������Ĳ��� 0 ��ʾΪ�����1Ϊ�Ҽ���2Ϊ�м���3/4Ϊ�����������еĻ���
            {
                Vector3 clickPoint = Input.mousePosition;//��ȡ���������Ļ���꣨����Ļ���½�Ϊ0��0���ƽ������ϵ��
                clickPoint = Camera.main.ScreenToWorldPoint(clickPoint);//������ ����ĻΪ����ϵ תΪ ����Ϸ�������������꣩Ϊ����ϵ
                clickPoint.z = 0;//�����������z��������Ϊ0��2d��Ϸz����Ĭ��Ϊ0��

                GameObject Object = Instantiate(prefabrication);
                //ʵ����Ԥ���塣Ԥ����������java���࣬���ɳ�������Ϸ�������ʵ����Instantiate���൱��newһ������

                Object.transform.position = clickPoint;//�ı� Object ��������λ�øı䵽�����������ꡣ
            }
        }
    }
}
