package dataType;

public class student {
	public interface command//定义一个接口用于执行对数组的操作
	{
		void process(int []  target);//抽象的方法
	}
	public  void  process(int [] target,command cmd){//这不是抽象的方法，是用来执行对数组的具体操作，这里使用了java的命令模式
		cmd.process(target);
	}
	
}
