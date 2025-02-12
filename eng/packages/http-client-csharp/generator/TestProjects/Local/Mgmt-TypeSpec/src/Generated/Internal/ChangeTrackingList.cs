// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace MgmtTypeSpec
{
    internal partial class ChangeTrackingList<T> : IList<T>, IReadOnlyList<T>
    {
        private IList<T> _innerList;

        public ChangeTrackingList()
        {
        }

        public ChangeTrackingList(IList<T> innerList)
        {
            if (innerList != null)
            {
                _innerList = innerList;
            }
        }

        public ChangeTrackingList(IReadOnlyList<T> innerList)
        {
            if (innerList != null)
            {
                _innerList = innerList.ToList();
            }
        }

        /// <summary> Gets the IsUndefined. </summary>
        public bool IsUndefined => _innerList == null;

        /// <summary> Gets the Count. </summary>
        public int Count => IsUndefined ? 0 : EnsureList().Count;

        /// <summary> Gets the IsReadOnly. </summary>
        public bool IsReadOnly => IsUndefined ? false : EnsureList().IsReadOnly;

        /// <summary> Gets or sets the value associated with the specified key. </summary>
        public T this[int index]
        {
            get
            {
                if (IsUndefined)
                {
                    throw new ArgumentOutOfRangeException(nameof(index));
                }
                return EnsureList()[index];
            }
            set
            {
                if (IsUndefined)
                {
                    throw new ArgumentOutOfRangeException(nameof(index));
                }
                EnsureList()[index] = value;
            }
        }

        public void Reset()
        {
            _innerList = null;
        }

        public IEnumerator<T> GetEnumerator()
        {
            if (IsUndefined)
            {
                IEnumerator<T> enumerateEmpty()
                {
                    yield break;
                }
                return enumerateEmpty();
            }
            return EnsureList().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(T item)
        {
            EnsureList().Add(item);
        }

        public void Clear()
        {
            EnsureList().Clear();
        }

        public bool Contains(T item)
        {
            if (IsUndefined)
            {
                return false;
            }
            return EnsureList().Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            if (IsUndefined)
            {
                return;
            }
            EnsureList().CopyTo(array, arrayIndex);
        }

        public bool Remove(T item)
        {
            if (IsUndefined)
            {
                return false;
            }
            return EnsureList().Remove(item);
        }

        public int IndexOf(T item)
        {
            if (IsUndefined)
            {
                return -1;
            }
            return EnsureList().IndexOf(item);
        }

        public void Insert(int index, T item)
        {
            EnsureList().Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            if (IsUndefined)
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }
            EnsureList().RemoveAt(index);
        }

        public IList<T> EnsureList()
        {
            return _innerList ??= new List<T>();
        }
    }
}
