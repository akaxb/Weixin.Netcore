﻿using Weixin.Netcore.Core.Exceptions;
using Weixin.Netcore.Core.Message.Handler;
using Weixin.Netcore.Model.WeixinMessage;

namespace Weixin.Netcore.Core.Message.Processer
{
    /// <summary>
    /// 消息处理器（视频消息）- 无重复验证
    /// </summary>
    public class VideoMessageProcesserCanRepet : IMessageProcesser
    {
        private readonly IVideoMessageHandler _videoMessageHandler;

        public VideoMessageProcesserCanRepet(IVideoMessageHandler videoMessageHandler)
        {
            _videoMessageHandler = videoMessageHandler;
        }

        public string ProcessMessage(IMessage message)
        {
            if (message is VideoMessage)//视频消息
            {
                return _videoMessageHandler.VideoMessageHandler(message as VideoMessage);
            }
            else
            {
                throw new MessageNotSupportException("不支持的消息类型");
            }
        }
    }
}