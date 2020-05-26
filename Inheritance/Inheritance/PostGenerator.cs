using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class PostGenerator
    {
        static void Main(string[] args)
        {
            Post post1 = new Post("Thanks for the birthday wishes",true,"Daniel Muñoz");

            ImagePost imagePost1 = new ImagePost("Check out my new shoes", "httpss//images.com/shoes", "Daniel Muñoz", true);

            VideoPost videoPost1 = new VideoPost("Super THUMBNAIL", "https://music.youtube.com/watch?v=_Xq2wK3dI4g&list=RDAMVM_Xq2wK3dI4g", "Daniel Muñoz", 10, true);

            Console.WriteLine(post1.ToString());
            Console.WriteLine(videoPost1.ToString());
            Console.WriteLine(imagePost1.ToString());

            videoPost1.Play();
            Console.WriteLine("Press any key to stop the video");
            Console.ReadKey();
            videoPost1.Stop();

            Console.ReadLine();
        }
    }
}
