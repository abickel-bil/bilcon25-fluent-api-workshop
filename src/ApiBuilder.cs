public class ApiBuilder
{
    private string _domainName;
    private string _userName;

    private string _password;

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

    public ApiBuilder WithDomainName(string domainName)
    {
        _domainName = domainName;

        return new ApiBuilder(this);
    }
}