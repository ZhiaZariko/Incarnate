//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Articy.Hireathconcept;
using Articy.Unity;
using Articy.Unity.Constraints;
using Articy.Unity.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Articy.Hireathconcept.Features
{
    
    
    public class DefaultExtendedCharacterFeatureFeatureConstraint
    {
        
        private Boolean mLoadedConstraints;
        
        private NumberConstraint mTalent_charm;
        
        private NumberConstraint mTalent_combat;
        
        private NumberConstraint mTalent_leadership;
        
        private NumberConstraint mTalent_scholarship;
        
        private NumberConstraint mTalent_seduction;
        
        private NumberConstraint mTalent_stealth;
        
        private NumberConstraint mTalent_strategy;
        
        public NumberConstraint talent_charm
        {
            get
            {
                EnsureConstraints();
                return mTalent_charm;
            }
        }
        
        public NumberConstraint talent_combat
        {
            get
            {
                EnsureConstraints();
                return mTalent_combat;
            }
        }
        
        public NumberConstraint talent_leadership
        {
            get
            {
                EnsureConstraints();
                return mTalent_leadership;
            }
        }
        
        public NumberConstraint talent_scholarship
        {
            get
            {
                EnsureConstraints();
                return mTalent_scholarship;
            }
        }
        
        public NumberConstraint talent_seduction
        {
            get
            {
                EnsureConstraints();
                return mTalent_seduction;
            }
        }
        
        public NumberConstraint talent_stealth
        {
            get
            {
                EnsureConstraints();
                return mTalent_stealth;
            }
        }
        
        public NumberConstraint talent_strategy
        {
            get
            {
                EnsureConstraints();
                return mTalent_strategy;
            }
        }
        
        public virtual void EnsureConstraints()
        {
            if ((mLoadedConstraints == true))
            {
                return;
            }
            mLoadedConstraints = true;
            mTalent_charm = new Articy.Unity.Constraints.NumberConstraint(1D, 10D, 0, 0, 0, "1");
            mTalent_combat = new Articy.Unity.Constraints.NumberConstraint(1D, 10D, 0, 0, 0, "1");
            mTalent_leadership = new Articy.Unity.Constraints.NumberConstraint(1D, 10D, 0, 0, 0, "1");
            mTalent_scholarship = new Articy.Unity.Constraints.NumberConstraint(1D, 10D, 0, 0, 0, "1");
            mTalent_seduction = new Articy.Unity.Constraints.NumberConstraint(1D, 10D, 5, 0, 0, "1");
            mTalent_stealth = new Articy.Unity.Constraints.NumberConstraint(1D, 10D, 0, 0, 0, "1");
            mTalent_strategy = new Articy.Unity.Constraints.NumberConstraint(1D, 10D, 0, 0, 0, "1");
        }
    }
}
