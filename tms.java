package com.briup.www;
import java.util.Scanner;
public class tms{
	private Teacher [] tea=new Teacher[6];//定义tea数组用于保存Teacher对象
	private int index=0;//定义index用于记录当前数组中的对象个数
	public void Save(Teacher teacher){//用于将对象保存入数组当中
		if(index>=tea.length){//判断数组中当前的对象是否已经超出当前数组的容量
			Teacher [] t1=new Teacher[index+6];//创建一个新的数组，并将数组容量加到原来的一倍
			System.arraycopy(tea,0,t1,0,index );//拷贝数组
			tea=t1;//将新的数组地址附给旧数组
			}
		tea[index++]=teacher;//将对象放入数组中
		}
	public void update(Teacher teacher){//用于数组中对象的更新
		for(int i=0;i<index;i++){//使用for循环
			if(teacher.getId()==tea[i].getId()){//如果在数组中查找到对应的id号
				tea[i].setname(teacher.getname());//将新对象的名字附给旧对象的名字
				tea[i].setage(teacher.getage());//将对象的年龄附个旧对象的年龄
				}
			}
		}
	public int getIndexById(long id){//通过id来找出该id在数组中的索引
		int num=-1;//用于承放目标的索引，这里的-1是一个很重要的标志
		for(int i=0;i<index;i++){//使用for循环来查找
			if(tea[i].getId()==id){//如果找到了id，则将其赋给num
				num=i;
				break;
			}
		}
		return num;//将目标索引返回
	}
	public void deleteById(long id){//通过id来删除对象
		int num=getIndexById(id);//通过id来找出所要删除的对象在存储数组中的目标索引
		for(int i=num;i<index-1;i++){
			tea[i]=tea[i+1];//将目标索引位置以后的元素向前移一位，将其覆盖
			}
			tea[--index]=null;//将后面的置为空
		}
	public Teacher[] queryAll(){//在存储对象的数组中去掉，空值
		Teacher [] demo=new Teacher[index];
		System.arraycopy(tea,0,demo,0,index);//将数组进行拷贝
		return demo;//返回新的数组
		}
	public Teacher queryById(long id){//在没有空值的数组中，通过id进行查找对象
		int num=getIndexById(id);//通过id查找目标索引
		return num==-1?null:tea[num];//返回查找的结果
		}
	public static void main(String [] args){/主函数
		tms ms=new tms();//使用类名定义对象
		ms.menu();//调用菜单
		Scanner sc =new Scanner(System.in);//创建扫描器
		while(true){//为了避免程序只执行一次，使用死循环
			System.out.println("请输入您想要操作的编号");
			String option=sc.nextLine();//接收用户输入的数据
			switch(option){
				case"1":
					System.out.println("以下是所有教师的信息");
					Teacher[] Tea=ms.queryAll();//创建一个新的数组，存放当前数组中的对象
					for(Teacher i : Tea){//使用数组遍历
						System.out.print(i);
						}
					System.out.println("总共查到"+ms.index+"个教师信息");
					break;
				case"2":
					while(true){
					System.out.println("请输入教师的信息【id#name#age】或者键入break返回目录");
					String teachers=sc.nextLine();//接收输入的信息
					if(teachers.equals("break")){//判别输入的信息是否为break
						break;
						}
					String [] teachersArr=teachers.split("#");//将输入的字符串以#号为分隔符，分隔放入数组中
					long id =Long.parseLong(teachersArr[0]);//使用类型包装器
					String name=teachersArr[1];//使用类型包装器
					int age=Integer.parseInt(teachersArr[2]);//使用类型包装器
					Teacher tea1=new Teacher(id,name,age);//使用输入的信息创建一个对象
					ms.Save(tea1);//将对象进行保存
					System.out.println("保存成功！");
				}
					break;
				case"3":
					while(true){
					System.out.println("请输入要删除教师的id，或者输入break返回目录");
					String t1=sc.nextLine();//接收输入的信息
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
					long id=Long.parseLong(t1);//使用包装器将id进行包装
					Teacher t2=ms.queryById(id);//通过id来查找目标对象
					System.out.println(t2==null?"sorry,not found you need!":t2);
					}
					break;
			case"5":
				while(true){
					System.out.println("请输入要修改的教师的id号，或者键入break返回目录");
					String t1=sc.nextLine();//接收输入信息
					if(t1.equals("break")){//判断输入信息是否为break
							break;
						}
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
						ms.update(newteacher);//进行对象在数组中的更新
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