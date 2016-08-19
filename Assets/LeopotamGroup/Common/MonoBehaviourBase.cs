﻿//-------------------------------------------------------
// LeopotamGroupLibrary for unity3d
// Copyright (c) 2012-2016 Leopotam <leopotam@gmail.com>
//-------------------------------------------------------

using UnityEngine;

namespace LeopotamGroup.Common {
    /// <summary>
    /// Replacement for MonoBehaviour class with transform caching.
    /// </summary>
    public abstract class MonoBehaviourBase : MonoBehaviour {
        /// <summary>
        /// Patched transform, gains 2x performance boost compare to standard.
        /// </summary>
        /// <value>The transform.</value>
        public new Transform transform {
            get {
                if ((System.Object) _cachedTransform == null) {
                    _cachedTransform = base.transform;
                }
                return _cachedTransform;
            }
        }

        /// <summary>
        /// Internal cached transform. Dont be fool to overwrite it, no protection for additional 2x performance boost.
        /// </summary>
        protected Transform _cachedTransform;

        protected virtual void Awake () {
            if ((System.Object) _cachedTransform == null) {
                _cachedTransform = base.transform;
            }
        }
    }
}