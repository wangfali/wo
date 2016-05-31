package briup.com.www;

public class librarant {
	private long id;
	private String name;
	private String question;
	private long phone;
	private String address;
	public librarant(){}
	public long getId() {
		return id;
	}
	public void setId(long id) {
		this.id = id;
	}
	public String getName() {
		return name;
	}
	public void setName(String name) {
		this.name = name;
	}
	public String getQuestion() {
		return question;
	}
	public void setQuestion(String question) {
		this.question = question;
	}
	public long getPhone() {
		return phone;
	}
	public void setPhone(long phone) {
		this.phone = phone;
	}
	public String getAddress() {
		return address;
	}
	public void setAddress(String address) {
		this.address = address;
	}
	@Override
	public String toString() {
		return "librarant [id=" + id + ", name=" + name + ", question="
				+ question + ", phone=" + phone + ", address=" + address + "]";
	}
	public librarant(long id, String name, String question, long phone,
			String address) {
		super();
		this.id = id;
		this.name = name;
		this.question = question;
		this.phone = phone;
		this.address = address;
	}
	
}
