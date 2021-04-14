using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DoorOpen : MonoBehaviour
{

   [SerializeField] private AudioSource _audioSource;
   
   private float _deltaVolume;
   private bool _doorOpened;
   
   
   private void OnTriggerExit2D(Collider2D colison)
   {
      if (colison.TryGetComponent<Thief>(out Thief thief))
      {
         if (_audioSource.volume==0)
         {
            _audioSource.Play();
            _deltaVolume = 0.0004f;
         }
         else
         {
            _deltaVolume=-0.0004f;
         }
      }
   }

   private void Update()
   {
      _audioSource.volume += _deltaVolume;
   }
}
