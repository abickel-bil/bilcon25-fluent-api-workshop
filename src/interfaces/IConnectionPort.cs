public interface IConnectionPort
{
    string WithPort(int portNumber);

    string WithDefaultPort();
}