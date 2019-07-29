using System;
using Xunit;

namespace CollectionTesting.Test
{
    //this test class will test all behavior of StringCollection
    // Different kinds of automated testing
    // unit testing: test individual slices of behavior, not the whole app/library/class
    //advantages: If a test breaks, you know exactly what part of the code is wrong
    //having to write unit tests enforces better design on the code itself


    public class StringCollectionTests
    {
        // with xUnit each test method should test one thing only
        // everything else it needsto do, setup code IS assumed to be correct
        //those parts should have their own seperate tests


        [Fact]//the "fact" attribute turns this into a test method visible to xunit

        public void ConstructorShouldCreateObject()
        {
            //arrange
            var collection = new StringCollectionTests()

            //act
            collection.Add("abc");

            //assert
            //(if no exception thrown then succesful test)
        }
        public void AddshouldAdd()
        {
            //arrange
            var collection = new StringCollectionTests()

            //act
            collection.Add("abc");

            //assert
            Assert.Equal("abc", collection[0]);
        }

        //fact is for 0 parameter ltests
        //theory is for tests that we want to run with different values
        [Theory]
        public void AddShouldAddUnusualValues(string value)
        {
            //arrange
            var collection = new StringCollectionTests()

            //act
            collection.Add("abc");

            //assert
            Assert.Equal("abc", collection[0]);
        }
    }
}
