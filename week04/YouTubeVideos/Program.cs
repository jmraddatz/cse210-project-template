using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Chicken Dinos", "Greg", 183);
        Video video2 = new Video("Why Autumn Is The Best Season", "Samantha", 300);
        Video video3 = new Video("Aliens Are Coming To Destroy Us", "Taylor", 600);

        List<Video> videoList = new List<Video>
        {
            video1,
            video2,
            video3
        };

        List<Comment> v1Comments = new List<Comment>
        {
            new Comment("George", "This is so hilarious!"),
            new Comment("Eliza", "I showed this to my kids and they can't stop watching it."),
            new Comment("Judy", "A friend referred this to me. I don't know why everyone finds it so funny.")
        };

        List<Comment> v2Comments = new List<Comment>
        {
            new Comment("Faith", "I love the colors of Fall time too!"),
            new Comment("Roger", "I agree that it's beautiful. It's just too cold for me."),
            new Comment("John", "I personally think that Spring time is better. Flowers are the prettiest thing ever.")
        };

        List<Comment> v3Comments = new List<Comment>
        {
            new Comment("Brad", "If this is true, then I think we should be getting everyone to prepare more."),
            new Comment("Chad", "This is super scary to think about! Why isn't anyone else talking about this!?!"),
            new Comment("Shad", "These aliens must not be very smart if they've given us so many signs that they're coming.")
        };

        foreach (Comment comment in v1Comments)
        {
            video1.AddComments(comment);

        }
        foreach (Comment comment in v2Comments)
        {
            video2.AddComments(comment);

        }
        foreach (Comment comment in v3Comments)
        {
            video3.AddComments(comment);

        }

        foreach (Video video in videoList)
        {
            video.DisplayVideos();
        }
    }
}





