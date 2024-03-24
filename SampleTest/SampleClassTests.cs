using NUnit.Framework;

[TestFixture]
public class SampleClassTests
{
    [Test]
    public void SnakeCase_InputBOBLovesCoding_Returns_bob_loves_coding()
    {
        // Arrange
        string input = "BOB loves-coding";
        string expected = "bob_loves_coding";

        // Act
        string result = SampleClass.SnakeCase(input);

        // Assert
        
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void SnakeCase_InputILikeCatsAndDogs_Returns_i_like_cats_dogs()
    {
        // Arrange
        string input = "I like cats&dogs";
        string expected = "i_like_cats_dogs";

        // Act
        string result = SampleClass.SnakeCase(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void SnakeCase_InputABCD_E_FG_Returns_a_b_c_d_e_f_g()
    {
        // Arrange
        string input = "a b c d-e-f%g";
        string expected = "a_b_c_d_e_f_g";

        // Act
        string result = SampleClass.SnakeCase(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void SnakeCase_InputEmptyString_Returns_EmptyString()
    {
        // Arrange
        string input = "";
        string expected = "";

        // Act
        string result = SampleClass.SnakeCase(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void SnakeCase_InputNull_Returns_EmptyString()
    {
        // Arrange
        string input = null;
        string expected = "";

        // Act
        string result = SampleClass.SnakeCase(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
