using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DefinitionExtension;
using System.Collections.Generic;

namespace UnitTests
{
    [TestClass]
    public class ExpressionEvaluatorTest
    {
        [TestMethod]
        public void testSimplePositiveExpressionEvaluation()
        {
            String expression = "A = B";

            List<Signal> signals = ExpressionEvaluator.evaluate(expression);

            Assert.AreEqual(1, signals.Count);

            Assert.AreEqual('A', signals[0].Name);

            Assert.AreEqual('B', signals[0].Positives[0]);
        }
        
        [TestMethod]
        public void testSimpleNegativeExpressionEvaluation()
        {
            String expression = "A = - B";

            List<Signal> signals = ExpressionEvaluator.evaluate(expression);

            Assert.AreEqual(1, signals.Count);

            Assert.AreEqual('A', signals[0].Name);

            Assert.AreEqual('B', signals[0].Negatives[0]);
        }

        [TestMethod]
        public void testMultiplePositiveExpressionEvaluation()
        {
            String expression = "A = B + C";

            List<Signal> signals = ExpressionEvaluator.evaluate(expression);

            Assert.AreEqual(1, signals.Count);

            Assert.AreEqual('A', signals[0].Name);

            Assert.AreEqual('B', signals[0].Positives[0]);

            Assert.AreEqual('C', signals[0].Positives[1]);
        }

        [TestMethod]
        public void testMultipleNegativeExpressionEvaluation()
        {
            String expression = "A = - B - C";

            List<Signal> signals = ExpressionEvaluator.evaluate(expression);

            Assert.AreEqual(1, signals.Count);

            Assert.AreEqual('A', signals[0].Name);

            Assert.AreEqual('B', signals[0].Negatives[0]);

            Assert.AreEqual('C', signals[0].Negatives[1]);
        }

        [TestMethod]
        public void testMultipleComplexExpressionEvaluation()
        {
            String expression = "A = - B + C";

            List<Signal> signals = ExpressionEvaluator.evaluate(expression);

            Assert.AreEqual(1, signals.Count);

            Assert.AreEqual('A', signals[0].Name);

            Assert.AreEqual('B', signals[0].Negatives[0]);

            Assert.AreEqual('C', signals[0].Positives[0]);
        }

        [TestMethod]
        public void testMultipleSignalComplexExpressionEvaluation()
        {
            String expression = "A + B = - C + D";

            List<Signal> signals = ExpressionEvaluator.evaluate(expression);

            Assert.AreEqual(2, signals.Count);

            Assert.AreEqual('A', signals[0].Name);

            Assert.AreEqual('B', signals[1].Name);

            Assert.AreEqual('C', signals[0].Negatives[0]);

            Assert.AreEqual('D', signals[0].Positives[0]);

            Assert.AreEqual('C', signals[1].Negatives[0]);

            Assert.AreEqual('D', signals[1].Positives[0]);
        }
    }
}
