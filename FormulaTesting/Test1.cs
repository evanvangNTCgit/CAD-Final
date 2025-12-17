using CAD_Final;

namespace FormulaTesting
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void MonthlyPaymentTest()
        {
            // Act
            var monthlyPayment = LoanFormulas.MonthlyPayment(10000, 4.2, 36);

            // Arrange
            monthlyPayment = Math.Round(monthlyPayment, 2);

            // Assert
            Assert.AreEqual(monthlyPayment, 296.13);
        }

        [TestMethod]
        public void TotalInterestPaidTest()
        {
            // Act
            var TotalInterestPaid = LoanFormulas.TotalInterestPaid(10000, 4.2, 36);

            // Arrange
            TotalInterestPaid = Math.Round(TotalInterestPaid, 2);

            // Assert
            Assert.AreEqual(TotalInterestPaid, 660.69);
        }

        [TestMethod]
        public void TotalPrincipalPaidTest()
        {
            // Act
            var totalPrincipalPaid = LoanFormulas.TotalPrincipalPaid(10000, 4.2, 36);

            // Arrange
            totalPrincipalPaid = Math.Round(totalPrincipalPaid, 2);

            // Assert
            Assert.AreEqual(totalPrincipalPaid, 10660.69);
        }

        [TestMethod]
        public void TotalPrincipalPlusInterestTest()
        {
            // Act
            var totalPrincipalPaidPlusInterest = LoanFormulas.TotalPrincipalPlusInterest(10000, 4.2, 36);

            // Arrange
            totalPrincipalPaidPlusInterest = Math.Round(totalPrincipalPaidPlusInterest, 2);

            // Assert
            Assert.AreEqual(totalPrincipalPaidPlusInterest, 11321.39);
        }
    }
}
