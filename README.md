# MonoGame_Animation
适用于MonoGame框架的动画库
# 效果
![animation](https://user-images.githubusercontent.com/41114110/159201432-dd1a4344-7c86-4abe-bc67-73fe50dbd249.gif)
# 使用方法
* 1.实例一个Animation数据：在LoadContent阶段，new一个Animation实例
* 2.每帧调用AnimationPlayer的PlayAnimation函数，此函数将设置动画播放器的动画数据，此函数是安全的，如果是新的动画片段则会改变动画，如果是当前的动画片段则什么也不会发生
* 3.在Draw阶段，调用AnimationPlayer.Draw函数，这将绘制最终的动画效果
