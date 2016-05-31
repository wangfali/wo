package briup.com.www;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import java.util.List;

public class math {
	String driver="com.mysql.jdbc.Driver";
	String url="jdbc:mysql://127.0.0.1:3306/wangfali";
	String user="root";
	String password="root";
	List<student> array =new ArrayList<student>();
	List<String>bookarray=new ArrayList<String>();
	List<librarant>larray=new ArrayList<librarant>();
	public void save(student s){
		try{
			Connection conn=null;
			PreparedStatement premt=null;
			try{
				conn=connectionfactory.getConn();
				String sql="insert into student(id,name,class,phone) values(?,?,?,?)";
				premt=conn.prepareStatement(sql);
				premt.setLong(1, s.getId());
				premt.setString(2, s.getName());
				premt.setLong(4, s.getPhone());
				premt.setString(3, s.gets_class());
				int num=premt.executeUpdate();
				System.out.println(num+"条数据改动成功");
			}finally{
				connectionfactory.close(null, premt, conn);
			}
			
		}catch(Exception e){e.printStackTrace();}
	}
	public void s_update_borrow(String bookname,long id){
		try{
			Connection conn=null;
			PreparedStatement premt=null;
			try{
				conn=connectionfactory.getConn();
				String sql="update student set borrow= ? where id=?  ";
				premt=conn.prepareStatement(sql);
				premt.setString(1, "借阅"+bookname);
				premt.setLong(2, id);
				
				
				int num=premt.executeUpdate();
				System.out.println(num+"借阅成功！");
			}finally{
				connectionfactory.close(null, premt, conn);
			}
		}catch(Exception e){e.printStackTrace();}
	}
	public void s_alter_borrow(String bookname,long id){
		try{
			Connection conn=null;
			PreparedStatement premt=null;
			try{
				conn=connectionfactory.getConn();
				String sql="update student set borrow=? where id=? and borrow=?";
				premt=conn.prepareStatement(sql);
				premt.setString(1, "借阅"+bookname);
				premt.setLong(2, id);
				premt.setString(3, "借阅"+bookname);
				int num=premt.executeUpdate();
				System.out.println(num+"还书成功！欢迎再次借阅!");
			}finally{
				connectionfactory.close(null, premt, conn);
			}
		}catch(Exception e){System.out.println("书名不正确！请核对后再输");}
	}
	public String RecodeByStudent(long id){
		try{
			Connection conn=null;
			PreparedStatement premt=null;
			ResultSet rs=null;
			try{
				conn=connectionfactory.getConn();
			String sql="select *from student where id=? ";
			premt=conn.prepareStatement(sql);
			premt.setLong(1, id);
			rs=premt.executeQuery();
			if(rs.next()){
				return rs.getString(5);
			}
			}finally{
				connectionfactory.close(null, premt, conn);
			}
		}catch(Exception e){e.printStackTrace();}
		return null;
	}
	
	public void RecodeByl(String name){
		try{
			Connection conn=null;
			PreparedStatement premt=null;
			ResultSet rs=null;
			try{
				conn=connectionfactory.getConn();
			String sql="select phone,address from librarant where name=? ";
			premt=conn.prepareStatement(sql);
			premt.setString(1, name);
			rs=premt.executeQuery();
			if(rs.next()){
				System.out.println("上班时间为"+rs.getString("address")+"联系方式为"+rs.getLong("phone"));
			}
			else{
				System.out.println("该管理员不存在");
			}
			}finally{
				connectionfactory.close(null, premt, conn);
			}
		}catch(Exception e){e.printStackTrace();
		}
	}
	public void save_libraant(long id,String name,String question, long phone,String address ){
		try{
			Connection  conn=null;
			PreparedStatement premt=null;
			try{
				conn=connectionfactory.getConn();
				String sql="insert into librarant values(?,?,?,?,?)";
				premt=conn.prepareStatement(sql);
				premt.setLong(1, id);
				premt.setString(2, name);
				premt.setString(3, question);
				premt.setLong(4, phone);
				premt.setString(5, address);
				int num =premt.executeUpdate();
				System.out.println(num+"条有改动");
				
			}finally{
				connectionfactory.close(null, premt, conn);
			}
		}catch(Exception e){e.printStackTrace();}
	}	
		public String RecodeByLibrarant(long id){
			try{
				Connection conn=null;
				PreparedStatement  premt=null;
				ResultSet rs=null;
				try{
					conn=connectionfactory.getConn();
					String sql="select *from librarant where id=?";
					premt=conn.prepareStatement(sql);
					premt.setLong(1, id);
					rs=premt.executeQuery();
					while(rs.next()){
						return rs.getString("name");
					}
				}finally{
					connectionfactory.close(null, premt, conn);
				}
				
			}catch(Exception e){e.printStackTrace();}

			return null;
	}
		public void select_book(String clasify){
			try{
				Connection conn=null;
				PreparedStatement premt=null;
				ResultSet rs=null;
				try{
					conn=connectionfactory.getConn();
					String sql="select name   from book where classify=?";
					premt=conn.prepareStatement(sql);
					premt.setString(1, clasify);
					rs=premt.executeQuery();
					while(rs.next()){
						System.out.println(rs.getString("name")+",");
					}
					
					
				}finally{
					connectionfactory.close(rs, premt, conn);
				}
			}catch(Exception e){e.printStackTrace();}
		}
		public void insert_book(long id, String name, String storey, String classify, long number){
			try{
				Connection conn=null;
				PreparedStatement  premt=null;
				try{
					conn=connectionfactory.getConn();
					String sql="insert into book(id,name,storey,classify,number)  values(?,?,?,?,?)";
					premt=conn.prepareStatement(sql);
					premt.setLong(1, id);
					premt.setString(2, name);
					premt.setString(3, storey);
					premt.setString(4, classify);
					premt.setLong(5, number);
					int num=premt.executeUpdate();
					System.out.println(num+"本图书插入成功！");
					
				}finally{
					connectionfactory.close(null, premt, conn);
				}
				
			}catch(Exception e){e.printStackTrace();}
	}
		public void delete_student(long id){
			try{
				Connection conn=null;
				PreparedStatement premt=null;
				try{
					conn=connectionfactory.getConn();
					String sql="delete from student where id=?";
					premt=conn.prepareStatement(sql);
					premt.setLong(1, id);
					int num=premt.executeUpdate();
					System.out.println(num+"条信息删除成功！");
				}finally{
					connectionfactory.close(null, premt, conn);
				}
			}catch(Exception e){e.printStackTrace();}
		}
		public void alter_student(long id,String name,String s_class,long phone){
			try{
				Connection conn=null;
				PreparedStatement premt=null;
				try{
					conn=connectionfactory.getConn();
					String sql="update student set name=?,class=?,phone=?  where id=?";
					premt=conn.prepareStatement(sql);
					premt.setString(1, name);
					premt.setString(2, s_class);
					premt.setLong(3, phone);
					premt.setLong(4, id);
					int num=premt.executeUpdate();
					System.out.println(num+"条信息修改成功！");
				}finally{
					connectionfactory.close(null, premt, conn);
				}
			}catch(Exception e){e.printStackTrace();}
		}
	
		public void RecodeBy(String question){
			try{
				Connection conn=null;
				PreparedStatement premt=null;
				ResultSet rs=null;
				try{
					conn=connectionfactory.getConn();
				String sql="select id from librarant where question=? ";
				premt=conn.prepareStatement(sql);
				premt.setString(1, question);
				rs=premt.executeQuery();
				if(rs.next()){
					System.out.println("你的密码为"+rs.getLong("id"));			
				}else{System.out.println("错误!");}
				}finally{
					connectionfactory.close(null, premt, conn);
				}
			}catch(Exception e){e.printStackTrace();}
			
			
		}
}
