using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpSystem
{
    [Serializable]
    public class OrderedDictionary<TKey, TVal> : IEnumerable<TKey>
    {
        private List<TKey> keys = new List<TKey>();
        private List<TVal> vals = new List<TVal>();

        public List<TKey> Keys
        {
            get { return keys; }
        }

        public List<TVal> Vals
        {
            get { return vals; }
        }


        #region Класс-итератор
        private class Iterator : IEnumerator<TKey>
        {
            private int current;
            private OrderedDictionary<TKey, TVal> mydict;

            public Iterator(OrderedDictionary<TKey, TVal> mydict)
            {
                this.mydict = mydict;
                this.current = -1;
            }

            public TKey Current
            {
                get { return mydict.keys[current]; }
            }

            #region
            public void Dispose()
            {
                //throw new NotImplementedException();
            }

            object System.Collections.IEnumerator.Current
            {
                get { throw new NotImplementedException(); }
            }
            #endregion


            public bool MoveNext()
            {
                ++current;
                if (current < mydict.keys.Count)
                    return true;
                else
                    return false;
            }

            public void Reset()
            {
                current = -1;
            }
        }
        #endregion


        public TVal this[TKey index]
        {
            get
            {
                if (keys.Contains(index))
                    return vals[keys.IndexOf(index)];
                else
                    throw new IndexOutOfRangeException();
            }
            set { vals[keys.IndexOf(index)] = value; }
        }


        public IEnumerator<TKey> GetEnumerator()
        {
            return new Iterator(this);
        }

        #region
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
        #endregion

        /// <param name="k">Ключ</param>
        /// <param name="v">Элемент</param>
        public bool Add(TKey k, TVal v)
        {
            if (keys.Contains(k))
                return false;
            keys.Add(k);
            vals.Add(v);
            return true;
        }

        public void Add(object o)
        {
            throw new Exception("не не не");
        }

        public int Count
        {
            get { return keys.Count; }
        }

        public void Clear()
        {
            keys.Clear();
            vals.Clear();
        }

        /// <param name="k">Искомый ключ</param>
        public bool ContainsKey(TKey k)
        {
            return keys.Contains(k);
        }

        /// <summary>
        /// Проверяет наличие значения в коллекции
        /// </summary>
        /// <param name="v">Искомое значение</param>
        public bool ContainsValue(TVal v)
        {
            return vals.Contains(v);
        }

        /// <param name="pos">Позиция в коллекции</param>
        /// <param name="k">Ключ</param>
        /// <param name="v">Значение</param>
        public bool Insert(int pos, TKey k, TVal v)
        {
            if (keys.Contains(k))
                return false;
            keys.Insert(pos, k);
            vals.Insert(pos, v);
            return true;
        }

        /// <param name="k">Ключ элемента</param>
        public bool Remove(TKey k)
        {
            if (!keys.Contains(k))
                return false;
            vals.RemoveAt(keys.IndexOf(k));
            keys.Remove(k);
            return true;
        }

        /// <param name="pos">Позиция</param>
        public bool RemoveAt(int pos)
        {
            if (pos < 0 || pos >= keys.Count)
                return false;
            vals.RemoveAt(pos);
            keys.RemoveAt(pos);
            return true;
        }

    }
}
