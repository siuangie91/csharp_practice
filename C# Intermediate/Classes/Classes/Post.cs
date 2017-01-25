using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedOn = DateTime.Now;
        private int _voteValue = 0;

        public void UpVote()
        {
            _voteValue++;
        }

        public void DownVote()
        {
            _voteValue--;
        }

        private int GetVoteCount()
        {
            return _voteValue;
        }

        public void DisplayPostInfo()
        {
            var voteCount = GetVoteCount();
            Console.WriteLine("--------------------------");
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Created on: " + CreatedOn);
            Console.WriteLine("Description: " + Description);
            Console.WriteLine("Vote count: " + voteCount);
            Console.WriteLine("--------------------------");
        }
    }
}
