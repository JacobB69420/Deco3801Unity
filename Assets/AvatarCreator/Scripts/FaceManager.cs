using System.Collections.Generic;
using UnityEngine;

public class FaceManager : MonoBehaviour
{
    // ~~ 1. Updates All Animations to Match Player Selections

    [SerializeField] private SO_Face face;

    // String Arrays
    [SerializeField] private string[] facePartTypes;
    
    // Animation
    private Animator animator;
    private AnimationClip animationClip;
    private AnimatorOverrideController animatorOverrideController;
    private AnimationClipOverrides defaultAnimationClips;

    private void Start()
    {
        // Set animator
        animator = GetComponent<Animator>();
        animatorOverrideController = new AnimatorOverrideController(animator.runtimeAnimatorController);
        animator.runtimeAnimatorController = animatorOverrideController;

        defaultAnimationClips = new AnimationClipOverrides(animatorOverrideController.overridesCount);
        animatorOverrideController.GetOverrides(defaultAnimationClips);

        // Set body part animations
        UpdateFaceParts();
    }

    public void UpdateFaceParts()
    {
        // Override default animation clips with face parts
        for (int partIndex = 0; partIndex < facePartTypes.Length; partIndex++)
        {
            // Get current face part
            string partType = facePartTypes[partIndex];
            // Get current face part ID
            string partID = face.faceComponents[partIndex].faceComponent.facePartAnimationID.ToString();

            animationClip = Resources.Load<AnimationClip>("Player Animations/" + partType + "/" + partType + "_" + partID);

            // Override default animation
            defaultAnimationClips[partType + "_" + 0] = animationClip;
        }

        // Apply updated animations
        animatorOverrideController.ApplyOverrides(defaultAnimationClips);
    }

    public class AnimationClipOverrides : List<KeyValuePair<AnimationClip, AnimationClip>>
    {
        public AnimationClipOverrides(int capacity) : base(capacity) { }

        public AnimationClip this[string name]
        {
            get { return this.Find(x => x.Key.name.Equals(name)).Value; }
            set
            {
                int index = this.FindIndex(x => x.Key.name.Equals(name));
                if (index != -1)
                    this[index] = new KeyValuePair<AnimationClip, AnimationClip>(this[index].Key, value);
            }
        }
    }
}