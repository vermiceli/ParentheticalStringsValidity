// <copyright file="WellFormedMatchingTest.cs" company="Michael Miceli">
// Copyright Michael Miceli.  All rights are reserved.
// </copyright>

namespace ParenthesesMatching
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// This is a test class for WellFormedMatchingTest and is intended
    /// to contain all WellFormedMatchingTest Unit Tests
    /// </summary>
    [TestClass]
    public class WellFormedMatchingTest
    {
        /// <summary>
        /// Some test cases
        /// </summary>
        [TestMethod]
        public void Validate()
        {
            Assert.IsFalse(BracketMatching.IsValidParentheticalExpression("[}]"));
            Assert.IsFalse(BracketMatching.IsValidParentheticalExpression("(test)(test)(()"));
            Assert.IsTrue(BracketMatching.IsValidParentheticalExpression("<<(((((())))))[]>>"));
            Assert.IsTrue(BracketMatching.IsValidParentheticalExpression("([][]{[]}()())"));
        }
    }
}
