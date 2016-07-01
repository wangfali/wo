package dataType;

import dataType.student.command;//导入接口

public class PrintCommand implements command{//定义类用来实现接口，已达到对数组的具体操作
	public void process(int [] target){//对数组操作的方法
		System.out.println("数组内的元素为");
		for(int a : target)
		{
			System.out.print(a+" ");//遍历输出
		}
	}
}
