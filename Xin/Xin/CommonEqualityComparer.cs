using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Xin
{
    /// <summary>
    /// 公共比较器
    /// </summary>
    /// <typeparam name="T">类型</typeparam>
    /// <typeparam name="V">属性类型</typeparam>
    public class CommonEqualityComparer<T, V> : IEqualityComparer<T>
    {
        private Func<T, V> keySelector;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="keySelector">属性选择器</param>
        public CommonEqualityComparer(Func<T, V> keySelector)
        {
            this.keySelector = keySelector;
        }

        public bool Equals(T x, T y)
        {
            return EqualityComparer<V>.Default.Equals(keySelector(x), keySelector(y));
        }

        public int GetHashCode(T obj)
        {
            return EqualityComparer<V>.Default.GetHashCode(keySelector(obj));
        }
    }
}
