﻿namespace Memorabilia.Domain.Entities;

public class UserPaymentOption : Entity
{
    public UserPaymentOption() { }

    public UserPaymentOption(int userId, 
                             int paymentOptionId, 
                             string paymentHandle,
                             PaymentOptionTypes paymentOptionType)
    {
        IsPrimary = paymentOptionType == PaymentOptionTypes.Primary;
        PaymentHandle = paymentHandle;
        PaymentOptionId = paymentOptionId;
        UserId = userId;
    }

    public bool IsPrimary { get; private set; }

    public string PaymentHandle { get; private set; }

    public int PaymentOptionId { get; private set; }    

    public int UserId { get; private set; }

    public void Set(string paymentHandle, PaymentOptionTypes paymentOptionType)
    {
        IsPrimary = paymentOptionType == PaymentOptionTypes.Primary;
        PaymentHandle = paymentHandle;  
    }
}
