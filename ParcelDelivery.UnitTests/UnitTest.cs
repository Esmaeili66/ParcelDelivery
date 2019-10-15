using ParcelDelivery.Core.Domain;
using ParcelDelivery.Core.Service;
using ParcelDelivery.UnitTests.Constant;
using Xunit;

namespace ParcelDelivery.UnitTests
{
    public class UnitTest
    {
        private DeliveryEngine deliveryEngine = new DeliveryEngine();
        [Theory]
        [InlineData(0.8, 5000)]
        public void CreateParcel(double weight, double value)
        {
            #region Prepare Data

            var parcel = new Parcel
            {
                Recipient = SampleData.Recipient,
                Sender = SampleData.Sender,
                Weight = weight,
                Value = value
            };

            #endregion

            #region Action

            var deliveryResult = deliveryEngine.Send(parcel);

            #endregion

            #region Check

            Assert.True(deliveryResult.IsSucceed);

            #endregion
        }
    }
}
