using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;



namespace DALProject
{
    public class program1
    {
        static void Main(string[] args)
        {
            #region 属性
            /*Role role = new Role();
            ModelProject.Role r = new ModelProject.Role();
            r.RoleId = 21;
            r.RoleName = ROleName.管理员;
            r.Remark = "wedxc";
             Console.WriteLine( role.add(r));
            //Console.WriteLine(role.edit(r));
            Console.ReadLine();*/
           /* User user = new User();
            ModelProject.User u = new ModelProject.User();
            u.Userid = 1234;
            u.UserName = "wang";
            u.Userpwd = "1234587";
            u.UserRemark = "fsdwq ";*/
           /* Log log = new Log();
            ModelProject.Log l = new ModelProject.Log();
            l.Logid = "123";
            l.LogName = "磕碜和";
            l.LogRemark = "HEYI";
            l.Logta = whether.无;
            l.LogRenk = RenkForU.低;
            l.LogDate = DateTime.Now;
            l.Userid = 123;
            Console.Write(log.edit(l));
            //Console.Write(log.del(l));
           // Console.WriteLine(log.add(l));
           // Console.WriteLine(user.edit(u));
           //Console.WriteLine(user.del(u));
            //Console.WriteLine(user.add(u));
            
            Console.ReadLine();*/
            /*Student student = new Student();
            ModelProject.Student s = new ModelProject.Student();
            ModelProject.Class c = new ModelProject.Class();
            //第一个班级
            c.
            //第二个班级
            s.Stno = "0001";
            s.Sex = ModelProject.Student.SEX.男;
            s.Stname = "小王";
            s.Stadd = "dfsfhd";
            s.Stage = 24;
            s.Stbirthday =Convert.ToDateTime( "1991-4-2");
            s.Enrollt = Convert.ToDateTime("2016-2-4");
            Console.Write(student.add(s));*/
            #endregion 
            /* Major major=new Major();
            ModelProject.Major m = new ModelProject.Major();
            //第一个部门
            ModelProject.Department one = new ModelProject.Department();
            one.Depno = "0001";
            one.Depnum = 2;
            one.Depname = "建筑与资源工程系";
            one.Depmember = "教师";
            one.Depma = "王";
            one.Depchecking = "有";
            one.Depfunctian = "教学";
            one.Depjob = "etgs";
            m.departmentList.Add(one);
            //第二个部门
            ModelProject.Department two = new ModelProject.Department();
            two.Depno = "0001";
            two.Depnum = 2;
            two.Depname = "建筑与资源工程系";
            two.Depmember = "教师";
            two.Depma = "王";
            two.Depchecking = "有";
            two.Depfunctian = "教学";
            two.Depjob = "etgs";
            m.departmentList.Add(two);*/

            ModelProject.User user = new ModelProject.User();
            User u = new User();
            user.Userid = "A0001";
            string a = "A0001";
            user.Userpwd = "123456";
            if (u.find("Userid='" +a + "'") == null)
            {
                Console.Write("成功！");
            }
           
        }
    }
}
