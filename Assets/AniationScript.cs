using UnityEngine;
using UnityEngine.InputSystem;




public class KeyBindTest : MonoBehaviour
{
   public InputActionAsset PlayerAction;
   public Animator PlayerAnimator;
   


   // Update is called once per frame
   void Update()
   {
       if (PlayerAction.FindAction("Jump").IsPressed()) // Name comes from Player Input (ex. movements)
       {
           PlayerAnimator.SetBool("Jump", true); // Name comes from Animator, Parameters, Bools -
       }
       else
       {
           PlayerAnimator.SetBool("Jump", false); // Name comes from Animator, Parameters, Bools -
       }


       if (PlayerAction.FindAction("Movement").IsPressed()) // Name comes from Player Input (ex. movements)
       {
           PlayerAnimator.SetBool("Walk", true); // Name comes from Animator, Parameters, Bools -
       }
       else
       {
           PlayerAnimator.SetBool("Walk", false); // Name comes from Animator, Parameters, Bools -
       }
   }


}
