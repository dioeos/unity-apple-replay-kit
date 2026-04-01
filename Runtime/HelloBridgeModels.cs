using System;

namespace HelloBridge
{
    [Serializable]
    public struct HelloMessage
    {
        public string text;
        public int count;

        public HelloMessage(string text, int count)
        {
            this.text = text;
            this.count = count;
        }
    }
}
