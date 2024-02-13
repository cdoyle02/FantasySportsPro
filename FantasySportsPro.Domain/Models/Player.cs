using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasySportsPro.Domain.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int JerseyNumber { get; set; }

        public Player(int id, string firstName, string lastName, string nickName, DateTime dateOfBirth, int jerseyNumber)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            NickName = nickName;
            DateOfBirth = dateOfBirth;
            JerseyNumber = jerseyNumber;
        }
    }
}
