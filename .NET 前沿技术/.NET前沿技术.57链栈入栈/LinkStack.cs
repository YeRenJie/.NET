using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exec4
{
  public class LinkStack<T> : IStack<T> {
	private Node<T> top; // 栈顶指针
	private int length; // 栈中元素个数

	public LinkStack() {
		this.top = null;
		this.length = 0;
	}
	
	//判断为空
	public bool IsEmpty() {
		return this.top == null;
	}
	
	//判断为满
	public bool IsFull() {
		return false;
	}
	
	//获取栈顶元素
	public T Peek() {
		return default(T);
	}
	
    //出栈
	public T Pop() {
		return default(T);

	}

	//入栈
	public bool Push(T element) {
		Node<T> q = new Node<T>(element);
		q.Next=top; 
		top = q;
		this.length++;
		return true;
	}
	//获取栈内数据个数
	public int Size() {
        return 0;
	}
	public override string ToString(){
		string msg="";
		Node<T> temp=top;
		if(temp==null)
			return msg;
		
		while(temp.Next!=null){
			msg+=temp.Data.ToString()+" ";
			temp=temp.Next;
		}
		
		msg+=temp.Data.ToString()+" ";

		string[] msgs=msg.Split(new char[]{' '});
		string str="";
		for(int i=msgs.Length-1;i>=0;i--)
			str+=msgs[i]+" ";
		return str;
	}
}

}
