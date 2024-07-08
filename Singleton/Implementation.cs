/*
The intent of the singleton pattern is to ensure that a class only has one instance,
and to provide a global point of access to it.

Real-life example:
- Logger: One instance is preffered to avoid unintended consequences.

Pattern Consequences:
- Strict control over how and when client access it
- Avoids polluting the namespace with global variables
- Subclassing allows configuring the application with an instance of the class
you need at runtime
- Multiple instances can be allowed without having to alter the client
- Violates the single responsibility principle

Related Patterns:
Abstract Factory, Builder, and Prototype pattern can be implemented as a singleton.
State objects are often implemented as singletons.

*/



namespace Singleton
{
    /// <summary>
    /// Singleton
    /// </summary>>
    public class Logger 
    {
        //Lazy<T>
        private static readonly Lazy<Logger> _lazyLogger
            = new Lazy<Logger>(() => new Logger());
        //private static Logger? _instance;

        /// <summary>
        /// Instance
        /// </summary>>
        public static Logger Instance 
        {
            get 
            {
                return _lazyLogger.Value;
                //    if (_instance == null) 
                //    {
                //        _instance = new Logger();
                //    }
                //    return _instance;
            }
        }
        protected Logger() 
        {
            
        }

        ///<summary>
        ///SingletonOperation
        ///</summary>
        public void Log(string message) 
        {
            Console.WriteLine($"Message to log: {message}");
        }

    }
}
