using DevFreela.Core.DTOs;

public interface IPaymentService
    {
        Task<bool> ProcessPayment(PaymentInfoDTO paymentInfoDto);   
    }

