using System.Threading.Tasks;
using Binance.Net;
using Binance.Net.Interfaces;
using Binance.Net.Objects.Spot.MarketData;
using CryptoExchange.Net.Objects;

namespace MyBinanceBot.Services
{
    public class BinanceService : IBinanceService
    {
        private static readonly BinanceClient BinanceClient = new BinanceClient();

        public async Task<WebCallResult<BinanceAveragePrice>> GetAveragePrice(string symbol)
        {
            return await BinanceClient.Spot.Market.GetCurrentAvgPriceAsync(symbol);
        }

        public async Task<WebCallResult<BinancePrice>> GetCurrentPrice(string symbol)
        {
            return await BinanceClient.Spot.Market.GetPriceAsync(symbol);
        }

        public async Task<WebCallResult<IBinanceTick>> GetInformation24H(string symbol)
        {
            return await BinanceClient.Spot.Market.Get24HPriceAsync(symbol);
        }
    }
}