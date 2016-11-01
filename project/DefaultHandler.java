package xml.project;

import java.util.ArrayList;
import java.util.List;

import org.xml.sax.Attributes;
import org.xml.sax.SAXException;

/*
 * ʹ��SAX�������õ�����
 */
public class DefaultHandler extends org.xml.sax.helpers.DefaultHandler{
	//����һ��ͨѸ¼�������
	person pers;
	//����һ���������ڴ洢����
	List<person>list=new ArrayList<person>();
	//����һ���������ڷ��ؼ���
	public List<person>getlist(){
		return list;
	}
	//����һ���������ڴ洢��ǰ�����ı�ǩ��
	String qname;
	@Override
	public void startElement(String uri, String localName, String qName,
			Attributes attributes) throws SAXException {
			//�ж��Ƿ���һ����ʼ���µĶ���
			qname=qName;
			if("person".equals(qName)){
				pers=new person();
				pers.setId(Integer.parseInt(attributes.getValue("id")));
			}
	}
	@Override
	public void characters(char[] ch, int start, int length)
			throws SAXException {
		//�ж��ı������ݽ��д洢
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
			if("��".equals(text)){
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
