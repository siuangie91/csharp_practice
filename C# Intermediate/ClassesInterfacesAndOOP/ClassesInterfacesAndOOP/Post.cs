using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesInterfacesAndOOP
{
    class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }

        private int VoteValue = 0;

        public Post(string title, string description)
        {
            this.Title = title;
            this.Description = description;
            this.DateCreated = DateTime.Now;
        }

        public void UpVote()
        {
            this.VoteValue++;
        }

        public void DownVote()
        {
            this.VoteValue--;
        }

        public int ShowVoteValue()
        {
            return VoteValue;
        }
    }
}
