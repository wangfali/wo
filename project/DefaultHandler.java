package xml.project;

import java.util.ArrayList;
import java.util.List;

import org.xml.sax.Attributes;
import org.xml.sax.SAXException;

/*
 * 使用SAX解析所用到的类
 */
public class DefaultHandler extends org.xml.sax.helpers.DefaultHandler{
	//创建一个通迅录对象变量
	person pers;
	//创建一个集合用于存储对象
	List<person>list=new ArrayList<person>();
	//创建一个方法用于返回集合
	public List<person>getlist(){
		return list;
	}
	//创建一个变量用于存储当前读到的标签名
	String qname;
	@Override
	public void startElement(String uri, String localName, String qName,
			Attributes attributes) throws SAXException {
			//判断是否是一个开始的新的对象
			qname=qName;
			if("person".equals(qName)){
				pers=new person();
				pers.setId(Integer.parseInt(attributes.getValue("id")));
			}
	}
	@Override
	public void characters(char[] ch, int start, int length)
			throws SAXException {
		//判断文本的内容进行存储
		String text=new String(ch,start,length);
		if("name".equals(qname)){
			pers.setName(text);
		}
		if("phone".equals(qname)){
			pers.setPhone(text);
		}
		if("email".equals(qname)){
			pers.setEmail(text);
		}
		if("qq".equals(qname)){
			pers.setQq(text);
		}
		if("sex".equals(qname)){
			if("男".equals(text)){
				pers.setSex(Gender.man);
			}else {
				pers.setSex(Gender.woman);
			}
		}
		if("age".equals(qname)){
			pers.setAge(Integer.parseInt(text));
		}
	}
	@Override
	public void endElement(String uri, String localName, String qName)
			throws SAXException {
		qname=null;
		if("person".equals(qName)){
			list.add(pers);
		}
	}
}
