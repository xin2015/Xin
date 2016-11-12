using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Xin.Expressions
{
    public interface IObjectMethodInvoker
    {
        object Invoke(object instance, params object[] parameters);

        MethodInfo Method { get; }
    }

    public class ObjectMethodInvoker : IObjectMethodInvoker
    {
        private Func<object, object[], object> invoker;

        public MethodInfo Method { get; }

        public object Invoke(object instance, params object[] parameters)
        {
            return invoker(instance, parameters);
        }

        public ObjectMethodInvoker(MethodInfo method)
        {
            Method = method;
            InitializeInvoker();
        }

        public void InitializeInvoker()
        {
            if (Method.ReturnType == typeof(void))
            {
                throw new NotSupportedException("The method's returnType is void, please use VoidMethodInvoker");
            }
            else
            {
                ParameterExpression instanceParam = Expression.Parameter(typeof(object), "instance");
                ParameterExpression parametersParam = Expression.Parameter(typeof(object[]), "parameters");
                ParameterInfo[] parameters = Method.GetParameters();
                List<UnaryExpression> parameterConverts = new List<UnaryExpression>();
                for (int i = 0; i < parameters.Length; i++)
                {
                    BinaryExpression parameterParam = Expression.ArrayIndex(parametersParam, Expression.Constant(i));
                    UnaryExpression parameterConvert = Expression.Convert(parameterParam, parameters[i].ParameterType);
                    parameterConverts.Add(parameterConvert);
                }
                UnaryExpression instanceConvert = Method.IsStatic ? null : Expression.Convert(instanceParam, Method.ReflectedType);
                MethodCallExpression call = Expression.Call(instanceConvert, Method, parameterConverts);
                invoker = Expression.Lambda<Func<object, object[], object>>(call, instanceParam, parametersParam).Compile();
            }
        }
    }

    public interface IVoidMethodInvoker
    {
        void Invoke(object instance, params object[] parameters);

        MethodInfo Method { get; }
    }

    public class VoidMethodInvoker : IVoidMethodInvoker
    {
        private Action<object, object[]> invoker;

        public MethodInfo Method { get; }

        public void Invoke(object instance, params object[] parameters)
        {
            invoker(instance, parameters);
        }

        public VoidMethodInvoker(MethodInfo method)
        {
            Method = method;
            InitializeInvoker();
        }

        private void InitializeInvoker()
        {
            if (Method.ReturnType == typeof(void))
            {
                ParameterExpression instanceParam = Expression.Parameter(typeof(object), "instance");
                ParameterExpression parametersParam = Expression.Parameter(typeof(object[]), "parameters");
                ParameterInfo[] parameters = Method.GetParameters();
                List<UnaryExpression> parameterConverts = new List<UnaryExpression>();
                for (int i = 0; i < parameters.Length; i++)
                {
                    BinaryExpression parameterParam = Expression.ArrayIndex(parametersParam, Expression.Constant(i));
                    UnaryExpression parameterConvert = Expression.Convert(parameterParam, parameters[i].ParameterType);
                    parameterConverts.Add(parameterConvert);
                }
                UnaryExpression instanceConvert = Method.IsStatic ? null : Expression.Convert(instanceParam, Method.ReflectedType);
                MethodCallExpression call = Expression.Call(instanceConvert, Method, parameterConverts);
                invoker = Expression.Lambda<Action<object, object[]>>(call, instanceParam, parametersParam).Compile();
            }
            else
            {
                throw new NotSupportedException("The method's returnType is not void, please use ObjectMethodInvoker");
            }
        }
    }
}
