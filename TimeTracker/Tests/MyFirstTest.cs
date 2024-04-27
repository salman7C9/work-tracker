using Build;

namespace Tests {

        public class MyFirstTest
        {
                [Fact]
                public void Foo_Input4_ReturnFalse()
                {
                        var program = new Program();
                        var result = program.Foo(4);

                        Assert.False(result, "bar=4 should be foo!");
                }
        }
}
