namespace CSharpExamples
{
    // PascalCase                   => Class, Method, Attribute , Namespace
    // camelCase                    => Method parameter, Field, 
    // UPPERCASE_WORD_WORD          => Constants, Compliler Flag
    // snake_case                   => This is usually using in Python

    internal class CodingStandarts
    {
        private const string CAR_ENGINE_CONFIGURATION = "v8";

        // Underscore prefix: for private variables (I don’t like it)
        private int _speed;
        private void SpeedMethod(int speed)
        {
            //this.speed = speed;
            _speed = speed;         // Some developer use this code instead of upper line
        }


        public void ConfigureCarEngine()
        {
            string engineType = CAR_ENGINE_CONFIGURATION;
        }

    }
}
