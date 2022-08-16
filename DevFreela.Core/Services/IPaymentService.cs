using DevFreela.Core.DTOs;

public interface IPaymentService
    {
        void ProcessPayment(PaymentInfoDTO paymentInfoDto);   
    }

