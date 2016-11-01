package xml.project;

import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.util.List;

import javax.xml.parsers.SAXParser;
import javax.xml.parsers.SAXParserFactory;

/*
 * 通讯录系统的界面
 */
public class window {
	public static void main(String[] args)throws Exception {
		BufferedReader bufferedReader=new BufferedReader(new InputStreamReader(System.in));
		while(true){
		System.out.println("欢迎进入通讯录系统！ 请选择您的服务");
		System.out.println("[1].添加联系人");
		System.out.println("[2].修改联系人");
		System.out.println("[3].删除联系人");
		System.out.println("[4].查询所有的联系人");
		System.out.println("[0].退出程序");
		String option=bufferedReader.readLine();
		int opt=Integer.parseInt(option);
		switch (opt) {
		case 0:
			System.exit(0);
			break;
		case 1:
			System.out.println("请按：编号#姓名#电话#年龄#邮箱#QQ#性别     输入您的信息");
			String readLine = bufferedReader.readLine();
			String[] split = readLine.split("#");
			String save = SavePerson.save(Integer.parseInt(split[0]),split[1],split[2], split[5], split[4],Integer.parseInt(split[3]) ,split[6]);
			if(save!=null){
				System.out.println(save);
			}else{
				System.out.println("保存成功！");
			}
			break;
			case 2:
				System.out.println("请重新输入您要修改的数据！编号#姓名#电话#年龄#邮箱#QQ#性别");
				String readLine2 = bufferedReader.readLine();
				String[] split2 = readLine2.split("#");
				SavePerson.update(Integer.parseInt(split2[0]),split2[1],split2[2], split2[5], split2[4],Integer.parseInt(split2[3]) ,split2[6]);
				break;
			case 3:
				System.out.println("请输入联系人编号！");
				String readLine3 = bufferedReader.readLine();
				SavePerson.delete(readLine3);
				break;
			case 4:
				SAXParser parser=SAXParserFactory.newInstance().newSAXParser();
				DefaultHandler dh=new DefaultHandler();
				parser.parse("E://person.xml", dh);
				List<person> list = dh.getlist();
				if(list!=null){
				for (person person : list) {
					System.out.println(person);
				}
				}else{
					System.out.println("当前没有记录！");
				}
				break;
		default:
			System.out.println("您的输入不正确！请核对后再输");
			break;
		}
		//bufferedReader.close();
		}
	}
}
