package com.briup.www.tms;

import java.util.ArrayList;
import java.util.Iterator;
import java.util.List;
import java.util.Scanner;

public class tms {
	private int index;
	 List<Teacher> tea=new ArrayList<Teacher>();
	public void Save(Teacher teacher){//用于将对象保存入数组当中
		tea.add(teacher);
		
	}
	public void printteacher(){
		for(Teacher tera:tea){
			System.out.println(tera);
			index++;
		}
	}
	
	public void update(Teacher teacher){//用于数组中对象的更新
		for(Teacher tear:tea){
			if(tear.getId()==teacher.getId()){
				tear.setAge(teacher.getAge());
				tear.setname(teacher.getname());
			}
		}
		}
	public int getIndexById(long id){//通过id来找出该id在数组中的索引
		int num=-1;//用于承放目标的索引，这里的-1是一个很重要的标志
		for(Teacher tear:tea){
			if(tear.getId()==id){
				return tea.indexOf(tear);
			}
		}
		return num;//将目标索引返回
	}
	public void deleteById(long id){//通过id来删除对象
		/*for(Teacher tear:tea){
			if(tear.getId()==id){
				tea.remove(tear);
				break;
			}
			}*/
		Iterator<Teacher>iter=tea.iterator();
		while(iter.hasNext()){
			if(iter.next().getId()==id){
				iter.remove();
			}
		}
		}
	
	public Teacher queryById(long id){//在没有空值的数组中，通过id进行查找对象
		for(Teacher tear:tea){
		if(tear.getId()==id){
			return tear;
		}	
		}
		return null;
		}
	public static void main(String [] args){//主函数
		tms ms=new tms();//使用类名定义对象
		ms.menu();//调用菜单
		@SuppressWarnings("resource")
		Scanner sc =new Scanner(System.in);//创建扫描器
		while(true){//为了避免程序只执行一次，使用死循环
			System.out.println("请输入您想要操作的编号");
			String option=sc.nextLine();//接收用户输入的数据
			switch(option){
				case"1":
					System.out.println("以下是所有教师的信息");
					ms.printteacher();
					
					System.out.println("总共查到"+ms.index+"个教师信息");
					break;
				case"2":
					while(true){
					System.out.println("请输入教师的信息【id#name#age】或者键入break返回目录");
					String teachers=sc.nextLine();//接收输入的信息
					if(teachers.equals("break")){//判别输入的信息是否为break
						break;
						}
					try{
					String [] teachersArr=teachers.split("#");//将输入的字符串以#号为分隔符，分隔放入数组中
					long id =Long.parseLong(teachersArr[0]);//使用类型包装器
					String name=teachersArr[1];//使用类型包装器
					int age=Integer.parseInt(teachersArr[2]);//使用类型包装器
					Teacher tea1=new Teacher(id,name,age);//使用输入的信息创建一个对象
					ms.Save(tea1);}
					catch(Exception e){
						System.out.println("输入错误！请核对后输入");
						continue;
					}
					System.out.println("保存成功！");
				}
					break;
				case"3":
					while(true){
					System.out.println("请输入要删除教师的id，或者输入break返回目录");
					String t1=sc.nextLine();//接收输入的信息
					try{
					if(t1.equals("break")){//判断输入的信息是否为break
						break;
						}
					long id =Long.parseLong(t1);//使用包装器
					Teacher t2=ms.queryById(id);//使用id查找存储对象的数组中的目标对象
					if(t2==null){
						System.out.println("您要删除的教师不存在");
							continue;
							}
					ms.deleteById(id);//通过id删除对象
					}catch(Exception e){
						System.out.println("输入有误请输入id号");
						continue;
					}
					System.out.println("删除成功！");
					}
				break;
			case"4":
				while(true){
					System.out.println("请输入要查找教师的id，或者输入break返回目录");
					String t1=sc.nextLine();//接收输入的信息
					if(t1.equals("break")){//判断输入的信息是否为break
						break;
						}
					try{
					long id=Long.parseLong(t1);//使用包装器将id进行包装
					Teacher t2=ms.queryById(id);
					
					System.out.println(t2==null?"sorry,not found you need!":t2);
					}
				catch(Exception e){
					System.out.println("输入有误！请重新输入");
				}
				}
					break;
			case"5":
				while(true){
					System.out.println("请输入要修改的教师的id号，或者键入break返回目录");
					String t1=sc.nextLine();//接收输入信息
					if(t1.equals("break")){//判断输入信息是否为break
							break;
						}
					try{
					long id=Long.parseLong(t1);//使用包装器对id进行包装
					Teacher t2=ms.queryById(id);//使用id查找目标对象
					if(t2==null){
						System.out.println("您要修改的教师信息不存在！");
						continue;
						}
					System.out.println("原信息为"+t2);
					System.out.println("请输入新信息【name#age】");
						String t3=sc.nextLine();//接收输入的信息
						
						String [] t4arr=t3.split("#");//通过#号对输入的信息分隔
						String name=t4arr[0];//提取出name属性
						int age=Integer.parseInt(t4arr[1]);//提取出age属性，并使用包装器进行包装
						Teacher newteacher=new Teacher(id,name,age);//使用键入的信息创建新对象
						ms.update(newteacher);
						}catch(Exception e){
							System.out.println("输入错误！请核对后再输");
							continue;
						}//进行对象在数组中的更新
						System.out.println("保存成功");
					}
					 break;
			case"6":
				System.out.println("欢迎使用 ");
				System.exit(0);//系统中的退出函数
			case"7":
				ms.menu();
				break;
			default:
				System.out.println("输入出错");
			}

		}
				
	}
	public void menu(){
		System.out.println("*************欢迎进入教师管理系统**************");
		System.out.println("1* 查询系统中教师人数");
		System.out.println("2* 录入教师的信息");
		System.out.println("3* 删除教师的信息");
		System.out.println("4* 查找教师的信息");
		System.out.println("5* 修改教师信息");
		System.out.println("6* 退出系统");
		System.out.println("7* 获取帮助");
		System.out.println("************************************************");
		}

	
}
