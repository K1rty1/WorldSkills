using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldSkills.Model;


namespace WorldSkills.ViewModel
{
   
    public class UsersViewModel
    {
        Core db = new Core();
        /// <summary>
        /// сущетсвует ли пользователь
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool Auth(string login, string password) {
            Users user = db.context.Users.Where(
                x => x.Login == login && x.Password == password
                ).FirstOrDefault();
            if (user!=null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Поиск всей информации о пользователе
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public Users AllInformationUser(string login, string password)
        {
            Users user = db.context.Users.Where(
                x => x.Login == login && x.Password == password
                ).FirstOrDefault();
            return user;
        }
        /// <summary>
        /// Определение  роли у пользователя
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public int DefiningTheRole(string login,string password)
        {
            Users  user= AllInformationUser(login, password);
            if (user != null)
            {
                return Convert.ToInt32(user.IdRole);
            }
            else
            {
                throw new Exception("Пользователь не найден");
            }

        }
    }
}
