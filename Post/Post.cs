using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post
{
    class Post
    {
        public string Title { get; set; } = "";
        public string Question { get; set; } = "";
        public List<Post> Answer { get; set; } = new List<Post>();
        public int Votes { get; private set; } = 0;



        public Post(string title)
        {
            this.Title = title;
        }

        public Post(string title, string question) 
            : this(title)
        {
            this.Question = question;
        }


        public void ModifyTitle(string title)
        {
            this.Title = title;
        }

        public void ModifyQuestion(string question)
        {
            this.Question = question;
        }

        public void LikeUpDown(bool like)
        {
            if (like)
            {
                this.Votes += 1;
            }
            else
            {
                this.Votes -= 1;
            }
        }

        public void Response (string response)
        {
            //new Post(this.Title, response);
            this.Answer.Add(new Post(this.Title, response));
        }

        //add indexer for modifying LikeUpDowns of Answers

    }
}
