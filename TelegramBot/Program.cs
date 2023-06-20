using Telegram.Bot;
using Telegram.Bot.Types;

namespace TelegramBotExperiments
{
    class Program
    {
        static void Main(string[] args)
        {
            var botClient = new TelegramBotClient("6062646845:AAGgh1fuVM8SBovfi1YYoX9vbv_uBnH77Tg");
            botClient.StartReceiving(Update, Error);
            Console.ReadKey();
        }
        private static Task Update(ITelegramBotClient client, Update update, CancellationToken token)
        {
            var message = update.Message;
            if(message != null) 
            { 
            
            }

        }

        private static Task Error(ITelegramBotClient client, Exception exception, CancellationToken token)
        {
            string errorMessage = $"Произошла ошибка: {exception.Message}";
            errorMessage += $"\nStackTrace: {exception.StackTrace}";
            return client.SendTextMessageAsync(chatId: "ваш ID чата", text: errorMessage, cancellationToken: token);
        }

    }   
}