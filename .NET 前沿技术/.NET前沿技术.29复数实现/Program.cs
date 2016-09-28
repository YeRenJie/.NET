using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Complex
{
    //-----存储结构的定义
    public class Complex
    {
        float realpart;// 实数部分
        float imagpart;// 虚数部分

        // -----基本操作的实现
        // 构造复数 Z,其实部和虚部分别被赋以参数realval和 imagval 的值
        public Complex(float realval, float imagval)
        {
            this.realpart = realval;
            this.imagpart = imagval;
        }

        public Complex()
        {

        }

        // 返回复数 Z 的实部值
        float getReal(Complex z)
        {
            return z.realpart;
        }

        // 返回复数 Z 的虚部值
        float getImag(Complex z)
        {
            return z.imagpart;
        }

        // 以 sum 返回两个复数 的和
        public Complex add(Complex z2)
        {
            Complex sum = new Complex();
            sum.realpart = this.realpart + z2.realpart;
            sum.imagpart = this.imagpart + z2.imagpart;
            return sum;
        }

        // 以 mul 返回两个复数的乘积
        public Complex multiply(Complex z2)
        {
            Complex mul = new Complex();
            mul.realpart = this.realpart * z2.realpart - this.imagpart
                    * z2.imagpart;
            mul.imagpart = this.realpart * z2.imagpart + this.imagpart
                    * z2.realpart;
            return mul;
        }

        // 以 div 返回两个复数 的商
        public Complex divide(Complex z2)
        {
            Complex conjugate = new Complex(this.realpart, -this.imagpart);
            Complex multiplication = conjugate.multiply(z2);
            multiplication.realpart /= this.realpart * this.realpart
                    + this.imagpart * this.imagpart;
            multiplication.imagpart /= this.realpart * this.realpart
                    + this.imagpart * this.imagpart;
            return multiplication;
        }
        //打印输出
        public override string ToString()
        {
            string show = this.realpart + " + " + this.imagpart + "i";
            return show;
        }
        static void Main(){
	        Complex z1 = new Complex (8,6);
	        Complex z2= new Complex (4,3);

	        Console.WriteLine((z1.multiply(z2)));
	   }
    }
}
