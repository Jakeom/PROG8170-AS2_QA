using Assignment02_QA;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02_Tests
{
    public class RectangleTests
    {
        [Test]
        public void Check_Rectangle_Length_Integer_Value()
        {
            //Arrange
            var rectangle = new Rectangle();

            //Act
            var result = rectangle.GetLength();

            //Assert
            Assert.IsInstanceOf<int>(result);
        }
        [Test]
        public void Check_Rectangle_Length_Integer_Set_Value()
        {
            //Arrange
            var rectangle = new Rectangle();

            //Act
            var result = rectangle.SetLength(1);

            //Assert
            Assert.IsInstanceOf<int>(result);
        }

        [Test]
        public void Check_Rectangle_Length_Get_Default()
        {
            //Arrange
            var rectangle = new Rectangle();

            //Act
            var result = rectangle.GetLength();

            //Assert
            Assert.AreEqual(1, result);
        }

        [Test]
        public void Check_Rectangle_Length_Set_Default()
        {
            //Arrange
            var rectangle = new Rectangle();
            int testValue = 10;
            //Act
            var result = rectangle.SetLength(testValue);

            //Assert
            Assert.AreEqual(testValue, result);
        }

        [Test]
        public void Check_Rectangle_Length_Get_Value()
        {
            //Arrange
            var rectangle = new Rectangle();

            //Act
            var result = rectangle.GetLength();
            //Assert
            Assert.AreEqual(rectangle.GetLength(), result);
        }

        [Test]
        public void Check_Rectangle_Length_Set_Value()
        {
            //Arrange
            var rectangle = new Rectangle();

            // Act
            var testLength = 3;

            //Act
            var result = rectangle.SetLength(testLength);
            //Assert
            Assert.AreEqual(testLength, result);
        }


        [Test]
        public void Check_Rectangle_Heigh_Integer_Get_Value()
        {
            //Arrange
            var rectangle = new Rectangle();

            //Act
            var result = rectangle.GetHeight();

            //Arrange
            Assert.IsInstanceOf<int>(result);
        }

        [Test]
        public void Check_Rectangle_Height_Integer_Set_Value()
        {
            //Arrange
            var rectangle = new Rectangle();

            //Act
            var result = rectangle.SetHeight(1);

            //Arrange
            Assert.IsInstanceOf<int>(result);
        }

        [Test]
        public void Check_Rectangle_Height_Set_Default()
        {
            //Arrange
            var rectangle = new Rectangle();
            int testValue = 10;
            //Act
            var result = rectangle.SetHeight(testValue);

            //Assert
            Assert.AreEqual(testValue, result);
        }

        [Test]
        public void Check_Rectangle_Height_Get_Value()
        {
            //Arrange
            var rectangle = new Rectangle();

            //Act 
            var result = rectangle.GetHeight();

            //Assert
            Assert.AreEqual(rectangle.GetHeight(), result);
        }

        [Test]
        public void Check_Rectangle_Height_Get_Default()
        {
            //Arrange
            var rectangle = new Rectangle();

            //Act
            var result = rectangle.GetHeight();

            //Assert
            Assert.AreEqual(1, result);
        }

        [Test]
        public void Check_Rectangle_Height_Set_Value()
        {
            //Arrange
            var rectangle = new Rectangle();

            // Act
            var testHeight = 3;

            //Act
            var result = rectangle.SetHeight(testHeight);
            //Assert
            Assert.AreEqual(testHeight, result);
        }


        [Test]
        public void Check_Rectangle_Width_Integer_Get_Value()
        {
            //Arrange
            var rectangle = new Rectangle();

            //Act
            var result = rectangle.GetWidth();

            //Assert
            Assert.IsInstanceOf<int>(result);
        }

        [Test]
        public void Check_Rectangle_Width_Integer_Set_Value()
        {
            //Arrange
            var rectangle = new Rectangle();

            //Act
            var result = rectangle.SetWidth(1);

            //Assert
            Assert.IsInstanceOf<int>(result);
        }

        [Test]
        public void Check_Rectangle_Width_Set_Default()
        {
            //Arrange
            var rectangle = new Rectangle();
            int testValue = 10;
            //Act
            var result = rectangle.SetWidth(testValue);

            //Assert
            Assert.AreEqual(testValue, result);
        }

        [Test]
        public void Check_Rectangle_Width_Get_Value()
        {
            //Arrange
            var rectangle = new Rectangle();

            //Act
            var result = rectangle.GetWidth();

            //Arrange
            Assert.AreEqual(rectangle.GetWidth(), result);
        }

        [Test]
        public void Check_Rectangle_Width_Get_Default()
        {
            //Arrange
            var rectangle = new Rectangle();

            //Act
            var result = rectangle.GetWidth();

            //Assert
            Assert.AreEqual(1, result);
        }

        [Test]
        public void Check_Rectangle_Width_Set_Value()
        {
            //Arrange
            var rectangle = new Rectangle();

            // Act
            var testWidth = 3;

            //Act
            var result = rectangle.SetWidth(testWidth);
            //Assert
            Assert.AreEqual(testWidth, result);
        }
        

        [Test]
        public void Check_Rectangle_Volume_Integer_Get_Value()
        {
            //Arrange
            var rectangle = new Rectangle();

            //Act
            var result = rectangle.GetVolume();

            //Assert
            Assert.IsInstanceOf<int>(result);
        }

        [Test]
        public void Check_Rectangle_Volume_Default()
        {
            //Arrange
            var rectangle = new Rectangle();

            //Act
            var result = rectangle.GetVolume();

            //Assert
            Assert.AreEqual(1, result);
        }


        [Test]
        public void Check_Rectangle_Volume_Change_Value()
        {
            //Arrange
            int testLength = 3;
            int testHeight = 4;
            int testWidth = 5;
            
            //Act
            var rectangle = new Rectangle();
            rectangle.SetLength(testLength);
            rectangle.SetHeight(testHeight);
            rectangle.SetWidth(testWidth);
            var expectedVolume = testWidth * testLength * testHeight;
            var resultVolume = rectangle.GetVolume();

            //Assert
            Assert.AreEqual(expectedVolume, resultVolume);
        }
    }
}
