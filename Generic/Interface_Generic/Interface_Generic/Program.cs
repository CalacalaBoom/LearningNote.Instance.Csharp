using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Generic
{
    //创建一个泛型接口
    public interface IGenericInterface<T>
    {
        T CreateInterface();
    }
    //实现上面泛型接口的泛型类
    public class Factory<T, T1> : IGenericInterface<T1> where T : T1, new()
    {
        public T1 CreateInterface()
        {
            return new T();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IGenericInterface<System.ComponentModel.IListSource> factory = 
                new Factory<System.Data.DataTable, System.ComponentModel.IListSource>();
            //输出指定泛型的类型
            Console.WriteLine(factory.CreateInterface().GetType().ToString());
            Console.ReadLine();
        }
    }
}
