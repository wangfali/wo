package com.briup.www;
public class Teacher{
	private long Id;
	private String name;
	private int age;
	public Teacher(long Id,String name,int age){
			this.Id=Id;
			this.name=name;
			this.age=age;
		}
	public void setId(long Id){
		this.Id=Id;
		}
	public long getId(){
		return this.Id;
	}
	public void setname(String name){
		this.name=name;
		}
	public String getname(){
		return this.name;
	}
	public void setAge(int age){
		this.age=age;
		}
	public int getAge(){
		return this.age;
	}
	public String toString(){//��ʹ���������ʱ���Զ����øú���
		//��Ϊ����object�����Ѿ����˵ķ����������е��඼�Ǽ̳�object

		return "Teacher[id:"+this.Id+"name:"+this.name+",age"+this.age+"]";
		}
}
