public class ApiBuilder : IConnectionStringBuilder, IConnectionUser, IConnectionPassword, IConnectionPort
{
    public static int MinPortNumber => 1000;
    
    /// <summary>
    /// The domain name to use for the connection string
    /// </summary>
    private string _domainName;

    /// <summary>
    /// The user name to use for the connection string
    /// </summary>
    private string _userName;

    /// <summary>
    /// the password to use for the connection string
    /// </summary>
    private string _password;

    /// <summary>
    /// the port number to use for the connection string
    /// </summary>
    private int _port;

    // default ctor, initialize with empty values
    public ApiBuilder()
    {
        _domainName = string.Empty;
        _userName = string.Empty;
        _password = string.Empty;
        _port = 0;
    }

    // clone ctor, copy all props from the original object
    private ApiBuilder(ApiBuilder origin)
    {
        /**
        Note! pass-by-reference types (i.e., classes) must have their own 
        copy constructors or other 'cloning' mechanisms to achieve expected 
        idempotency when implementing a clone constructor for your API.

        Pritives and pass-by-value types can safely use the illustrated approach
        */

        _domainName = origin._domainName;
        _userName = origin._userName;
        _password = origin._password;
        _port = origin._port;
    }

    public IConnectionUser WithDefaultDomainName()
    {
        _domainName = "my-domain.io";
        return Clone();
    }

    public IConnectionPassword WithDefaultUserName()
    {
        _userName = "default";
        return Clone();
    }

    public IConnectionUser WithDomainName(string domainName)
    {
        AssertNotEmpty(domainName);

        _domainName = domainName;

        return Clone();
    }

    public IConnectionPort WithPassword(string password)
    {
        AssertNotEmpty(password);

        _password = password;
        return Clone();
    }

    public string WithPort(int portNumber)
    {
        AssertMin(portNumber, MinPortNumber);

        _port = portNumber;
        return Serialize();
    }

    public string WithDefaultPort()
    {
        _port = 1000;
        return Serialize();
    }

    public IConnectionPassword WithUserName(string userName)
    {
        AssertNotEmpty(userName);

        _userName = userName;
        return Clone();
    }

    /// <summary>
    /// Clone the ApiBuilder instance
    /// </summary>
    /// <returns>a clone of the builder instance, with all configuration values from the origin object</returns>
    private ApiBuilder Clone() => new ApiBuilder(this);

    /// <summary>
    /// Create the connection string
    /// </summary>
    /// <returns>the completed connection string</returns>
    private string Serialize() => $"{_domainName};user={_userName};password={_password};port={_port}";

    /// <summary>
    /// Utility method to ensure a string input is not null or empty.
    /// <br />
    /// Throws argument exception if input is null or empty
    /// </summary>
    /// <param name="input">the input to validate</param>
    /// <exception cref="ArgumentException"></exception> 
    private void AssertNotEmpty(string input) => ArgumentException.ThrowIfNullOrWhiteSpace(input);

    /// <summary>
    /// Utility method to ensure that a provided integer input is greater than or equal the specified minimum
    /// </summary>
    /// <param name="actual">the input value to be validated</param>
    /// <param name="floor">the minimum value to be accepted</param>
    /// <exception cref="ArgumentException"></exception>
    private void AssertMin(int actual, int floor)
    {
        if (actual < floor)
        {
            throw new ArgumentException($"input must be minimum value {floor}");
        }
    }
}