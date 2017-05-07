﻿using System.Threading.Tasks;
using NetTelegramBotApi.Types;

namespace NetTelegramBot.Framework.Abstractions
{
    public interface IMessageHandler<TIBot>
        where TIBot : IBot
    {
        IBot Bot { get; set; }

        bool CanHandle(Update update);

        Task HandleMessageAsync(Update update);
    }
}
