using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace X//下面的代码都属于 X 这个命名空间，类似于java的包
{
    public class SummonGameObject : MonoBehaviour
    //如果一个脚本需要挂载到游戏物体上，则必选文件名和类名保证一致。
    //脚本需要挂载到物体上才能自动运行，所以把这个脚本挂载到摄像机上使其运行。
    {
        public GameObject prefabrication;//存放预制体的变量，预制体使用GameObject类来保存。设为 public 可以在unity中拖动预制体到这个变量并绑定
        void Update()//Update方法，会在游戏中每一帧执行一次
        {
            if (Input.GetMouseButtonDown(0))//如果 鼠标按下，方法里面的参数 0 表示为左键，1为右键，2为中键，3/4为鼠标侧键（如果有的话）
            {
                Vector3 clickPoint = Input.mousePosition;//获取鼠标点击的屏幕坐标（以屏幕左下角为0，0点的平面坐标系）
                clickPoint = Camera.main.ScreenToWorldPoint(clickPoint);//将向量 以屏幕为坐标系 转为 以游戏场景（世界坐标）为坐标系
                clickPoint.z = 0;//把这个向量的z分向量设为0（2d游戏z坐标默认为0）

                GameObject Object = Instantiate(prefabrication);
                //实例化预制体。预制体类似于java的类，生成出来的游戏对象就是实例，Instantiate就相当于new一个对象。

                Object.transform.position = clickPoint;//改变 Object 这个物体的位置改变到鼠标点击点的坐标。
            }
        }
    }
}
