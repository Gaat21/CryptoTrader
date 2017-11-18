﻿namespace CryptoTrading.Logic.Services.Interfaces
{
    public interface IUserBalanceService
    {
        decimal TotalProfit { get; }

        decimal TotalPercentage { get; }
        void SetBuyPrice(decimal price);
        decimal GetProfit(decimal sellPrice);
    }
}