 using System;
using System.ComponentModel;
using System.Data;

namespace Inheritance
{
    class Post
    {
        private static int currentPostId;

        // properties
        protected int ID { get; set; }
        protected string Title { get; set; }
        protected string SendByUserName { get; set; }
        public bool IsPublic { get; set; }


        //DefaultBindingPropertyAttribute constructor. IF a derived class does not invoke a base
        //class constructor explicitly, the default constructor is calles implicitly.

        public Post()
        {
            ID = 0;
            Title = "My first post";
            IsPublic = true;
            SendByUserName = "Daniel Muñoz";
        }

        //Instances constructor that has three parameters
        public Post(string title, bool isPublic, string sendByUsername)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUserName = sendByUsername;
            this.IsPublic = isPublic;
        }

        protected int GetNextID()
        {
            return ++currentPostId;
        }

        public void Update(string title, bool isPublic)
        {
            this.Title = title;
            this.IsPublic = isPublic;
        }

        // Virtual MethodAccessException override ArgumentOutOfRangeException the ToString method that is inherited
        // from System.Object.
        public override string ToString()
        {
            return String.Format("{0} - {1} - {2}",this.ID,this.Title,this.SendByUserName);
        }


    }   
    
    
    
}
