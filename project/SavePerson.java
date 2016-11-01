package xml.project;

import java.io.File;
import java.io.FileOutputStream;
import java.io.OutputStream;

import org.dom4j.Document;
import org.dom4j.DocumentHelper;
import org.dom4j.Element;
import org.dom4j.io.OutputFormat;
import org.dom4j.io.SAXReader;
import org.dom4j.io.XMLWriter;

/*
 * 通讯录保存类
 * private int id;
	private String name;
	private String phone;
	private String qq;
	private String email;
	private int age;
	private Gender sex;
 */
public class SavePerson {
	public static String save(int id,String name,String phone,String qq,String email,int age,String sex)
	throws Exception{
		Document document = DocumentHelper.createDocument();
		Element personElement = document.addElement("person");
		personElement.addAttribute("id", Integer.toString(id));
		Element namElement = personElement.addElement("name");
		namElement.addText(name);
		Element phonElement = personElement.addElement("phone");
		phonElement.addText(phone);
		Element qqElement = personElement.addElement("qq");
		qqElement.addText(email);
		Element emailElement = personElement.addElement("email");
		emailElement.addText(email);
		Element sexeElement = personElement.addElement("sex");
		if("男".equals(sex)){
			sexeElement.addText(sex);
		}else if("女".equals(sex)){
			sexeElement.addText(sex);
		}else{
			return new String("error!your input sex type no found!");
		}
		Element ageElement = personElement.addElement("age");
		ageElement.addText(Integer.toString(age));
		OutputStream out=new FileOutputStream(new File("E://person.xml"));
		OutputFormat format=OutputFormat.createPrettyPrint();
		format.setEncoding("UTF-8");
		XMLWriter writer=new XMLWriter(out, format);
		writer.write(document);
		writer.close();
		return null;
	}
	public static void update(int id,String name,String phone,String qq,String email,int age,String sex)
			throws Exception{
		SAXReader saxReader=new SAXReader();
		Document document = saxReader.read("E://person.xml");
		Element node =(Element)document.selectSingleNode("//person[@id="+Integer.toString(id)+"]");
		node.detach();
		String save = save(id, name, phone, qq, email, age, sex);
		if(save!=null){
			System.out.println("修改失败！"+save);
		}else{
			System.out.println("修改成功！");
		}
	}

	public static void delete(String id)throws Exception{
		SAXReader saxReader=new SAXReader();
		Document document = saxReader.read("E://person.xml");
		Element node =(Element)document.selectSingleNode("//person[@id="+id+"]");
		node.detach();
		OutputStream out=new FileOutputStream(new File("E://person.xml"));
		OutputFormat format=OutputFormat.createPrettyPrint();
		format.setEncoding("UTF-8");
		XMLWriter writer=new XMLWriter(out, format);
		writer.write(document);
		writer.close();
	}
}
