﻿namespace Lykke.Job.Messages.Core.Domain.Email.MessagesData
{
    public class SwiftCashOutRequestData : IEmailMessageData
    {
        public string AssetId { get; set; }
        public double Amount { get; set; }
        public string ClientId { get; set; }
        public string Bic { get; set; }
        public string AccNum { get; set; }
        public string AccName { get; set; }
        public string BankName { get; set; }
        public string AccHolderAddress { get; set; }
        public string CashOutRequestId { get; set; }

        public string MessageId()
        {
            return "SwiftCashOutRequest";
        }
    }
}
