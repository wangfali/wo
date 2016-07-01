package dataType;

import dataType.student.command;

public class AddCommand implements command{//定义一个类实现了接口，用于实现对数组具体的操作
	int sum=0;
	public void process(int [] target)//实现对数组操作的具体方法
	{
		for(int i=0;i<target.length;i++){
			sum+=target[i];
		}
		System.out.println("数组中数据的和为"+sum);//求和输出
	}
}
