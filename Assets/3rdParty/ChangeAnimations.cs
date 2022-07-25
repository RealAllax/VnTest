using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Spine.Unity;

public class ChangeAnimations : MonoBehaviour
{
    public SkeletonGraphic skeletonAnimation;
    

	public int currentState = 1;
	public int maxCount = 5;

	public Spine.Animation TargetAnimation { get; private set; }

    private void Awake()
    {
		SetAnimation();
	}

	private void SetAnimation()
    {
		skeletonAnimation.AnimationState.SetAnimation(0, currentState.ToString(), true);

	}

	public void NextAnimation()
    {
		if(currentState != maxCount)
        {
			currentState++;
			SetAnimation();
		}
	}

	public void PreviousAnimation()
    {
		if (currentState != 1)
        {
			currentState --;
			SetAnimation();
		}
		
    }

}
