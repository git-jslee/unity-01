using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    void Update()
    {
        if(Input.anyKeyDown){
            Debug.Log("플레이어가 아무 키를 눌렀습니다.");
        }

        if(Input.GetKeyDown(KeyCode.Return))
            Debug.Log("아이템을 구입하였습니다.");
        
        if(Input.GetKey(KeyCode.LeftArrow))
            Debug.Log(("왼쪽으로 이동 중"));
        
        if(Input.GetKey(KeyCode.RightArrow))
            Debug.Log(("오른쪽 이동을 멈추었습니다."));
    }
}
