namespace MyMaxLibTest;
using Xunit;
using MyMaxLib;
public class UnitTest1
{
 
[Fact]
	public void TestMaxOf3numbers() {
	
		double a = 4;
        double b = 6;
        double c = 8;
		double expected = 8;
	
		double actual = Max.FindMax(a,b,c); // act
 
		Assert.Equal(expected, actual); // assert
	}	
	[Fact]
    public void TestMaxOf2numbers() {
    
		double a = 9; 
        double b = 8;
		double expected = 9;
	
		double actual = Max.FindMax(a,b); // act

		Assert.Equal(expected, actual); // assert
	} 
}