package briup.com.www;

import java.util.Scanner;

public class lms {
	public static void main(String[] args){
	while(true){
		try{
		menu me=new menu();
		math ma=new math();
		me.menu0();
		System.out.println("请输入对应指令");
		Scanner sc =new Scanner(System.in);
		while(true){
		String  t=sc.nextLine();
		switch(t){
			case "1":
			while(true){
			 me.menu1();
            System.out.println("请输入对应的指令");
            String s=sc.nextLine();
			switch(s){
				case "1":
					while(true){
					System.out.println("请输入你的学号或输入break退出");
						String u=sc.nextLine();
						if(u.equals("break")){
							
								break;
							}
						long l =Long.parseLong(u);
					if(ma.RecodeByStudent(l)!=null){
							System.out.println("输入正确！");
								}
					else {
						System.out.println("您还没有注册！请注册");
						break;
						      }
                                while(true){
                                me.menu2();
								System.out.println("请输入对应指令");
								String  p=sc.nextLine();
								switch(p){
									case "1":
										while(true){
										System.out.println(ma.RecodeByStudent(l));
										System.out.println("请输入任意字符退出");
										
										break;}
										break;
									case "2":
										while(true){
											System.out.println("请输入要查询图书的类别");
											String  clasify=sc.nextLine();
										ma.select_book(clasify);
										System.out.println("请输入任意字符退出");
									
										break;
									}
									break;
									case"3":
										System.out.println("请输入管理员姓名");
										String  name=sc.nextLine();
										ma.RecodeByl(name);
										break;
									case "4":
										System.out.println("欢迎再次使用");
										System.exit(0);
									
									default:
										System.out.println("输入不正确！请核对后再输");
											break;}
										}
					}
					
				
				case"2":
					while(true){
						System.out.println("请以：学号#姓名#班级#联系方式     的形式输入你的信息或输入break退出");
						String h=sc.nextLine();
						if(h.equals("break")){
							break;
							}
						try{
						String []arr=h.split("#");
						long id=Long.parseLong(arr[0]);
						String n=arr[1];
						String p=arr[2];
						long phone=Long.parseLong(arr[3]);
						student str=new student(id,n,p,phone);
						ma.save(str);
						}
						catch(Exception e){
							System.out.println("输入有误！请重新输入");
							continue;
						}
						System.out.println("保存成功！");
						}break;
				
					case "3":
						System.out.println("欢迎再次使用");
						System.exit(0);
					
					default:
						System.out.println("输入错误请核对后再输");
					break;
			}
			}
			case "2":
				while(true){
					me.menua();
					System.out.println("请输入对应的指令");
					String  y=sc.nextLine();
					switch(y){
						case "1":
							while(true){
								try{
							System.out.println("请输入你的密码或输入break退出");
							String x=sc.nextLine();
										if(x.equals("break")){
											break;
											}
								long v =Long.parseLong(x);
							if(ma.RecodeByLibrarant(v)!=null){
							System.out.println("输入正确！");
								}
							else{
							System.out.println("您还没有注册！请注册");
							break;}
							while(true){
							me.menub();
							System.out.println("请输入对应的指令");
							String  g=sc.nextLine();
							switch(g){
								case "1":
									while(true){
										try{
										System.out.println("请输入   图书编号#书名#放置楼层#类别 #数目   或键入break退出");
										String h=sc.nextLine();
										
										if(h.equals("break")){
								        break;
										}String []arr=h.split("#");
										long id=Long.parseLong(arr[0]);
										String name=arr[1];
										String storey=arr[2];
										String classify =arr[3];
										long number=Long.parseLong(arr[4]);
							           ma.insert_book(id, name, storey, classify, number);
									   System.out.println("保存成功");
										}catch(Exception e){e.printStackTrace();}
									   }break;
									   
								case "2":
										while(true){
										System.out.println("请输入学生的学号或输入break取消");
										String u=sc.nextLine();
										if(u.equals("break")){
											break;
											}
										int l = Integer.parseInt(u);
										if(ma.RecodeByStudent(l)!=null){
							            System.out.println(ma.RecodeByStudent(1));
										System.out.println("请输入所借的图书");
										String f=sc.nextLine();
										ma.s_update_borrow(f,l);
										}
										else{
											System.out.println("该学生不存在！不能借书");
											}
									break;}
									break;
								case "3":
									while(true){
										System.out.println("请输入学生的学号或输入break取消");
										String m=sc.nextLine();
										if(m.equals("break")){
											break;
											}
										int n = Integer.parseInt(m);
										if(ma.RecodeByStudent(n)!=null){
							            System.out.println(ma.RecodeByStudent(n));
										System.out.println("请输入所借的图书或按enter返回");
										String f=sc.nextLine();
										ma.s_alter_borrow(f,n);
													}
										else{
											System.out.println("该学生不存在！不能还书");
											}
									break;
									}break;
								case "4":
									while(true){
										try{
										System.out.println("请输入学生的学号或输入break取消");
										String m=sc.nextLine();
										if(m.equals("break")){
											break;
											}
										int id = Integer.parseInt(m);
										if(ma.RecodeByStudent(id)!=null){
							            System.out.println(ma.RecodeByStudent(id));
										System.out.println("请以 姓名#班级#联系方式  的格式输入");
										String f=sc.nextLine();
										String []arr=f.split("#");
										long phone=Long.parseLong(arr[2]);
										String n=arr[1];
										String p=arr[2];
										ma.alter_student(id, n, p, phone);
													}
										else{
											System.out.println("该学生不存在！不能还书");
											}
										}catch(Exception e){
											e.printStackTrace();
											}
										}
									break;
									
								case"5":
									while(true){
										System.out.println("请输入学生的学号或输入break取消");
										String m=sc.nextLine();
										if(m.equals("break")){
											break;
											}
										int n = Integer.parseInt(m);
										if(ma.RecodeByStudent(n)!=null){
										ma.delete_student(n);
													}
										else{
											System.out.println("该学生不存在！");
											}
									break;
									}break;
									
									case "6":
									System.out.println("欢迎再次使用");
									System.exit(0);
									default:
										System.out.println("输入有误！请核对后再输");
										break;
									}
						   }
							}
							catch(Exception e){e.printStackTrace();}
							}
						case "2": 
							while(true){
							System.out.println("请以    密码#姓名#解码所提问题#电话#上班时间    的形式输入或输入break退出");
							String h=sc.nextLine();
							if(h.equals("break")){
								me.menu0();
								break;
								}
							try{
							String []arr=h.split("#");
							long id=Long.parseLong(arr[0]);
							String name=arr[1];
							String question=arr[2];
							long phone=Long.parseLong(arr[3]);
							String address=arr[4];
							ma.save_libraant(id, name, question, phone, address);
							}catch(Exception e){
								System.out.println("输入格式有误！请重新输入");
								continue;
							}
							System.out.println("保存成功！");
							me.menu0();
							System.out.println("请输入对应指令！");
							break;	
										}break;
					
			case"3":
				while(true){
					System.out.println("请输入你之前设置的问题或键入break切换用户");
					String  name=sc.nextLine();
					if(name.equals("break")){
						me.menu0();
						break;
						}
				ma.RecodeBy(name);
				
				}break;
			case "4":	
				System.out.println("欢迎再次使用");
				sc.close();
				System.exit(0);
		default:
		  System.out.println("输入有误！请核对后再输");
		   break;}
				}
		
		default:
			  System.out.println("输入有误！请核对后再输");
			   break;}
		}

			}catch(Exception e){e.printStackTrace();}}
	}
}
