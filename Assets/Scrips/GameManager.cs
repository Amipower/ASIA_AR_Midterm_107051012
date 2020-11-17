using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("蘑菇")]
    public Transform gugu;
    [Header("菇菇")]
    public Transform gugugu;
    [Header("虛擬搖桿")]
    public FixedJoystick joystick;
    [Header("旋轉速度"), Range(0.1f, 20f)]
    public float turn = 1.5f;
    [Header("縮放"), Range(0f, 5f)]
    public float size = 0.3f;
    public float Speed = 1.5f;
    [Header("縮放"), Range(0.1f, 1f)]
    public float Size = 0f;
    [Header("蘑菇動畫元件")]
    public Animator anigugu;
    [Header("菇菇動畫元件")]
    public Animator anigugugu;
    private void Start()
    {
        print("開始事件");
    }
    public float test = 1;
    private void Update()
    {
       

        
        gugu.localScale = new Vector3(1, 1, 1) * joystick.Vertical;
        gugu.Rotate(0, joystick.Horizontal * Speed, 0);
        gugugu.Rotate(0, joystick.Horizontal * Speed, 0);
        gugu.localScale += new Vector3(1, 1, 1) * joystick.Vertical * Size;
        gugu.localScale = new Vector3(1, 1, 1) * Mathf.Clamp(gugu.localScale.x, 0.5f, 2f);
        gugugu.localScale += new Vector3(1, 1, 1) * joystick.Vertical * Size;
        gugugu.localScale = new Vector3(1, 1, 1) * Mathf.Clamp(gugugu.localScale.x, 0.5f, 2f);
       
    }
    public void Attack()
    {
        print("攻擊");
        anigugu.SetTrigger("菇攻擊");
        anigugugu.SetTrigger("菇攻擊");

    }
    public void PlayAnimation(string aniName)
    {
        print(aniName);
        anigugu.SetTrigger(aniName);
        anigugugu.SetTrigger(aniName);


    }
}
