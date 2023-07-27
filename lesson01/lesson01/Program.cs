using System;   //使用命名空间System

// 所有语句都必须在类内，但是类不一定要在命名空间内
// 类是一种自定义的数据类型
class MyTest
{
    public void Test()
    {
        Console.WriteLine("这是一个命名空间外的class");
    }
}
namespace lesson01   //定义命名空间用namespace Name
{
    class Program
    {
      /* main方法是所有C#程序的入口
       * main方法必须是静态的
       * main方法的调用级别可以是：public、protected、private。默认public
       */
        static void Main(string[] args)
        {
          // 创建一个自定义类的对象
            MyTest a = new MyTest();
            a.Test();   //使用类中的方法

            // 采用索引进行格式化输入
            Console.WriteLine("{0} + {1} = {2}",10,15,10+15);

            // 采用字符串参数格式化
            string firstName = "hello";
            string lastName = "kitten";
            Console.WriteLine($"Full name is {firstName} {lastName}"); 

            // 从键盘输入并接收的方法:readline()，使用时要进行null检测
            Console.Write("请输入用户名：");
            string usrName = Console.ReadLine()??"默认用户名";
            Console.Write("请输入密码：");
            string passWord = Console.ReadLine()??"默认密码，请及时修改";
            Console.WriteLine($"您输入的帐号为：{usrName}\n密码为：{passWord}\n恭喜注册成功");
        }
    }
}
