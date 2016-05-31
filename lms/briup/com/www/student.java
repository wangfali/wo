package briup.com.www;

public class student {
	private long id;
	private String name;
	private	String s_class;
	private String borrow;
	private long  phone;
	public long getPhone() {
		return phone;
	}
	public void setPhone(long phone) {
		this.phone = phone;
	}
	public student(){
		}
	public student(long id,String name,String s_class,long phone){
		this.id=id;
		this.name=name;
		this.s_class=s_class;
		this.borrow="暂无借书记录";
		this.phone=phone;
		
		}
	public void setId(long id){
		this.id=id;
	}
	public long getId(){
		return this.id;
	}
	public void setName(String name){
		this.name=name;
		}
	public String getName(){
		return this.name;
		}
	public void sets_class(String i){
		this.s_class=i;
		}
	public String  gets_class(){
		return this.s_class;
	}
	public void setborrow(String b){
		this.borrow=b;
		}
	public String  getborrow(){
		return this.borrow;
		}
    public String toString(){
		return "student[【学号】:"+this.id+",【姓名】:"+this.name+",【系别与班级】:"+this.s_class+"【是否有借书记录】:"+borrow+"]";
		}
}
