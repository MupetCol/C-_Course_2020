using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

namespace Inheritance
{
    class VideoPost : Post
    {
        // member fields
        protected bool isPlaying = false;
        protected int currDuration = 0;
        Timer timer;

        // Properties
        public string VideoURL { get; set; }
        public int Length { get; set; }
        public VideoPost() { }

        public VideoPost(string title, string videoURL, string sendByUserName, int length, bool isPublic)
        {
            //The following properties and method is inherited from Post.
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUserName = sendByUserName;
            this.IsPublic = isPublic;
            // Properties below are members from VideoPost, but not from Post.
            this.VideoURL = videoURL;
            this.Length = length;

        }

        public void Play()
        {
            if (!isPlaying)
            {
                isPlaying = true;
                Console.WriteLine("Playing");
                timer = new Timer(TimerCallback, null, 0, 1000);
            }
            
        }

        private void TimerCallback(Object o)
        {
            if(currDuration < Length)
            {
                currDuration++;
                Console.WriteLine("Video at {0}s", currDuration);
                GC.Collect();
            }
            else
            {
                Stop();
            }
        }

        public void Stop()
        {
            if (isPlaying)
            {
                isPlaying = false;
                Console.WriteLine("Stopped at {0}s", currDuration);
                currDuration = 0;
                timer.Dispose();
            }
            
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} - {3} - {4}", this.ID, this.Title, this.VideoURL, this.Length, this.SendByUserName);
        }
    }
}
