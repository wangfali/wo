package briup.com.www;

public class book {
private long id;
private String name;
private String storey;
private String classify;
public String getClassify() {
	return classify;
}
public void setClassify(String classify) {
	this.classify = classify;
}
private int number;
private int all_book_number;
public long getId() {
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
public String getStorey() {
	return storey;
}
public void setStorey(String storey) {
	this.storey = storey;
}
public int getNumber() {
	return number;
}
public void setNumber(int number) {
	this.number = number;
}
public int getAll_book_number() {
	return all_book_number;
}
public void setAll_book_number(int all_book_number) {
	this.all_book_number = all_book_number;
}
@Override
public String toString() {
	return "book [id=" + id + ", name=" + name + ", storey=" + storey
			+ ", number=" + number 
			+ "]";
}
public book(long id, String name, String storey, String classify, int number
		) {
	super();
	this.id = id;
	this.name = name;
	this.storey = storey;
	this.classify = classify;
	this.number = number;
	
}


}
