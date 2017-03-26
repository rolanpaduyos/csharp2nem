﻿// ReSharper disable once CheckNamespace

namespace NemApi
{
    /*
    * Stores the transaction announce response
    */

    public class NemAnnounceResponse
    {
        public class TransactionHash
        {
            public string Data { get; set; }
        }

        public class InnerTransactionHash
        {
            public string Data { get; set; }
        }

        public class Response
        {
            public int Type { get; set; }
            public int Code { get; set; }
            public string Message { get; set; }
            public TransactionHash TransactionHash { get; set; }
            public InnerTransactionHash InnerTransactionHash { get; set; }
        }
    }
}