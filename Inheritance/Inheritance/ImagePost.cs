using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{

    // ImagePost derives from Post and adds a property (imageURL) and two constructors
    class ImagePost:Post
    {

        public string ImageURL { get; set; }
        public ImagePost() { }

        public ImagePost(string title, string imageURL, string sendByUserName, bool isPublic)
        {
            //The following properties and method is inherited from Post.
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUserName = sendByUserName;
            this.IsPublic = isPublic;
            // Property imageURL is a member of ImagePost, but not from Post.
            this.ImageURL = imageURL;

        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} - {3}", this.ID, this.Title, this.ImageURL, this.SendByUserName);
        }

    }
}
