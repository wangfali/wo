package dataType;

public class ProcessArray {
	public static void main(String[] args) {
		student p=new student();
		int [] target={1,3,4,6,-1};
		p.process(target, new PrintCommand());
		System.out.println("-------------");
		p.process(target, new AddCommand());
	}
}
