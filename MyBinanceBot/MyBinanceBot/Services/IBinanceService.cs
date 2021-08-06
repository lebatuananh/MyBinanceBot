using System.Threading.Tasks;
using Binance.Net.Interfaces;
using Binance.Net.Objects.Spot.MarketData;
using CryptoExchange.Net.Objects;

namespace MyBinanceBot.Services
{
    public interface IBinanceService
    {
        Task<WebCallResult<BinanceAveragePrice>> GetAveragePrice(string symbol);
        Task<WebCallResult<BinancePrice>> GetCurrentPrice(string symbol);
        Task<WebCallResult<IBinanceTick>> GetInformation24H(string symbol);
    }
}