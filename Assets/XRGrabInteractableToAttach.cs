using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class XRGrabInteractableToAttach : XRGrabInteractable
{
  public Transform LeftAttachTransform;
  public Transform rightAttachTransform;
  
  
  protected override void OnSelectEntered(SelectEnterEventArgs args)
  {
    if (args.interactorObject.transform.CompareTag("Left Hand"))
    {
      attachTransform = LeftAttachTransform;
    }
    else if (args.interactorObject.transform.CompareTag("Right Hand"))
    {
      attachTransform = rightAttachTransform;
    }
    base.OnSelectEntered(args);
  }
}
