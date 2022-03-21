using Microsoft.Xna.Framework.Graphics;

namespace StartFramework
{
    /// <summary>
    /// 一个动画片段的数据
    /// </summary>
    public class Animation
    {
        //纹理
        public Texture2D Texture
        {
            get { return texture; }
        }
        Texture2D texture;

        //每帧动画的持续时间
        public float FrameTime
        {
            get { return frameTime; }
        }
        float frameTime;

        //循环
        public bool IsLooping
        {
            get { return isLooping; }
        }
        bool isLooping;

        //动画有几帧
        public int FrameCount
        {
            get { return Texture.Width / FrameHeight; }
        }

        //每帧的宽度
        public int FrameWidth
        {
            get { return Texture.Height; }
        }

        //每帧的高度
        public int FrameHeight
        {
            get { return Texture.Height; }
        }

        //构造
        public Animation(Texture2D texture, float frameTime, bool isLooping)
        {
            this.texture = texture;
            this.frameTime = frameTime;
            this.isLooping = isLooping;
        }
    }
}