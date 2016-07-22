using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLProject
{
    public class Users:BLLSuper
    {
        public Users()
        {
            DAL = new DALProject.Users();
        }

        public ModelProject.Users validate()
        {
            Object obj= DAL.getMe(Model.ID);
            if (obj == null)
                return null;
            else
            {
                ModelProject.Users  temp=(ModelProject.Users)obj;
                if (temp.Password == ((ModelProject.Users)Model).Password)
                    return temp;
                else
                    return null;
            }
        }
        /// <summary>
        /// 身份验证
        /// </summary>
        /// <returns>返回0表示账号错误，返回1表示验证通过，返回-1表示密码错误</returns>
        public int checkUser()
        {
            Object obj = DAL.getMe(Model.ID);
            if (obj == null)
                return 0;
            else
            {
                ModelProject.Users temp = (ModelProject.Users)obj;
                if (temp.Password == ((ModelProject.Users)Model).Password)
                {
                    if (temp.Status == "正常")
                        return 1;
                    else
                        return -2;//账号锁定
                }
                else
                    return -1;
            }
        }
    }
}
