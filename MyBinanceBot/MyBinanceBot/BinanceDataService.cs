using System;
using System.Threading;
using System.Threading.Tasks;
using Binance.Net;
using Microsoft.Extensions.Hosting;

namespace MyBinanceBot
{
    public class BinanceDataService : BackgroundService
    {
        private static readonly BinanceSocketClient BinanceSocketClient = new BinanceSocketClient();
        private static readonly BinanceClient BinanceClient = new BinanceClient();

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            // await BinanceSocketClient.Spot.SubscribeToBookTickerUpdatesAsync(
            //     "DEGOUSDT", data => { Console.WriteLine(data.Data); }
            // );
            // await BinanceSocketClient.Spot.SubscribeToTradeUpdatesAsync("DEGOUSDT",
            //     data => { Console.WriteLine(data.Data); });
            // var currentPrice = await BinanceClient.Spot.Market.GetPriceAsync("DEGOUSDD", stoppingToken);
            var price = await BinanceClient.Spot.Market.Get24HPriceAsync("DEGOUSDT", stoppingToken);
        }
    }
}