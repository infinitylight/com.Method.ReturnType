using System;
/// <summary>
/// 本项目主要演示说明方法的几种返回类型及其定义和调用方式。
/// </summary>

namespace com.Method.ReturnType
{
    class Program
    {
        public static double c;
        public static double f;
        static double result(double a, double b)
        //     static int result(double a, double b)
        //     public        static void result()
        /*
     * 静态类是程序在一开始运行的时候就为其分配了内存空间，而非静态类（引用类型）是在实例化之后才为其分配内存空间。
     * 静态类方法不“属于”实例（对象），属于类。不能通过实例（对象）引用静态成员。
静态类方法 请用 :类名.方法（）         调用,例如：   Program .  doAgain(c);            Program.doAgain(122222);
引用类方法 请用 :(new 类名()).方法（） 调用，例如：  (new Program()).Last();            (new Program()).Last(4444);
 */
        {
            c = (a + b);//Program.c
            Console.WriteLine(("c=" + a + "+" + b + "=") + (c = (a + b)));

          //  return;
            //  return Program.f;
            //  int g=11;
            // return Program.c+a+b+g;
            return Program.c + a + b;
            //  return Console.ReadKey(Program.c+a+b);//ReadKey()方法可以读取bool类型变量。
            //  return b;
        }
        /* 
         *  static double？ doAgain(double? d)
        无法将方法的返回类型用英文问号?定义成可空类型,要用关键字void来定义方法的返回类型为空的类型
        方法的返回类型中不存在可空类型————要么有返回值；要么没有返回值。
        方法的返回值类型可以是任何类型，但是在定义方法时必须指定方法的返回值类型。
        */
        static double doAgain(double c)
    //   public   static void  doAgain()
        {
             double? d = null;
          //  double d=0;
            Console.WriteLine("++++d------=" + d + "\t" + "c=" + c);
            d = c * c;
            Console.WriteLine("++++d=" + d + "\t" + "c=" + c);

           return Program.c;
        }

     void Last()
            //  void Last(double c)
        {
            double e = c * 12;
            Console.WriteLine("Last.e="+e);

            return;
            //可以利用return语句立即从方法中退出。
            c = 11223;//该语句不会被执行。
        }

        static void Main(string[] args)
        {
            Console.WriteLine("将result方法作为Second变量计算的参数");
            double Second = result(result(11, 12), result(11, 12));
            //实际上  double Second = result(result(11, 12), result(11, 12));是执行了三次result方法后再把结果赋值给Second的。
            Console.WriteLine("Second=" + Second);
            /*
             当result方法的返回值为  return b;时，        Console.WriteLine("Second=" + Second);
             输出：c=11+12=23  c=11+12=23  c=12+12=24  Second=12
             当result方法的返回值为  return Program.c;时，Console.WriteLine("Second=" + Second);
             输出：c=11+12=23  c=11+12=23  c=23+23=46  Second=46
             当result方法的返回值为  return Program.f;时，Console.WriteLine("Second=" + Second);
             输出: c=11+12=23  c=11+12=23  c=0+0=0     Second=0
             由此可见方法的返回值决定了方法执行后返回什么样的值。
             这些值可以是任意值(但是这些值的值类型必须与方法的返回（值）类型相符————相同或者可以隐式转换)，
             并且该方法的返回值只和return语句有关，而和方法的其他执行过程没有任何关系。
             */

            //静态类带返回值的方法调用
            Console.WriteLine("doAgain方法传入参数变量c");
            Program.doAgain(c);
            Console.WriteLine("doAgain方法传入实参122222");
            Program.doAgain(122222);
            Console.WriteLine("doAgain方法将result方法作为参数");
            Program.doAgain(result(11, 12));

            //引用类无返回值的方法调用
            (new Program()).Last();
          //  (new Program()).Last(4444);

            Console.Read();

        }
    }
}

