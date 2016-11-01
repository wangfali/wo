package xml.project;
/*
 * 通讯录中的对象
 * 编号  姓名  性别  年龄  电话  QQ 邮箱
 */
enum Gender{
	man("男"),woman("女");
	String value;
	private Gender(String value){
		this.value=value;
	}
}
public class person {
	private int id;
	private String name;
	private String phone;
	private String qq;
	private String email;
	private int age;
	private Gender sex;
	public int getId() {
		return id;
	}
	public void setId(int id) {
		this.id = id;
	}
	public String getName() {
		return name;
	}
	public void setName(String name) {
		this.name = name;
	}
	public String getPhone() {
		return phone;
	}
	public void setPhone(String phone) {
		this.phone = phone;
	}
	public String getQq() {
		return qq;
	}
	public void setQq(String qq) {
		this.qq = qq;
	}
	public String getEmail() {
		return email;
	}
	public void setEmail(String email) {
		this.email = email;
	}
	public int getAge() {
		return age;
	}
	public void setAge(int age) {
		this.age = age;
	}
	public Gender getSex() {
		return sex;
	}
	public void setSex(Gender sex) {
		this.sex = sex;
	}
	@Override
	public String toString() {
		return "person [id=" + id + ", name=" + name + ", phone=" + phone
				+ ", qq=" + qq + ", email=" + email + ", age=" + age + ", sex="
				+ sex + "]";
	}
	
	
}
