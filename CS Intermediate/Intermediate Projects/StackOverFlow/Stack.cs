using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Intermediate.Intermediate_Projects.StackOverFlow
{
    class StackPost
    {
        private DateTime _creationDate;
        private String _title;
        private String _description;
        private int _upVotes;
        private int _downVotes;


        public StackPost(string postTitle, string postDescription)
        {            
            _creationDate = DateTime.Now;
            _description = postDescription;
            _title = postTitle;
            _upVotes = 0;
            _downVotes = 0;

        }
        

        public void UpVote()
        {
            _upVotes++;
        }

        public void DownVote()
        {
            _downVotes--;
        }

        public override string ToString()
        {
            return _title + _description + _creationDate + _upVotes + _downVotes; //Formatting is messy but the functionality is able to be verified
        }
    }
}
