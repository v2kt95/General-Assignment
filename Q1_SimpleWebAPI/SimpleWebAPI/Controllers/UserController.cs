using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SimpleWebAPI.Models;

namespace SimpleWebAPI.Controllers
{
    public class UserController : ApiController
    {
        User[] Users = new User[]
        {
            new User {ID = 1, Name = "vuong" },
            new User {ID = 2, Name = "The" },
            new User {ID = 3, Name = "Tai" }
        };

        FriendShip[] FriendShips = new FriendShip[]
        {
            new FriendShip {UserID1 = 1, UserID2 = 2 },
            new FriendShip {UserID1 = 1, UserID2 = 3 },
            new FriendShip {UserID1 = 3, UserID2 = 2 },
        };
        public IEnumerable<User> GetAllUsers()
        {
            return Users;
        }

        public IHttpActionResult GetUserInfo(int id)
        {
            var User = Users.FirstOrDefault((p) => p.ID == id);
            if(User == null)
            {
                return NotFound();
            }
            List<int> FriendID = new List<int>();
            foreach (FriendShip friendship in FriendShips)
            {
                if (friendship.UserID1 == id)
                {
                    FriendID.Add(friendship.UserID2);
                }
                if (friendship.UserID2 == id)
                {
                    FriendID.Add(friendship.UserID1);
                }
            }
            User.Friends = FriendID;
            return Ok(User);
        }
    }
}
