using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dancer : MonoBehaviour
{
    private Animator playerAnimator;
    private float animTime;
    
    public readonly int IsHipHopHash = Animator.StringToHash("IsHipHop");
    public readonly int IsRumbaHash = Animator.StringToHash("IsRumba");
    public readonly int IsSillyHash = Animator.StringToHash("IsSilly");

    // Start is called before the first frame update
    void Start()
    {
        playerAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        animTime += Time.deltaTime;
        if (animTime <= 5)
        {
            playerAnimator.SetBool(IsHipHopHash, true);
            playerAnimator.SetBool(IsRumbaHash, false);
            playerAnimator.SetBool(IsSillyHash, false);
        }
        else if (animTime > 5 && animTime <= 10)
        {
            playerAnimator.SetBool(IsHipHopHash, false);
            playerAnimator.SetBool(IsRumbaHash, true);
            playerAnimator.SetBool(IsSillyHash, false);
        }
        else if (animTime > 10 && animTime <= 15 )
        {
            playerAnimator.SetBool(IsHipHopHash, false);
            playerAnimator.SetBool(IsRumbaHash, false);
            playerAnimator.SetBool(IsSillyHash, true);

            animTime = 0;
        }
    }
}
