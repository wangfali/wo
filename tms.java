package com.briup.www;
import java.util.Scanner;
public class tms{
	private Teacher [] tea=new Teacher[6];//����tea�������ڱ���Teacher����
	private int index=0;//����index���ڼ�¼��ǰ�����еĶ������
	public void Save(Teacher teacher){//���ڽ����󱣴������鵱��
		if(index>=tea.length){//�ж������е�ǰ�Ķ����Ƿ��Ѿ�������ǰ���������
			Teacher [] t1=new Teacher[index+6];//����һ���µ����飬�������������ӵ�ԭ����һ��
			System.arraycopy(tea,0,t1,0,index );//��������
			tea=t1;//���µ������ַ����������
			}
		tea[index++]=teacher;//���������������
		}
	public void update(Teacher teacher){//���������ж���ĸ���
		for(int i=0;i<index;i++){//ʹ��forѭ��
			if(teacher.getId()==tea[i].getId()){//����������в��ҵ���Ӧ��id��
				tea[i].setname(teacher.getname());//���¶�������ָ����ɶ��������
				tea[i].setage(teacher.getage());//����������丽���ɶ��������
				}
			}
		}
	public int getIndexById(long id){//ͨ��id���ҳ���id�������е�����
		int num=-1;//���ڳз�Ŀ��������������-1��һ������Ҫ�ı�־
		for(int i=0;i<index;i++){//ʹ��forѭ��������
			if(tea[i].getId()==id){//����ҵ���id�����丳��num
				num=i;
				break;
			}
		}
		return num;//��Ŀ����������
	}
	public void deleteById(long id){//ͨ��id��ɾ������
		int num=getIndexById(id);//ͨ��id���ҳ���Ҫɾ���Ķ����ڴ洢�����е�Ŀ������
		for(int i=num;i<index-1;i++){
			tea[i]=tea[i+1];//��Ŀ������λ���Ժ��Ԫ����ǰ��һλ�����串��
			}
			tea[--index]=null;//���������Ϊ��
		}
	public Teacher[] queryAll(){//�ڴ洢�����������ȥ������ֵ
		Teacher [] demo=new Teacher[index];
		System.arraycopy(tea,0,demo,0,index);//��������п���
		return demo;//�����µ�����
		}
	public Teacher queryById(long id){//��û�п�ֵ�������У�ͨ��id���в��Ҷ���
		int num=getIndexById(id);//ͨ��id����Ŀ������
		return num==-1?null:tea[num];//���ز��ҵĽ��
		}
	public static void main(String [] args){/������
		tms ms=new tms();//ʹ�������������
		ms.menu();//���ò˵�
		Scanner sc =new Scanner(System.in);//����ɨ����
		while(true){//Ϊ�˱������ִֻ��һ�Σ�ʹ����ѭ��
			System.out.println("����������Ҫ�����ı��");
			String option=sc.nextLine();//�����û����������
			switch(option){
				case"1":
					System.out.println("���������н�ʦ����Ϣ");
					Teacher[] Tea=ms.queryAll();//����һ���µ����飬��ŵ�ǰ�����еĶ���
					for(Teacher i : Tea){//ʹ���������
						System.out.print(i);
						}
					System.out.println("�ܹ��鵽"+ms.index+"����ʦ��Ϣ");
					break;
				case"2":
					while(true){
					System.out.println("�������ʦ����Ϣ��id#name#age�����߼���break����Ŀ¼");
					String teachers=sc.nextLine();//�����������Ϣ
					if(teachers.equals("break")){//�б��������Ϣ�Ƿ�Ϊbreak
						break;
						}
					String [] teachersArr=teachers.split("#");//��������ַ�����#��Ϊ�ָ������ָ�����������
					long id =Long.parseLong(teachersArr[0]);//ʹ�����Ͱ�װ��
					String name=teachersArr[1];//ʹ�����Ͱ�װ��
					int age=Integer.parseInt(teachersArr[2]);//ʹ�����Ͱ�װ��
					Teacher tea1=new Teacher(id,name,age);//ʹ���������Ϣ����һ������
					ms.Save(tea1);//��������б���
					System.out.println("����ɹ���");
				}
					break;
				case"3":
					while(true){
					System.out.println("������Ҫɾ����ʦ��id����������break����Ŀ¼");
					String t1=sc.nextLine();//�����������Ϣ
					if(t1.equals("break")){//�ж��������Ϣ�Ƿ�Ϊbreak
						break;
						}
					long id =Long.parseLong(t1);//ʹ�ð�װ��
					Teacher t2=ms.queryById(id);//ʹ��id���Ҵ洢����������е�Ŀ�����
					if(t2==null){
						System.out.println("��Ҫɾ���Ľ�ʦ������");
							continue;
							}
					ms.deleteById(id);//ͨ��idɾ������
					System.out.println("ɾ���ɹ���");
					}
				break;
			case"4":
				while(true){
					System.out.println("������Ҫ���ҽ�ʦ��id����������break����Ŀ¼");
					String t1=sc.nextLine();//�����������Ϣ
					if(t1.equals("break")){//�ж��������Ϣ�Ƿ�Ϊbreak
						break;
						}
					long id=Long.parseLong(t1);//ʹ�ð�װ����id���а�װ
					Teacher t2=ms.queryById(id);//ͨ��id������Ŀ�����
					System.out.println(t2==null?"sorry,not found you need!":t2);
					}
					break;
			case"5":
				while(true){
					System.out.println("������Ҫ�޸ĵĽ�ʦ��id�ţ����߼���break����Ŀ¼");
					String t1=sc.nextLine();//����������Ϣ
					if(t1.equals("break")){//�ж�������Ϣ�Ƿ�Ϊbreak
							break;
						}
					long id=Long.parseLong(t1);//ʹ�ð�װ����id���а�װ
					Teacher t2=ms.queryById(id);//ʹ��id����Ŀ�����
					if(t2==null){
						System.out.println("��Ҫ�޸ĵĽ�ʦ��Ϣ�����ڣ�");
						continue;
						}
					System.out.println("ԭ��ϢΪ"+t2);
					System.out.println("����������Ϣ��name#age��");
						String t3=sc.nextLine();//�����������Ϣ
						String [] t4arr=t3.split("#");//ͨ��#�Ŷ��������Ϣ�ָ�
						String name=t4arr[0];//��ȡ��name����
						int age=Integer.parseInt(t4arr[1]);//��ȡ��age���ԣ���ʹ�ð�װ�����а�װ
						Teacher newteacher=new Teacher(id,name,age);//ʹ�ü������Ϣ�����¶���
						ms.update(newteacher);//���ж����������еĸ���
						System.out.println("����ɹ�");
					}
					 break;
			case"6":
				System.out.println("��ӭʹ�� ");
				System.exit(0);//ϵͳ�е��˳�����
			case"7":
				ms.menu();
				break;
			default:
				System.out.println("�������");
			}

		}
				
	}
	public void menu(){
		System.out.println("*************��ӭ�����ʦ����ϵͳ**************");
		System.out.println("1* ��ѯϵͳ�н�ʦ����");
		System.out.println("2* ¼���ʦ����Ϣ");
		System.out.println("3* ɾ����ʦ����Ϣ");
		System.out.println("4* ���ҽ�ʦ����Ϣ");
		System.out.println("5* �޸Ľ�ʦ��Ϣ");
		System.out.println("6* �˳�ϵͳ");
		System.out.println("7* ��ȡ����");
		System.out.println("************************************************");
		}

	
}