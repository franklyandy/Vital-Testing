using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Tests
{
    public class TriangleClassifierTests
    {
        [TestFixture]
        public class ClassifyTriangleMethod
        {
            private TriangleClassifier _triangleClassifier;

            [SetUp]
            public void SetUpTests()
            {
                _triangleClassifier = new TriangleClassifier();
            }

            [Test]
            public void When_All_Sides_Of_The_Triangle_Are_The_Same_Length_Then_The_Triangle_Should_Be_Equilateral()
            {
                var triangle = new Triangle(1,1,1);

                _triangleClassifier.ClassifyTriangle(triangle);
            }
        }
    }

    internal class TriangleClassifier
    {
        public TriangleType ClassifyTriangle(Triangle triangle)
        {
            return TriangleType.Equilateral;
        }
    }

    internal class Triangle
    {
        private readonly int _sideA;
        private readonly int _sideB;
        private readonly int _sideC;

        public Triangle(int sideA, int sideB, int sideC)
        {
            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }
    }

    internal enum TriangleType
    {
        Equilateral
    }
}
