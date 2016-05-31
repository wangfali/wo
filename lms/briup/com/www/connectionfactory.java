package briup.com.www;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;

public class connectionfactory {
	private static String driver="com.mysql.jdbc.Driver";
	private static String url="jdbc:mysql://127.0.0.1:3306/wangfali";
	private static String user="root";
	private static String password="root";

	public static Connection getConn() throws Exception{
		Class.forName(driver);
		return DriverManager.getConnection(url, user, password);
		}
	public static void close(ResultSet rs,PreparedStatement pstmt,Connection conn){
		try{
			if(rs!=null){
				rs.close();
			}
			
			if(pstmt!=null){
				pstmt.close();
			}
			if(conn!=null){
				conn.close();
			}
		}catch(Exception e){
			e.printStackTrace();
		}
	}
	}
