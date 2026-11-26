using System;

namespace KDH
{
    [Serializable] public class Msg
    {
        public string speaker;
        public string text_en;
        public string text_kr;
        public float delay = 0.15f;
    }

    [Serializable] public class ChoiceEffect
    {
        public string axis;
        public int delta;
    }

    [Serializable] public class Choice
    {
        public string id;
        public string text_en;
        public string text_kr;
        public int timerSec = 0;
        public ChoiceEffect[] effects;
        // "goto" is reserved in C#, we map it to goto_ when parsing
        public string goto_;
    }

    [Serializable] public class ThreadData
    {
        public string id;
        public string[] participants;
        public Msg[] messages;
        public Choice[] choices;
        public EndingBlock ending;
    }

    [Serializable] public class EpisodeWrapper
    {
        public string episodeId;
        public string title_en;
        public string title_kr;
        public ThreadData[] threads;
    }

    [Serializable] public class EndingBlock
    {
        public string name_en;
        public string name_kr;
        public string summary_en;
        public string summary_kr;
        public string[] rewards;
    }
}
