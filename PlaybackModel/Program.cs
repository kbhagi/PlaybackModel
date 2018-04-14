using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Audible
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
public class PlaybackModel
    {
public List<Chapter> Chapters { get; private set; }
public TimeSpan PlaybackPos
        {
            get
            {
                ....
            }
            set
            {
                ....
            }
        }}
    public interface CurrentChapter
    {
        get 
         {
        for (var i = Chapters.Count - 1; i >=0; i--)
            {
            var chapter = Chapters[i];
            if  (PlaybackPos >= chapter.StartTime)
            {
            return i;
            }
    }
return 0;
}
        set 
        {
            PlaybackPos = Chapters[value].StartTime;
        }
}

