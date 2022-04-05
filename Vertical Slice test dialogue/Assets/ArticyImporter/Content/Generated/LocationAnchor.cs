//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Articy.Unity;
using Articy.Unity.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Articy.Hireathconcept
{
    
    
    [Serializable()]
    public class LocationAnchor : IArticyBaseObject
    {
        
        [SerializeField()]
        private Single mAnchorPositionX;
        
        [SerializeField()]
        private Single mAnchorPositionY;
        
        [SerializeField()]
        private Color mAnchorColor;
        
        [SerializeField()]
        private LocationAnchorSize mAnchorSize = new LocationAnchorSize();
        
        public Single AnchorPositionX
        {
            get
            {
                return mAnchorPositionX;
            }
            set
            {
                mAnchorPositionX = value;
            }
        }
        
        public Single AnchorPositionY
        {
            get
            {
                return mAnchorPositionY;
            }
            set
            {
                mAnchorPositionY = value;
            }
        }
        
        public Color AnchorColor
        {
            get
            {
                return mAnchorColor;
            }
            set
            {
                mAnchorColor = value;
            }
        }
        
        public LocationAnchorSize AnchorSize
        {
            get
            {
                return mAnchorSize;
            }
            set
            {
                mAnchorSize = value;
            }
        }
        
        private void CloneProperties(object aClone, Articy.Unity.ArticyObject aFirstClassParent)
        {
            LocationAnchor newClone = ((LocationAnchor)(aClone));
            newClone.AnchorPositionX = AnchorPositionX;
            newClone.AnchorPositionY = AnchorPositionY;
            newClone.AnchorColor = AnchorColor;
            newClone.AnchorSize = AnchorSize;
        }
        
        public object CloneObject(object aParent, Articy.Unity.ArticyObject aFirstClassParent)
        {
            LocationAnchor clone = new LocationAnchor();
            CloneProperties(clone, aFirstClassParent);
            return clone;
        }
        
        public virtual bool IsLocalizedPropertyOverwritten(string aProperty)
        {
            return false;
        }
    }
}
