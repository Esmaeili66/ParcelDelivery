using ParcelDelivery.AcceptanceTests.Constant;
using ParcelDelivery.Core.Domain;
using ParcelDelivery.Core.Implement;
using ParcelDelivery.Core.Service;
using System.Linq;
using Xunit;

namespace ParcelDelivery.AcceptanceTests
{
    public class ParcelDeliveryScenarioTest
    {
        private readonly DeliveryEngine _deliveryEngine = new DeliveryEngine();

        [Theory]
        [InlineData(0.8, 1)]
        [InlineData(0.5, 200)]
        [InlineData(0.658, 999)]
        public void LowWeight_LowPrice_HandelByEmail(double weight, double value)
        {
            #region Prepare Data

            var parcel = new Parcel
            {
                Recipient = SampleData.Recipient,
                Sender = SampleData.Sender,
                Value = value,
                Weight = weight
            };

            #endregion

            #region Action

            var deliveryResult = _deliveryEngine.Send(parcel);

            #endregion

            #region Result
            Assert.NotNull(deliveryResult);
            Assert.True(deliveryResult.IsSucceed);
            Assert.IsType<EmailDepartment>(deliveryResult.ExecutedDepartmentList.First());
            #endregion
        }
        [Theory]
        [InlineData(1, 1)]
        [InlineData(5, 200)]
        [InlineData(9.99, 999)]
        public void MiddleWeight_LowPrice_HandelByRegular(double weight, double value)
        {
            #region Prepare Data

            var parcel = new Parcel
            {
                Recipient = SampleData.Recipient,
                Sender = SampleData.Sender,
                Value = value,
                Weight = weight
            };

            #endregion

            #region Action

            var deliveryResult = _deliveryEngine.Send(parcel);

            #endregion

            #region Result
            Assert.NotNull(deliveryResult);
            Assert.True(deliveryResult.IsSucceed);
            Assert.IsType<RegularDepartment>(deliveryResult.ExecutedDepartmentList.First());
            #endregion
        }
        [Theory]
        [InlineData(80, 1)]
        [InlineData(500, 200)]
        [InlineData(2650, 999)]
        public void HighWeight_LowPrice_HandelByHeavy(double weight, double value)
        {
            #region Prepare Data

            var parcel = new Parcel
            {
                Recipient = SampleData.Recipient,
                Sender = SampleData.Sender,
                Value = value,
                Weight = weight
            };

            #endregion

            #region Action

            var deliveryResult = _deliveryEngine.Send(parcel);

            #endregion

            #region Result
            Assert.NotNull(deliveryResult);
            Assert.True(deliveryResult.IsSucceed);
            Assert.IsType<HeavyDepartment>(deliveryResult.ExecutedDepartmentList.First());
            #endregion
        }


        [Theory]
        [InlineData(0.8, 1500)]
        [InlineData(0.5, 2000)]
        [InlineData(0.658, 9999)]
        public void LowWeight_HighPrice_SignOf_HandelByEmail(double weight, double value)
        {
            #region Prepare Data

            var parcel = new Parcel
            {
                Recipient = SampleData.Recipient,
                Sender = SampleData.Sender,
                Value = value,
                Weight = weight
            };

            #endregion

            #region Action

            var deliveryResult = _deliveryEngine.Send(parcel);

            #endregion

            #region Result
            Assert.NotNull(deliveryResult);
            Assert.True(deliveryResult.IsSucceed);

            #endregion
        }
        [Theory]
        [InlineData(1, 1000)]
        [InlineData(5, 250)]
        [InlineData(9.99, 9999)]
        public void MiddleWeight_High_SignOfPrice_HandelByRegular(double weight, double value)
        {
            #region Prepare Data

            var parcel = new Parcel
            {
                Recipient = SampleData.Recipient,
                Sender = SampleData.Sender,
                Value = value,
                Weight = weight
            };

            #endregion

            #region Action

            var deliveryResult = _deliveryEngine.Send(parcel);

            #endregion

            #region Result
            Assert.NotNull(deliveryResult);
            Assert.True(deliveryResult.IsSucceed);
            #endregion
        }
        [Theory]
        [InlineData(80, 1000)]
        [InlineData(500, 300)]
        [InlineData(2650, 8559)]
        public void HighWeight_HighPrice_SignOf_HandelByHeavy(double weight, double value)
        {
            #region Prepare Data

            var parcel = new Parcel
            {
                Recipient = SampleData.Recipient,
                Sender = SampleData.Sender,
                Value = value,
                Weight = weight
            };

            #endregion

            #region Action

            var deliveryResult = _deliveryEngine.Send(parcel);

            #endregion

            #region Result
            Assert.NotNull(deliveryResult);
            Assert.True(deliveryResult.IsSucceed);
            #endregion
        }
    }
}
