package xml.project;

import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.util.List;

import javax.xml.parsers.SAXParser;
import javax.xml.parsers.SAXParserFactory;

/*
 * ͨѶ¼ϵͳ�Ľ���
 */
public class window {
	public static void main(String[] args)throws Exception {
		BufferedReader bufferedReader=new BufferedReader(new InputStreamReader(System.in));
		while(true){
		System.out.println("��ӭ����ͨѶ¼ϵͳ�� ��ѡ�����ķ���");
		System.out.println("[1].�����ϵ��");
		System.out.println("[2].�޸���ϵ��");
		System.out.println("[3].ɾ����ϵ��");
		System.out.println("[4].��ѯ���е���ϵ��");
		System.out.println("[0].�˳�����");
		String option=bufferedReader.readLine();
		int opt=Integer.parseInt(option);
		switch (opt) {
		case 0:
			System.exit(0);
			break;
		case 1:
			System.out.println("�밴�����#����#�绰#����#����#QQ#�Ա�     ����������Ϣ");
			String readLine = bufferedReader.readLine();
			String[] split = readLine.split("#");
			String save = SavePerson.save(Integer.parseInt(split[0]),split[1],split[2], split[5], split[4],Integer.parseInt(split[3]) ,split[6]);
			if(save!=null){
				System.out.println(save);
			}else{
				System.out.println("����ɹ���");
			}
			break;
			case 2:
				System.out.println("������������Ҫ�޸ĵ����ݣ����#����#�绰#����#����#QQ#�Ա�");
				String readLine2 = bufferedReader.readLine();
				String[] split2 = readLine2.split("#");
				SavePerson.update(Integer.parseInt(split2[0]),split2[1],split2[2], split2[5], split2[4],Integer.parseInt(split2[3]) ,split2[6]);
				break;
			case 3:
				System.out.println("��������ϵ�˱�ţ�");
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
					System.out.println("��ǰû�м�¼��");
				}
				break;
		default:
			System.out.println("�������벻��ȷ����˶Ժ�����");
			break;
		}
		//bufferedReader.close();
		}
	}
}
